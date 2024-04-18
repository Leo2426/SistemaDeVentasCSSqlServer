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
            //cargar datagrid
            loadGrid();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddClientForm addClientForm = new AddClientForm();
            addClientForm.ShowDialog();
            loadGrid();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //obtener cliente seleccionado
            Client client = new Client();
            
            //select el cliente del datagrid
            client = (Client)dt_clients.CurrentRow.DataBoundItem;

            UpdateClientForm updateClientForm = new UpdateClientForm(client);
            updateClientForm.ShowDialog();

            loadGrid();
        }

        void loadGrid()
        {

            ClientRepository clientRepository = new ClientRepository();
            //llenar datagrid
            List<Client> clients = clientRepository.GetAllClients();

            dt_clients.DataSource = clients;

            //renombrar columnas
            dt_clients.Columns["Id"].HeaderText = "Id";
            dt_clients.Columns["Name"].HeaderText = "Nombre";
            dt_clients.Columns["Address"].HeaderText = "Dirección";
            dt_clients.Columns["Document"].HeaderText = "Documento";
            dt_clients.Columns["Phone"].HeaderText = "Teléfono";
            dt_clients.Columns["Reference"].HeaderText = "Referencia";
            dt_clients.Columns["Department"].HeaderText = "Departamento";
            dt_clients.Columns["Province"].HeaderText = "Provincia";
            dt_clients.Columns["District"].HeaderText = "Distrito";

            //ocultar id
            dt_clients.Columns["Id"].Visible = false;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //validar si se selecciono un cliente
            if (dt_clients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un cliente", "Eliminar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

            loadGrid();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string searchTerm = txt_search.Text;
            ClientRepository clientRepository = new ClientRepository();
            List<Client> clients = clientRepository.searchClient(searchTerm);

            dt_clients.DataSource = clients;


        }

        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            //si presiona enter buscar
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_search.PerformClick();
            }
        }
    }
}
