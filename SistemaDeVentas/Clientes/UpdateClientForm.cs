using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeVentas.Clientes
{
    public partial class UpdateClientForm : Form
    {
        Client client;
        public UpdateClientForm(Client client)
        {
            InitializeComponent();
            this.client = client;
        }

        private void UpdateClientForm_Load(object sender, EventArgs e)
        {
            txt_name.Text = client.Name;
            txt_address.Text = client.Address;
            txt_document.Text = client.Document;
            txt_phone.Text = client.Phone;
            txt_reference.Text = client.Reference;
            cb_department.Text = client.Department;
            cb_province.Text = client.Province;
            cb_district.Text = client.District;

        }

        private void btn_add_client_Click(object sender, EventArgs e)
        {
            client.Name = txt_name.Text;
            client.Address = txt_address.Text;
            client.Document = txt_document.Text;
            client.Phone = txt_phone.Text;
            client.Reference = txt_reference.Text;
            client.Department = cb_department.Text;
            client.Province = cb_province.Text;
            client.District = cb_district.Text;

            ClientRepository clientRepository = new ClientRepository();
            clientRepository.UpdateClient(client);
            this.Close();

        }
    }
}
