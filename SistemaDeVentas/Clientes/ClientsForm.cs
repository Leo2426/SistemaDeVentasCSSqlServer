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

        List<Client> clients;
        public ClientsForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

            //si no hay columnas en el datagridview
            if (dt_clients.Columns.Count == 0)
            {
                //renombrar columnas
                dt_clients.Columns.Add("Id", "Id");
                dt_clients.Columns.Add("Name", "Nombre");
                dt_clients.Columns.Add("Address", "Dirección");
                dt_clients.Columns.Add("Document", "Documento");
                dt_clients.Columns.Add("Phone", "Teléfono");
                dt_clients.Columns.Add("Reference", "Referencia");
                dt_clients.Columns.Add("Department", "Departamento");
                dt_clients.Columns.Add("Province", "Provincia");
                dt_clients.Columns.Add("District", "Distrito");

                //cargar el cb_columns con los nombres de las columnas del datagrid
                foreach (DataGridViewColumn column in dt_clients.Columns)
                {
                    cb_columns.Items.Add(column.HeaderText);
                }

                //seleccionar por defecto nombre
                cb_columns.SelectedIndex = 1;
                //cargar datagrid
                loadGrid();
            }
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
            client.Id= (int)(dt_clients.CurrentRow.Cells[0].Value);
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

            loadGrid();
        }

        // Asegúrate de que el método sea async
        async void loadGrid()
        {
            ClientRepository clientRepository = new ClientRepository();

            // Usar Task.Run para ejecutar de forma asíncrona la obtención de datos
            clients = await Task.Run(() => clientRepository.GetAllClientsAsync().Result);

            // Acceder al control de la UI en el thread principal
            this.Invoke((MethodInvoker)delegate
            {
                dt_clients.Rows.Clear();

                // Insertar lista de clientes en datagrid
                foreach (Client client in clients)
                {
                    dt_clients.Rows.Add(client.Id, client.Name, client.Address, client.Document, client.Phone, client.Reference, client.Department, client.Province, client.District);
                }

                // Ocultar columna id
                dt_clients.Columns["Id"].Visible = false;
            });



        }

        public void FilterData(string filterColumn, string filterValue)
        {
            var filteredList = clients.Where(client =>
                client.GetType().GetProperty(filterColumn)?.GetValue(client, null).ToString().IndexOf(filterValue, StringComparison.OrdinalIgnoreCase) >= 0
            ).ToList();

            UpdateDataGridView(filteredList);
        }


        private void UpdateDataGridView(List<Client> filteredClients)
        {
            dt_clients.Rows.Clear();
            foreach (var client in filteredClients)
            {
                dt_clients.Rows.Add(client.Id, client.Name, client.Address, client.Document, client.Phone, client.Reference, client.Department, client.Province, client.District);
            }
        }

        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            //si presiona enter buscar
            if (e.KeyChar == (char)Keys.Enter)
            {
                //string selectedColumn = cb_columns.SelectedItem.ToString();
                string selectedColumn;
                if (cb_columns.SelectedItem.ToString() == "Nombre")
                    selectedColumn = "Name";
                else if (cb_columns.SelectedItem.ToString() == "Dirección")
                    selectedColumn = "Address";
                else if (cb_columns.SelectedItem.ToString() == "Documento")
                    selectedColumn = "Document";
                else if (cb_columns.SelectedItem.ToString() == "Teléfono")
                    selectedColumn = "Phone";
                else if (cb_columns.SelectedItem.ToString() == "Referencia")
                    selectedColumn = "Reference";
                else if (cb_columns.SelectedItem.ToString() == "Departamento")
                    selectedColumn = "Department";
                else if (cb_columns.SelectedItem.ToString() == "Provincia")
                    selectedColumn = "Province";
                else
                    selectedColumn = "District";



                FilterData(selectedColumn, txt_search.Text);

                e.Handled = true;
            }

            //cargar el dt

            if (txt_search.Text == "")
            {
                loadGrid();
            }

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
                loadGrid();

            }


        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //reinciar el datagrid
            FilterData("Name", "");
        }
    }
}
