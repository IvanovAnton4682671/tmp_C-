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
    public partial class FormProductAdd : Form
    {
        public NpgsqlConnection conn;

        public FormProductAdd(NpgsqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonProductAddCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonProductAddYes_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand("INSERT INTO Product (product_name, product_measurement_units) VALUES (:product_name, :product_measurement_units)", conn);
                command.Parameters.AddWithValue("product_name", textBoxProductName.Text);
                command.Parameters.AddWithValue("product_measurement_units", textBoxProductMeasurementUnits.Text);
                command.ExecuteNonQuery();
                Close();
            }
            catch (Exception ex)
            {
            }
        }
    }
}
