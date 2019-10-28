using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examenwinform
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private const string connectionString = "Server=localhost;Port=3306;" +
           "Database=sakila;Uid=root;";
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void durationListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // select length from film where title = "FORRESTER COMANCHEROS";
            
        }

        private void filmDescriptionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // select description from film where title = "FORRESTER COMANCHEROS";
        }

        private void ratingListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // select rating from film where title = "FORRESTER COMANCHEROS";
        }
    }
}
