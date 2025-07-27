namespace CadastroVendedores
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            dataGridView1 = new DataGridView();
            btnBuscar = new Button();
            btnAdicionar = new Button();
            btnCancelar = new Button();
            tbBuscarMeta = new TextBox();
            lbQtdRegistros = new Label();
            btnLimpar = new Button();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnF2;
            dataGridView1.Location = new Point(54, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(684, 285);
            dataGridView1.TabIndex = 0;
            dataGridView1.ColumnHeaderMouseClick += dataGridView1_ColumnHeaderMouseClick;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.BackColor = Color.DarkCyan;
            btnBuscar.Font = new Font("Montserrat", 9F);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(634, 40);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(104, 26);
            btnBuscar.TabIndex = 18;
            btnBuscar.Text = "Buscar (F11)";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdicionar.BackColor = Color.Green;
            btnAdicionar.Font = new Font("Montserrat", 9F);
            btnAdicionar.ForeColor = Color.White;
            btnAdicionar.Location = new Point(634, 389);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(100, 26);
            btnAdicionar.TabIndex = 17;
            btnAdicionar.Text = "Adicionar [+]";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelar.BackColor = Color.Maroon;
            btnCancelar.Font = new Font("Montserrat", 9F);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(54, 389);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 26);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Excluir";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // tbBuscarMeta
            // 
            tbBuscarMeta.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbBuscarMeta.Font = new Font("Montserrat", 9F);
            tbBuscarMeta.Location = new Point(54, 41);
            tbBuscarMeta.Multiline = true;
            tbBuscarMeta.Name = "tbBuscarMeta";
            tbBuscarMeta.Size = new Size(541, 26);
            tbBuscarMeta.TabIndex = 19;
            // 
            // lbQtdRegistros
            // 
            lbQtdRegistros.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbQtdRegistros.AutoSize = true;
            lbQtdRegistros.ForeColor = Color.Gray;
            lbQtdRegistros.Location = new Point(54, 359);
            lbQtdRegistros.Name = "lbQtdRegistros";
            lbQtdRegistros.Size = new Size(38, 15);
            lbQtdRegistros.TabIndex = 20;
            lbQtdRegistros.Text = "label1";
            // 
            // btnLimpar
            // 
            btnLimpar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimpar.BackColor = Color.White;
            btnLimpar.Image = (Image)resources.GetObject("btnLimpar.Image");
            btnLimpar.Location = new Point(601, 40);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(26, 26);
            btnLimpar.TabIndex = 21;
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditar.BackColor = Color.SteelBlue;
            btnEditar.Font = new Font("Montserrat", 9F);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(552, 389);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 26);
            btnEditar.TabIndex = 22;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 67, 85);
            ClientSize = new Size(800, 450);
            Controls.Add(btnEditar);
            Controls.Add(btnLimpar);
            Controls.Add(lbQtdRegistros);
            Controls.Add(tbBuscarMeta);
            Controls.Add(btnBuscar);
            Controls.Add(btnAdicionar);
            Controls.Add(btnCancelar);
            Controls.Add(dataGridView1);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Metas";
            KeyDown += FormPrincipal_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnBuscar;
        private Button btnAdicionar;
        private Button btnCancelar;
        private DataGridViewTextBoxColumn nomeVendedorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn periodicidadeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn produtoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorMetaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoMetaDataGridViewTextBoxColumn;
        private TextBox tbBuscarMeta;
        private Label lbQtdRegistros;
        private Button btnLimpar;
        private Button btnEditar;
    }
}