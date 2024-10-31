namespace Parcial2DS4
{
    partial class ReporteMontoPorProvincia
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
            this.dataGridViewMontoProvincia = new System.Windows.Forms.DataGridView();
            this.btnMostrarMontoProvincia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMontoProvincia)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMontoProvincia
            // 
            this.dataGridViewMontoProvincia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dataGridViewMontoProvincia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMontoProvincia.Location = new System.Drawing.Point(25, 86);
            this.dataGridViewMontoProvincia.Name = "dataGridViewMontoProvincia";
            this.dataGridViewMontoProvincia.RowHeadersWidth = 51;
            this.dataGridViewMontoProvincia.RowTemplate.Height = 24;
            this.dataGridViewMontoProvincia.Size = new System.Drawing.Size(741, 336);
            this.dataGridViewMontoProvincia.TabIndex = 0;
            // 
            // btnMostrarMontoProvincia
            // 
            this.btnMostrarMontoProvincia.BackColor = System.Drawing.Color.DarkOrange;
            this.btnMostrarMontoProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarMontoProvincia.Location = new System.Drawing.Point(343, 23);
            this.btnMostrarMontoProvincia.Name = "btnMostrarMontoProvincia";
            this.btnMostrarMontoProvincia.Size = new System.Drawing.Size(107, 39);
            this.btnMostrarMontoProvincia.TabIndex = 1;
            this.btnMostrarMontoProvincia.Text = "Mostrar";
            this.btnMostrarMontoProvincia.UseVisualStyleBackColor = false;
            this.btnMostrarMontoProvincia.Click += new System.EventHandler(this.btnMostrarMontoPorProvincia_Click);
            // 
            // ReporteMontoPorProvincia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrarMontoProvincia);
            this.Controls.Add(this.dataGridViewMontoProvincia);
            this.Name = "ReporteMontoPorProvincia";
            this.Text = "ReporteMontoPorProvincia";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMontoProvincia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMontoProvincia;
        private System.Windows.Forms.Button btnMostrarMontoProvincia;
    }
}