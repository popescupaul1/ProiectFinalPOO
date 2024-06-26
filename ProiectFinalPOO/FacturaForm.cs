using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectFinalPOO
{
    public partial class FacturaForm : Form
    {

        private List<Produs> cosDeCumparaturi;
        private Bitmap facturaImagine;
        private Client client;
        private Furnizor furnizor;

        public FacturaForm(List<Produs> cosDeCumparaturi, Client client, Furnizor furnizor)
        {
            InitializeComponent();
            this.cosDeCumparaturi = cosDeCumparaturi;
            this.client = client;
            this.furnizor = furnizor;

            GenerateBillImage();
        }

        private void GenerateBillImage()
        {
            int width = 1430;
            int height = 1198; 

            facturaImagine = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(facturaImagine))
            {
                Deseneaza(g);
            }

            pictureBoxFactura.Image = facturaImagine;
        }

        private void Deseneaza(Graphics g)
        {
            int startX = 50;
            int startY = 50;
            int offset = 40;
            Font font = new Font("Arial", 12);
            Font fontBold = new Font("Arial", 12, FontStyle.Bold);
            Brush brush = Brushes.Black;

            g.DrawString("Factura", new Font("Arial", 16, FontStyle.Bold), brush, startX, startY);
            startY += offset;

            g.DrawString($"Furnizor: {furnizor.Nume}", fontBold, brush, startX, startY);
            g.DrawString($"CIF: {furnizor.CIF}", font, brush, startX, startY + offset / 2);
            g.DrawString($"Adresa: {furnizor.Adresa}", font, brush, startX, startY + offset);
            g.DrawString($"Telefon: {furnizor.Telefon}", font, brush, startX, startY + 1.5f * offset);
            g.DrawString($"Email: {furnizor.Email}", font, brush, startX, startY + 2 * offset);
            startY += 3 * offset;


            g.DrawString($"Client: {ClientCurent.nume}", fontBold, brush, startX, startY);
            g.DrawString($"CIF: {ClientCurent.CIF}", font, brush, startX, startY + offset / 2);
            g.DrawString($"Adresa: {ClientCurent.adresa}", font, brush, startX, startY + offset);
            g.DrawString($"Banca: {ClientCurent.banca}", font, brush, startX, startY + 1.5f * offset);
            g.DrawString($"Cont: {ClientCurent.cont}", font, brush, startX, startY + 2 * offset);
            startY += 3 * offset;

            g.DrawString("Denumire", fontBold, brush, startX, startY);
            g.DrawString("Cantitate", fontBold, brush, startX + 200, startY);
            g.DrawString("Pret Unitar", fontBold, brush, startX + 350, startY);
            g.DrawString("TVA", fontBold, brush, startX + 500, startY);
            g.DrawString("Total", fontBold, brush, startX + 650, startY);
            startY += offset;

            double totalfaraTVA = 0;
            double totalTVA = 0;

            foreach (var produs in cosDeCumparaturi)
            {
                double pretUnit = produs.Pret;
                double tva = pretUnit * 0.19;
                double total = pretUnit + tva;

                g.DrawString(produs.Denumire, font, brush, startX, startY);
                g.DrawString("1", font, brush, startX + 200, startY); 
                g.DrawString(pretUnit.ToString("F2") + " lei", font, brush, startX + 350, startY);
                g.DrawString(tva.ToString("F2") + " lei", font, brush, startX + 500, startY);
                g.DrawString(total.ToString("F2") + " lei", font, brush, startX + 650, startY);

                totalfaraTVA += pretUnit;
                totalTVA += tva;

                startY += offset;
            }

            g.DrawString("Total fara TVA: ", fontBold, brush, startX, startY);
            g.DrawString(totalfaraTVA.ToString("F2") + " lei", fontBold, brush, startX + 200, startY);
            startY += offset;

            g.DrawString("Total TVA: ", fontBold, brush, startX, startY);
            g.DrawString(totalTVA.ToString("F2") + " lei", fontBold, brush, startX + 200, startY);
            startY += offset;

            g.DrawString("Total de plata: ", fontBold, brush, startX, startY);
            g.DrawString((totalfaraTVA + totalTVA).ToString("F2") + " lei", fontBold, brush, startX + 200, startY);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Bitmap bitmap = new Bitmap(pictureBoxFactura.Width, pictureBoxFactura.Height))
            {
                pictureBoxFactura.DrawToBitmap(bitmap, new Rectangle(0, 0, pictureBoxFactura.Width, pictureBoxFactura.Height));

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PNG Image|*.png";
                saveFileDialog.Title = "Salveaza factura ca imagine .png";
                saveFileDialog.FileName = "factura.png";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    bitmap.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                    MessageBox.Show("Imaginea facturii a fost salvata cu succes.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonGenFactura_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (pictureBoxFactura.Image != null)
            {
                e.Graphics.DrawImage(pictureBoxFactura.Image, e.MarginBounds);
            }
        }
    }
}
