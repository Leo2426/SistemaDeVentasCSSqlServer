namespace SistemaDeVentas.Clientes
{
    partial class ClientsForm
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
            this.dt_clients = new System.Windows.Forms.DataGridView();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_add = new FontAwesome.Sharp.IconButton();
            this.btn_edit = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.btn_search = new FontAwesome.Sharp.IconButton();
            this.cb_columns = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dt_clients)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_clients
            // 
            this.dt_clients.AllowUserToAddRows = false;
            this.dt_clients.AllowUserToDeleteRows = false;
            this.dt_clients.AllowUserToOrderColumns = true;
            this.dt_clients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dt_clients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_clients.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dt_clients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_clients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dt_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_clients.Location = new System.Drawing.Point(36, 57);
            this.dt_clients.MultiSelect = false;
            this.dt_clients.Name = "dt_clients";
            this.dt_clients.ReadOnly = true;
            this.dt_clients.RowHeadersWidth = 62;
            this.dt_clients.RowTemplate.Height = 28;
            this.dt_clients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_clients.ShowCellErrors = false;
            this.dt_clients.ShowEditingIcon = false;
            this.dt_clients.Size = new System.Drawing.Size(1119, 597);
            this.dt_clients.TabIndex = 0;
            this.dt_clients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_clients_CellDoubleClick);
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(693, 14);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(402, 31);
            this.txt_search.TabIndex = 4;
            this.txt_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_search_KeyPress);
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
            this.btn_add.Location = new System.Drawing.Point(876, 676);
            this.btn_add.Name = "btn_add";
            this.btn_add.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.btn_add.Size = new System.Drawing.Size(279, 67);
            this.btn_add.TabIndex = 15;
            this.btn_add.Text = "Añadir";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
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
            this.btn_edit.Location = new System.Drawing.Point(281, 676);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.btn_edit.Size = new System.Drawing.Size(279, 67);
            this.btn_edit.TabIndex = 16;
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
            this.iconButton2.Location = new System.Drawing.Point(576, 676);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.iconButton2.Size = new System.Drawing.Size(279, 67);
            this.iconButton2.TabIndex = 17;
            this.iconButton2.Text = "Eliminar";
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.btn_delete_Click);
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
            this.btn_search.Location = new System.Drawing.Point(1112, 12);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(43, 34);
            this.btn_search.TabIndex = 45;
            this.btn_search.TabStop = false;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // cb_columns
            // 
            this.cb_columns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_columns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_columns.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_columns.FormattingEnabled = true;
            this.cb_columns.Location = new System.Drawing.Point(269, 16);
            this.cb_columns.Name = "cb_columns";
            this.cb_columns.Size = new System.Drawing.Size(247, 34);
            this.cb_columns.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(603, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 26);
            this.label1.TabIndex = 47;
            this.label1.Text = "Buscar";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 26);
            this.label2.TabIndex = 47;
            this.label2.Text = "Columna";
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 769);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_columns);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.dt_clients);
            this.Controls.Add(this.txt_search);
            this.Name = "ClientsForm";
            this.Text = "ClientForm";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_clients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dt_clients;
        private System.Windows.Forms.TextBox txt_search;
        private FontAwesome.Sharp.IconButton btn_add;
        private FontAwesome.Sharp.IconButton btn_edit;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btn_search;
        private System.Windows.Forms.ComboBox cb_columns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}