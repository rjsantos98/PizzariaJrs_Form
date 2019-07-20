namespace UI
{
    partial class FrmPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidos));
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.txtConsTel = new System.Windows.Forms.MaskedTextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblConsultTel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gpPedidos = new System.Windows.Forms.GroupBox();
            this.gpProdutosPedidos = new System.Windows.Forms.GroupBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.btnIncluirProdutos = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvProdutosPedidos = new System.Windows.Forms.DataGridView();
            this.lblListaProdutos = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.CancelarProdutos = new System.Windows.Forms.Button();
            this.btnSalvarProduto = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblDetalhes = new System.Windows.Forms.Label();
            this.btnMaisProdutos = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDtEntrega = new System.Windows.Forms.Label();
            this.lblDtEfetuada = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtDtEntrega = new System.Windows.Forms.TextBox();
            this.txtDtEfetuada = new System.Windows.Forms.TextBox();
            this.lblProdutosPedidos = new System.Windows.Forms.Label();
            this.dgvListaProdutos = new System.Windows.Forms.DataGridView();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtTelefonePedido = new System.Windows.Forms.MaskedTextBox();
            this.lblTelPedido = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblNomePedido = new System.Windows.Forms.Label();
            this.txtNomePedido = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.gpPedidos.SuspendLayout();
            this.gpProdutosPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHorario
            // 
            this.lblHorario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHorario.AutoSize = true;
            this.lblHorario.BackColor = System.Drawing.Color.Transparent;
            this.lblHorario.Font = new System.Drawing.Font("MV Boli", 12F);
            this.lblHorario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHorario.Location = new System.Drawing.Point(666, 9);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(0, 21);
            this.lblHorario.TabIndex = 0;
            // 
            // lblData
            // 
            this.lblData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("MV Boli", 12F);
            this.lblData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblData.Location = new System.Drawing.Point(546, 9);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(0, 21);
            this.lblData.TabIndex = 1;
            // 
            // txtConsTel
            // 
            this.txtConsTel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtConsTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConsTel.Font = new System.Drawing.Font("Arial", 12F);
            this.txtConsTel.Location = new System.Drawing.Point(36, 49);
            this.txtConsTel.Mask = "(99)99999-9999";
            this.txtConsTel.Name = "txtConsTel";
            this.txtConsTel.Size = new System.Drawing.Size(151, 26);
            this.txtConsTel.TabIndex = 13;
            this.txtConsTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtConsTel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(198)))), ((int)(((byte)(30)))));
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(491, 49);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(111, 26);
            this.btnAlterar.TabIndex = 19;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(350, 49);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(111, 26);
            this.btnCadastrar.TabIndex = 18;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExcluir.BackColor = System.Drawing.Color.LightCoral;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(628, 49);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(111, 26);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedidos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(36, 94);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.Size = new System.Drawing.Size(703, 276);
            this.dgvPedidos.TabIndex = 16;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConsultar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(213, 49);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(111, 26);
            this.btnConsultar.TabIndex = 15;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.UseVisualStyleBackColor = false;
            // 
            // lblConsultTel
            // 
            this.lblConsultTel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblConsultTel.AutoSize = true;
            this.lblConsultTel.BackColor = System.Drawing.Color.Transparent;
            this.lblConsultTel.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultTel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblConsultTel.Location = new System.Drawing.Point(32, 28);
            this.lblConsultTel.Name = "lblConsultTel";
            this.lblConsultTel.Size = new System.Drawing.Size(155, 21);
            this.lblConsultTel.TabIndex = 14;
            this.lblConsultTel.Text = "Telefone do Cliente";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gpPedidos
            // 
            this.gpPedidos.BackColor = System.Drawing.Color.White;
            this.gpPedidos.Controls.Add(this.gpProdutosPedidos);
            this.gpPedidos.Controls.Add(this.cmbStatus);
            this.gpPedidos.Controls.Add(this.lblDetalhes);
            this.gpPedidos.Controls.Add(this.btnMaisProdutos);
            this.gpPedidos.Controls.Add(this.lblValor);
            this.gpPedidos.Controls.Add(this.lblStatus);
            this.gpPedidos.Controls.Add(this.lblDtEntrega);
            this.gpPedidos.Controls.Add(this.lblDtEfetuada);
            this.gpPedidos.Controls.Add(this.txtValorTotal);
            this.gpPedidos.Controls.Add(this.txtDtEntrega);
            this.gpPedidos.Controls.Add(this.txtDtEfetuada);
            this.gpPedidos.Controls.Add(this.lblProdutosPedidos);
            this.gpPedidos.Controls.Add(this.dgvListaProdutos);
            this.gpPedidos.Controls.Add(this.lblObservacao);
            this.gpPedidos.Controls.Add(this.txtObservacao);
            this.gpPedidos.Controls.Add(this.txtID);
            this.gpPedidos.Controls.Add(this.btnPesquisar);
            this.gpPedidos.Controls.Add(this.btnCancelar);
            this.gpPedidos.Controls.Add(this.txtTelefonePedido);
            this.gpPedidos.Controls.Add(this.lblTelPedido);
            this.gpPedidos.Controls.Add(this.btnSalvar);
            this.gpPedidos.Controls.Add(this.lblNomePedido);
            this.gpPedidos.Controls.Add(this.txtNomePedido);
            this.gpPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gpPedidos.Font = new System.Drawing.Font("Arial", 12F);
            this.gpPedidos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gpPedidos.Location = new System.Drawing.Point(26, 81);
            this.gpPedidos.Name = "gpPedidos";
            this.gpPedidos.Size = new System.Drawing.Size(746, 350);
            this.gpPedidos.TabIndex = 20;
            this.gpPedidos.TabStop = false;
            this.gpPedidos.Text = " Cadastrar Pedido";
            this.gpPedidos.Visible = false;
            // 
            // gpProdutosPedidos
            // 
            this.gpProdutosPedidos.BackColor = System.Drawing.Color.LightBlue;
            this.gpProdutosPedidos.Controls.Add(this.dgvProdutos);
            this.gpProdutosPedidos.Controls.Add(this.btnIncluirProdutos);
            this.gpProdutosPedidos.Controls.Add(this.label6);
            this.gpProdutosPedidos.Controls.Add(this.dgvProdutosPedidos);
            this.gpProdutosPedidos.Controls.Add(this.lblListaProdutos);
            this.gpProdutosPedidos.Controls.Add(this.textBox5);
            this.gpProdutosPedidos.Controls.Add(this.CancelarProdutos);
            this.gpProdutosPedidos.Controls.Add(this.btnSalvarProduto);
            this.gpProdutosPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gpProdutosPedidos.Font = new System.Drawing.Font("Arial", 12F);
            this.gpProdutosPedidos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gpProdutosPedidos.Location = new System.Drawing.Point(6, 69);
            this.gpProdutosPedidos.Name = "gpProdutosPedidos";
            this.gpProdutosPedidos.Size = new System.Drawing.Size(746, 237);
            this.gpProdutosPedidos.TabIndex = 49;
            this.gpProdutosPedidos.TabStop = false;
            this.gpProdutosPedidos.Text = "Lista de Produtos";
            this.gpProdutosPedidos.Visible = false;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(26, 46);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(339, 106);
            this.dgvProdutos.TabIndex = 47;
            // 
            // btnIncluirProdutos
            // 
            this.btnIncluirProdutos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIncluirProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(189)))), ((int)(((byte)(12)))));
            this.btnIncluirProdutos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIncluirProdutos.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnIncluirProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluirProdutos.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirProdutos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIncluirProdutos.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluirProdutos.Image")));
            this.btnIncluirProdutos.Location = new System.Drawing.Point(341, 17);
            this.btnIncluirProdutos.Name = "btnIncluirProdutos";
            this.btnIncluirProdutos.Size = new System.Drawing.Size(24, 26);
            this.btnIncluirProdutos.TabIndex = 46;
            this.btnIncluirProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluirProdutos.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 18);
            this.label6.TabIndex = 33;
            this.label6.Text = "Produtos Pedidos";
            // 
            // dgvProdutosPedidos
            // 
            this.dgvProdutosPedidos.AllowUserToAddRows = false;
            this.dgvProdutosPedidos.AllowUserToDeleteRows = false;
            this.dgvProdutosPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutosPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutosPedidos.Location = new System.Drawing.Point(382, 46);
            this.dgvProdutosPedidos.Name = "dgvProdutosPedidos";
            this.dgvProdutosPedidos.ReadOnly = true;
            this.dgvProdutosPedidos.Size = new System.Drawing.Size(339, 106);
            this.dgvProdutosPedidos.TabIndex = 32;
            // 
            // lblListaProdutos
            // 
            this.lblListaProdutos.AutoSize = true;
            this.lblListaProdutos.Location = new System.Drawing.Point(23, 25);
            this.lblListaProdutos.Name = "lblListaProdutos";
            this.lblListaProdutos.Size = new System.Drawing.Size(157, 18);
            this.lblListaProdutos.TabIndex = 31;
            this.lblListaProdutos.Text = "Produtos Disponiveis";
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(702, 12);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(30, 26);
            this.textBox5.TabIndex = 29;
            this.textBox5.Visible = false;
            // 
            // CancelarProdutos
            // 
            this.CancelarProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CancelarProdutos.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.CancelarProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelarProdutos.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarProdutos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelarProdutos.Image = ((System.Drawing.Image)(resources.GetObject("CancelarProdutos.Image")));
            this.CancelarProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelarProdutos.Location = new System.Drawing.Point(382, 183);
            this.CancelarProdutos.Name = "CancelarProdutos";
            this.CancelarProdutos.Size = new System.Drawing.Size(103, 26);
            this.CancelarProdutos.TabIndex = 27;
            this.CancelarProdutos.Text = "Cancelar";
            this.CancelarProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelarProdutos.UseVisualStyleBackColor = false;
            this.CancelarProdutos.Click += new System.EventHandler(this.CancelarProdutos_Click);
            // 
            // btnSalvarProduto
            // 
            this.btnSalvarProduto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalvarProduto.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSalvarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarProduto.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarProduto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvarProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarProduto.Image")));
            this.btnSalvarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarProduto.Location = new System.Drawing.Point(262, 183);
            this.btnSalvarProduto.Name = "btnSalvarProduto";
            this.btnSalvarProduto.Size = new System.Drawing.Size(103, 26);
            this.btnSalvarProduto.TabIndex = 15;
            this.btnSalvarProduto.Text = "Salvar";
            this.btnSalvarProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarProduto.UseVisualStyleBackColor = false;
            this.btnSalvarProduto.Click += new System.EventHandler(this.btnSalvarProduto_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(455, 240);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(145, 26);
            this.cmbStatus.TabIndex = 48;
            // 
            // lblDetalhes
            // 
            this.lblDetalhes.AutoSize = true;
            this.lblDetalhes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDetalhes.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalhes.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblDetalhes.Location = new System.Drawing.Point(662, 28);
            this.lblDetalhes.Name = "lblDetalhes";
            this.lblDetalhes.Size = new System.Drawing.Size(59, 14);
            this.lblDetalhes.TabIndex = 47;
            this.lblDetalhes.Text = "DETALHES";
            this.lblDetalhes.Click += new System.EventHandler(this.lblDetalhes_Click);
            // 
            // btnMaisProdutos
            // 
            this.btnMaisProdutos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMaisProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(189)))), ((int)(((byte)(12)))));
            this.btnMaisProdutos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaisProdutos.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnMaisProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaisProdutos.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaisProdutos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMaisProdutos.Image = ((System.Drawing.Image)(resources.GetObject("btnMaisProdutos.Image")));
            this.btnMaisProdutos.Location = new System.Drawing.Point(697, 74);
            this.btnMaisProdutos.Name = "btnMaisProdutos";
            this.btnMaisProdutos.Size = new System.Drawing.Size(24, 26);
            this.btnMaisProdutos.TabIndex = 46;
            this.btnMaisProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaisProdutos.UseVisualStyleBackColor = false;
            this.btnMaisProdutos.Click += new System.EventHandler(this.btnMaisProdutos_Click);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(613, 219);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(80, 18);
            this.lblValor.TabIndex = 45;
            this.lblValor.Text = "Valor Total";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(452, 219);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(107, 18);
            this.lblStatus.TabIndex = 44;
            this.lblStatus.Text = "Status Pedido";
            // 
            // lblDtEntrega
            // 
            this.lblDtEntrega.AutoSize = true;
            this.lblDtEntrega.Location = new System.Drawing.Point(239, 219);
            this.lblDtEntrega.Name = "lblDtEntrega";
            this.lblDtEntrega.Size = new System.Drawing.Size(101, 18);
            this.lblDtEntrega.TabIndex = 43;
            this.lblDtEntrega.Text = "Data Entrega";
            // 
            // lblDtEfetuada
            // 
            this.lblDtEfetuada.AutoSize = true;
            this.lblDtEfetuada.Location = new System.Drawing.Point(26, 219);
            this.lblDtEfetuada.Name = "lblDtEfetuada";
            this.lblDtEfetuada.Size = new System.Drawing.Size(109, 18);
            this.lblDtEfetuada.TabIndex = 42;
            this.lblDtEfetuada.Text = "Data Efetuada";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Location = new System.Drawing.Point(616, 240);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(105, 26);
            this.txtValorTotal.TabIndex = 41;
            // 
            // txtDtEntrega
            // 
            this.txtDtEntrega.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDtEntrega.Enabled = false;
            this.txtDtEntrega.Location = new System.Drawing.Point(242, 240);
            this.txtDtEntrega.Name = "txtDtEntrega";
            this.txtDtEntrega.Size = new System.Drawing.Size(196, 26);
            this.txtDtEntrega.TabIndex = 39;
            // 
            // txtDtEfetuada
            // 
            this.txtDtEfetuada.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDtEfetuada.Enabled = false;
            this.txtDtEfetuada.Location = new System.Drawing.Point(29, 240);
            this.txtDtEfetuada.Name = "txtDtEfetuada";
            this.txtDtEfetuada.Size = new System.Drawing.Size(196, 26);
            this.txtDtEfetuada.TabIndex = 38;
            // 
            // lblProdutosPedidos
            // 
            this.lblProdutosPedidos.AutoSize = true;
            this.lblProdutosPedidos.Location = new System.Drawing.Point(379, 82);
            this.lblProdutosPedidos.Name = "lblProdutosPedidos";
            this.lblProdutosPedidos.Size = new System.Drawing.Size(148, 18);
            this.lblProdutosPedidos.TabIndex = 33;
            this.lblProdutosPedidos.Text = "Produtos do Pedido";
            // 
            // dgvListaProdutos
            // 
            this.dgvListaProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProdutos.Location = new System.Drawing.Point(382, 103);
            this.dgvListaProdutos.Name = "dgvListaProdutos";
            this.dgvListaProdutos.Size = new System.Drawing.Size(339, 106);
            this.dgvListaProdutos.TabIndex = 32;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(26, 84);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(93, 18);
            this.lblObservacao.TabIndex = 31;
            this.lblObservacao.Text = "Observação";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(29, 105);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(336, 104);
            this.txtObservacao.TabIndex = 30;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(0, 324);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(30, 26);
            this.txtID.TabIndex = 29;
            this.txtID.Visible = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPesquisar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(173, 44);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(32, 26);
            this.btnPesquisar.TabIndex = 28;
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(382, 298);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 26);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtTelefonePedido
            // 
            this.txtTelefonePedido.Location = new System.Drawing.Point(29, 44);
            this.txtTelefonePedido.Mask = "(99)99999-9999";
            this.txtTelefonePedido.Name = "txtTelefonePedido";
            this.txtTelefonePedido.Size = new System.Drawing.Size(138, 26);
            this.txtTelefonePedido.TabIndex = 2;
            this.txtTelefonePedido.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblTelPedido
            // 
            this.lblTelPedido.AutoSize = true;
            this.lblTelPedido.Location = new System.Drawing.Point(26, 23);
            this.lblTelPedido.Name = "lblTelPedido";
            this.lblTelPedido.Size = new System.Drawing.Size(141, 18);
            this.lblTelPedido.TabIndex = 17;
            this.lblTelPedido.Text = "Telefone do Cliente";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(262, 298);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(103, 26);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // lblNomePedido
            // 
            this.lblNomePedido.AutoSize = true;
            this.lblNomePedido.Location = new System.Drawing.Point(224, 22);
            this.lblNomePedido.Name = "lblNomePedido";
            this.lblNomePedido.Size = new System.Drawing.Size(125, 18);
            this.lblNomePedido.TabIndex = 5;
            this.lblNomePedido.Text = "Nome do Cliente";
            // 
            // txtNomePedido
            // 
            this.txtNomePedido.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNomePedido.Enabled = false;
            this.txtNomePedido.Location = new System.Drawing.Point(226, 44);
            this.txtNomePedido.Name = "txtNomePedido";
            this.txtNomePedido.Size = new System.Drawing.Size(495, 26);
            this.txtNomePedido.TabIndex = 1;
            // 
            // FrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(770, 395);
            this.Controls.Add(this.gpPedidos);
            this.Controls.Add(this.txtConsTel);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblConsultTel);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblHorario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPedidos";
            this.Text = "Pedidos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPedidos_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.gpPedidos.ResumeLayout(false);
            this.gpPedidos.PerformLayout();
            this.gpProdutosPedidos.ResumeLayout(false);
            this.gpProdutosPedidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.MaskedTextBox txtConsTel;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblConsultTel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox gpPedidos;
        private System.Windows.Forms.Label lblProdutosPedidos;
        private System.Windows.Forms.DataGridView dgvListaProdutos;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.MaskedTextBox txtTelefonePedido;
        private System.Windows.Forms.Label lblTelPedido;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblNomePedido;
        private System.Windows.Forms.TextBox txtNomePedido;
        private System.Windows.Forms.Button btnMaisProdutos;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDtEntrega;
        private System.Windows.Forms.Label lblDtEfetuada;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TextBox txtDtEntrega;
        private System.Windows.Forms.TextBox txtDtEfetuada;
        private System.Windows.Forms.Label lblDetalhes;
        private System.Windows.Forms.GroupBox gpProdutosPedidos;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button btnIncluirProdutos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvProdutosPedidos;
        private System.Windows.Forms.Label lblListaProdutos;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button CancelarProdutos;
        private System.Windows.Forms.Button btnSalvarProduto;
        private System.Windows.Forms.ComboBox cmbStatus;
    }
}