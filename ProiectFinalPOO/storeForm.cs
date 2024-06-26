using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace ProiectFinalPOO
{
    public partial class storeForm : Form
    {
        Furnizor furnizor = new Furnizor();
        Depozit depozit = Depozit.Instance;
        List<Produs> CosDeCumparaturi = new List<Produs>();
        Client conectat = new Client();

        public storeForm()
        {
            InitializeComponent();
        }
        void afiseaza(List<Produs> produs)
        {
            listProduse.Items.Clear();
            foreach (Produs p in produs)
            {
                if (p != null && !string.IsNullOrWhiteSpace(p.Denumire))
                {
                    listProduse.Items.Add(p);  // Aici se adaugă produsul individual, nu lista de produse
                }
            }
            if (listProduse.Items.Count == 0)
            {
                MessageBox.Show("Nu s-au gasit produse!");
            }
        }

        void cautaProdus(List<Produs> produs)
        {
            listProduse.Items.Clear();
            foreach (Produs p in produs)
            {
                if (p != null && !string.IsNullOrWhiteSpace(p.Denumire))
                {
                    listProduse.Items.Add(p);  // Aici se adaugă produsul individual, nu lista de produse
                }
            }

            string searchTerm = searchBox.Text.Trim().ToLower();
            listProduse.Items.Clear();

            var filteredProducts = produs.Where(p => p != null && !string.IsNullOrWhiteSpace(p.Denumire) && p.Denumire.ToLower().Contains(searchTerm)).ToList();

            foreach (Produs p in filteredProducts)
            {
                listProduse.Items.Add(p);
            }
        }
        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deconectareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void incarcaProduseleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            afiseaza(depozit.produse);
        }
        private void listProduse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listProduse.SelectedIndex < 0) return;

            Produs produsSelectat = (Produs)listProduse.SelectedItem;


            bool produsInCos = CosDeCumparaturi.Any(p => p.Cod == produsSelectat.Cod);
            if (!produsInCos)
            {
                CosDeCumparaturi.Add(produsSelectat);
            }

            listCos.Items.Clear();
            foreach (var p in CosDeCumparaturi)
            {
                listCos.Items.Add(p);
            }
        }

        private void listCos_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0 || e.Index >= listCos.Items.Count)
            {
                return;
            }

            e.DrawBackground();


            if (listCos.Items[e.Index] is Produs P)
            {
                int listBoxWidth = listCos.ClientSize.Width;
                string productText = P.Denumire + " (" + P.Stoc + " buc)";
                SizeF textSize = e.Graphics.MeasureString(productText, new Font("Arial", 12, FontStyle.Bold));
                float codeXPosition = listBoxWidth - e.Graphics.MeasureString(P.Cod.ToString(), new Font("Arial", 12, FontStyle.Bold)).Width - 10;
                e.Graphics.DrawString(productText, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.Bounds.X + 20, e.Bounds.Y);
                e.Graphics.DrawString(P.Cod.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, codeXPosition, e.Bounds.Y);
            }

            e.DrawFocusRectangle();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            cautaProdus(depozit.produse);
        }

        private void listCos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listCos.SelectedIndex < 0) return;

            Produs produsSelectat = (Produs)listCos.SelectedItem;

            Image barcodeImage = produsSelectat.CodEAN_8();

            if (barcodeImage != null)
            {
                PBCodBare.BackgroundImage = barcodeImage;
                PBCodBare.BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        private void buttonDeconecteaza_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void buttonGenFactura_Click(object sender, EventArgs e)
        {
            string filePath = "cosCumparaturi.txt";

            try
            {
                string content = $"{conectat.id}\n";

                foreach (var produs in CosDeCumparaturi)
                {
                    content += $"{produs.Cod}/{produs.Cantitate}\n";
                }

                File.WriteAllText(filePath, content);
                MessageBox.Show("Succes!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            Furnizor furnizor = new Furnizor
            {
                Nume = "Popescu Paul-Constantin",
                Parola = "12349876",
                Adresa = "Barlad",
                Banca = "RaiffeisenBank",
                Cont = "RO53RZBR0000060019974649",
                RegCom = "J13/12345/1990",
                CIF = "ROF1268745834813",
                Email = "paul.popescu263@gmail.com",
                Telefon = "0741492525"
            };

            // Create and show the FacturaForm with the necessary parameters
            FacturaForm factForm = new FacturaForm(CosDeCumparaturi, conectat, furnizor);
            factForm.Size = new Size(1015, 925);
            factForm.Show();
        }

        private void listProduse_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                Produs P = CosDeCumparaturi[Convert.ToInt32(listProduse.Items[e.Index])];
                String text = P.Denumire + " (" + P.Descriere + ")";
                System.Drawing.Font font = new System.Drawing.Font("Arial", 16, FontStyle.Bold);
                StringFormat sf = new StringFormat();
                sf.LineAlignment = StringAlignment.Center;
                SizeF ms = e.Graphics.MeasureString(text, font);
                Rectangle r = new Rectangle(e.Bounds.Height, e.Bounds.Top + 4, (int)ms.Width + 5, e.Bounds.Height - 8);
                e.Graphics.DrawString(text, font, Brushes.Blue, r, sf);
                text = P.Stoc + " buc";
                ms = e.Graphics.MeasureString(text, font);
                r = new Rectangle(e.Bounds.Width - (int)ms.Width - 4, e.Bounds.Top + 4, (int)ms.Width + 5, e.Bounds.Height - 8);
                e.Graphics.DrawString(text, font, Brushes.Green, r, sf);

                e.DrawFocusRectangle();
            }
            catch { }
        }
    }
}
