using CadastroVendedores.DadosTelaCadastro;
using CadastroVendedores.Extensoes;
using CadastroVendedores.Extensoes.Exceptions;
using CadastroVendedores.Model;
using System.ComponentModel;
using System.Text;
using static CadastroVendedores.Model.ProdutoDto;

namespace CadastroVendedores
{
    public partial class FormCadastro : Form
    {
        private BindingList<MetaVendedorDto> ListaMetas = [];

        public MetaVendedorDto MetaEditada { get; set; }

        public bool Editando { get; set; }

        public FormCadastro(BindingList<MetaVendedorDto> listaMetas, bool editando, MetaVendedorDto metaParaEditar = null)
        {
            InitializeComponent();

            InteracaoMouseNoBotao();

            SetarTamanhoTela();

            CarregarDadosProduto();

            CarregarDadosPeriodicidade();

            ListaMetas = listaMetas;

            this.KeyPreview = true;

            Editando = editando;

            if (!metaParaEditar.IsNull())
                MetaEditada = metaParaEditar;

            if (Editando)
                CarregarDadosEdicao();
        }

        private void InteracaoMouseNoBotao()
        {
            btnCancelar.Cursor = Cursors.Hand;
            btnDuplicar.Cursor = Cursors.Hand;
            btnSalvar.Cursor = Cursors.Hand;
            btnVoltar.Cursor = Cursors.Hand;

            rbLitro.Cursor = Cursors.Hand;
            rbMonetario.Cursor = Cursors.Hand;
            rbUnidade.Cursor = Cursors.Hand;
        }

        private void SetarTamanhoTela()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void CarregarDadosProduto()
        {
            cbProduto.DataSource = Produtos.ObterProdutos();
            cbProduto.DisplayMember = "NomeProduto";
            cbProduto.ValueMember = "Handle";
            cbProduto.SelectedIndex = -1;
        }

        private void CarregarDadosEdicao()
        {
            cbVendedor.SelectedItem = cbVendedor.Items.Cast<VendedorDto>().FirstOrDefault(v => v.NomeVendedor == MetaEditada.NomeVendedor);

            cbProduto.SelectedItem = cbProduto.Items.Cast<ProdutoDto>().FirstOrDefault(p => p.NomeProduto == MetaEditada.Produto);

            cbPeriodicidade.SelectedValue = MetaEditada.Periodicidade;

            tbValorMeta.Text = MetaEditada.ValorMeta.ToString();

            foreach (RadioButton rb in gpMeta.Controls.OfType<RadioButton>())
            {
                rb.Checked = rb.Text == MetaEditada.TipoMeta;
            }

            cbVendedor.Enabled = false;

            btnDuplicar.Visible = true;
        }

        private void SalvarEdicao()
        {
            ValidarCampos();

            var itemNaLista = ListaMetas.FirstOrDefault(m => m.NomeVendedor == MetaEditada.NomeVendedor);

            if (itemNaLista != null)
            {
                itemNaLista.Periodicidade = (Periodicidade)cbPeriodicidade.SelectedValue;

                var produtoSelecionado = (ProdutoDto)cbProduto.SelectedItem;
                itemNaLista.Produto = produtoSelecionado?.NomeProduto;

                itemNaLista.ValorMeta = decimal.TryParse(RemoverCifrao(tbValorMeta.Text.Trim()), out decimal valor) ? valor : 0;

                MessageBox.Show(Constantes.MsgMetaEditadaComSucesso, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var rbSelecionado = gpMeta.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked);
                itemNaLista.TipoMeta = rbSelecionado?.Text;

                this.Close();
            }
        }

        private void tbValorMeta_Leave(object sender, EventArgs e)
        {
            if (rbMonetario.Checked)
                AdicionarCifrao();
            else
                tbValorMeta.Text = RemoverCifrao(tbValorMeta.Text.Trim());
        }

        private void AdicionarCifrao()
        {
            var texto = tbValorMeta.Text.Trim();

            if (decimal.TryParse(texto,
                                 System.Globalization.NumberStyles.Any,
                                 new System.Globalization.CultureInfo("pt-BR"),
                                 out decimal valor))
            {
                tbValorMeta.Text = valor.ToString("C", new System.Globalization.CultureInfo("pt-BR"));
            }
            else
            {
                tbValorMeta.Text = "R$ 0,00";
            }
        }

        private string RemoverCifrao(string textoFormatado)
        {
            if (decimal.TryParse(textoFormatado, System.Globalization.NumberStyles.Currency,
                     new System.Globalization.CultureInfo("pt-BR"), out decimal valor))
            {
                return ((int)valor).ToString();
            }

            return "0";
        }

        private void tbValorMeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Editando)
                    SalvarEdicao();
                else
                    SalvarDados();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SalvarDados()
        {
            ValidarCampos();

            ValidarDados();

            SalvarMeta();

            MessageBox.Show(Constantes.MsgMetaCadastrada, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void SalvarMeta()
        {
            RadioButton rbSelecionado = gpMeta.Controls
                                        .OfType<RadioButton>()
                                        .FirstOrDefault(r => r.Checked);

            var novaMeta = new MetaVendedorDto
            {
                NomeVendedor = ((VendedorDto)cbVendedor.SelectedItem).NomeVendedor,
                Periodicidade = (Periodicidade)cbPeriodicidade.SelectedValue,
                Produto = ((ProdutoDto)cbProduto.SelectedItem).NomeProduto,
                ValorMeta = ExtensaoString.ConverterParaDecimal(tbValorMeta.Text),
                TipoMeta = rbSelecionado?.Text
            };

            ListaMetas.Add(novaMeta);
        }

        private void ValidarCampos()
        {
            var ocorrencias = new StringBuilder();

            ValidarVendedor(ocorrencias);
            ValidarPeriodicidade(ocorrencias);
            ValidarProduto(ocorrencias);
            ValidarValorMeta(ocorrencias);
            ValidarMeta(ocorrencias);

            if (ocorrencias.Length > 0)
                throw new ValidacaoDadosException(ocorrencias.ToString());
        }

        private void ValidarCampo(Control controle, string mensagemErro, StringBuilder ocorrencias)
        {
            string texto = string.Empty;

            if (controle is ComboBox cb)
                texto = cb.Text;
            else if (controle is TextBox tb)
                texto = tb.Text;

            if (string.IsNullOrWhiteSpace(texto))
            {
                controle.BackColor = Color.FromArgb(252, 199, 194);
                ocorrencias.AppendLine(mensagemErro);
            }
        }

        private void ValidarDados()
        {
            if (ListaMetas.Any(x => x.NomeVendedor.ToUpper() == cbVendedor.Text.ToUpper()))
                throw new ValidacaoDadosException(Constantes.MsgMetaVendedorCadastrada);
        }

        private void ValidarMeta()
        {
            try
            {
                var produtoSelecionado = (ProdutoDto)cbProduto.SelectedItem;

                string tipoMetaSelecionada = gpMeta.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked)?.Text;

                if (tipoMetaSelecionada == "Litros" && produtoSelecionado.Categoria != CategoriaProduto.Liquido)
                {
                    LimparRadioButton();

                    throw new ValidacaoDadosException(Constantes.MsgMetaLitrosParaProdutoLiquido);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void ValidarVendedor(StringBuilder ocorrencias)
        {
            ValidarCampo(cbVendedor, Constantes.MsgVendedorNaoPreenchido, ocorrencias);
        }

        private void ValidarPeriodicidade(StringBuilder ocorrencias)
        {
            ValidarCampo(cbPeriodicidade, Constantes.MsgPeriodicidadeNaoPreenchida, ocorrencias);
        }

        private void ValidarProduto(StringBuilder ocorrencias)
        {
            ValidarCampo(cbProduto, Constantes.MsgProdutoNaoPreenchido, ocorrencias);
        }

        private void ValidarValorMeta(StringBuilder ocorrencias)
        {
            ValidarCampo(tbValorMeta, Constantes.MsgValorMetaNaoPreenchida, ocorrencias);

            if (int.TryParse(RemoverCifrao(tbValorMeta.Text).Trim(), out int valor) && valor <= 0)
                ocorrencias.AppendLine(Constantes.MsgValorNaoPodeSerZero);
        }

        private void ValidarMeta(StringBuilder ocorrencias)
        {
            if (gpMeta.NenhumRadioSelecionado())
                ocorrencias.AppendLine(Constantes.MsgTipoMetaNaoPreenchida);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Constantes.MsgDesejaCancelar, "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                LimparDados();
        }

        private void LimparDados()
        {
            cbVendedor.SelectedIndex = -1;
            cbProduto.SelectedIndex = -1;
            cbPeriodicidade.SelectedIndex = -1;
            tbValorMeta.Clear();
            LimparRadioButton();
        }

        private void LimparRadioButton()
        {
            foreach (RadioButton rb in gpMeta.Controls.OfType<RadioButton>())
            {
                rb.Checked = false;
            }
        }

        private void FecharTela()
        {
            if (MessageBox.Show(Constantes.MsgVoltarTelaInicial, "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FecharTela();
        }

        private void FormCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                FecharTela();

            if (e.KeyCode == Keys.F2)
            {
                if (Editando)
                    SalvarEdicao();
                else
                    SalvarDados();
            }
        }

        private void ResetarCorDeFundo(Control controle)
        {
            controle.BackColor = Color.White;
        }

        private void cbVendedor_MouseClick(object sender, MouseEventArgs e)
        {
            ResetarCorDeFundo(cbVendedor);
        }

        private void cbPeriodicidade_MouseClick(object sender, MouseEventArgs e)
        {
            ResetarCorDeFundo(cbPeriodicidade);
        }

        private void cbProduto_MouseClick(object sender, MouseEventArgs e)
        {
            ResetarCorDeFundo(cbProduto);
        }

        private void tbValorMeta_MouseClick(object sender, MouseEventArgs e)
        {
            ResetarCorDeFundo(tbValorMeta);
        }

        private static void ResetarCorDropDown(object sender)
        {
            if (sender is ComboBox combo)
                combo.BackColor = Color.White;
        }

        private void cbVendedor_DropDown(object sender, EventArgs e)
        {
            ResetarCorDropDown(sender);
        }

        private void cbPeriodicidade_DropDown(object sender, EventArgs e)
        {
            ResetarCorDropDown(sender);
        }

        private void cbProduto_DropDown(object sender, EventArgs e)
        {
            ResetarCorDropDown(sender);
        }

        private void AjustarTipoInput()
        {
            if (rbMonetario.Checked)
            {
                tbValorMeta.KeyPress -= CampoInteiro;
                tbValorMeta.KeyPress += CampoDecimal;
                AdicionarCifrao();
            }
            else
            {
                tbValorMeta.KeyPress -= CampoDecimal;
                tbValorMeta.KeyPress += CampoInteiro;
                tbValorMeta.Text = RemoverCifrao(tbValorMeta.Text).Trim();
            }
        }

        private void rbMonetario_CheckedChanged(object sender, EventArgs e)
        {
            AjustarTipoInput();
            ValidarMeta();
        }

        private void rbLitro_CheckedChanged(object sender, EventArgs e)
        {
            AjustarTipoInput();
            ValidarMeta();
        }

        private void rbUnidade_CheckedChanged(object sender, EventArgs e)
        {
            AjustarTipoInput();
            ValidarMeta();
        }

        private void CampoInteiro(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void CampoDecimal(object sender, KeyPressEventArgs e)
        {
            var tb = sender as TextBox;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',' && e.KeyChar != '.'))
            {
                e.Handled = true;
                return;
            }

            if ((e.KeyChar == ',' || e.KeyChar == '.') && (tb.Text.Contains(",") || tb.Text.Contains(".")))
                e.Handled = true;
        }

        private void cbProduto_DropDownClosed(object sender, EventArgs e)
        {
            ValidarMeta();
        }

        private void btnDuplicar_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(RemoverCifrao(tbValorMeta.Text.Trim()), out decimal valor))
            {
                decimal duplicado = valor * 2;
                tbValorMeta.Text = duplicado.ToString();

                AjustarTipoInput();
            }
        }
    }
}
