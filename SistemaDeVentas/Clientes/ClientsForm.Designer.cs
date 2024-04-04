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
            this.dt_clients = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_update = new FontAwesome.Sharp.IconButton();
            this.btn_delete = new FontAwesome.Sharp.IconButton();
            this.btn_add_client = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dt_clients)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dt_clients
            // 
            this.dt_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_clients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dt_clients.Location = new System.Drawing.Point(0, 0);
            this.dt_clients.Name = "dt_clients";
            this.dt_clients.RowHeadersWidth = 62;
            this.dt_clients.RowTemplate.Height = 28;
            this.dt_clients.Size = new System.Drawing.Size(1212, 525);
            this.dt_clients.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dt_clients);
            this.panel1.Location = new System.Drawing.Point(3, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1212, 525);
            this.panel1.TabIndex = 1;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_update.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_update.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btn_update.IconColor = System.Drawing.Color.Black;
            this.btn_update.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_update.IconSize = 40;
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(306, 639);
            this.btn_update.Name = "btn_update";
            this.btn_update.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_update.Size = new System.Drawing.Size(279, 67);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "Actualizar";
            this.btn_update.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_delete.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_delete.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
            this.btn_delete.IconColor = System.Drawing.Color.Black;
            this.btn_delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_delete.IconSize = 40;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(611, 639);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_delete.Size = new System.Drawing.Size(279, 67);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Eliminar";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_add_client
            // 
            this.btn_add_client.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_add_client.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_client.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_add_client.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btn_add_client.IconColor = System.Drawing.Color.Black;
            this.btn_add_client.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_add_client.IconSize = 40;
            this.btn_add_client.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_client.Location = new System.Drawing.Point(920, 639);
            this.btn_add_client.Name = "btn_add_client";
            this.btn_add_client.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_add_client.Size = new System.Drawing.Size(279, 67);
            this.btn_add_client.TabIndex = 2;
            this.btn_add_client.Text = "Añadir";
            this.btn_add_client.UseVisualStyleBackColor = false;
            this.btn_add_client.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 718);
            this.Controls.Add(this.btn_add_client);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.panel1);
            this.Name = "ClientsForm";
            this.Text = "ClientForm";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_clients)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dt_clients;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_update;
        private FontAwesome.Sharp.IconButton btn_delete;
        private FontAwesome.Sharp.IconButton btn_add_client;
    }
}