namespace SistemaDeVentas.Ventas
{
    partial class ProductsWithSalesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dt_products = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dt_products)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_products
            // 
            this.dt_products.AllowUserToAddRows = false;
            this.dt_products.AllowUserToDeleteRows = false;
            this.dt_products.AllowUserToOrderColumns = true;
            this.dt_products.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dt_products.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dt_products.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dt_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dt_products.DefaultCellStyle = dataGridViewCellStyle2;
            this.dt_products.Location = new System.Drawing.Point(42, 176);
            this.dt_products.MultiSelect = false;
            this.dt_products.Name = "dt_products";
            this.dt_products.ReadOnly = true;
            this.dt_products.RowHeadersWidth = 62;
            this.dt_products.RowTemplate.Height = 28;
            this.dt_products.Size = new System.Drawing.Size(1024, 489);
            this.dt_products.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "SELECCIONAR PRODUCTO";
            // 
            // ProductsWithSalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 691);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dt_products);
            this.Name = "ProductsWithSalesForm";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.ProductsWithSalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dt_products;
        private System.Windows.Forms.Label label1;
    }
}