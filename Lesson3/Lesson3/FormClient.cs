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
    public partial class FormClient : Form
    {
        public NpgsqlConnection conn;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        public FormClient(NpgsqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            String sql = "Select * from Client";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridViewClient.DataSource = dt;
            dataGridViewClient.Columns[0].HeaderText = "Номер";
            dataGridViewClient.Columns[1].HeaderText = "ФИО";
            dataGridViewClient.Columns[2].HeaderText = "Адрес";
            dataGridViewClient.Columns[3].HeaderText = "Телефон";
            dataGridViewClient.Refresh();
        }

        private void Update()
        {
            String sql = "Select * from Client";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridViewClient.DataSource = dt;
            dataGridViewClient.Columns[0].HeaderText = "Номер";
            dataGridViewClient.Columns[1].HeaderText = "ФИО";
            dataGridViewClient.Columns[2].HeaderText = "Адрес";
            dataGridViewClient.Columns[3].HeaderText = "Телефон";
            dataGridViewClient.Refresh();
        }

        private void buttonClientShowAdd_Click(object sender, EventArgs e)
        {
            FormClientAdd formClientAdd = new FormClientAdd(conn);
            formClientAdd.ShowDialog();
            Update();
        }

        private void buttonClientChange_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridViewClient.CurrentRow.Cells["client_id"].Value;
            string clientName = (string)dataGridViewClient.CurrentRow.Cells["client_name"].Value.ToString();
            string clientAddress = (string)dataGridViewClient.CurrentRow.Cells["client_address"].Value.ToString();
            string clientPhone = (string)dataGridViewClient.CurrentRow.Cells["client_phone"].Value.ToString();
            FormClientAdd formClientAdd = new FormClientAdd(conn, id, clientName, clientAddress, clientPhone);
            formClientAdd.ShowDialog();
            Update();
        }

        private void buttonClientDel_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridViewClient.CurrentRow.Cells["client_id"].Value;
                NpgsqlCommand command = new NpgsqlCommand("DELETE FROM Client WHERE client_id = :client_id", conn);
                command.Parameters.AddWithValue("client_id", id);
                command.ExecuteNonQuery();
                Update();
            }
            catch (Exception ex) { }
        }
    }
}
