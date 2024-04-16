﻿namespace SistemaDeVentas.Productos
{
    partial class AddProductForm
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
            this.cb_sizes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_unit_price = new System.Windows.Forms.TextBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.txt_unit_cost = new System.Windows.Forms.TextBox();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.txt_initial_stock = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_minimum_stock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_add_client
            // 
            this.btn_add_client.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_client.Location = new System.Drawing.Point(61, 600);
            this.btn_add_client.Name = "btn_add_client";
            this.btn_add_client.Size = new System.Drawing.Size(331, 39);
            this.btn_add_client.TabIndex = 24;
            this.btn_add_client.Text = "Añadir";
            this.btn_add_client.UseVisualStyleBackColor = true;
            this.btn_add_client.Click += new System.EventHandler(this.btn_add_client_Click);
            // 
            // cb_sizes
            // 
            this.cb_sizes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_sizes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_sizes.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_sizes.FormattingEnabled = true;
            this.cb_sizes.Location = new System.Drawing.Point(61, 507);
            this.cb_sizes.Name = "cb_sizes";
            this.cb_sizes.Size = new System.Drawing.Size(145, 34);
            this.cb_sizes.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 26);
            this.label3.TabIndex = 20;
            this.label3.Text = "Descripción";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 478);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 26);
            this.label6.TabIndex = 19;
            this.label6.Text = "Talla";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(246, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 26);
            this.label5.TabIndex = 16;
            this.label5.Text = "Precio Unitario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "Costo Unitario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "Código";
            // 
            // txt_unit_price
            // 
            this.txt_unit_price.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_unit_price.Location = new System.Drawing.Point(251, 335);
            this.txt_unit_price.Name = "txt_unit_price";
            this.txt_unit_price.Size = new System.Drawing.Size(141, 31);
            this.txt_unit_price.TabIndex = 4;
            // 
            // txt_description
            // 
            this.txt_description.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_description.Location = new System.Drawing.Point(61, 249);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(333, 31);
            this.txt_description.TabIndex = 2;
            // 
            // txt_unit_cost
            // 
            this.txt_unit_cost.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_unit_cost.Location = new System.Drawing.Point(61, 335);
            this.txt_unit_cost.Name = "txt_unit_cost";
            this.txt_unit_cost.Size = new System.Drawing.Size(147, 31);
            this.txt_unit_cost.TabIndex = 3;
            // 
            // txt_code
            // 
            this.txt_code.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_code.Location = new System.Drawing.Point(61, 163);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(333, 31);
            this.txt_code.TabIndex = 1;
            // 
            // txt_initial_stock
            // 
            this.txt_initial_stock.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_initial_stock.Location = new System.Drawing.Point(61, 421);
            this.txt_initial_stock.Name = "txt_initial_stock";
            this.txt_initial_stock.Size = new System.Drawing.Size(145, 31);
            this.txt_initial_stock.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "Stock Inicial";
            // 
            // txt_minimum_stock
            // 
            this.txt_minimum_stock.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_minimum_stock.Location = new System.Drawing.Point(251, 421);
            this.txt_minimum_stock.Name = "txt_minimum_stock";
            this.txt_minimum_stock.Size = new System.Drawing.Size(141, 31);
            this.txt_minimum_stock.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(246, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "Stock Mínimo";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(54, 55);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(333, 40);
            this.label17.TabIndex = 48;
            this.label17.Text = "AGREGAR PRODUCTO";
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 671);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btn_add_client);
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
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(474, 727);
            this.MinimumSize = new System.Drawing.Size(474, 727);
            this.Name = "AddProductForm";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add_client;
        private System.Windows.Forms.ComboBox cb_sizes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_unit_price;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.TextBox txt_unit_cost;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.TextBox txt_initial_stock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_minimum_stock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label17;
    }
}