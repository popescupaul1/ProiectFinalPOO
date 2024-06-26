using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectFinalPOO
{
    public partial class accountForm : Form
    {
        private static int IDcurent = 1001;
        Client client;
        private List<Client> clienti; 

        public accountForm()
        {
            InitializeComponent();
            clienti = new List<Client>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client clientNou = new Client
            {
                id = IDcurent,
                Nume = textBoxNume.Text,
                Parola = textBoxParola.Text,
                Adresa = textBoxAdresa.Text,
                CIF = textBoxCIF.Text,
                Banca = textBoxBanca.Text,
                RegCom = textBoxRegCom.Text,
                Cont = textBoxCont.Text
            };

            clienti.Add(clientNou);

            try
            {

                string folderPath = @"D:\ProiectFinalPOO\ProiectFinalPOO\bin\Debug\Clienti";
                string filePath = Path.Combine(folderPath, $"{clientNou.id}.txt");
                Directory.CreateDirectory(folderPath);

                string content = $"Nume: {clientNou.Nume}\n" +
                                 $"Parola: {clientNou.Parola}\n" +
                                 $"Adresa: {clientNou.Adresa}\n" +
                                 $"CIF: {clientNou.CIF}\n" +
                                 $"Banca: {clientNou.Banca}\n" +
                                 $"RegCom: {clientNou.RegCom}\n" +
                                 $"Cont: {clientNou.Cont}\n";

                File.WriteAllText(filePath, content);

                IDcurent++;

                MessageBox.Show("Succes!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            Close();
        }
    }
}
