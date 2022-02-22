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

namespace SingleResponsibility
{
    public partial class Form1 : Form
    {
        /*
         * Bir nesnenin yalnızca bir sorumluluğu olmalı!
         * 
         * Bir nesne içinde değişiklik yapmak için birden fazla sebebiniz varsa prensibe uymuyorsunuz demektir !!!
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            string name = textBoxProductName.Text;
            decimal price = Convert.ToDecimal(textBoxUnitPrice.Text);

            var affectedRows = new ProductService().AddProduct(name, price);
            string message = affectedRows > 0 ? "Başarılı" : "Başarısız";
            MessageBox.Show(message);

        }
    }
}
