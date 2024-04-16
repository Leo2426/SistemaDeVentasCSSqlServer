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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sistemadeventasdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemadeventasdbDataSet = new SistemaDeVentas.sistemadeventasdbDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_total_sales = new System.Windows.Forms.Label();
            this.dt_sales = new System.Windows.Forms.DataGridView();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lbl_date = new System.Windows.Forms.Label();
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
            this.lbl_total_sales.Location = new System.Drawing.Point(45, 101);
            this.lbl_total_sales.Name = "lbl_total_sales";
            this.lbl_total_sales.Size = new System.Drawing.Size(126, 46);
            this.lbl_total_sales.TabIndex = 2;
            this.lbl_total_sales.Text = "label3";
            // 
            // dt_sales
            // 
            this.dt_sales.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dt_sales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_sales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dt_sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_sales.Location = new System.Drawing.Point(366, 368);
            this.dt_sales.Name = "dt_sales";
            this.dt_sales.RowHeadersWidth = 62;
            this.dt_sales.RowTemplate.Height = 28;
            this.dt_sales.Size = new System.Drawing.Size(758, 253);
            this.dt_sales.TabIndex = 3;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(42, 368);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(362, 329);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(51, 20);
            this.lbl_date.TabIndex = 6;
            this.lbl_date.Text = "label1";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 769);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dt_sales);
            this.Controls.Add(this.lbl_total_sales);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_total_sales;
        private System.Windows.Forms.DataGridView dt_sales;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lbl_date;
    }
}