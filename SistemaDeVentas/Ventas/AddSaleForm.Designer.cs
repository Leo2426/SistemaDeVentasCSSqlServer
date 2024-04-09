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
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.txt_product_price = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
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
            this.txt_cash = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_credit = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_client_name = new System.Windows.Forms.ComboBox();
            this.btn_add_client = new FontAwesome.Sharp.IconButton();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_size = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dt_products)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(867, 785);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(197, 39);
            this.btn_add.TabIndex = 39;
            this.btn_add.Text = "Generar Venta";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cb_sales_man
            // 
            this.cb_sales_man.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_sales_man.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_sales_man.FormattingEnabled = true;
            this.cb_sales_man.Location = new System.Drawing.Point(857, 79);
            this.cb_sales_man.Name = "cb_sales_man";
            this.cb_sales_man.Size = new System.Drawing.Size(229, 33);
            this.cb_sales_man.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(853, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Vendedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Referencia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(549, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Dirección";
            // 
            // txt_reference
            // 
            this.txt_reference.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_reference.Location = new System.Drawing.Point(289, 64);
            this.txt_reference.Name = "txt_reference";
            this.txt_reference.Size = new System.Drawing.Size(228, 30);
            this.txt_reference.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Tipo de Comprobante";
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(553, 65);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(228, 30);
            this.txt_address.TabIndex = 26;
            // 
            // cb_type
            // 
            this.cb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Items.AddRange(new object[] {
            "BOLETA",
            "FACTURA",
            "COTIZACION",
            "NOTA DE VENTA"});
            this.cb_type.Location = new System.Drawing.Point(67, 79);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(234, 33);
            this.cb_type.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Tipo de Pago";
            // 
            // cb_payment_type
            // 
            this.cb_payment_type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_payment_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_payment_type.FormattingEnabled = true;
            this.cb_payment_type.Location = new System.Drawing.Point(330, 79);
            this.cb_payment_type.Name = "cb_payment_type";
            this.cb_payment_type.Size = new System.Drawing.Size(228, 33);
            this.cb_payment_type.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "Condición de Pago";
            // 
            // cb_payment_condition
            // 
            this.cb_payment_condition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_payment_condition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_payment_condition.FormattingEnabled = true;
            this.cb_payment_condition.Location = new System.Drawing.Point(51, 341);
            this.cb_payment_condition.Name = "cb_payment_condition";
            this.cb_payment_condition.Size = new System.Drawing.Size(248, 33);
            this.cb_payment_condition.TabIndex = 38;
            // 
            // txt_observation
            // 
            this.txt_observation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_observation.Location = new System.Drawing.Point(594, 341);
            this.txt_observation.Name = "txt_observation";
            this.txt_observation.Size = new System.Drawing.Size(485, 30);
            this.txt_observation.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(590, 306);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 20);
            this.label10.TabIndex = 34;
            this.label10.Text = "Observación";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(326, 315);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 20);
            this.label11.TabIndex = 34;
            this.label11.Text = "Canal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(596, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Fecha";
            // 
            // dtp_date
            // 
            this.dtp_date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date.Checked = false;
            this.dtp_date.CustomFormat = "dd /  MM  / yyyy";
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_date.Location = new System.Drawing.Point(600, 81);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(228, 26);
            this.dtp_date.TabIndex = 40;
            // 
            // dt_products
            // 
            this.dt_products.AllowUserToAddRows = false;
            this.dt_products.AllowUserToDeleteRows = false;
            this.dt_products.AllowUserToOrderColumns = true;
            this.dt_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_products.Location = new System.Drawing.Point(41, 547);
            this.dt_products.MultiSelect = false;
            this.dt_products.Name = "dt_products";
            this.dt_products.ReadOnly = true;
            this.dt_products.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dt_products.RowHeadersWidth = 62;
            this.dt_products.RowTemplate.Height = 28;
            this.dt_products.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_products.ShowEditingIcon = false;
            this.dt_products.Size = new System.Drawing.Size(1048, 193);
            this.dt_products.TabIndex = 41;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_quantity);
            this.groupBox1.Controls.Add(this.txt_size);
            this.groupBox1.Controls.Add(this.txt_product_price);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txt_product_name);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_product_code);
            this.groupBox1.Location = new System.Drawing.Point(41, 400);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(929, 120);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producto";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantity.Location = new System.Drawing.Point(788, 66);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(89, 30);
            this.txt_quantity.TabIndex = 45;
            // 
            // txt_product_price
            // 
            this.txt_product_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_price.Location = new System.Drawing.Point(673, 66);
            this.txt_product_price.Name = "txt_product_price";
            this.txt_product_price.Size = new System.Drawing.Size(89, 30);
            this.txt_product_price.TabIndex = 45;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(784, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 20);
            this.label14.TabIndex = 1;
            this.label14.Text = "Cantidad";
            // 
            // txt_product_name
            // 
            this.txt_product_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_name.Location = new System.Drawing.Point(282, 66);
            this.txt_product_name.Name = "txt_product_name";
            this.txt_product_name.Size = new System.Drawing.Size(235, 30);
            this.txt_product_name.TabIndex = 45;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(669, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "Precio";
            // 
            // btn_search
            // 
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.IconChar = FontAwesome.Sharp.IconChar.SearchDollar;
            this.btn_search.IconColor = System.Drawing.Color.Black;
            this.btn_search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_search.IconSize = 30;
            this.btn_search.Location = new System.Drawing.Point(224, 66);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(43, 34);
            this.btn_search.TabIndex = 44;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(278, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Código";
            // 
            // txt_product_code
            // 
            this.txt_product_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_code.Location = new System.Drawing.Point(26, 66);
            this.txt_product_code.Name = "txt_product_code";
            this.txt_product_code.Size = new System.Drawing.Size(196, 30);
            this.txt_product_code.TabIndex = 0;
            // 
            // cb_chanel
            // 
            this.cb_chanel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_chanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_chanel.FormattingEnabled = true;
            this.cb_chanel.Items.AddRange(new object[] {
            "FACEBOOK",
            "INSTAGRAM",
            "WHATSAPP"});
            this.cb_chanel.Location = new System.Drawing.Point(324, 341);
            this.cb_chanel.Name = "cb_chanel";
            this.cb_chanel.Size = new System.Drawing.Size(228, 33);
            this.cb_chanel.TabIndex = 38;
            // 
            // btn_add_product_to_dt
            // 
            this.btn_add_product_to_dt.FlatAppearance.BorderSize = 0;
            this.btn_add_product_to_dt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_add_product_to_dt.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btn_add_product_to_dt.IconColor = System.Drawing.Color.Green;
            this.btn_add_product_to_dt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_add_product_to_dt.IconSize = 55;
            this.btn_add_product_to_dt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_add_product_to_dt.Location = new System.Drawing.Point(976, 408);
            this.btn_add_product_to_dt.Name = "btn_add_product_to_dt";
            this.btn_add_product_to_dt.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btn_add_product_to_dt.Size = new System.Drawing.Size(120, 112);
            this.btn_add_product_to_dt.TabIndex = 43;
            this.btn_add_product_to_dt.Text = "Agregar";
            this.btn_add_product_to_dt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_add_product_to_dt.UseVisualStyleBackColor = true;
            this.btn_add_product_to_dt.Click += new System.EventHandler(this.btn_add_product_to_dt_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(806, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 20);
            this.label15.TabIndex = 45;
            this.label15.Text = "Teléfono";
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone.Location = new System.Drawing.Point(810, 65);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(228, 30);
            this.txt_phone.TabIndex = 44;
            // 
            // txt_total
            // 
            this.txt_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(51, 798);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(133, 30);
            this.txt_total.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(47, 775);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 20);
            this.label16.TabIndex = 32;
            this.label16.Text = "TOTAL";
            // 
            // txt_cash
            // 
            this.txt_cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cash.Location = new System.Drawing.Point(218, 798);
            this.txt_cash.Name = "txt_cash";
            this.txt_cash.Size = new System.Drawing.Size(133, 30);
            this.txt_cash.TabIndex = 26;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(214, 775);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 20);
            this.label17.TabIndex = 32;
            this.label17.Text = "CONTADO";
            // 
            // txt_credit
            // 
            this.txt_credit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_credit.Location = new System.Drawing.Point(406, 798);
            this.txt_credit.Name = "txt_credit";
            this.txt_credit.Size = new System.Drawing.Size(133, 30);
            this.txt_credit.TabIndex = 26;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(402, 775);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 20);
            this.label18.TabIndex = 32;
            this.label18.Text = "CRÉDITO";
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
            this.groupBox2.Location = new System.Drawing.Point(41, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1055, 137);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // cb_client_name
            // 
            this.cb_client_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_client_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_client_name.FormattingEnabled = true;
            this.cb_client_name.Items.AddRange(new object[] {
            "BOLETA",
            "FACTURA",
            "COTIZACION",
            "NOTA DE VENTA"});
            this.cb_client_name.Location = new System.Drawing.Point(26, 65);
            this.cb_client_name.Name = "cb_client_name";
            this.cb_client_name.Size = new System.Drawing.Size(196, 33);
            this.cb_client_name.TabIndex = 38;
            this.cb_client_name.SelectedIndexChanged += new System.EventHandler(this.cb_client_name_SelectedIndexChanged);
            // 
            // btn_add_client
            // 
            this.btn_add_client.FlatAppearance.BorderSize = 0;
            this.btn_add_client.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btn_add_client.IconColor = System.Drawing.Color.Black;
            this.btn_add_client.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_add_client.IconSize = 30;
            this.btn_add_client.Location = new System.Drawing.Point(228, 64);
            this.btn_add_client.Name = "btn_add_client";
            this.btn_add_client.Size = new System.Drawing.Size(43, 34);
            this.btn_add_client.TabIndex = 44;
            this.btn_add_client.UseVisualStyleBackColor = true;
            this.btn_add_client.Click += new System.EventHandler(this.btn_add_client_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(549, 43);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 20);
            this.label19.TabIndex = 1;
            this.label19.Text = "Talla";
            // 
            // txt_size
            // 
            this.txt_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_size.Location = new System.Drawing.Point(553, 66);
            this.txt_size.Name = "txt_size";
            this.txt_size.Size = new System.Drawing.Size(89, 30);
            this.txt_size.TabIndex = 45;
            // 
            // AddSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 880);
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
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_observation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_credit);
            this.Controls.Add(this.txt_cash);
            this.Controls.Add(this.txt_total);
            this.Name = "AddSaleForm";
            this.Text = "AddSaleForm";
            this.Load += new System.EventHandler(this.AddSaleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_products)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.TextBox txt_product_price;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_cash;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_credit;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_client_name;
        private FontAwesome.Sharp.IconButton btn_add_client;
        private System.Windows.Forms.TextBox txt_size;
        private System.Windows.Forms.Label label19;
    }
}