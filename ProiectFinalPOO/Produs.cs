using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectFinalPOO
{
    public class Produs
    {
        public string Cod { get; set; }
        public string Denumire { get; set; }
        public string Descriere { get; set; }
        public string Categorie { get; set; }
        public double Pret { get; set; }
        public int Stoc { get; set; }

        public int Cantitate = 1;

        public Produs() { }
        public Produs(string categorie)
        {
            Categorie = categorie;
        }
        public Produs(string cod, string denumire, string descriere, string categorie, double pret, int stoc)
        {
            this.Cod = cod;
            this.Denumire = denumire;
            this.Descriere = descriere;
            this.Categorie = categorie;
            this.Pret = pret;
            this.Stoc = stoc;
        }

        public override string ToString()
        {
            return Denumire; 
        }

        public static bool operator <=(Produs P1, Produs P2)
        {
            return string.Compare(P1.Denumire, P2.Denumire) <= 0;
        }
        public static bool operator >=(Produs P1, Produs P2)
        {
            return string.Compare(P1.Denumire, P2.Denumire) >= 0;
        }
        public bool Verifica_Cod()
        {
            string x = Cod;
            int S1 = 0, S2 = 0;
            for (int i = 1; i < x.Length; i++)
            {
                int d = Int32.Parse(x[i].ToString());
                if (i % 2 == 1) S1 += d;
                else S2 += d;
            }
            int r = 0;
            r = 3 * S1 + S2;
            if (r % 10 == (10 - (r % 10)) % 10)
                return false;
            else return true;
        }

        public string SirCaractere()
        {
            string x = Cod;
            string str = "";
            str += "101";
            for (int i = 0; i < 3; i++)
            {
                switch (Int32.Parse(x[i].ToString()))
                {
                    default:
                        {
                            break;
                        }
                    case 1:
                        {
                            str += "0011001";
                            break;
                        }
                    case 2:
                        {
                            str += "0010011";
                            break;
                        }
                    case 3:
                        {
                            str += "0111101";
                            break;
                        }
                    case 4:
                        {
                            str += "0100011";
                            break;
                        }
                    case 5:
                        {
                            str += "0110001";
                            break;
                        }
                    case 6:
                        {
                            str += "0101111";
                            break;
                        }
                    case 7:
                        {
                            str += "0111011";
                            break;
                        }
                    case 8:
                        {
                            str += "0110111";
                            break;
                        }
                    case 9:
                        {
                            str += "0001011";
                            break;
                        }
                }
            }

            switch (Int32.Parse(x[3].ToString()))
            {
                default:
                    {
                        str += "1110010";
                        break;
                    }
                case 1:
                    {
                        str += "1100110";
                        break;
                    }
                case 2:
                    {
                        str += "1101100 ";
                        break;
                    }
                case 3:
                    {
                        str += "1000010";
                        break;
                    }
                case 4:
                    {
                        str += "1011100";
                        break;
                    }
                case 5:
                    {
                        str += "1001110";
                        break;
                    }
                case 6:
                    {
                        str += "1010000";
                        break;
                    }
                case 7:
                    {
                        str += "1000100";
                        break;
                    }
                case 8:
                    {
                        str += "1001000";
                        break;
                    }
                case 9:
                    {
                        str += "1110100";
                        break;
                    }
            }
            str += "01010";
            for (int i = 4; i < 7; i++)
            {
                switch (Int32.Parse(x[i].ToString()))
                {
                    default:
                        {
                            str += "0100111";
                            break;
                        }
                    case 1:
                        {
                            str += "0110011";
                            break;
                        }
                    case 2:
                        {
                            str += " 0011011";
                            break;
                        }
                    case 3:
                        {
                            str += "0100001";
                            break;
                        }
                    case 4:
                        {
                            str += "0011101";
                            break;
                        }
                    case 5:
                        {
                            str += "0111001";
                            break;
                        }
                    case 6:
                        {
                            str += "0000101";
                            break;
                        }
                    case 7:
                        {
                            str += "0010001";
                            break;
                        }
                    case 8:
                        {
                            str += "0001001";
                            break;
                        }
                    case 9:
                        {
                            str += "0010111";
                            break;
                        }
                }
            }
            switch (Int32.Parse(x[7].ToString()))
            {
                default:
                    {
                        str += "1110010";
                        break;
                    }
                case 1:
                    {
                        str += "1100110";
                        break;
                    }
                case 2:
                    {
                        str += "1101100 ";
                        break;
                    }
                case 3:
                    {
                        str += "1000010";
                        break;
                    }
                case 4:
                    {
                        str += "1011100";
                        break;
                    }
                case 5:
                    {
                        str += "1001110";
                        break;
                    }
                case 6:
                    {
                        str += "1010000";
                        break;
                    }
                case 7:
                    {
                        str += "1000100";
                        break;
                    }
                case 8:
                    {
                        str += "1001000";
                        break;
                    }
                case 9:
                    {
                        str += "1110100";
                        break;
                    }
            }
            str += "101";
            return str;
        }
        public Image CodEAN_8()
        {
            Font fontBold = new Font("Arial", 20, FontStyle.Bold);
            Font fontRegular = new Font("Arial", 20);
            Brush brush = Brushes.Black;
            if (this.Verifica_Cod())
            {
                string str = this.SirCaractere();
                char[] s = str.ToCharArray();
                Bitmap bitmap = new Bitmap(522, 249);
                int x = 26, y1 = 20, y2 = 190, y3 = 179;


                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    graphics.Clear(Color.White);
                    int z = 0, z1 = 1;
                    foreach (char c in s)
                    {
                        if (c == '1')
                        {
                            if (z > 2 && z < 30 || z > 35 && z < 63)
                            {
                                using (Pen pen = new Pen(Color.Black, 3))
                                {
                                    Point startPoint = new Point(x, y1);
                                    Point endPoint = new Point(x, y3);
                                    x += 5;
                                    graphics.DrawLine(pen, startPoint, endPoint);

                                }
                            }
                            else
                            {
                                using (Pen pen = new Pen(Color.Black, 3))
                                {
                                    Point startPoint = new Point(x, y1);
                                    Point endPoint = new Point(x, y2);
                                    x += 5;
                                    graphics.DrawLine(pen, startPoint, endPoint);

                                }
                            }
                        }
                        else
                        {
                            if (z > 2 && z < 30 || z > 35 && z < 63)
                            {
                                using (Pen pen = new Pen(Color.White, 3))
                                {
                                    Point startPoint = new Point(x, y1);
                                    Point endPoint = new Point(x, y3);
                                    x += 5;
                                    graphics.DrawLine(pen, startPoint, endPoint);

                                }
                            }
                            else
                            {
                                using (Pen pen = new Pen(Color.White, 3))
                                {
                                    Point startPoint = new Point(x, y1);
                                    Point endPoint = new Point(x, y2);
                                    x += 5;
                                    graphics.DrawLine(pen, startPoint, endPoint);
                                }
                            }
                        }
                        z++;
                    }
                    int x1 = 40;
                    for (int j = 0; j < Cod.Length / 2; j++)
                    {
                        string c = Cod[j].ToString();
                        using (Pen pen = new Pen(Color.White, 3))
                        {

                            graphics.DrawString(c.ToString(), fontBold, brush, x1, y3 + 2);
                            x1 += 33;

                        }
                    }
                    for (int j = Cod.Length / 2; j < Cod.Length; j++)
                    {
                        string c = Cod[j].ToString();
                        using (Pen pen = new Pen(Color.White, 3))
                        {

                            graphics.DrawString(c.ToString(), fontBold, brush, x1 + 40, y3 + 2);
                            x1 += 33;

                        }
                    }
                }

                Image image = (Image)bitmap;
                return image;
            }
            else
            {
                MessageBox.Show("Nu se valideaza");
                return null;
            }
        }
    }

    class ProdusAlimentar : Produs
    {
        public DateTime Expirare { get; set; }
        public ProdusAlimentar(string cod, string denumire, string descriere, string categorie, double pret, int stoc, DateTime expirare)
            : base(cod, denumire, descriere, "alimentar", pret, stoc)
        {
            this.Expirare = expirare;
        }
    }

    public class ProdusNealimentar : Produs
    {
        DateTime garantie;
        public ProdusNealimentar(string cod, string denumire, string descriere, string categorie, double pret, int stoc, DateTime garantie)
            : base(cod, denumire, descriere, "nealimentar", pret, stoc)
        {
            this.garantie = garantie;
        }
    }
}
