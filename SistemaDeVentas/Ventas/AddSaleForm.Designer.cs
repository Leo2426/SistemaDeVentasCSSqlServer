namespace SistemaDeVentas.Ventas
{
    partial class AddSaleForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_add = new System.Windows.Forms.Button();
            this.cb_sales_man = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_reference = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_payment_type = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_payment_condition = new System.Windows.Forms.ComboBox();
            this.txt_observation = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.dt_products = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_quantity = new System.Windows.Forms.NumericUpDown();
            this.txt_product_stock = new System.Windows.Forms.TextBox();
            this.txt_size = new System.Windows.Forms.TextBox();
            this.txt_product_price = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_product_name = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_search = new FontAwesome.Sharp.IconButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_product_code = new System.Windows.Forms.TextBox();
            this.cb_chanel = new System.Windows.Forms.ComboBox();
            this.btn_add_product_to_dt = new FontAwesome.Sharp.IconButton();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lbl_cash = new System.Windows.Forms.Label();
            this.lbl_credit = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_client_name = new System.Windows.Forms.ComboBox();
            this.btn_add_client = new FontAwesome.Sharp.IconButton();
            this.lbl_days_credit = new System.Windows.Forms.Label();
            this.txt_cash = new System.Windows.Forms.TextBox();
            this.txt_credit = new System.Windows.Forms.TextBox();
            this.txt_days_credit = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dt_products)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_quantity)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(905, 854);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(197, 58);
            this.btn_add.TabIndex = 5;
            this.btn_add.TabStop = false;
            this.btn_add.Text = "Generar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cb_sales_man
            // 
            this.cb_sales_man.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_sales_man.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_sales_man.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sales_man.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_sales_man.FormattingEnabled = true;
            this.cb_sales_man.Location = new System.Drawing.Point(851, 156);
            this.cb_sales_man.Name = "cb_sales_man";
            this.cb_sales_man.Size = new System.Drawing.Size(251, 34);
            this.cb_sales_man.TabIndex = 38;
            this.cb_sales_man.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 26);
            this.label3.TabIndex = 37;
            this.label3.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(846, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 26);
            this.label6.TabIndex = 36;
            this.label6.Text = "Vendedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(799, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 26);
            this.label2.TabIndex = 34;
            this.label2.Text = "Referencia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(542, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 26);
            this.label4.TabIndex = 32;
            this.label4.Text = "Dirección";
            // 
            // txt_reference
            // 
            this.txt_reference.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_reference.Location = new System.Drawing.Point(804, 74);
            this.txt_reference.Name = "txt_reference";
            this.txt_reference.Size = new System.Drawing.Size(234, 30);
            this.txt_reference.TabIndex = 1;
            this.txt_reference.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 26);
            this.label1.TabIndex = 31;
            this.label1.Text = "Tipo de Comprobante";
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(547, 74);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(225, 30);
            this.txt_address.TabIndex = 2;
            this.txt_address.TabStop = false;
            // 
            // cb_type
            // 
            this.cb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_type.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Items.AddRange(new object[] {
            "BOLETA",
            "FACTURA",
            "COTIZACION",
            "NOTA DE VENTA"});
            this.cb_type.Location = new System.Drawing.Point(57, 156);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(234, 34);
            this.cb_type.TabIndex = 38;
            this.cb_type.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(319, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 26);
            this.label8.TabIndex = 36;
            this.label8.Text = "Tipo de Pago";
            // 
            // cb_payment_type
            // 
            this.cb_payment_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_payment_type.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_payment_type.FormattingEnabled = true;
            this.cb_payment_type.Location = new System.Drawing.Point(324, 156);
            this.cb_payment_type.Name = "cb_payment_type";
            this.cb_payment_type.Size = new System.Drawing.Size(249, 34);
            this.cb_payment_type.TabIndex = 38;
            this.cb_payment_type.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(53, 385);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 26);
            this.label9.TabIndex = 36;
            this.label9.Text = "Condición de Pago";
            // 
            // cb_payment_condition
            // 
            this.cb_payment_condition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_payment_condition.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_payment_condition.FormattingEnabled = true;
            this.cb_payment_condition.Location = new System.Drawing.Point(57, 420);
            this.cb_payment_condition.Name = "cb_payment_condition";
            this.cb_payment_condition.Size = new System.Drawing.Size(248, 34);
            this.cb_payment_condition.TabIndex = 4;
            this.cb_payment_condition.TabStop = false;
            this.cb_payment_condition.SelectedIndexChanged += new System.EventHandler(this.cb_payment_condition_SelectedIndexChanged);
            // 
            // txt_observation
            // 
            this.txt_observation.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_observation.Location = new System.Drawing.Point(600, 423);
            this.txt_observation.Name = "txt_observation";
            this.txt_observation.Size = new System.Drawing.Size(502, 31);
            this.txt_observation.TabIndex = 1;
            this.txt_observation.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(596, 388);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 26);
            this.label10.TabIndex = 34;
            this.label10.Text = "Observación";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(332, 385);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 26);
            this.label11.TabIndex = 34;
            this.label11.Text = "Canal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(589, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 26);
            this.label5.TabIndex = 34;
            this.label5.Text = "Fecha";
            // 
            // dtp_date
            // 
            this.dtp_date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date.Checked = false;
            this.dtp_date.CustomFormat = "dd /  MM  / yyyy";
            this.dtp_date.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_date.Location = new System.Drawing.Point(594, 158);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(225, 31);
            this.dtp_date.TabIndex = 40;
            this.dtp_date.TabStop = false;
            // 
            // dt_products
            // 
            this.dt_products.AllowUserToAddRows = false;
            this.dt_products.AllowUserToDeleteRows = false;
            this.dt_products.AllowUserToOrderColumns = true;
            this.dt_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_products.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dt_products.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dt_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_products.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dt_products.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dt_products.Location = new System.Drawing.Point(47, 626);
            this.dt_products.MultiSelect = false;
            this.dt_products.Name = "dt_products";
            this.dt_products.ReadOnly = true;
            this.dt_products.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_products.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dt_products.RowHeadersWidth = 62;
            this.dt_products.RowTemplate.Height = 28;
            this.dt_products.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_products.ShowEditingIcon = false;
            this.dt_products.Size = new System.Drawing.Size(1055, 193);
            this.dt_products.TabIndex = 41;
            this.dt_products.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_quantity);
            this.groupBox1.Controls.Add(this.txt_product_stock);
            this.groupBox1.Controls.Add(this.txt_size);
            this.groupBox1.Controls.Add(this.txt_product_price);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txt_product_name);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_product_code);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(47, 479);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(929, 120);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producto";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantity.Location = new System.Drawing.Point(726, 71);
            this.txt_quantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txt_quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(89, 30);
            this.txt_quantity.TabIndex = 3;
            this.txt_quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txt_product_stock
            // 
            this.txt_product_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_stock.Location = new System.Drawing.Point(834, 70);
            this.txt_product_stock.Name = "txt_product_stock";
            this.txt_product_stock.ReadOnly = true;
            this.txt_product_stock.Size = new System.Drawing.Size(62, 30);
            this.txt_product_stock.TabIndex = 45;
            this.txt_product_stock.TabStop = false;
            // 
            // txt_size
            // 
            this.txt_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_size.Location = new System.Drawing.Point(509, 71);
            this.txt_size.Name = "txt_size";
            this.txt_size.ReadOnly = true;
            this.txt_size.Size = new System.Drawing.Size(89, 30);
            this.txt_size.TabIndex = 45;
            this.txt_size.TabStop = false;
            // 
            // txt_product_price
            // 
            this.txt_product_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_price.Location = new System.Drawing.Point(615, 72);
            this.txt_product_price.Name = "txt_product_price";
            this.txt_product_price.Size = new System.Drawing.Size(89, 30);
            this.txt_product_price.TabIndex = 2;
            this.txt_product_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cash_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(830, 41);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 26);
            this.label18.TabIndex = 1;
            this.label18.Text = "Stock";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(722, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 26);
            this.label14.TabIndex = 1;
            this.label14.Text = "Cantidad";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(505, 42);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 26);
            this.label19.TabIndex = 1;
            this.label19.Text = "Talla";
            // 
            // txt_product_name
            // 
            this.txt_product_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_name.Location = new System.Drawing.Point(255, 71);
            this.txt_product_name.Name = "txt_product_name";
            this.txt_product_name.ReadOnly = true;
            this.txt_product_name.Size = new System.Drawing.Size(235, 30);
            this.txt_product_name.TabIndex = 45;
            this.txt_product_name.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(611, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 26);
            this.label13.TabIndex = 1;
            this.label13.Text = "Precio";
            // 
            // btn_search
            // 
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
            this.btn_search.IconColor = System.Drawing.Color.Black;
            this.btn_search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_search.IconSize = 30;
            this.btn_search.Location = new System.Drawing.Point(192, 72);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(43, 34);
            this.btn_search.TabIndex = 44;
            this.btn_search.TabStop = false;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(251, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 26);
            this.label12.TabIndex = 1;
            this.label12.Text = "Producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 26);
            this.label7.TabIndex = 1;
            this.label7.Text = "Código";
            // 
            // txt_product_code
            // 
            this.txt_product_code.AllowDrop = true;
            this.txt_product_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_code.Location = new System.Drawing.Point(26, 72);
            this.txt_product_code.Name = "txt_product_code";
            this.txt_product_code.Size = new System.Drawing.Size(160, 30);
            this.txt_product_code.TabIndex = 1;
            this.txt_product_code.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_product_code_KeyDown);
            // 
            // cb_chanel
            // 
            this.cb_chanel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_chanel.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_chanel.FormattingEnabled = true;
            this.cb_chanel.Items.AddRange(new object[] {
            "FACEBOOK",
            "INSTAGRAM",
            "WHATSAPP"});
            this.cb_chanel.Location = new System.Drawing.Point(330, 420);
            this.cb_chanel.Name = "cb_chanel";
            this.cb_chanel.Size = new System.Drawing.Size(228, 34);
            this.cb_chanel.TabIndex = 5;
            this.cb_chanel.TabStop = false;
            // 
            // btn_add_product_to_dt
            // 
            this.btn_add_product_to_dt.FlatAppearance.BorderSize = 0;
            this.btn_add_product_to_dt.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_product_to_dt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_add_product_to_dt.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btn_add_product_to_dt.IconColor = System.Drawing.Color.Green;
            this.btn_add_product_to_dt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_add_product_to_dt.IconSize = 55;
            this.btn_add_product_to_dt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_add_product_to_dt.Location = new System.Drawing.Point(990, 492);
            this.btn_add_product_to_dt.Name = "btn_add_product_to_dt";
            this.btn_add_product_to_dt.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btn_add_product_to_dt.Size = new System.Drawing.Size(112, 107);
            this.btn_add_product_to_dt.TabIndex = 4;
            this.btn_add_product_to_dt.Text = "Agregar";
            this.btn_add_product_to_dt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_add_product_to_dt.UseVisualStyleBackColor = true;
            this.btn_add_product_to_dt.Click += new System.EventHandler(this.btn_add_product_to_dt_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(378, 44);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 26);
            this.label15.TabIndex = 45;
            this.label15.Text = "Teléfono";
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone.Location = new System.Drawing.Point(383, 74);
            this.txt_phone.MaxLength = 9;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(143, 30);
            this.txt_phone.TabIndex = 3;
            this.txt_phone.TabStop = false;
            // 
            // txt_total
            // 
            this.txt_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(57, 877);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(133, 30);
            this.txt_total.TabIndex = 26;
            this.txt_total.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(53, 854);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 20);
            this.label16.TabIndex = 32;
            this.label16.Text = "TOTAL";
            // 
            // lbl_cash
            // 
            this.lbl_cash.AutoSize = true;
            this.lbl_cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cash.Location = new System.Drawing.Point(261, 854);
            this.lbl_cash.Name = "lbl_cash";
            this.lbl_cash.Size = new System.Drawing.Size(94, 20);
            this.lbl_cash.TabIndex = 32;
            this.lbl_cash.Text = "CONTADO";
            // 
            // lbl_credit
            // 
            this.lbl_credit.AutoSize = true;
            this.lbl_credit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_credit.Location = new System.Drawing.Point(449, 854);
            this.lbl_credit.Name = "lbl_credit";
            this.lbl_credit.Size = new System.Drawing.Size(88, 20);
            this.lbl_credit.TabIndex = 32;
            this.lbl_credit.Text = "CRÉDITO";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_phone);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txt_address);
            this.groupBox2.Controls.Add(this.txt_reference);
            this.groupBox2.Controls.Add(this.cb_client_name);
            this.groupBox2.Controls.Add(this.btn_add_client);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(47, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1055, 137);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // cb_client_name
            // 
            this.cb_client_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_client_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_client_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_client_name.FormattingEnabled = true;
            this.cb_client_name.Items.AddRange(new object[] {
            "BOLETA",
            "FACTURA",
            "COTIZACION",
            "NOTA DE VENTA"});
            this.cb_client_name.Location = new System.Drawing.Point(27, 70);
            this.cb_client_name.Name = "cb_client_name";
            this.cb_client_name.Size = new System.Drawing.Size(296, 33);
            this.cb_client_name.TabIndex = 38;
            this.cb_client_name.TabStop = false;
            this.cb_client_name.SelectedIndexChanged += new System.EventHandler(this.cb_client_name_SelectedIndexChanged);
            // 
            // btn_add_client
            // 
            this.btn_add_client.FlatAppearance.BorderSize = 0;
            this.btn_add_client.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btn_add_client.IconColor = System.Drawing.Color.Black;
            this.btn_add_client.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_add_client.IconSize = 30;
            this.btn_add_client.Location = new System.Drawing.Point(324, 68);
            this.btn_add_client.Name = "btn_add_client";
            this.btn_add_client.Size = new System.Drawing.Size(48, 35);
            this.btn_add_client.TabIndex = 44;
            this.btn_add_client.TabStop = false;
            this.btn_add_client.UseVisualStyleBackColor = true;
            this.btn_add_client.Click += new System.EventHandler(this.btn_add_client_Click);
            // 
            // lbl_days_credit
            // 
            this.lbl_days_credit.AutoSize = true;
            this.lbl_days_credit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_days_credit.Location = new System.Drawing.Point(615, 854);
            this.lbl_days_credit.Name = "lbl_days_credit";
            this.lbl_days_credit.Size = new System.Drawing.Size(136, 20);
            this.lbl_days_credit.TabIndex = 32;
            this.lbl_days_credit.Text = "DÍAS CRÉDITO";
            // 
            // txt_cash
            // 
            this.txt_cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cash.Location = new System.Drawing.Point(265, 878);
            this.txt_cash.MaxLength = 8;
            this.txt_cash.Name = "txt_cash";
            this.txt_cash.Size = new System.Drawing.Size(133, 30);
            this.txt_cash.TabIndex = 26;
            this.txt_cash.TabStop = false;
            this.txt_cash.TextChanged += new System.EventHandler(this.txt_cash_TextChanged);
            this.txt_cash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cash_KeyPress);
            // 
            // txt_credit
            // 
            this.txt_credit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_credit.Location = new System.Drawing.Point(453, 878);
            this.txt_credit.MaxLength = 8;
            this.txt_credit.Name = "txt_credit";
            this.txt_credit.ReadOnly = true;
            this.txt_credit.Size = new System.Drawing.Size(133, 30);
            this.txt_credit.TabIndex = 26;
            this.txt_credit.TabStop = false;
            this.txt_credit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cash_KeyPress);
            // 
            // txt_days_credit
            // 
            this.txt_days_credit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_days_credit.Location = new System.Drawing.Point(619, 878);
            this.txt_days_credit.MaxLength = 3;
            this.txt_days_credit.Name = "txt_days_credit";
            this.txt_days_credit.Size = new System.Drawing.Size(133, 30);
            this.txt_days_credit.TabIndex = 26;
            this.txt_days_credit.TabStop = false;
            this.txt_days_credit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_days_credit_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(54, 43);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(268, 40);
            this.label17.TabIndex = 47;
            this.label17.Text = "INGRESAR VENTA";
            // 
            // AddSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 940);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_add_product_to_dt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dt_products);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cb_payment_condition);
            this.Controls.Add(this.cb_payment_type);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cb_chanel);
            this.Controls.Add(this.cb_sales_man);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl_days_credit);
            this.Controls.Add(this.lbl_credit);
            this.Controls.Add(this.lbl_cash);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_observation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_days_credit);
            this.Controls.Add(this.txt_credit);
            this.Controls.Add(this.txt_cash);
            this.Controls.Add(this.txt_total);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1199, 996);
            this.MinimumSize = new System.Drawing.Size(1199, 996);
            this.Name = "AddSaleForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddSaleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_products)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_quantity)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox cb_sales_man;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_reference;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_payment_type;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_payment_condition;
        private System.Windows.Forms.TextBox txt_observation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.DataGridView dt_products;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_chanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_product_code;
        private FontAwesome.Sharp.IconButton btn_add_product_to_dt;
        private System.Windows.Forms.TextBox txt_product_name;
        private FontAwesome.Sharp.IconButton btn_search;
        private System.Windows.Forms.TextBox txt_product_price;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl_cash;
        private System.Windows.Forms.Label lbl_credit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_client_name;
        private FontAwesome.Sharp.IconButton btn_add_client;
        private System.Windows.Forms.TextBox txt_size;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown txt_quantity;
        private System.Windows.Forms.Label lbl_days_credit;
        private System.Windows.Forms.TextBox txt_cash;
        private System.Windows.Forms.TextBox txt_credit;
        private System.Windows.Forms.TextBox txt_days_credit;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_product_stock;
        private System.Windows.Forms.Label label18;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}