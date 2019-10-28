using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using MySql.Data.MySqlClient;

namespace examenwinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mainrichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private const string connectionString = "Server=localhost;Port=3306;" +
           "Database=sakila;Uid=root;";

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
  
            List<Film> films = new List<Film>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            string sql = $"SELECT title FROM film " + "WHERE title = {filmTextBox.Text}";
            films = conn.Query<Film>(sql).ToList();
            Console.WriteLine(films[5].title);
            conn.Close();
        }

     
        private void filmListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
/*
 * 1 Busqueda peliculas en text box y mostrar en listbox
 * 
 */
