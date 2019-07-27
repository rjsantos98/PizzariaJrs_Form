namespace UI
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.picProdutos = new System.Windows.Forms.PictureBox();
            this.picClientes = new System.Windows.Forms.PictureBox();
            this.picPedidos = new System.Windows.Forms.PictureBox();
            this.lblProdutos = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.lblPedidos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // picProdutos
            // 
            this.picProdutos.BackColor = System.Drawing.Color.Transparent;
            this.picProdutos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picProdutos.BackgroundImage")));
            this.picProdutos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picProdutos.Location = new System.Drawing.Point(128, 100);
            this.picProdutos.Name = "picProdutos";
            this.picProdutos.Size = new System.Drawing.Size(120, 117);
            this.picProdutos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProdutos.TabIndex = 0;
            this.picProdutos.TabStop = false;
            this.picProdutos.Click += new System.EventHandler(this.picProdutos_Click);
            // 
            // picClientes
            // 
            this.picClientes.BackColor = System.Drawing.Color.Transparent;
            this.picClientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picClientes.BackgroundImage")));
            this.picClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClientes.Location = new System.Drawing.Point(333, 100);
            this.picClientes.Name = "picClientes";
            this.picClientes.Size = new System.Drawing.Size(120, 117);
            this.picClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picClientes.TabIndex = 1;
            this.picClientes.TabStop = false;
            this.picClientes.Click += new System.EventHandler(this.picClientes_Click);
            // 
            // picPedidos
            // 
            this.picPedidos.BackColor = System.Drawing.Color.Transparent;
            this.picPedidos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPedidos.BackgroundImage")));
            this.picPedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPedidos.Location = new System.Drawing.Point(537, 100);
            this.picPedidos.Name = "picPedidos";
            this.picPedidos.Size = new System.Drawing.Size(120, 117);
            this.picPedidos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picPedidos.TabIndex = 2;
            this.picPedidos.TabStop = false;
            this.picPedidos.Click += new System.EventHandler(this.picPedidos_Click);
            // 
            // lblProdutos
            // 
            this.lblProdutos.AutoSize = true;
            this.lblProdutos.BackColor = System.Drawing.Color.Transparent;
            this.lblProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProdutos.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutos.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblProdutos.Location = new System.Drawing.Point(145, 220);
            this.lblProdutos.Name = "lblProdutos";
            this.lblProdutos.Size = new System.Drawing.Size(85, 21);
            this.lblProdutos.TabIndex = 3;
            this.lblProdutos.Text = "Produtos";
            this.lblProdutos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblProdutos.Click += new System.EventHandler(this.lblProdutos_Click);
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.BackColor = System.Drawing.Color.Transparent;
            this.lblClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClientes.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblClientes.Location = new System.Drawing.Point(355, 220);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(76, 21);
            this.lblClientes.TabIndex = 4;
            this.lblClientes.Text = "Clientes";
            this.lblClientes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblClientes.Click += new System.EventHandler(this.lblClientes_Click);
            // 
            // lblPedidos
            // 
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.BackColor = System.Drawing.Color.Transparent;
            this.lblPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPedidos.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidos.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPedidos.Location = new System.Drawing.Point(561, 225);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(73, 21);
            this.lblPedidos.TabIndex = 5;
            this.lblPedidos.Text = "Pedidos";
            this.lblPedidos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPedidos.Click += new System.EventHandler(this.lblPedidos_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(770, 395);
            this.Controls.Add(this.lblPedidos);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.lblProdutos);
            this.Controls.Add(this.picPedidos);
            this.Controls.Add(this.picClientes);
            this.Controls.Add(this.picProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "Pizzaria Juniors";
            ((System.ComponentModel.ISupportInitialize)(this.picProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picProdutos;
        private System.Windows.Forms.PictureBox picClientes;
        private System.Windows.Forms.PictureBox picPedidos;
        private System.Windows.Forms.Label lblProdutos;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lblPedidos;
    }
}

