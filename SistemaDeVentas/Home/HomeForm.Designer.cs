namespace SistemaDeVentas.Home
{
    partial class HomeForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sistemadeventasdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemadeventasdbDataSet = new SistemaDeVentas.sistemadeventasdbDataSet();
            this.lbl_total_sales = new System.Windows.Forms.Label();
            this.dt_sales = new System.Windows.Forms.DataGridView();
            this.dt_start = new System.Windows.Forms.DateTimePicker();
            this.dt_end = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_profit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sistemadeventasdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemadeventasdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_sales)).BeginInit();
            this.SuspendLayout();
            // 
            // sistemadeventasdbDataSetBindingSource
            // 
            this.sistemadeventasdbDataSetBindingSource.DataSource = this.sistemadeventasdbDataSet;
            this.sistemadeventasdbDataSetBindingSource.Position = 0;
            // 
            // sistemadeventasdbDataSet
            // 
            this.sistemadeventasdbDataSet.DataSetName = "sistemadeventasdbDataSet";
            this.sistemadeventasdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_total_sales
            // 
            this.lbl_total_sales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_total_sales.AutoSize = true;
            this.lbl_total_sales.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_sales.Location = new System.Drawing.Point(561, 58);
            this.lbl_total_sales.Name = "lbl_total_sales";
            this.lbl_total_sales.Size = new System.Drawing.Size(132, 49);
            this.lbl_total_sales.TabIndex = 2;
            this.lbl_total_sales.Text = "label3";
            // 
            // dt_sales
            // 
            this.dt_sales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dt_sales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_sales.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dt_sales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_sales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dt_sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_sales.Location = new System.Drawing.Point(31, 229);
            this.dt_sales.Name = "dt_sales";
            this.dt_sales.RowHeadersWidth = 62;
            this.dt_sales.RowTemplate.Height = 28;
            this.dt_sales.Size = new System.Drawing.Size(1125, 435);
            this.dt_sales.TabIndex = 3;
            // 
            // dt_start
            // 
            this.dt_start.Location = new System.Drawing.Point(31, 137);
            this.dt_start.Name = "dt_start";
            this.dt_start.Size = new System.Drawing.Size(200, 26);
            this.dt_start.TabIndex = 7;
            this.dt_start.ValueChanged += new System.EventHandler(this.dt_start_ValueChanged);
            // 
            // dt_end
            // 
            this.dt_end.Location = new System.Drawing.Point(295, 137);
            this.dt_end.Name = "dt_end";
            this.dt_end.Size = new System.Drawing.Size(200, 26);
            this.dt_end.TabIndex = 7;
            this.dt_end.ValueChanged += new System.EventHandler(this.dt_start_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(24, 32);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(325, 40);
            this.label17.TabIndex = 49;
            this.label17.Text = "REPORTE DE VENTAS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 26);
            this.label1.TabIndex = 49;
            this.label1.Text = "Fecha Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(290, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 26);
            this.label3.TabIndex = 49;
            this.label3.Text = "Fecha Fin";
            // 
            // lbl_profit
            // 
            this.lbl_profit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_profit.AutoSize = true;
            this.lbl_profit.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_profit.Location = new System.Drawing.Point(563, 126);
            this.lbl_profit.Name = "lbl_profit";
            this.lbl_profit.Size = new System.Drawing.Size(104, 40);
            this.lbl_profit.TabIndex = 2;
            this.lbl_profit.Text = "label3";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 769);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dt_end);
            this.Controls.Add(this.dt_start);
            this.Controls.Add(this.dt_sales);
            this.Controls.Add(this.lbl_profit);
            this.Controls.Add(this.lbl_total_sales);
            this.Name = "HomeForm";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistemadeventasdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemadeventasdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_sales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource sistemadeventasdbDataSetBindingSource;
        private sistemadeventasdbDataSet sistemadeventasdbDataSet;
        private System.Windows.Forms.Label lbl_total_sales;
        private System.Windows.Forms.DataGridView dt_sales;
        private System.Windows.Forms.DateTimePicker dt_start;
        private System.Windows.Forms.DateTimePicker dt_end;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_profit;
    }
}