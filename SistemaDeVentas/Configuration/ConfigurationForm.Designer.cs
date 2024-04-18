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
            this.btn_edit_user = new System.Windows.Forms.Button();
            this.btn_add_client = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_delete_size);
            this.groupBox1.Controls.Add(this.btn_add_size);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(49, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1067, 103);
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
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.btn_edit_user);
            this.groupBox2.Controls.Add(this.btn_add_client);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(49, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1067, 103);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usuarios";
            // 
            // btn_edit_user
            // 
            this.btn_edit_user.Location = new System.Drawing.Point(412, 44);
            this.btn_edit_user.Name = "btn_edit_user";
            this.btn_edit_user.Size = new System.Drawing.Size(282, 37);
            this.btn_edit_user.TabIndex = 0;
            this.btn_edit_user.Text = "Editar";
            this.btn_edit_user.UseVisualStyleBackColor = true;
            // 
            // btn_add_client
            // 
            this.btn_add_client.Location = new System.Drawing.Point(56, 44);
            this.btn_add_client.Name = "btn_add_client";
            this.btn_add_client.Size = new System.Drawing.Size(282, 37);
            this.btn_add_client.TabIndex = 0;
            this.btn_add_client.Text = "Agregar";
            this.btn_add_client.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(779, 44);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(282, 37);
            this.btn_delete.TabIndex = 0;
            this.btn_delete.Text = "Eliminar";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 769);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConfigurationForm";
            this.Text = "ConfigurationForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_delete_size;
        private System.Windows.Forms.Button btn_add_size;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_edit_user;
        private System.Windows.Forms.Button btn_add_client;
        private System.Windows.Forms.Button btn_delete;
    }
}