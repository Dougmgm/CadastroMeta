using CadastroVendedores.Extensoes.Enums;
using CadastroVendedores.Model;
using Periodicidade = CadastroVendedores.Model.Periodicidade;

namespace CadastroVendedores
{
    partial class FormCadastro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            VendedorDto vendedorDto1 = new VendedorDto();
            VendedorDto vendedorDto2 = new VendedorDto();
            VendedorDto vendedorDto3 = new VendedorDto();
            VendedorDto vendedorDto4 = new VendedorDto();
            VendedorDto vendedorDto5 = new VendedorDto();
            ProdutoDto produtoDto1 = new ProdutoDto();
            ProdutoDto produtoDto2 = new ProdutoDto();
            ProdutoDto produtoDto3 = new ProdutoDto();
            cbVendedor = new ComboBox();
            label1 = new Label();
            gpMeta = new GroupBox();
            rbUnidade = new RadioButton();
            rbLitro = new RadioButton();
            rbMonetario = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            cbProduto = new ComboBox();
            cbPeriodicidade = new ComboBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            tbValorMeta = new TextBox();
            label4 = new Label();
            btnVoltar = new Button();
            btnDuplicar = new Button();
            gpMeta.SuspendLayout();
            SuspendLayout();
            // 
            // cbVendedor
            // 
            cbVendedor.Anchor = AnchorStyles.None;
            cbVendedor.DisplayMember = "NomeVendedor";
            cbVendedor.Font = new Font("Montserrat", 8.999999F);
            cbVendedor.FormattingEnabled = true;
            vendedorDto1.Handle = 1;
            vendedorDto1.NomeVendedor = "João da Silva";
            vendedorDto2.Handle = 2;
            vendedorDto2.NomeVendedor = "Maria Oliveira";
            vendedorDto3.Handle = 3;
            vendedorDto3.NomeVendedor = "Carlos Eduardo";
            vendedorDto4.Handle = 4;
            vendedorDto4.NomeVendedor = "Fernanda Souza";
            vendedorDto5.Handle = 5;
            vendedorDto5.NomeVendedor = "Lucas Pereira";
            cbVendedor.Items.AddRange(new object[] { vendedorDto1, vendedorDto2, vendedorDto3, vendedorDto4, vendedorDto5 });
            cbVendedor.Location = new Point(27, 105);
            cbVendedor.Name = "cbVendedor";
            cbVendedor.Size = new Size(501, 26);
            cbVendedor.TabIndex = 0;
            cbVendedor.ValueMember = "Handle";
            cbVendedor.DropDown += cbVendedor_DropDown;
            cbVendedor.MouseClick += cbVendedor_MouseClick;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 9F);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(27, 84);
            label1.Name = "label1";
            label1.Size = new Size(66, 18);
            label1.TabIndex = 1;
            label1.Text = "Vendedor";
            // 
            // gpMeta
            // 
            gpMeta.Anchor = AnchorStyles.Right;
            gpMeta.Controls.Add(rbUnidade);
            gpMeta.Controls.Add(rbLitro);
            gpMeta.Controls.Add(rbMonetario);
            gpMeta.Font = new Font("Montserrat", 9F);
            gpMeta.ForeColor = Color.Gold;
            gpMeta.Location = new Point(557, 84);
            gpMeta.Name = "gpMeta";
            gpMeta.Size = new Size(167, 107);
            gpMeta.TabIndex = 2;
            gpMeta.TabStop = false;
            gpMeta.Text = "Meta";
            // 
            // rbUnidade
            // 
            rbUnidade.AutoSize = true;
            rbUnidade.Location = new Point(12, 78);
            rbUnidade.Name = "rbUnidade";
            rbUnidade.Size = new Size(82, 22);
            rbUnidade.TabIndex = 2;
            rbUnidade.TabStop = true;
            rbUnidade.Text = "Unidades";
            rbUnidade.UseVisualStyleBackColor = true;
            rbUnidade.CheckedChanged += rbUnidade_CheckedChanged;
            // 
            // rbLitro
            // 
            rbLitro.AutoSize = true;
            rbLitro.Location = new Point(12, 50);
            rbLitro.Name = "rbLitro";
            rbLitro.Size = new Size(60, 22);
            rbLitro.TabIndex = 1;
            rbLitro.TabStop = true;
            rbLitro.Text = "Litros";
            rbLitro.UseVisualStyleBackColor = true;
            rbLitro.CheckedChanged += rbLitro_CheckedChanged;
            // 
            // rbMonetario
            // 
            rbMonetario.AutoSize = true;
            rbMonetario.Location = new Point(12, 21);
            rbMonetario.Name = "rbMonetario";
            rbMonetario.Size = new Size(115, 22);
            rbMonetario.TabIndex = 0;
            rbMonetario.TabStop = true;
            rbMonetario.Text = "Monetário (R$)";
            rbMonetario.UseVisualStyleBackColor = true;
            rbMonetario.CheckedChanged += rbMonetario_CheckedChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 9F);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(27, 144);
            label2.Name = "label2";
            label2.Size = new Size(91, 18);
            label2.TabIndex = 3;
            label2.Text = "Periodicidade";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 9F);
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(198, 144);
            label3.Name = "label3";
            label3.Size = new Size(59, 18);
            label3.TabIndex = 4;
            label3.Text = "Produto";
            // 
            // cbProduto
            // 
            cbProduto.Anchor = AnchorStyles.None;
            cbProduto.DisplayMember = "NomeProduto";
            cbProduto.Font = new Font("Montserrat", 8.999999F);
            cbProduto.FormattingEnabled = true;
            produtoDto1.Categoria = ProdutoDto.CategoriaProduto.Liquido;
            produtoDto1.Handle = 0;
            produtoDto1.NomeProduto = null;
            produtoDto2.Categoria = ProdutoDto.CategoriaProduto.Liquido;
            produtoDto2.Handle = 0;
            produtoDto2.NomeProduto = null;
            produtoDto3.Categoria = ProdutoDto.CategoriaProduto.Liquido;
            produtoDto3.Handle = 0;
            produtoDto3.NomeProduto = null;
            cbProduto.Items.AddRange(new object[] { produtoDto1, produtoDto2, produtoDto3 });
            cbProduto.Location = new Point(198, 165);
            cbProduto.Name = "cbProduto";
            cbProduto.Size = new Size(156, 26);
            cbProduto.TabIndex = 5;
            cbProduto.DropDown += cbProduto_DropDown;
            cbProduto.DropDownClosed += cbProduto_DropDownClosed;
            cbProduto.MouseClick += cbProduto_MouseClick;
            // 
            // cbPeriodicidade
            // 
            cbPeriodicidade.Anchor = AnchorStyles.None;
            cbPeriodicidade.DisplayMember = "Texto";
            cbPeriodicidade.Font = new Font("Montserrat", 8.999999F);
            cbPeriodicidade.FormattingEnabled = true;
            cbPeriodicidade.Location = new Point(27, 165);
            cbPeriodicidade.Name = "cbPeriodicidade";
            cbPeriodicidade.Size = new Size(152, 26);
            cbPeriodicidade.TabIndex = 6;
            cbPeriodicidade.ValueMember = "Valor";
            cbPeriodicidade.DropDown += cbPeriodicidade_DropDown;
            cbPeriodicidade.MouseClick += cbPeriodicidade_MouseClick;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSalvar.BackColor = Color.Gold;
            btnSalvar.Font = new Font("Montserrat", 9F);
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.Location = new Point(635, 28);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(89, 26);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar (F2)";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.Font = new Font("Montserrat", 9F);
            btnCancelar.Location = new Point(27, 28);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(76, 26);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Limpar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // tbValorMeta
            // 
            tbValorMeta.Anchor = AnchorStyles.None;
            tbValorMeta.Font = new Font("Montserrat", 8.999999F);
            tbValorMeta.Location = new Point(376, 166);
            tbValorMeta.Multiline = true;
            tbValorMeta.Name = "tbValorMeta";
            tbValorMeta.Size = new Size(152, 25);
            tbValorMeta.TabIndex = 9;
            tbValorMeta.MouseClick += tbValorMeta_MouseClick;
            tbValorMeta.KeyPress += tbValorMeta_KeyPress;
            tbValorMeta.Leave += tbValorMeta_Leave;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat", 9F);
            label4.ForeColor = Color.Gold;
            label4.Location = new Point(376, 145);
            label4.Name = "label4";
            label4.Size = new Size(89, 18);
            label4.TabIndex = 10;
            label4.Text = "Valor da Meta";
            // 
            // btnVoltar
            // 
            btnVoltar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVoltar.BackColor = Color.FromArgb(51, 67, 85);
            btnVoltar.Font = new Font("Montserrat", 9F);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(538, 28);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(91, 26);
            btnVoltar.TabIndex = 11;
            btnVoltar.Text = "Voltar (Esc)";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnDuplicar
            // 
            btnDuplicar.BackColor = Color.OrangeRed;
            btnDuplicar.Font = new Font("Montserrat", 9F);
            btnDuplicar.ForeColor = Color.White;
            btnDuplicar.Location = new Point(119, 28);
            btnDuplicar.Name = "btnDuplicar";
            btnDuplicar.Size = new Size(108, 26);
            btnDuplicar.TabIndex = 12;
            btnDuplicar.Text = "Duplicar meta";
            btnDuplicar.UseVisualStyleBackColor = false;
            btnDuplicar.Visible = false;
            btnDuplicar.Click += btnDuplicar_Click;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 67, 85);
            ClientSize = new Size(746, 248);
            Controls.Add(btnDuplicar);
            Controls.Add(tbValorMeta);
            Controls.Add(gpMeta);
            Controls.Add(label4);
            Controls.Add(btnCancelar);
            Controls.Add(cbProduto);
            Controls.Add(cbPeriodicidade);
            Controls.Add(btnSalvar);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(btnVoltar);
            Controls.Add(label1);
            Controls.Add(cbVendedor);
            ForeColor = SystemColors.ControlText;
            Name = "FormCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Meta";
            KeyDown += FormCadastro_KeyDown;
            gpMeta.ResumeLayout(false);
            gpMeta.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void CarregarDadosPeriodicidade()
        {
            cbPeriodicidade.DataSource = Enum.GetValues(typeof(Periodicidade))
                                             .Cast<Periodicidade>()
                                             .Select(e => new { Valor = e, Texto = e.DescricaoEnum() })
                                             .ToList();

            cbPeriodicidade.DisplayMember = "Texto";
            cbPeriodicidade.ValueMember = "Valor";
            cbPeriodicidade.SelectedIndex = -1;
        }

        #endregion

        private ComboBox cbVendedor;
        private Label label1;
        private GroupBox gpMeta;
        private RadioButton rbUnidade;
        private RadioButton rbLitro;
        private RadioButton rbMonetario;
        private Label label2;
        private Label label3;
        private ComboBox cbProduto;
        private ComboBox cbPeriodicidade;
        private Button btnSalvar;
        private Button btnCancelar;
        private TextBox tbValorMeta;
        private Label label4;
        private Button btnVoltar;
        private Button btnDuplicar;
    }
}
