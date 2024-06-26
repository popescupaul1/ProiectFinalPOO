using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectFinalPOO
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void despreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutForm despreForm = new aboutForm();
            despreForm.ShowDialog();
        }

        private void viewStock_Click(object sender, EventArgs e)
        {
            viewStockForm vsForm = new viewStockForm();
            vsForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            accountForm accForm = new accountForm();
            accForm.Show();
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            string directoryPath = @"D:\ProiectFinalPOO\ProiectFinalPOO\bin\Debug\Clienti";
            Manager manager = new Manager(directoryPath);
            loginForm lgForm = new loginForm(manager);
            lgForm.ShowDialog();
        }
    }
}
