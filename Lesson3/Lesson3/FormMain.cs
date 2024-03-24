using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Lesson3
{
    public partial class FormMain : Form
    {
        public NpgsqlConnection conn;

        public FormMain()
        {
            InitializeComponent();
            MyLoad();
        }

        public void MyLoad()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            conn = new NpgsqlConnection("Server=localhost;Port=5432;UserID=postgres;Password=postpass;Database=C#_database_Ivanov_Anton_34");
            conn.Open();
        }

        private void buttonProduct_Click(object sender, EventArgs e)
        {
            FormProduct formProduct = new FormProduct(conn);
            formProduct.ShowDialog();
        }
    }
}
