using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson3
{
    public partial class FormProduct : Form
    {
        public NpgsqlConnection conn;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        public FormProduct(NpgsqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            String sql = "Select * from Product";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridViewProduct.DataSource = dt;
            dataGridViewProduct.Columns[0].HeaderText = "Номер";
            dataGridViewProduct.Columns[1].HeaderText = "Наименование";
            dataGridViewProduct.Columns[2].HeaderText = "Единицы измерения";
            dataGridViewProduct.Refresh();
        }

        private void Update()
        {
            String sql = "Select * from Product";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridViewProduct.DataSource = dt;
            dataGridViewProduct.Columns[0].HeaderText = "Номер";
            dataGridViewProduct.Columns[1].HeaderText = "Наименование";
            dataGridViewProduct.Columns[2].HeaderText = "Единицы измерения";
            dataGridViewProduct.Refresh();
        }

        private void buttonProductShowAdd_Click(object sender, EventArgs e)
        {
            FormProductAdd formProductAdd = new FormProductAdd(conn);
            formProductAdd.ShowDialog();
            Update();
        }

        private void buttonProductDel_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridViewProduct.CurrentRow.Cells["product_id"].Value;
                NpgsqlCommand command = new NpgsqlCommand("DELETE FROM Product WHERE product_id = :product_id", conn);
                command.Parameters.AddWithValue("product_id", id);
                command.ExecuteNonQuery();
                Update();
            }
            catch (Exception ex)
            {
            }
        }

        private void buttonProductChange_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridViewProduct.CurrentRow.Cells["product_id"].Value;
            string productName = (string)dataGridViewProduct.CurrentRow.Cells["product_name"].Value.ToString();
            string productMeasurementUnits = (string)dataGridViewProduct.CurrentRow.Cells["product_measurement_units"].Value.ToString();
            FormProductAdd formProductAdd = new FormProductAdd(conn, id, productName, productMeasurementUnits);
            formProductAdd.ShowDialog();
            Update();
        }
    }
}
