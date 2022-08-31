
namespace ControleGastos
{
    partial class CadastroGastos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroGastos));
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.nmrValor = new System.Windows.Forms.NumericUpDown();
            this.lblNecessaria = new System.Windows.Forms.Label();
            this.checkNecessaria = new System.Windows.Forms.CheckBox();
            this.dateCompra = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.controle_gastoDataSet = new ControleGastos.controle_gastoDataSet();
            this.gastoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gastoTableAdapter = new ControleGastos.controle_gastoDataSetTableAdapters.gastoTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datacompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foinecessariaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nmrValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controle_gastoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(141, 46);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(100, 20);
            this.txtDescricao.TabIndex = 0;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(141, 89);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(100, 20);
            this.txtCategoria.TabIndex = 1;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(67, 48);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(68, 16);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(67, 91);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(68, 16);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(291, 48);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(42, 16);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "Valor:";
            // 
            // nmrValor
            // 
            this.nmrValor.Location = new System.Drawing.Point(339, 46);
            this.nmrValor.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nmrValor.Name = "nmrValor";
            this.nmrValor.Size = new System.Drawing.Size(120, 20);
            this.nmrValor.TabIndex = 5;
            // 
            // lblNecessaria
            // 
            this.lblNecessaria.AutoSize = true;
            this.lblNecessaria.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNecessaria.Location = new System.Drawing.Point(291, 89);
            this.lblNecessaria.Name = "lblNecessaria";
            this.lblNecessaria.Size = new System.Drawing.Size(93, 16);
            this.lblNecessaria.TabIndex = 6;
            this.lblNecessaria.Text = "Foi necessaria:";
            this.lblNecessaria.Click += new System.EventHandler(this.Label1_Click);
            // 
            // checkNecessaria
            // 
            this.checkNecessaria.AutoSize = true;
            this.checkNecessaria.Location = new System.Drawing.Point(405, 90);
            this.checkNecessaria.Name = "checkNecessaria";
            this.checkNecessaria.Size = new System.Drawing.Size(15, 14);
            this.checkNecessaria.TabIndex = 7;
            this.checkNecessaria.UseVisualStyleBackColor = true;
            this.checkNecessaria.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // dateCompra
            // 
            this.dateCompra.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCompra.Location = new System.Drawing.Point(513, 81);
            this.dateCompra.Name = "dateCompra";
            this.dateCompra.Size = new System.Drawing.Size(236, 23);
            this.dateCompra.TabIndex = 8;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(591, 47);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(87, 16);
            this.lblData.TabIndex = 9;
            this.lblData.Text = "Data compra:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrar.Location = new System.Drawing.Point(339, 142);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(81, 26);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.datacompraDataGridViewTextBoxColumn,
            this.foinecessariaDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.gastoBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(70, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(641, 246);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick_1);
            // 
            // controle_gastoDataSet
            // 
            this.controle_gastoDataSet.DataSetName = "controle_gastoDataSet";
            this.controle_gastoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gastoBindingSource
            // 
            this.gastoBindingSource.DataMember = "gasto";
            this.gastoBindingSource.DataSource = this.controle_gastoDataSet;
            // 
            // gastoTableAdapter
            // 
            this.gastoTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            // 
            // datacompraDataGridViewTextBoxColumn
            // 
            this.datacompraDataGridViewTextBoxColumn.DataPropertyName = "data_compra";
            this.datacompraDataGridViewTextBoxColumn.HeaderText = "data_compra";
            this.datacompraDataGridViewTextBoxColumn.Name = "datacompraDataGridViewTextBoxColumn";
            // 
            // foinecessariaDataGridViewCheckBoxColumn
            // 
            this.foinecessariaDataGridViewCheckBoxColumn.DataPropertyName = "foi_necessaria";
            this.foinecessariaDataGridViewCheckBoxColumn.HeaderText = "foi_necessaria";
            this.foinecessariaDataGridViewCheckBoxColumn.Name = "foinecessariaDataGridViewCheckBoxColumn";
            // 
            // CadastroGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.dateCompra);
            this.Controls.Add(this.checkNecessaria);
            this.Controls.Add(this.lblNecessaria);
            this.Controls.Add(this.nmrValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtDescricao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroGastos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de gastos";
            this.Load += new System.EventHandler(this.CadastroGastos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controle_gastoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.NumericUpDown nmrValor;
        private System.Windows.Forms.Label lblNecessaria;
        private System.Windows.Forms.CheckBox checkNecessaria;
        private System.Windows.Forms.DateTimePicker dateCompra;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private controle_gastoDataSet controle_gastoDataSet;
        private System.Windows.Forms.BindingSource gastoBindingSource;
        private controle_gastoDataSetTableAdapters.gastoTableAdapter gastoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datacompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn foinecessariaDataGridViewCheckBoxColumn;
    }
}