namespace SistemaDeVentas.User
{
    partial class UpdateUserForm
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
            this.btn_edit_user = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_confirm_password = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_rol = new System.Windows.Forms.ComboBox();
            this.cb_user = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_edit_user
            // 
            this.btn_edit_user.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit_user.Location = new System.Drawing.Point(74, 563);
            this.btn_edit_user.Name = "btn_edit_user";
            this.btn_edit_user.Size = new System.Drawing.Size(325, 39);
            this.btn_edit_user.TabIndex = 60;
            this.btn_edit_user.Text = "Editar";
            this.btn_edit_user.UseVisualStyleBackColor = true;
            this.btn_edit_user.Click += new System.EventHandler(this.btn_add_user_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(67, 55);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(356, 40);
            this.label17.TabIndex = 65;
            this.label17.Text = "ACTUALIZAR  USUARIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 26);
            this.label3.TabIndex = 62;
            this.label3.Text = "Confirmar Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 26);
            this.label2.TabIndex = 63;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 26);
            this.label1.TabIndex = 64;
            this.label1.Text = "Nombre";
            // 
            // txt_confirm_password
            // 
            this.txt_confirm_password.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confirm_password.Location = new System.Drawing.Point(74, 370);
            this.txt_confirm_password.Name = "txt_confirm_password";
            this.txt_confirm_password.Size = new System.Drawing.Size(325, 31);
            this.txt_confirm_password.TabIndex = 58;
            this.txt_confirm_password.Leave += new System.EventHandler(this.txt_confirm_password_Leave);
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(74, 276);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(325, 31);
            this.txt_password.TabIndex = 57;
            this.txt_password.Leave += new System.EventHandler(this.txt_confirm_password_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 26);
            this.label4.TabIndex = 61;
            this.label4.Text = "Rol";
            // 
            // cb_rol
            // 
            this.cb_rol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_rol.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_rol.FormattingEnabled = true;
            this.cb_rol.Location = new System.Drawing.Point(74, 458);
            this.cb_rol.Name = "cb_rol";
            this.cb_rol.Size = new System.Drawing.Size(325, 34);
            this.cb_rol.TabIndex = 59;
            // 
            // cb_user
            // 
            this.cb_user.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_user.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_user.FormattingEnabled = true;
            this.cb_user.Location = new System.Drawing.Point(74, 183);
            this.cb_user.Name = "cb_user";
            this.cb_user.Size = new System.Drawing.Size(325, 34);
            this.cb_user.TabIndex = 59;
            this.cb_user.SelectedIndexChanged += new System.EventHandler(this.cb_user_SelectedIndexChanged);
            // 
            // UpdateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 671);
            this.Controls.Add(this.cb_user);
            this.Controls.Add(this.cb_rol);
            this.Controls.Add(this.btn_edit_user);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_confirm_password);
            this.Controls.Add(this.txt_password);
            this.MaximizeBox = false;
            this.Name = "UpdateUserForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UpdateUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_edit_user;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_confirm_password;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_rol;
        private System.Windows.Forms.ComboBox cb_user;
    }
}