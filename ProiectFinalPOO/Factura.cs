using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectFinalPOO
{
    public class Factura
    {
        static int numarF;
        Furnizor F;
        Client C;
        List<Produs> cumparaturi = new List<Produs>();
        public Factura(Furnizor F,Client C, List<Produs> cumparaturi)
        {
            this.F = F;
            this.C = C;
            this.cumparaturi.AddRange(cumparaturi);
            numarF++;
        }
        public Factura() { numarF++; }

        public void Deseneaza(Graphics g)
        {
            int cellWidth = 150;  // Latimea celulei
            int cellHeight = 30;  // Inaltimea celulei
            int padding = 20;     // Padding intre tabele
            int startX = 50;      // Pozitia de start X
            int startY = 20;      // Pozitia de start Y

            int logoHeight = 50;
            int logoWidth = 150;// Inaltimea spatiului pentru logo
            // Încărcare și desenare logo
            Image logo = Properties.Resources.logo;
            g.DrawImage(logo, new Rectangle(startX, startY, logoWidth, logoHeight));

            startY += logoHeight; // Adaugam spatiu pentru logo


            Font fontTitle = new Font("Arial", 16, FontStyle.Bold);
            Font fontBold = new Font("Arial", 10, FontStyle.Bold);
            Font fontRegular = new Font("Arial", 10);
            Brush brush = Brushes.Black;
            Pen pen = new Pen(Color.Black);

            // Desenare titlu "Factura"
            g.DrawString("Factura", fontTitle, brush, new PointF(startX, startY));
            startY += 40; // Spatiu dupa titlu

            // Elemente pentru prima coloana
            List<string> primaColoana = new List<string>
            {
                "Nr. Reg. Com:",
                "CIF:",
                "Adresa:",
                "Email:",
                "Tel:",
                "Banca:",
                "Cont:"
            };
            List<string> adouaColoana = new List<string>
            {
               this.F.RegCom,
               this.F.CIF,
               this.F.Adresa,
               this.F.Email,
               this.F.Telefon,
               this.F.Banca,
               this.F.Cont
            };

            // Desenare tabel Furnizor
            g.DrawString("Furnizor: " + this.F.Nume, fontBold, brush, new PointF(startX, startY));
            g.DrawString("Nume Furnizor: " + this.F.Nume, fontRegular, brush, new PointF(startX, startY + 20));


            for (int i = 0; i < primaColoana.Count; i++)
            {
                int x = startX;
                int y = startY + 50 + i * cellHeight;

                // Desenare prima coloana
                g.DrawRectangle(pen, x, y, cellWidth, cellHeight);
                g.DrawString(primaColoana[i], fontRegular, brush, new PointF(x + 5, y + 5));

                // Desenare a doua coloana
                g.DrawRectangle(pen, x + cellWidth, y, cellWidth + 50, cellHeight);
                g.DrawString(adouaColoana[i], fontRegular, brush, new PointF((x + cellWidth) + 5, y + 5));
            }

            // Desenare tabel Client
            int startXClient = startX + 2 * cellWidth + 100 + padding;
            g.DrawString("Client: " + ClientCurent.nume, fontBold, brush, new PointF(startXClient, startY));
            g.DrawString("Nume Client: " + ClientCurent.nume, fontRegular, brush, new PointF(startXClient, startY + 20));
            List<string> primaColoanaC = new List<string>
            {
                "Reg.Com.:",
                "CIF:",
                "Adresa:",
                "Banca:",
                "Cont:"
            };
            List<string> adouaColoanaC = new List<string>
            {
               ClientCurent.regcom,
               ClientCurent.CIF,
               ClientCurent.adresa,
               ClientCurent.banca,
               ClientCurent.cont
            };

            for (int i = 0; i < primaColoanaC.Count; i++)
            {
                int x = startXClient;
                int y = startY + 50 + i * cellHeight;

                g.DrawRectangle(pen, x, y, cellWidth, cellHeight);
                g.DrawString(primaColoanaC[i], fontRegular, brush, new PointF(x + 5, y + 5));

                g.DrawRectangle(pen, x + cellWidth, y, cellWidth, cellHeight);
                g.DrawString(adouaColoanaC[i], fontRegular, brush, new PointF(x + 200, y + 5));
            }

            startY += 50 + primaColoana.Count * cellHeight + 30;
            g.DrawString("Factura nr.: " + numarF + " data: " + DateTime.Now.ToShortDateString(), fontRegular, brush, new PointF(startX, startY));
            g.DrawString("Cota TVA: 19%", fontRegular, brush, new PointF(startX + 400, startY));

            //Calculare TVA produs
            double TVAP(Produs P)
            {
                double tvaP = 0;
                tvaP = (P.Pret * 19) / 100;
                return tvaP;
            }
            // Desenare tabel produse
            List<string> headerProduse = new List<string> { "Denumire produse", "U.M.", "Cant.", "Pret unitar", "TVA", "Total" };

            List<string[]> detaliiProduse = cumparaturi.Select(p => new string[]
            {
                p.Denumire,
                "buc",
                "1",
                (p.Pret/10).ToString("0.00"),
                (TVAP(p)/10).ToString("0.00"),
                ((p.Pret + TVAP(p))/10).ToString("0.00")
            }).ToList();

            startY += 30;
            int produseStartX = startX;

            g.DrawRectangle(pen, produseStartX, startY, cellWidth, cellHeight);
            g.DrawString(headerProduse[0], fontBold, brush, new PointF(produseStartX + 5, startY + 5));

            for (int i = 1; i < headerProduse.Count; i++)
            {
                int x = produseStartX + cellWidth + (i - 1) * cellWidth / 2;
                g.DrawRectangle(pen, x, startY, cellWidth / 2, cellHeight);
                g.DrawString(headerProduse[i], fontBold, brush, new PointF(x + 5, startY + 5));
            }

            for (int i = 0; i < detaliiProduse.Count; i++)
            {
                int x = produseStartX;
                int y = startY + cellHeight + i * cellHeight;

                g.DrawRectangle(pen, x, y, cellWidth, cellHeight);
                g.DrawString(detaliiProduse[i][0], fontRegular, brush, new PointF(x + 5, y + 5));

                for (int j = 1; j < detaliiProduse[i].Length; j++)
                {
                    x = produseStartX + cellWidth + (j - 1) * cellWidth / 2;
                    g.DrawRectangle(pen, x, y, cellWidth / 2, cellHeight);
                    g.DrawString(detaliiProduse[i][j], fontRegular, brush, new PointF(x + 5, y + 5));
                }
            }
            //Calculare totaluri
            double pretFaraTVA = PretFaraTVA(cumparaturi);
            double tva = TVA(cumparaturi);
            double totalDePlata = pretFaraTVA + tva;
            // Desenare totaluri
            startY += cellHeight * (this.cumparaturi.Count + 1) + 20;
            int totalStartX = produseStartX + cellWidth + 2 * cellWidth / 2;
            List<string> totalHeaders = new List<string> { "Pret fara TVA", "Valoare TVA", "Total de plata" };
            List<string> totalValues = new List<string>
            {
            (pretFaraTVA/10).ToString("0.00"),
            (tva/10).ToString("0.00"),
            (totalDePlata/10).ToString("0.00")
            };

            for (int i = 0; i < totalHeaders.Count; i++)
            {
                int x = totalStartX;
                int y = startY + i * cellHeight;
                g.DrawRectangle(pen, x, y, cellWidth, cellHeight);
                g.DrawString(totalHeaders[i], fontBold, brush, new PointF(x + 5, y + 5));
                g.DrawRectangle(pen, x + cellWidth, y, cellWidth / 2, cellHeight);
                g.DrawString(totalValues[i], fontRegular, brush, new PointF(x + cellWidth + 5, y + 5));
            }

            // Desenare text final
            startY += totalHeaders.Count * cellHeight + 10;
            g.DrawString("TVA la incasare.", fontRegular, brush, new PointF(totalStartX, startY));
        }
        public double PretFaraTVA(List<Produs> cumparaturi)
        {
            double T1 = 0;
            foreach (Produs P in cumparaturi)
            {
                T1 += P.Pret;
            }
            return T1;
        }
        public double TVA(List<Produs> cumparaturi)
        {
            double Tva = 0;
            foreach (Produs P in cumparaturi)
            {
                Tva += (P.Pret * 19) / 100;
            }
            return Tva;
        }
    }
}
