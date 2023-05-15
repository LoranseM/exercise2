using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2exercise
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "typographyDataSet1.DataTable1". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.typographyDataSet.orders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "typographyDataSet.orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.typographyDataSet.orders);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.ordersTableAdapter.Update(this.typographyDataSet);
        }
    
    }
}

