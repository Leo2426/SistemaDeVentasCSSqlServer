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

        DataTable tabletemp = new DataTable();
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



            tabletemp.Columns.Add("Id", typeof(int));
            tabletemp.Columns.Add("Código", typeof(string));
            tabletemp.Columns.Add("Descripción", typeof(string));
            tabletemp.Columns.Add("Costo", typeof(decimal));
            tabletemp.Columns.Add("Precio", typeof(decimal));
            tabletemp.Columns.Add("Stok Mínimo", typeof(int));
            tabletemp.Columns.Add("Stock", typeof(int));
            tabletemp.Columns.Add("Talla", typeof(string));


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

            ////ocultar columna id
            //dt_products.Columns["Id"].Visible = false;

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

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (dt_products.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un producto");
                return;
            }

            var product = new Product();

            product.Id = (int)(dt_products.CurrentRow.Cells["Id"].Value);
            product.Code = dt_products.CurrentRow.Cells["Código"].Value.ToString();
            product.Description = dt_products.CurrentRow.Cells["Descripción"].Value.ToString();
            product.Cost = (decimal)(dt_products.CurrentRow.Cells["Costo"].Value);
            product.Price = (decimal)(dt_products.CurrentRow.Cells["Precio"].Value);
            product.MinimumStock = (int)(dt_products.CurrentRow.Cells["Stok Mínimo"].Value);
            product.InitialStock = (int)(dt_products.CurrentRow.Cells["Stock"].Value);
            product.SizesId = dt_products.CurrentRow.Cells["Talla"].Value.ToString();


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
            productToUpdate.SizesId = product.SizesId;

            //actualizar el producto en el DataGridView buscando el id del producto en table
            foreach (DataRow row in table.Rows)
            {
                if ((int)row["Id"] == productToUpdate.Id )
                {
                    row["Código"] = productToUpdate.Code;
                    row["Descripción"] = productToUpdate.Description;
                    row["Costo"] = productToUpdate.Cost;
                    row["Precio"] = productToUpdate.Price;
                    row["Stok Mínimo"] = productToUpdate.MinimumStock;
                    row["Stock"] = productToUpdate.InitialStock;
                    row["Talla"] = productToUpdate.SizesId;
                    break;
                }
            }

            //actualizar el tabletemp
            foreach (DataRow row in tabletemp.Rows)
            {
                if ((int)row["Id"] == productToUpdate.Id)
                {
                    row["Código"] = productToUpdate.Code;
                    row["Descripción"] = productToUpdate.Description;
                    row["Costo"] = productToUpdate.Cost;
                    row["Precio"] = productToUpdate.Price;
                    row["Stok Mínimo"] = productToUpdate.MinimumStock;
                    row["Stock"] = productToUpdate.InitialStock;
                    row["Talla"] = productToUpdate.SizesId;
                    break;
                }
            }


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

            tabletemp.Rows.Clear();

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
