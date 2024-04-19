namespace SistemaDeVentas.Configuration
{
    partial class ConfigurationForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_delete_size = new System.Windows.Forms.Button();
            this.btn_add_size = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add_user = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_save_printer_delivery = new System.Windows.Forms.Button();
            this.btn_save_printer_ticket = new System.Windows.Forms.Button();
            this.cb_printer_ticket = new System.Windows.Forms.ComboBox();
            this.cb_printer_delivery = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_delete_size);
            this.groupBox1.Controls.Add(this.btn_add_size);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(47, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 103);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tallas";
            // 
            // btn_delete_size
            // 
            this.btn_delete_size.Location = new System.Drawing.Point(412, 42);
            this.btn_delete_size.Name = "btn_delete_size";
            this.btn_delete_size.Size = new System.Drawing.Size(282, 37);
            this.btn_delete_size.TabIndex = 0;
            this.btn_delete_size.Text = "Eliminar Talla";
            this.btn_delete_size.UseVisualStyleBackColor = true;
            this.btn_delete_size.Click += new System.EventHandler(this.btn_delete_size_Click);
            // 
            // btn_add_size
            // 
            this.btn_add_size.Location = new System.Drawing.Point(56, 42);
            this.btn_add_size.Name = "btn_add_size";
            this.btn_add_size.Size = new System.Drawing.Size(282, 37);
            this.btn_add_size.TabIndex = 0;
            this.btn_add_size.Text = "Agregar Talla";
            this.btn_add_size.UseVisualStyleBackColor = true;
            this.btn_add_size.Click += new System.EventHandler(this.btn_add_size_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_update);
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.btn_add_user);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(47, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1071, 103);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usuarios";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(412, 44);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(282, 37);
            this.btn_update.TabIndex = 0;
            this.btn_update.Text = "Actualizar";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(762, 44);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(282, 37);
            this.btn_delete.TabIndex = 0;
            this.btn_delete.Text = "Eliminar";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add_user
            // 
            this.btn_add_user.Location = new System.Drawing.Point(56, 44);
            this.btn_add_user.Name = "btn_add_user";
            this.btn_add_user.Size = new System.Drawing.Size(282, 37);
            this.btn_add_user.TabIndex = 0;
            this.btn_add_user.Text = "Agregar";
            this.btn_add_user.UseVisualStyleBackColor = true;
            this.btn_add_user.Click += new System.EventHandler(this.btn_add_client_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cb_printer_delivery);
            this.groupBox3.Controls.Add(this.cb_printer_ticket);
            this.groupBox3.Controls.Add(this.btn_save_printer_delivery);
            this.groupBox3.Controls.Add(this.btn_save_printer_ticket);
            this.groupBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox3.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(47, 378);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(760, 264);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Impresoras";
            // 
            // btn_save_printer_delivery
            // 
            this.btn_save_printer_delivery.Location = new System.Drawing.Point(412, 178);
            this.btn_save_printer_delivery.Name = "btn_save_printer_delivery";
            this.btn_save_printer_delivery.Size = new System.Drawing.Size(282, 37);
            this.btn_save_printer_delivery.TabIndex = 0;
            this.btn_save_printer_delivery.Text = "Guardar";
            this.btn_save_printer_delivery.UseVisualStyleBackColor = true;
            this.btn_save_printer_delivery.Click += new System.EventHandler(this.btn_save_printer_delivery_Click);
            // 
            // btn_save_printer_ticket
            // 
            this.btn_save_printer_ticket.Location = new System.Drawing.Point(56, 178);
            this.btn_save_printer_ticket.Name = "btn_save_printer_ticket";
            this.btn_save_printer_ticket.Size = new System.Drawing.Size(282, 37);
            this.btn_save_printer_ticket.TabIndex = 0;
            this.btn_save_printer_ticket.Text = "Guardar";
            this.btn_save_printer_ticket.UseVisualStyleBackColor = true;
            this.btn_save_printer_ticket.Click += new System.EventHandler(this.btn_save_printer_ticket_Click);
            // 
            // cb_printer_ticket
            // 
            this.cb_printer_ticket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_printer_ticket.FormattingEnabled = true;
            this.cb_printer_ticket.Location = new System.Drawing.Point(56, 92);
            this.cb_printer_ticket.Name = "cb_printer_ticket";
            this.cb_printer_ticket.Size = new System.Drawing.Size(282, 34);
            this.cb_printer_ticket.TabIndex = 1;
            // 
            // cb_printer_delivery
            // 
            this.cb_printer_delivery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_printer_delivery.FormattingEnabled = true;
            this.cb_printer_delivery.Location = new System.Drawing.Point(412, 92);
            this.cb_printer_delivery.Name = "cb_printer_delivery";
            this.cb_printer_delivery.Size = new System.Drawing.Size(282, 34);
            this.cb_printer_delivery.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Impresora Ticket de Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Impresora Ticket Delivery";
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 769);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConfigurationForm";
            this.Text = "ConfigurationForm";
            this.Load += new System.EventHandler(this.ConfigurationForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_delete_size;
        private System.Windows.Forms.Button btn_add_size;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_add_user;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_printer_delivery;
        private System.Windows.Forms.ComboBox cb_printer_ticket;
        private System.Windows.Forms.Button btn_save_printer_delivery;
        private System.Windows.Forms.Button btn_save_printer_ticket;
    }
}