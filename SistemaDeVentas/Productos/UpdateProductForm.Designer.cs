namespace SistemaDeVentas.Productos
{
    partial class UpdateProductForm
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
            this.btn_update_product = new System.Windows.Forms.Button();
            this.cb_sizes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_minimum_stock = new System.Windows.Forms.TextBox();
            this.txt_initial_stock = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_unit_price = new System.Windows.Forms.TextBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.txt_unit_cost = new System.Windows.Forms.TextBox();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_update_product
            // 
            this.btn_update_product.Location = new System.Drawing.Point(499, 397);
            this.btn_update_product.Name = "btn_update_product";
            this.btn_update_product.Size = new System.Drawing.Size(197, 39);
            this.btn_update_product.TabIndex = 39;
            this.btn_update_product.Text = "Actualizar";
            this.btn_update_product.UseVisualStyleBackColor = true;
            this.btn_update_product.Click += new System.EventHandler(this.btn_update_product_click);
            // 
            // cb_sizes
            // 
            this.cb_sizes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_sizes.FormattingEnabled = true;
            this.cb_sizes.Location = new System.Drawing.Point(196, 308);
            this.cb_sizes.Name = "cb_sizes";
            this.cb_sizes.Size = new System.Drawing.Size(120, 28);
            this.cb_sizes.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Descripción";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Talla";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(434, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Stock Mínimo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Stock Inicial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Precio Unitario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Costo Unitario";
            // 
            // txt_minimum_stock
            // 
            this.txt_minimum_stock.Location = new System.Drawing.Point(576, 256);
            this.txt_minimum_stock.Name = "txt_minimum_stock";
            this.txt_minimum_stock.Size = new System.Drawing.Size(120, 26);
            this.txt_minimum_stock.TabIndex = 27;
            // 
            // txt_initial_stock
            // 
            this.txt_initial_stock.Location = new System.Drawing.Point(198, 242);
            this.txt_initial_stock.Name = "txt_initial_stock";
            this.txt_initial_stock.Size = new System.Drawing.Size(120, 26);
            this.txt_initial_stock.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Código";
            // 
            // txt_unit_price
            // 
            this.txt_unit_price.Location = new System.Drawing.Point(576, 192);
            this.txt_unit_price.Name = "txt_unit_price";
            this.txt_unit_price.Size = new System.Drawing.Size(120, 26);
            this.txt_unit_price.TabIndex = 29;
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(198, 116);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(498, 26);
            this.txt_description.TabIndex = 30;
            // 
            // txt_unit_cost
            // 
            this.txt_unit_cost.Location = new System.Drawing.Point(198, 188);
            this.txt_unit_cost.Name = "txt_unit_cost";
            this.txt_unit_cost.Size = new System.Drawing.Size(120, 26);
            this.txt_unit_cost.TabIndex = 26;
            // 
            // txt_code
            // 
            this.txt_code.Location = new System.Drawing.Point(198, 51);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(498, 26);
            this.txt_code.TabIndex = 25;
            // 
            // UpdateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 479);
            this.Controls.Add(this.btn_update_product);
            this.Controls.Add(this.cb_sizes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_minimum_stock);
            this.Controls.Add(this.txt_initial_stock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_unit_price);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.txt_unit_cost);
            this.Controls.Add(this.txt_code);
            this.Name = "UpdateProductForm";
            this.Text = "UpdateProductForm";
            this.Load += new System.EventHandler(this.UpdateProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_update_product;
        private System.Windows.Forms.ComboBox cb_sizes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_minimum_stock;
        private System.Windows.Forms.TextBox txt_initial_stock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_unit_price;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.TextBox txt_unit_cost;
        private System.Windows.Forms.TextBox txt_code;
    }
}