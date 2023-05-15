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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _2exercise
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = localhost; Initial Catalog = typography; Integrated Security = True");
            string str = "select * from login where login ='" + textBox1.Text + "' and password ='" + textBox2.Text + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            object obj = cmd.ExecuteScalar();
            if (obj == null)
            {
                MessageBox.Show("Такого логина и пароля в БД не существует");
            }
            else 
            { 
                MessageBox.Show("Вход успешно выполнен!");
            Form1 f1 = new Form1();
            f1.Show();
            Form3 f3 = new Form3();
            f3.Close();
            }

            

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }
    }
}
