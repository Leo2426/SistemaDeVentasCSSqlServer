﻿using SistemaDeVentas.Productos;
using SistemaDeVentas.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeVentas.Ventas
{
    public partial class SearchProductForm : Form
    {
        private string conectionString = Conexion.stringConexion;
        private List<Product> products = new List<Product>();
        public SearchProductForm()
        {
            InitializeComponent();
        }

        private void SearchProductForm_Load(object sender, EventArgs e)
        {
            //cargar los productos
            loadProducts();
        }


        private void loadProducts()
        {

            var productRepository = new ProductRepository();
            products = productRepository.getAllProductsWithSock();

            //si la no hay productos mostrar mensaje
            if (products.Count == 0)
            {
                MessageBox.Show("No hay productos registrados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }


            dt_products.DataSource = products;

            //ocultar columna id
            dt_products.Columns["Id"].Visible = false;

            //renombrar columnas
            dt_products.Columns["Code"].HeaderText = "Código";
            dt_products.Columns["Description"].HeaderText = "Descripción";
            dt_products.Columns["Cost"].HeaderText = "Costo";
            dt_products.Columns["Price"].HeaderText = "Precio";
            dt_products.Columns["MinimumStock"].HeaderText = "Stock mínimo";
            dt_products.Columns["InitialStock"].HeaderText = "Stock";
            dt_products.Columns["SizesId"].HeaderText = "Talla";

            //ocultar stock minimo
            dt_products.Columns["MinimumStock"].Visible = false;

            //ocultar productos con inital stock = 0 
            foreach (DataGridViewRow row in dt_products.Rows)
            {
                if (row.Cells["InitialStock"].Value.ToString() == "0")
                {
                    row.Visible = false;
                }
            }




        }

        private void dt_products_DoubleClick(object sender, EventArgs e)
        {
            //Retornar el producto seleccionado
            var product = new Product();
            product.Id = int.Parse(dt_products.CurrentRow.Cells["Id"].Value.ToString());
            product.Code = dt_products.CurrentRow.Cells["Code"].Value.ToString();
            product.Description = dt_products.CurrentRow.Cells["Description"].Value.ToString();
            product.Cost = decimal.Parse(dt_products.CurrentRow.Cells["Cost"].Value.ToString());
            product.Price = decimal.Parse(dt_products.CurrentRow.Cells["Price"].Value.ToString());
            product.MinimumStock = int.Parse(dt_products.CurrentRow.Cells["MinimumStock"].Value.ToString());
            product.InitialStock = int.Parse(dt_products.CurrentRow.Cells["InitialStock"].Value.ToString());
            product.SizesId = dt_products.CurrentRow.Cells["SizesId"].Value.ToString();

            GlobalClass.SelectedProduct = product;
            GlobalClass.isProductSelectProperly = true;
            this.Close();
        }


        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {

            //si presiona enter que busque
            if (e.KeyChar != (char)Keys.Enter)
            {
                return;
            }

            //si esta vacio que muestre todos los productos
            if (txt_search.Text == "")
            {
                loadProducts();
                e.Handled = true;
                return;
            }


            //filtrar productos del datagridview por nomnbre
            filterData();
            e.Handled = true;
        }

        private void filterData()
        {
            //limpiar el datagridview
            dt_products.DataSource = products;

            //filtrar productos del datagridview por nomnbre
            string filterValue = txt_search.Text;
            var filteredList = new List<Product>();


            foreach (DataGridViewRow row in dt_products.Rows)
            {
                if (row.Cells["Description"].Value.ToString().IndexOf(filterValue, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    filteredList.Add(new Product
                    {
                        Id = int.Parse(row.Cells["Id"].Value.ToString()),
                        Code = row.Cells["Code"].Value.ToString(),
                        Description = row.Cells["Description"].Value.ToString(),
                        Cost = decimal.Parse(row.Cells["Cost"].Value.ToString()),
                        Price = decimal.Parse(row.Cells["Price"].Value.ToString()),
                        MinimumStock = int.Parse(row.Cells["MinimumStock"].Value.ToString()),
                        InitialStock = int.Parse(row.Cells["InitialStock"].Value.ToString()),
                        SizesId = row.Cells["SizesId"].Value.ToString()
                    });
                }
            }

            dt_products.DataSource = filteredList;
        }


        private void btn_search_Click(object sender, EventArgs e)
        {
            dt_products.DataSource = products;

        }
    }
}
