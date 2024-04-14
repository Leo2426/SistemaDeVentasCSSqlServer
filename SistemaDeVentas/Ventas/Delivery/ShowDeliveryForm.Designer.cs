namespace SistemaDeVentas.Ventas.Delivery
{
    partial class ShowDeliveryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dt_deliverys = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dt_deliverys)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_deliverys
            // 
            this.dt_deliverys.AllowUserToAddRows = false;
            this.dt_deliverys.AllowUserToDeleteRows = false;
            this.dt_deliverys.AllowUserToOrderColumns = true;
            this.dt_deliverys.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dt_deliverys.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_deliverys.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dt_deliverys.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_deliverys.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dt_deliverys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_deliverys.Location = new System.Drawing.Point(41, 103);
            this.dt_deliverys.Name = "dt_deliverys";
            this.dt_deliverys.ReadOnly = true;
            this.dt_deliverys.RowHeadersWidth = 62;
            this.dt_deliverys.RowTemplate.Height = 28;
            this.dt_deliverys.Size = new System.Drawing.Size(1101, 498);
            this.dt_deliverys.TabIndex = 0;
            // 
            // ShowDeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 769);
            this.Controls.Add(this.dt_deliverys);
            this.Name = "ShowDeliveryForm";
            this.Text = "ShowDeliveryForm";
            this.Load += new System.EventHandler(this.ShowDeliveryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_deliverys)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dt_deliverys;
    }
}