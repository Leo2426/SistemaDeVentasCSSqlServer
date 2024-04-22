namespace SistemaDeVentas.Productos
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
            this.dt_products = new System.Windows.Forms.DataGridView();
            this.btn_add = new FontAwesome.Sharp.IconButton();
            this.btn_edit = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_columns = new System.Windows.Forms.ComboBox();
            this.btn_search = new FontAwesome.Sharp.IconButton();
            this.txt_search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dt_products)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_products
            // 
            this.dt_products.AllowUserToAddRows = false;
            this.dt_products.AllowUserToDeleteRows = false;
            this.dt_products.AllowUserToOrderColumns = true;
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
            this.dt_products.Location = new System.Drawing.Point(36, 53);
            this.dt_products.MultiSelect = false;
            this.dt_products.Name = "dt_products";
            this.dt_products.ReadOnly = true;
            this.dt_products.RowHeadersWidth = 62;
            this.dt_products.RowTemplate.Height = 28;
            this.dt_products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_products.ShowCellErrors = false;
            this.dt_products.ShowEditingIcon = false;
            this.dt_products.ShowRowErrors = false;
            this.dt_products.Size = new System.Drawing.Size(1101, 592);
            this.dt_products.TabIndex = 0;
            this.dt_products.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_products_CellDoubleClick);
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
            // btn_edit
            // 
            this.btn_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edit.BackColor = System.Drawing.SystemColors.Control;
            this.btn_edit.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_edit.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btn_edit.IconColor = System.Drawing.Color.Black;
            this.btn_edit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_edit.IconSize = 40;
            this.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_edit.Location = new System.Drawing.Point(263, 671);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.btn_edit.Size = new System.Drawing.Size(279, 67);
            this.btn_edit.TabIndex = 48;
            this.btn_edit.Text = "Actualizar";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_update_Click);
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
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 26);
            this.label2.TabIndex = 53;
            this.label2.Text = "Columna";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(588, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 26);
            this.label1.TabIndex = 54;
            this.label1.Text = "Buscar";
            // 
            // cb_columns
            // 
            this.cb_columns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_columns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_columns.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_columns.FormattingEnabled = true;
            this.cb_columns.Location = new System.Drawing.Point(263, 12);
            this.cb_columns.Name = "cb_columns";
            this.cb_columns.Size = new System.Drawing.Size(247, 34);
            this.cb_columns.TabIndex = 52;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.btn_search.IconColor = System.Drawing.Color.Black;
            this.btn_search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_search.IconSize = 25;
            this.btn_search.Location = new System.Drawing.Point(1097, 13);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(43, 34);
            this.btn_search.TabIndex = 51;
            this.btn_search.TabStop = false;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(678, 15);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(402, 31);
            this.txt_search.TabIndex = 50;
            this.txt_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_search_KeyPress);
            // 
            // ProductosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 769);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_columns);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.dt_products);
            this.Name = "ProductosForm";
            this.Text = "ProductosForm";
            this.Load += new System.EventHandler(this.ProductosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dt_products;
        private FontAwesome.Sharp.IconButton btn_add;
        private FontAwesome.Sharp.IconButton btn_edit;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_columns;
        private FontAwesome.Sharp.IconButton btn_search;
        private System.Windows.Forms.TextBox txt_search;
    }
}