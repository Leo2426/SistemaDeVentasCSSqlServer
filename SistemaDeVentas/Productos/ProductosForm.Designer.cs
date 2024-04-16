﻿namespace SistemaDeVentas.Productos
{
    partial class ProductosForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.dt_products = new System.Windows.Forms.DataGridView();
            this.btn_search = new FontAwesome.Sharp.IconButton();
            this.btn_add = new FontAwesome.Sharp.IconButton();
            this.btn_print = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dt_products)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(36, 12);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(495, 31);
            this.txt_search.TabIndex = 10;
            // 
            // dt_products
            // 
            this.dt_products.AllowUserToAddRows = false;
            this.dt_products.AllowUserToDeleteRows = false;
            this.dt_products.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dt_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_products.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dt_products.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dt_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_products.Location = new System.Drawing.Point(36, 52);
            this.dt_products.MultiSelect = false;
            this.dt_products.Name = "dt_products";
            this.dt_products.ReadOnly = true;
            this.dt_products.RowHeadersWidth = 62;
            this.dt_products.RowTemplate.Height = 28;
            this.dt_products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_products.ShowCellErrors = false;
            this.dt_products.ShowEditingIcon = false;
            this.dt_products.Size = new System.Drawing.Size(1101, 593);
            this.dt_products.TabIndex = 0;
            this.dt_products.VisibleChanged += new System.EventHandler(this.dt_products_VisibleChanged);
            // 
            // btn_search
            // 
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
            this.btn_search.IconColor = System.Drawing.Color.Black;
            this.btn_search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_search.IconSize = 30;
            this.btn_search.Location = new System.Drawing.Point(537, 12);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(43, 34);
            this.btn_search.TabIndex = 46;
            this.btn_search.TabStop = false;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.BackColor = System.Drawing.SystemColors.Control;
            this.btn_add.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_add.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btn_add.IconColor = System.Drawing.Color.Black;
            this.btn_add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_add.IconSize = 40;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add.Location = new System.Drawing.Point(858, 671);
            this.btn_add.Name = "btn_add";
            this.btn_add.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.btn_add.Size = new System.Drawing.Size(279, 67);
            this.btn_add.TabIndex = 47;
            this.btn_add.Text = "Añadir";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_product_Click);
            // 
            // btn_print
            // 
            this.btn_print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_print.BackColor = System.Drawing.SystemColors.Control;
            this.btn_print.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_print.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btn_print.IconColor = System.Drawing.Color.Black;
            this.btn_print.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_print.IconSize = 40;
            this.btn_print.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_print.Location = new System.Drawing.Point(263, 671);
            this.btn_print.Name = "btn_print";
            this.btn_print.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.btn_print.Size = new System.Drawing.Size(279, 67);
            this.btn_print.TabIndex = 48;
            this.btn_print.Text = "Actualizar";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton2.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton2.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 40;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.Location = new System.Drawing.Point(558, 671);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.iconButton2.Size = new System.Drawing.Size(279, 67);
            this.iconButton2.TabIndex = 49;
            this.iconButton2.Text = "Eliminar";
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // ProductosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 769);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dt_products);
            this.Controls.Add(this.txt_search);
            this.Name = "ProductosForm";
            this.Text = "ProductosForm";
            this.Load += new System.EventHandler(this.ProductosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.DataGridView dt_products;
        private FontAwesome.Sharp.IconButton btn_search;
        private FontAwesome.Sharp.IconButton btn_add;
        private FontAwesome.Sharp.IconButton btn_print;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}