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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_sales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sistemadeventasdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemadeventasdbDataSet = new SistemaDeVentas.sistemadeventasdbDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_total_sales = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart_sales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemadeventasdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemadeventasdbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_sales
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_sales.ChartAreas.Add(chartArea1);
            this.chart_sales.DataSource = this.sistemadeventasdbDataSetBindingSource;
            legend1.Name = "Legend1";
            this.chart_sales.Legends.Add(legend1);
            this.chart_sales.Location = new System.Drawing.Point(42, 293);
            this.chart_sales.Name = "chart_sales";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_sales.Series.Add(series1);
            this.chart_sales.Size = new System.Drawing.Size(654, 300);
            this.chart_sales.TabIndex = 0;
            this.chart_sales.Text = "chart1";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ventas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ventas Totales";
            // 
            // lbl_total_sales
            // 
            this.lbl_total_sales.AutoSize = true;
            this.lbl_total_sales.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_sales.Location = new System.Drawing.Point(47, 113);
            this.lbl_total_sales.Name = "lbl_total_sales";
            this.lbl_total_sales.Size = new System.Drawing.Size(126, 46);
            this.lbl_total_sales.TabIndex = 2;
            this.lbl_total_sales.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(892, 46);
            this.label3.TabIndex = 3;
            this.label3.Text = "Validar entrar los mismos productos en el list box\r\n";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 630);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_total_sales);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart_sales);
            this.Name = "HomeForm";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_sales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemadeventasdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemadeventasdbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_sales;
        private System.Windows.Forms.BindingSource sistemadeventasdbDataSetBindingSource;
        private sistemadeventasdbDataSet sistemadeventasdbDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_total_sales;
        private System.Windows.Forms.Label label3;
    }
}