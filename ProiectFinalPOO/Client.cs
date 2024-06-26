using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ProiectFinalPOO
{
    public class Client
    {

        public int id = 1000;
        public string Nume { get; set; }
        public string Parola { get; set; }
        public string Adresa { get; set; }

        public string Telefon {  get; set; }
        public string CIF { get; set; }
        public string Banca { get; set; }
        public string Cont { get; set; }
        public string RegCom { get; set; }

        public string Email { get; set; }


        public Client() { }

        public Client(int id, string nume, string parola, string adresa, string CIF, string banca, string cont, string regCom)
        {
            this.id = id;
            Nume = nume;
            Parola = parola;
            Adresa = adresa;
            this.CIF = CIF;
            Banca = banca;
            Cont = cont;
            RegCom = regCom;
        }
    }

    public class Furnizor : Client
    {
        public Furnizor()
        {
            this.Nume = "Popescu Paul-Constantin";
            this.Parola = "12349876";
            this.Adresa = "Barlad";
            this.Banca = "RaiffeisenBank";
            this.Cont = "RO53RZBR0000060019974649";
            this.RegCom = "J13/12345/1990";
            this.CIF = "ROF1268745834813";
            this.Email = "paul.popescu263@gmail.com";
            this.Telefon = "0741492525";
        }

        public string Email { get; set; }
        public string Telefon { get; set; }
    }

    public static class ClientCurent 
    {
        public static int id = 0;
        public static string nume = "";
        public static string parola = "";
        public static string CIF = "";
        public static string adresa = "";
        public static string regcom = "";
        public static string banca = "";
        public static string cont = "";
    }
}
