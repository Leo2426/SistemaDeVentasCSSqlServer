using SistemaDeVentas.Productos;
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

        List<Client> clients = new List<Client>();
        DataTable clientsTable = new DataTable();
        DataTable tabletemp = new DataTable();


        public ClientsForm()
        {
            InitializeComponent();
        }

        private async void ClientForm_Load(object sender, EventArgs e)
        {
            SetupDataTable();
            SetupDataTabletemp();
            await LoadClientsAsync();

            cb_columns.DataSource = clientsTable.Columns.Cast<DataColumn>()
                                    .Select(c => c.ColumnName).ToList();
            cb_columns.SelectedIndex = 1;  // Por defecto seleccionar 'Nombre'
        }

        private void SetupDataTabletemp()
        {
            tabletemp.Columns.Add("Id", typeof(int));
            tabletemp.Columns.Add("Nombre", typeof(string));
            tabletemp.Columns.Add("Dirección", typeof(string));
            tabletemp.Columns.Add("Documento", typeof(string));
            tabletemp.Columns.Add("Teléfono", typeof(string));
            tabletemp.Columns.Add("Referencia", typeof(string));
            tabletemp.Columns.Add("Departamento", typeof(string));
            tabletemp.Columns.Add("Provincia", typeof(string));
            tabletemp.Columns.Add("Distrito", typeof(string));
        }
        

        private void SetupDataTable()
        {
            clientsTable.Columns.Add("Id", typeof(int));
            clientsTable.Columns.Add("Nombre", typeof(string));
            clientsTable.Columns.Add("Dirección", typeof(string));
            clientsTable.Columns.Add("Documento", typeof(string));
            clientsTable.Columns.Add("Teléfono", typeof(string));
            clientsTable.Columns.Add("Referencia", typeof(string));
            clientsTable.Columns.Add("Departamento", typeof(string));
            clientsTable.Columns.Add("Provincia", typeof(string));
            clientsTable.Columns.Add("Distrito", typeof(string));
        }
        private async Task LoadClientsAsync()
        {
            var clientRepository = new ClientRepository();
            clients = await clientRepository.GetAllClientsAsync();

            clientsTable.Rows.Clear();
            foreach (var client in clients)
            {
                clientsTable.Rows.Add(client.Id, client.Name, client.Address, client.Document,
                                      client.Phone, client.Reference, client.Department,
                                      client.Province, client.District);
            }

            dt_clients.DataSource = clientsTable;
            dt_clients.Columns["Id"].Visible = false; // Ocultar columna de ID
        }


        private async void btn_add_Click(object sender, EventArgs e)
        {
            var addClientForm = new AddClientForm();

            // Suscribirse al evento ProductAdded
            addClientForm.cliendAdded += onClienAdded;

            if (addClientForm.ShowDialog() == DialogResult.OK)
            {
                await LoadClientsAsync();
            }
        }

        private void onClienAdded(Client client)
        {
            clientsTable.Rows.Add(client.Id, client.Name, client.Address, client.Document, client.Phone, client.Reference, client.Department, client.Province, client.District);
            clients.Add(client);

            dt_clients.Refresh();
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (dt_clients.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un cliente");
                return;
            }

            var client = new Client()
            {
                Id = Convert.ToInt32(dt_clients.CurrentRow.Cells["Id"].Value),
                Name = dt_clients.CurrentRow.Cells["Nombre"].Value.ToString(),
                Address = dt_clients.CurrentRow.Cells["Dirección"].Value.ToString(),
                Document = dt_clients.CurrentRow.Cells["Documento"].Value.ToString(),
                Phone = dt_clients.CurrentRow.Cells["Teléfono"].Value.ToString(),
                Reference = dt_clients.CurrentRow.Cells["Referencia"].Value.ToString(),
                Department = dt_clients.CurrentRow.Cells["Departamento"].Value.ToString(),
                Province = dt_clients.CurrentRow.Cells["Provincia"].Value.ToString(),
                District = dt_clients.CurrentRow.Cells["Distrito"].Value.ToString()
            };

            var updateClientForm = new UpdateClientForm(client);

            // Suscribirse al evento ProductUpdated
            updateClientForm.ClientUpdated += onClientUpdated;

            updateClientForm.ShowDialog();
        }

        private void onClientUpdated(Client client)
        {
            //actualizar la fila en la tabla
            var row = clientsTable.AsEnumerable().FirstOrDefault(r => r.Field<int>("Id") == client.Id);
            if (row != null)
            {
                row.SetField("Nombre", client.Name);
                row.SetField("Dirección", client.Address);
                row.SetField("Documento", client.Document);
                row.SetField("Teléfono", client.Phone);
                row.SetField("Referencia", client.Reference);
                row.SetField("Departamento", client.Department);
                row.SetField("Provincia", client.Province);
                row.SetField("Distrito", client.District);
            }

            //actualizar la lista de productos
            var clientToUpdate = clients.FirstOrDefault(c => c.Id == client.Id);
            if (clientToUpdate != null)
            {
                clientToUpdate.Name = client.Name;
                clientToUpdate.Address = client.Address;
                clientToUpdate.Document = client.Document;
                clientToUpdate.Phone = client.Phone;
                clientToUpdate.Reference = client.Reference;
                clientToUpdate.Department = client.Department;
                clientToUpdate.Province = client.Province;
                clientToUpdate.District = client.District;
            }

            //actualizar el tabletemp
            foreach (DataRow rowd in tabletemp.Rows)
            {
                if ((int)rowd["Id"] == clientToUpdate.Id)
                {
                    rowd["Nombre"] = clientToUpdate.Name;
                    rowd["Dirección"] = clientToUpdate.Address;
                    rowd["Documento"] = clientToUpdate.Document;
                    rowd["Teléfono"] = clientToUpdate.Phone;
                    rowd["Referencia"] = clientToUpdate.Reference;
                    rowd["Departamento"] = clientToUpdate.Department;
                    rowd["Provincia"] = clientToUpdate.Province;
                    rowd["Distrito"] = clientToUpdate.District;

                
                    break;
                }
            }


            dt_clients.Refresh();
        }

        public void FilterData(string filterColumn, string filterValue)
        {
            string propertyName = MapUserFriendlyNameToPropertyName(filterColumn);
            var filteredList = clients.Where(client =>
                client.GetType().GetProperty(propertyName)?.GetValue(client, null)?.ToString()?.IndexOf(filterValue, StringComparison.OrdinalIgnoreCase) >= 0
            ).ToList();

            UpdateDataGridView(filteredList);
        }

        private void UpdateDataGridView(List<Client> filteredClients)
        {
            tabletemp.Rows.Clear();
            foreach (var client in filteredClients)
            {
                tabletemp.Rows.Add(client.Id, client.Name, client.Address, client.Document, client.Phone, client.Reference, client.Department, client.Province, client.District);
            }
            dt_clients.DataSource = tabletemp;
        }


        private string MapUserFriendlyNameToPropertyName(string userFriendlyName)
        {
            switch (userFriendlyName)
            {
                case "Nombre": return "Name";
                case "Dirección": return "Address";
                case "Documento": return "Document";
                case "Teléfono": return "Phone";
                case "Referencia": return "Reference";
                case "Departamento": return "Department";
                case "Provincia": return "Province";
                case "Distrito": return "District";
                default: return null;  // Retorna nulo si no hay coincidencia
            }
        }




        private async void btn_delete_Click(object sender, EventArgs e)
        {
            if (dt_clients.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un cliente", "Eliminar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int clientId = Convert.ToInt32(dt_clients.CurrentRow.Cells["Id"].Value);
            var clientRepository = new ClientRepository();

            if (await clientRepository.ClientHasTransactionsAsync(clientId))
            {
                MessageBox.Show("No se puede eliminar el cliente porque tiene transacciones asociadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show("¿Está seguro que desea eliminar este cliente?", "Eliminar Cliente", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                clientRepository.deleteClient(clientId);

                // Eliminar la fila del DataGridView
                var row = clientsTable.AsEnumerable().FirstOrDefault(r => r.Field<int>("Id") == clientId);
                if (row != null)
                {
                    clientsTable.Rows.Remove(row);
                }

                // Eliminar el producto de la lista de productos
                var client = clients.FirstOrDefault(c => c.Id == clientId);
                if (client != null)
                {
                    clients.Remove(client);
                }

                // Eliminar el producto de la tabla temporal
                foreach (DataRow rowd in tabletemp.Rows)
                {
                    if ((int)rowd["Id"] == clientId)
                    {
                        tabletemp.Rows.Remove(rowd);
                        break;
                    }
                }

                dt_clients.Refresh();


            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            FilterData(cb_columns.Text, txt_search.Text);
        }

        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            //si se presiona la tecla enter
            if (e.KeyChar == (char)13)
            {
                FilterData(cb_columns.Text, txt_search.Text);

                e.Handled = true;
            }

        }

        private void dt_clients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_edit.PerformClick();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            DataGridView dataGrid = dt_clients;


            if (dataGrid.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.ApplicationClass MExcel = new Microsoft.Office.Interop.Excel.ApplicationClass();
                MExcel.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dataGrid.Columns.Count + 1; i++)
                {
                    MExcel.Cells[1, i] = dataGrid.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGrid.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGrid.Columns.Count; j++)
                    {
                        MExcel.Cells[i + 2, j + 1] = dataGrid.Rows[i].Cells[j].Value.ToString();
                    }
                }
                MExcel.Columns.AutoFit();
                MExcel.Rows.AutoFit();
                MExcel.Columns.Font.Size = 12;
                MExcel.Visible = true;
            }
            else
            {
                MessageBox.Show("No records found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
