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
                dt_clients.ColumnCount = 8;
                dt_clients.Columns[0].Name = "Nombre";
                dt_clients.Columns[1].Name = "Dirección";
                dt_clients.Columns[2].Name = "Documento";
                dt_clients.Columns[3].Name = "Teléfono";
                dt_clients.Columns[4].Name = "Referencia";
                dt_clients.Columns[5].Name = "Departamento";
                dt_clients.Columns[6].Name = "Provincia";
                dt_clients.Columns[7].Name = "Distrito";

                dt_clients.Rows.Add(c.Name, c.Address, c.Document, c.Phone, c.Reference, c.Department, c.Province, c.District);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddClientForm addClientForm = new AddClientForm();
            addClientForm.ShowDialog();

            //actualizar datagrid

            dt_clients.Rows.Clear();
            ClientRepository clientRepository = new ClientRepository();
            List<Client> clients = clientRepository.GetAllClients();
            foreach (Client c in clients) {
                dt_clients.Rows.Add(c.Name, c.Address, c.Document, c.Phone, c.Reference, c.Department, c.Province, c.District);
            }

        }
    }
}
