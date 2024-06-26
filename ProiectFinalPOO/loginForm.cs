using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProiectFinalPOO
{
    public partial class loginForm : Form
    {
        private Manager manager;

        public loginForm(Manager manager) 
        {
            InitializeComponent();
            this.manager = manager;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxNume.Text;
            string password = textBoxParola.Text;

            Client client_logat = manager.Authenticate(name, password);

            if (client_logat != null)
            {
                MessageBox.Show("Logat cu succes!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Create an instance of ClientData and populate it with authenticated client's information
                ClientCurent.nume = client_logat.Nume;
                ClientCurent.adresa = client_logat.Adresa;
                ClientCurent.banca = client_logat.Banca;
                ClientCurent.CIF = client_logat.CIF;
                ClientCurent.cont = client_logat.Cont;
                ClientCurent.regcom = client_logat.RegCom;

                this.Hide();
                storeForm storeForm = new storeForm();
                storeForm.Show();
            }
            else
            {
                MessageBox.Show("Nume/Parola invalida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
