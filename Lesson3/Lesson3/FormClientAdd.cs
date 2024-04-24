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
    public partial class FormClientAdd : Form
    {
        public NpgsqlConnection conn;
        public int clientId = -1;
        public string clientName;
        public string clientAddress;
        public string clientPhone;

        public FormClientAdd(NpgsqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public FormClientAdd(NpgsqlConnection conn, int clientId, string clientName, string clientAddress, string clientPhone)
        {
            InitializeComponent();
            this.conn = conn;
            this.clientId = clientId;
            this.clientName = clientName;
            this.clientAddress = clientAddress;
            this.clientPhone = clientPhone;
            textBoxClientName.Text = clientName;
            textBoxClientAddress.Text = clientAddress;
            textBoxClientPhone.Text = clientPhone;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonClientAddYes_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.clientId == -1)
                {
                    NpgsqlCommand command = new NpgsqlCommand("INSERT INTO Client (client_name, client_address, client_phone) VALUES (:client_name, :client_address, :client_phone)", conn);
                    command.Parameters.AddWithValue("client_name", textBoxClientName.Text);
                    command.Parameters.AddWithValue("client_address", textBoxClientAddress.Text);
                    command.Parameters.AddWithValue("client_phone", textBoxClientPhone.Text);
                    command.ExecuteNonQuery();
                    Close();
                }
                else
                {
                    NpgsqlCommand command = new NpgsqlCommand("UPDATE Client SET client_name = :client_name, client_address = :client_address, client_phone = :client_phone WHERE client_id = :client_id", conn);
                    command.Parameters.AddWithValue("client_id", this.clientId);
                    command.Parameters.AddWithValue("client_name", textBoxClientName.Text);
                    command.Parameters.AddWithValue("client_address", textBoxClientAddress.Text);
                    command.Parameters.AddWithValue("client_phone", textBoxClientPhone.Text);
                    command.ExecuteNonQuery();
                    Close();
                }
            }
            catch(Exception ex) { }
        }

        private void buttonClientAddCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
