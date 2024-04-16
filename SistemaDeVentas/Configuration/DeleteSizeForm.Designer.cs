namespace SistemaDeVentas.Configuration
{
    partial class DeleteSizeForm
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
            this.btn_add_client = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.cb_sizes = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_add_client
            // 
            this.btn_add_client.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_client.Location = new System.Drawing.Point(67, 216);
            this.btn_add_client.Name = "btn_add_client";
            this.btn_add_client.Size = new System.Drawing.Size(325, 39);
            this.btn_add_client.TabIndex = 56;
            this.btn_add_client.Text = "Borrar";
            this.btn_add_client.UseVisualStyleBackColor = true;
            this.btn_add_client.Click += new System.EventHandler(this.btn_add_client_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(55, 42);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(258, 40);
            this.label17.TabIndex = 55;
            this.label17.Text = "ELIMINAR TALLA";
            // 
            // cb_sizes
            // 
            this.cb_sizes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sizes.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_sizes.FormattingEnabled = true;
            this.cb_sizes.Location = new System.Drawing.Point(67, 137);
            this.cb_sizes.Name = "cb_sizes";
            this.cb_sizes.Size = new System.Drawing.Size(325, 34);
            this.cb_sizes.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 26);
            this.label6.TabIndex = 63;
            this.label6.Text = "Nombre";
            // 
            // DeleteSizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 311);
            this.Controls.Add(this.cb_sizes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_add_client);
            this.Controls.Add(this.label17);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(493, 367);
            this.MinimumSize = new System.Drawing.Size(493, 367);
            this.Name = "DeleteSizeForm";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.UpdateSizeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add_client;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cb_sizes;
        private System.Windows.Forms.Label label6;
    }
}