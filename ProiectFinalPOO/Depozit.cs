using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProiectFinalPOO
{
    internal class Depozit
    {
        private static Depozit instance = null;
        private static object Depozitlock = new object();
        public List<Produs> produse = new List<Produs>();

        private Depozit()
        {
            produse = preia_produse_de_pe_server();
        }

        public static Depozit Instance
        {
            get
            {
                lock (Depozitlock)
                {
                    if (instance == null)
                        instance = new Depozit();
                }
                return instance;
            }
        }

        private List<Produs> preia_produse_de_pe_server()
        {
            string file = @"D:\ProiectFinalPOO\ProiectFinalPOO\bin\Debug\stocuri.xml";
            List<Produs> noi = new List<Produs>();

            try
            {
                using (XmlTextReader reader = new XmlTextReader(file))
                {
                    Produs produsCurent = null;

                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element)
                        {
                            if (reader.Name == "produs" && reader.HasAttributes)
                            {
                                produsCurent = new Produs(reader.GetAttribute("categorie"));
                            }
                            else if (produsCurent != null)
                            {
                                switch (reader.Name)
                                {
                                    case "cod":
                                        produsCurent.Cod = reader.ReadElementContentAsString();
                                        break;
                                    case "denumire":
                                        produsCurent.Denumire = reader.ReadElementContentAsString();
                                        break;
                                    case "descriere":
                                        produsCurent.Descriere = reader.ReadElementContentAsString();
                                        break;
                                    case "pret":
                                        try
                                        {
                                            produsCurent.Pret = reader.ReadElementContentAsDouble();
                                        }
                                        catch
                                        {
                                            produsCurent.Pret = 0;
                                        }
                                        break;
                                    case "stoc":
                                        try
                                        {
                                            produsCurent.Stoc = reader.ReadElementContentAsInt();
                                        }
                                        catch
                                        {
                                            produsCurent.Stoc = 0;
                                        }
                                        break;
                                }
                            }
                        }
                        else if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "produs" && produsCurent != null)
                        {
                            noi.Add(produsCurent);
                            produsCurent = null;
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Eroare: {ex.Message}");
            }

            return noi;
        }
    }

}