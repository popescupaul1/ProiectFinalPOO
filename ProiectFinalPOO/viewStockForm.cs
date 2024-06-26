using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectFinalPOO
{
    public partial class viewStockForm : Form
    {
        Depozit depozit = Depozit.Instance;

        public viewStockForm()
        {
            InitializeComponent();
            afiseaza(depozit.produse);
        }

        void afiseaza(List<Produs> produs)
        {
            listProduseV.Items.Clear();
            foreach (Produs p in produs)
            {
                if (p != null && !string.IsNullOrWhiteSpace(p.Denumire))
                {
                    listProduseV.Items.Add(p);  // Aici se adaugă produsul individual, nu lista de produse
                }
            }
            if (listProduseV.Items.Count == 0)
            {
                MessageBox.Show("Nu s-au gasit produse!");
            }
        }

        private void listProduseV_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0 || e.Index >= listProduseV.Items.Count)
            {
                return;
            }

            e.DrawBackground();
            Produs P = (Produs)listProduseV.Items[e.Index];
            string text = P.Denumire + " (" + P.Stoc + " buc)";
            e.Graphics.DrawString(text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.Bounds.X + 20, e.Bounds.Y);
            e.DrawFocusRectangle();
        }

        private void buttonMeniu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
