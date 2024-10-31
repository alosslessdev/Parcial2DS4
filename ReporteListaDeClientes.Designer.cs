namespace Parcial2DS4
{
    partial class ReporteListaDeClientes
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
            this.dataGridViewListaClientes = new System.Windows.Forms.DataGridView();
            this.comboBoxFiltrar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListaClientes
            // 
            this.dataGridViewListaClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dataGridViewListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaClientes.Location = new System.Drawing.Point(27, 25);
            this.dataGridViewListaClientes.Name = "dataGridViewListaClientes";
            this.dataGridViewListaClientes.RowHeadersWidth = 51;
            this.dataGridViewListaClientes.RowTemplate.Height = 24;
            this.dataGridViewListaClientes.Size = new System.Drawing.Size(764, 617);
            this.dataGridViewListaClientes.TabIndex = 0;
            // 
            // comboBoxFiltrar
            // 
            this.comboBoxFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.comboBoxFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltrar.FormattingEnabled = true;
            this.comboBoxFiltrar.Items.AddRange(new object[] {
            "Todos",
            "Panamá",
            "Chiriquí",
            "Veraguas",
            "Coclé",
            "Panamá Oeste"});
            this.comboBoxFiltrar.Location = new System.Drawing.Point(828, 88);
            this.comboBoxFiltrar.Name = "comboBoxFiltrar";
            this.comboBoxFiltrar.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFiltrar.TabIndex = 1;
            this.comboBoxFiltrar.SelectedIndexChanged += new System.EventHandler(this.comboboxFiltrar_SelectedIndexChanged);
            // 
            // ReporteListaDeClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(976, 667);
            this.Controls.Add(this.comboBoxFiltrar);
            this.Controls.Add(this.dataGridViewListaClientes);
            this.Name = "ReporteListaDeClientes";
            this.Text = "ReporteListaDeClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListaClientes;
        private System.Windows.Forms.ComboBox comboBoxFiltrar;
    }
}