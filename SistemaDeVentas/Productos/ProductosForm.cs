using SistemaDeVentas.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeVentas.Productos
{
    public partial class ProductosForm : Form
    {

        List<Product> products = new List<Product>();

        DataTable table = new DataTable();
        public ProductosForm()
        {
            InitializeComponent();
        }

        private async void ProductosForm_Load(object sender, EventArgs e)
        {

            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Código", typeof(string));
            table.Columns.Add("Descripción", typeof(string));
            table.Columns.Add("Costo", typeof(decimal));
            table.Columns.Add("Precio", typeof(decimal));
            table.Columns.Add("Stok Mínimo", typeof(int));
            table.Columns.Add("Stock", typeof(int));
            table.Columns.Add("Talla", typeof(string));

            await LoadProductsAsync();

            //cargar el cb_columns con los nombres de las columnas del datagrid
            foreach (DataGridViewColumn column in dt_products.Columns)
            {
                cb_columns.Items.Add(column.HeaderText);
            }
                
            //seleccionar por defecto nombre
            cb_columns.SelectedIndex = 1;
                
            // Llamar a cargar productos de forma asincrónica



        }

        private async Task LoadProductsAsync()
        {
            var productRepository = new ProductRepository();
            products = await productRepository.GetAllProductsAsync();

            //foreach (var product in products)
            //{
            //    dt_products.Rows.Add(product.Id, product.Code, product.Description, product.Cost, product.Price, product.MinimumStock, product.InitialStock, product.SizesId);
            //}

            table.Rows.Clear();

            foreach (var product in products)
            {
                table.Rows.Add(product.Id, product.Code, product.Description, product.Cost, product.Price, product.MinimumStock, product.InitialStock, product.SizesId);
            }


            dt_products.DataSource = table;

            //ocultar columna id
            dt_products.Columns["Id"].Visible = false;

        }

        private  void btn_add_product_Click(object sender, EventArgs e)
        {
            var addProductForm = new AddProductForm();

            addProductForm.ProductAdded += OnProductAdded;
            addProductForm.ShowDialog();


        }

        private void OnProductAdded(Product product)
        {
           MessageBox.Show("Producto agregado correctamente" + product.Description, "Producto agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            table.Rows.Add(product.Id, product.Code, product.Description, product.Cost, product.Price, product.MinimumStock, product.InitialStock, product.SizesId);
            products.Add(product);

            dt_products.Refresh();

        }

        private async void btn_update_Click(object sender, EventArgs e)
        {
            if (dt_products.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un producto");
                return;
            }

            var product = new Product();

            product.Id = (int)(table.Rows[dt_products.CurrentRow.Index]["Id"]);
            product.Code = table.Rows[dt_products.CurrentRow.Index]["Código"].ToString();
            product.Description = table.Rows[dt_products.CurrentRow.Index]["Descripción"].ToString();
            product.Cost = decimal.Parse(table.Rows[dt_products.CurrentRow.Index]["Costo"].ToString());
            product.Price = decimal.Parse(table.Rows[dt_products.CurrentRow.Index]["Precio"].ToString());
            product.MinimumStock = int.Parse(table.Rows[dt_products.CurrentRow.Index]["Stok Mínimo"].ToString());
            product.InitialStock = int.Parse(table.Rows[dt_products.CurrentRow.Index]["Stock"].ToString());
            product.SizesId = table.Rows[dt_products.CurrentRow.Index]["Talla"].ToString();


            var updateProductForm = new UpdateProductForm(product);
            updateProductForm.ProductUpdated += OnProductUpdated;
            updateProductForm.ShowDialog();


        }

        private void OnProductUpdated(Product product)
        {
            //actualizar el producto en products
            var productToUpdate = products.Find(p => p.Id == product.Id);
            productToUpdate.Code = product.Code;
            productToUpdate.Description = product.Description;
            productToUpdate.Cost = product.Cost;
            productToUpdate.Price = product.Price;
            productToUpdate.MinimumStock = product.MinimumStock;
            productToUpdate.InitialStock = product.InitialStock;

            //actualizar el producto en el DataGridView
            table.Rows[dt_products.CurrentRow.Index]["Código"] = product.Code;
            table.Rows[dt_products.CurrentRow.Index]["Descripción"] = product.Description;
            table.Rows[dt_products.CurrentRow.Index]["Costo"] = product.Cost;
            table.Rows[dt_products.CurrentRow.Index]["Precio"] = product.Price;
            table.Rows[dt_products.CurrentRow.Index]["Stok Mínimo"] = product.MinimumStock;
            table.Rows[dt_products.CurrentRow.Index]["Stock"] = product.InitialStock;
            table.Rows[dt_products.CurrentRow.Index]["Talla"] = product.SizesId;

            dt_products.Refresh();
        }

        private async void btn_delete_Click(object sender, EventArgs e)
        {
            if (dt_products.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un producto");
                return;
            }
            var product = new Product();
            product.Id = int.Parse(dt_products.CurrentRow.Cells["Id"].Value.ToString());
            var productRepository = new ProductRepository();

            if (await productRepository.ProductHasSalesAsync(product.Id))
            {
                MessageBox.Show("No se puede eliminar el producto porque tiene ventas asociadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show($"¿Está seguro de eliminar el producto {product.Description}?", "Eliminar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                await productRepository.DeleteProductAsync(product.Id);
                
                // Eliminar el producto de la lista
                products.RemoveAll(p => p.Id == product.Id);

                // Eliminar el producto del DataGridView
                dt_products.Rows.Remove(dt_products.CurrentRow);

            }
        }



        public void FilterData(string filterColumn, string filterValue)
        {
            string propertyName = MapUserFriendlyNameToPropertyName(filterColumn);
            var filteredList = products.Where(product =>
                product.GetType().GetProperty(propertyName)?.GetValue(product, null)?.ToString()?.IndexOf(filterValue, StringComparison.OrdinalIgnoreCase) >= 0
            ).ToList();

            UpdateDataGridView(filteredList);
        }

        private string MapUserFriendlyNameToPropertyName(string userFriendlyName)
        {
            switch (userFriendlyName)
            {
                case "Código":
                    return "Code";
                case "Descripción":
                    return "Description";
                case "Costo":
                    return "Cost";
                case "Precio":
                    return "Price";
                case "Stok Mínimo":
                    return "MinimumStock";
                case "Stock":
                    return "InitialStock";
                case "Talla":
                    return "SizesId";
                default:
                    return userFriendlyName;
            }
        }


        private void UpdateDataGridView(List<Product> filteredProducts)
        {
            DataTable tabletemp = new DataTable();
            //agregar columna
            tabletemp.Columns.Add("Id", typeof(int));
            tabletemp.Columns.Add("Código", typeof(string));
            tabletemp.Columns.Add("Descripción", typeof(string));
            tabletemp.Columns.Add("Costo", typeof(decimal));
            tabletemp.Columns.Add("Precio", typeof(decimal));
            tabletemp.Columns.Add("Stok Mínimo", typeof(int));
            tabletemp.Columns.Add("Stock", typeof(int));
            tabletemp.Columns.Add("Talla", typeof(string));

            foreach (var product in filteredProducts)
            {
               tabletemp.Rows.Add(product.Id, product.Code, product.Description, product.Cost, product.Price, product.MinimumStock, product.InitialStock, product.SizesId);
            }

            dt_products.DataSource = tabletemp;
        }

        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
 

            //si presiona enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                string selectedColumn = cb_columns.Text;

                FilterData(selectedColumn, txt_search.Text);

                e.Handled = true;
            }   


        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //Resetear el filtro
            dt_products.DataSource = table;
        }
    }

}
