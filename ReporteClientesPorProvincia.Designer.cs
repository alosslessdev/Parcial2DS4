
namespace Parcial2DS4
{
    partial class ReporteClientesPorProvincia
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
            this.dataGridViewClientesProvincia = new System.Windows.Forms.DataGridView();
            this.btnListaClientes = new System.Windows.Forms.Button();
            this.btnMontoProvincia = new System.Windows.Forms.Button();
            this.btnClientesProvincia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientesProvincia)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClientesProvincia
            // 
            this.dataGridViewClientesProvincia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewClientesProvincia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dataGridViewClientesProvincia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientesProvincia.Location = new System.Drawing.Point(48, 77);
            this.dataGridViewClientesProvincia.Name = "dataGridViewClientesProvincia";
            this.dataGridViewClientesProvincia.RowHeadersWidth = 51;
            this.dataGridViewClientesProvincia.RowTemplate.Height = 24;
            this.dataGridViewClientesProvincia.Size = new System.Drawing.Size(763, 437);
            this.dataGridViewClientesProvincia.TabIndex = 0;
            // 
            // btnListaClientes
            // 
            this.btnListaClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListaClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnListaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaClientes.Location = new System.Drawing.Point(662, 29);
            this.btnListaClientes.Name = "btnListaClientes";
            this.btnListaClientes.Size = new System.Drawing.Size(140, 42);
            this.btnListaClientes.TabIndex = 5;
            this.btnListaClientes.Text = "Lista de Clientes";
            this.btnListaClientes.UseVisualStyleBackColor = false;
            this.btnListaClientes.Click += new System.EventHandler(this.btnListaClientes_Click);
            // 
            // btnMontoProvincia
            // 
            this.btnMontoProvincia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMontoProvincia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMontoProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMontoProvincia.Location = new System.Drawing.Point(436, 29);
            this.btnMontoProvincia.Name = "btnMontoProvincia";
            this.btnMontoProvincia.Size = new System.Drawing.Size(182, 42);
            this.btnMontoProvincia.TabIndex = 4;
            this.btnMontoProvincia.Text = "Monto por provincia";
            this.btnMontoProvincia.UseVisualStyleBackColor = false;
            this.btnMontoProvincia.Click += new System.EventHandler(this.btnMontoProvincia_Click);
            // 
            // btnClientesProvincia
            // 
            this.btnClientesProvincia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClientesProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientesProvincia.ForeColor = System.Drawing.Color.Black;
            this.btnClientesProvincia.Location = new System.Drawing.Point(48, 29);
            this.btnClientesProvincia.Name = "btnClientesProvincia";
            this.btnClientesProvincia.Size = new System.Drawing.Size(237, 42);
            this.btnClientesProvincia.TabIndex = 6;
            this.btnClientesProvincia.Text = "Mostrar Cientes por Provincia";
            this.btnClientesProvincia.UseVisualStyleBackColor = false;
            this.btnClientesProvincia.Click += new System.EventHandler(this.btnClientesProvincia_Click);
            // 
            // ReporteClientesPorProvincia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(855, 526);
            this.Controls.Add(this.btnClientesProvincia);
            this.Controls.Add(this.btnListaClientes);
            this.Controls.Add(this.btnMontoProvincia);
            this.Controls.Add(this.dataGridViewClientesProvincia);
            this.Name = "ReporteClientesPorProvincia";
            this.Text = "ReporteClientesPorProvincia";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientesProvincia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClientesProvincia;
        private System.Windows.Forms.Button btnListaClientes;
        private System.Windows.Forms.Button btnMontoProvincia;
        private System.Windows.Forms.Button btnClientesProvincia;
    }
}