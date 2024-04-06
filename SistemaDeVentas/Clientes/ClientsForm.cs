using SistemaDeVentas.Ubication;
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
    public partial class ClientsForm : Form
    {
        public ClientsForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

            ClientRepository clientRepository = new ClientRepository();
            //llenar datagrid
            List<Client> clients = clientRepository.GetAllClients();

            dt_clients.Rows.Clear();
            foreach (Client c in clients)
            {
                dt_clients.ColumnCount = 9;
                dt_clients.Columns[0].Name = "id";
                dt_clients.Columns[1].Name = "name";
                dt_clients.Columns[2].Name = "address";
                dt_clients.Columns[3].Name = "document";
                dt_clients.Columns[4].Name = "phone";
                dt_clients.Columns[5].Name = "reference";
                dt_clients.Columns[6].Name = "department";
                dt_clients.Columns[7].Name = "province";
                dt_clients.Columns[8].Name = "district";
              
                dt_clients.Rows.Add(c.Id, c.Name, c.Address, c.Document, c.Phone, c.Reference, c.Department, c.Province, c.District);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddClientForm addClientForm = new AddClientForm();
            addClientForm.ShowDialog();

            updateDataGrid();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //obtener cliente seleccionado
            Client client = new Client();
            client.Id = Convert.ToInt32(dt_clients.CurrentRow.Cells[0].Value);
            client.Name = dt_clients.CurrentRow.Cells[1].Value.ToString();
            client.Address = dt_clients.CurrentRow.Cells[2].Value.ToString();
            client.Document = dt_clients.CurrentRow.Cells[3].Value.ToString();
            client.Phone = dt_clients.CurrentRow.Cells[4].Value.ToString();
            client.Reference = dt_clients.CurrentRow.Cells[5].Value.ToString();
            client.Department = dt_clients.CurrentRow.Cells[6].Value.ToString();
            client.Province = dt_clients.CurrentRow.Cells[7].Value.ToString();
            client.District = dt_clients.CurrentRow.Cells[8].Value.ToString();

            UpdateClientForm updateClientForm = new UpdateClientForm(client);
            updateClientForm.ShowDialog();
            
            updateDataGrid();
        }

        void updateDataGrid()
        {
            dt_clients.Rows.Clear();
            ClientRepository clientRepository = new ClientRepository();
            List<Client> clients = clientRepository.GetAllClients();
            foreach (Client c in clients)
            {
                dt_clients.Rows.Add(c.Id, c.Name, c.Address, c.Document, c.Phone, c.Reference, c.Department, c.Province, c.District);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //seleccionar id del cliente
            int id = Convert.ToInt32(dt_clients.CurrentRow.Cells[0].Value);

            //crear message box para confirmar eliminacion
            DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar este cliente?", "Eliminar Cliente", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                //eliminar cliente
                ClientRepository clientRepository = new ClientRepository();
                clientRepository.deleteClient(id);
            }

            updateDataGrid();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string searchTerm = txt_search.Text;
            ClientRepository clientRepository = new ClientRepository();
            List<Client> clients = clientRepository.searchClient(searchTerm);

            dt_clients.Rows.Clear();
            foreach (Client c in clients)
            {
                dt_clients.Rows.Add(c.Id, c.Name, c.Address, c.Document, c.Phone, c.Reference, c.Department, c.Province, c.District);
            }


        }
    }
}
