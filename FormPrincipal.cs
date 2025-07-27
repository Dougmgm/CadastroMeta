using CadastroVendedores.DadosTelaCadastro;
using CadastroVendedores.Extensoes;
using CadastroVendedores.Model;
using System.ComponentModel;

namespace CadastroVendedores
{
    public partial class FormPrincipal : Form
    {
        private BindingList<MetaVendedorDto> ListaMetas = [];

        private BindingList<MetaVendedorDto> ListaFiltro = [];

        private string colunaOrdenada = "";

        private bool ordemAscendente = true;

        public FormPrincipal()
        {
            InitializeComponent();

            ListaMetas = Metas.ObterMetasVendedores();

            ListaFiltro = new BindingList<MetaVendedorDto>(ListaMetas);

            this.KeyPreview = true;

            CarregarDadosDataGridMetas();

            QuantidadeRegistros();
        }

        private void CarregarDadosDataGridMetas()
        {
            dataGridView1.DataSource = ListaMetas;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.Columns["NomeVendedor"].HeaderText = "Vendedor";
            dataGridView1.Columns["Periodicidade"].HeaderText = "Periodicidade";
            dataGridView1.Columns["Produto"].HeaderText = "Produto";
            dataGridView1.Columns["TipoMeta"].HeaderText = "Tipo de Meta";
            dataGridView1.Columns["ValorMeta"].HeaderText = "Meta";
        }

        private void QuantidadeRegistros()
        {
            lbQtdRegistros.Text = string.Format("{0} Registro(s)", ListaFiltro.Count);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var formCadastro = new FormCadastro(ListaMetas, false);

            formCadastro.ShowDialog();

            QuantidadeRegistros();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show(Constantes.MsgSelecionarMeta);
                return;
            }

            if (MessageBox.Show(Constantes.MsgExcluirMeta, "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var metaSelecionada = dataGridView1.CurrentRow.DataBoundItem as MetaVendedorDto;

                if (metaSelecionada != null)
                {
                    ListaMetas.Remove(metaSelecionada);

                    QuantidadeRegistros();
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarFiltro();
        }

        private void BuscarFiltro()
        {
            string termo = tbBuscarMeta.Text.Trim().ToUpper();

            var filtrado = ListaMetas.Where(x => x.NomeVendedor.ToUpper().Contains(termo) ||
                            x.Produto.ToUpper().Contains(termo) ||
                            x.TipoMeta.ToUpper().Contains(termo)).ToList();

            ListaFiltro = new BindingList<MetaVendedorDto>(filtrado);

            dataGridView1.DataSource = ListaFiltro;

            QuantidadeRegistros();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tbBuscarMeta.Text = "";

            ListaFiltro = new BindingList<MetaVendedorDto>(ListaMetas);

            dataGridView1.DataSource = ListaFiltro;

            QuantidadeRegistros();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var metaSelecionada = dataGridView1.CurrentRow.DataBoundItem as MetaVendedorDto;

            var formCadastro = new FormCadastro(ListaMetas, true, metaSelecionada);

            formCadastro.ShowDialog();

            QuantidadeRegistros();

            dataGridView1.Refresh();
        }

        private void FormPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
                BuscarFiltro();
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string nomeColuna = dataGridView1.Columns[e.ColumnIndex].DataPropertyName;

            if (colunaOrdenada == nomeColuna)
                ordemAscendente = !ordemAscendente;            
            else
            {
                colunaOrdenada = nomeColuna;
                ordemAscendente = true;
            }

            OrdenarGrid(nomeColuna, ordemAscendente);
        }

        private void OrdenarGrid(string nomeColuna, bool ascendente)
        {
            IEnumerable<MetaVendedorDto> listaOrdenada;

            switch (nomeColuna)
            {
                case "NomeVendedor":
                    listaOrdenada = ascendente ? ListaMetas.OrderBy(x => x.NomeVendedor) : ListaMetas.OrderByDescending(x => x.NomeVendedor);
                    break;

                case "Periodicidade":
                    listaOrdenada = ascendente ? ListaMetas.OrderBy(x => x.Periodicidade) : ListaMetas.OrderByDescending(x => x.Periodicidade);
                    break;

                case "Produto":
                    listaOrdenada = ascendente ? ListaMetas.OrderBy(x => x.Produto) : ListaMetas.OrderByDescending(x => x.Produto);
                    break;

                case "ValorMeta":
                    listaOrdenada = ascendente ? ListaMetas.OrderBy(x => x.ValorMeta) :  ListaMetas.OrderByDescending(x => x.ValorMeta);
                    break;

                case "TipoMeta":
                    listaOrdenada = ascendente ? ListaMetas.OrderBy(x => x.TipoMeta) : ListaMetas.OrderByDescending(x => x.TipoMeta);
                    break;

                default:
                    listaOrdenada = ListaMetas;
                    break;
            }

            ListaMetas = new BindingList<MetaVendedorDto>(listaOrdenada.ToList());
            dataGridView1.DataSource = ListaMetas;
        }
    }
}
