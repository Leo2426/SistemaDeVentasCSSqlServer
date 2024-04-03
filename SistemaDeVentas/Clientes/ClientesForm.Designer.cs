namespace SistemaDeVentas.Clientes
{
    partial class ClientesForm
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_document = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_reference = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_department = new System.Windows.Forms.ComboBox();
            this.cb_province = new System.Windows.Forms.ComboBox();
            this.cb_district = new System.Windows.Forms.ComboBox();
            this.btn_add_client = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(230, 47);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(328, 26);
            this.txt_name.TabIndex = 0;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(230, 126);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(328, 26);
            this.txt_address.TabIndex = 1;
            // 
            // txt_document
            // 
            this.txt_document.Location = new System.Drawing.Point(230, 199);
            this.txt_document.Name = "txt_document";
            this.txt_document.Size = new System.Drawing.Size(328, 26);
            this.txt_document.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "RUC/ DNI";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(234, 278);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(328, 26);
            this.txt_phone.TabIndex = 0;
            // 
            // txt_reference
            // 
            this.txt_reference.Location = new System.Drawing.Point(234, 357);
            this.txt_reference.Name = "txt_reference";
            this.txt_reference.Size = new System.Drawing.Size(328, 26);
            this.txt_reference.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Celular";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Referencia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 440);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Departamento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 496);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Provincia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 562);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Distrito";
            // 
            // cb_department
            // 
            this.cb_department.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_department.FormattingEnabled = true;
            this.cb_department.Location = new System.Drawing.Point(230, 431);
            this.cb_department.Name = "cb_department";
            this.cb_department.Size = new System.Drawing.Size(262, 28);
            this.cb_department.TabIndex = 6;
            this.cb_department.SelectedIndexChanged += new System.EventHandler(this.cb_department_SelectedIndexChanged);
            // 
            // cb_province
            // 
            this.cb_province.FormattingEnabled = true;
            this.cb_province.Location = new System.Drawing.Point(230, 488);
            this.cb_province.Name = "cb_province";
            this.cb_province.Size = new System.Drawing.Size(262, 28);
            this.cb_province.TabIndex = 6;
            this.cb_province.SelectedIndexChanged += new System.EventHandler(this.cb_province_SelectedIndexChanged);
            // 
            // cb_district
            // 
            this.cb_district.FormattingEnabled = true;
            this.cb_district.Location = new System.Drawing.Point(230, 554);
            this.cb_district.Name = "cb_district";
            this.cb_district.Size = new System.Drawing.Size(262, 28);
            this.cb_district.TabIndex = 6;
            // 
            // btn_add_client
            // 
            this.btn_add_client.Location = new System.Drawing.Point(419, 620);
            this.btn_add_client.Name = "btn_add_client";
            this.btn_add_client.Size = new System.Drawing.Size(197, 39);
            this.btn_add_client.TabIndex = 7;
            this.btn_add_client.Text = "Añadir";
            this.btn_add_client.UseVisualStyleBackColor = true;
            this.btn_add_client.Click += new System.EventHandler(this.btn_add_client_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(651, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(616, 507);
            this.dataGridView1.TabIndex = 8;
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 671);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_add_client);
            this.Controls.Add(this.cb_district);
            this.Controls.Add(this.cb_province);
            this.Controls.Add(this.cb_department);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_reference);
            this.Controls.Add(this.txt_document);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_name);
            this.Name = "ClientesForm";
            this.Text = "ClientesForm";
            this.Load += new System.EventHandler(this.ClientesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_document;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_reference;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_department;
        private System.Windows.Forms.ComboBox cb_province;
        private System.Windows.Forms.ComboBox cb_district;
        private System.Windows.Forms.Button btn_add_client;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}