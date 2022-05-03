
namespace EasyRFI
{
    partial class EasyRFI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EasyRFI));
            this.imgPerg = new System.Windows.Forms.ImageList(this.components);
            this.btnAddPergunta = new System.Windows.Forms.Button();
            this.btnAltPergunta = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnImportarCSV = new System.Windows.Forms.Button();
            this.btnDelPergunta = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dtPerguntas = new System.Windows.Forms.DataGridView();
            this.colPergunta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAderencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJustificativa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPergunta = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.cmbAderencia = new System.Windows.Forms.ComboBox();
            this.txtJustificativa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtPerguntas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgPerg
            // 
            this.imgPerg.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgPerg.ImageStream")));
            this.imgPerg.TransparentColor = System.Drawing.Color.Transparent;
            this.imgPerg.Images.SetKeyName(0, "help2.png");
            // 
            // btnAddPergunta
            // 
            this.btnAddPergunta.Location = new System.Drawing.Point(8, 14);
            this.btnAddPergunta.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddPergunta.Name = "btnAddPergunta";
            this.btnAddPergunta.Size = new System.Drawing.Size(125, 37);
            this.btnAddPergunta.TabIndex = 5;
            this.btnAddPergunta.Text = "&Adicionar";
            this.btnAddPergunta.UseVisualStyleBackColor = true;
            this.btnAddPergunta.Click += new System.EventHandler(this.BtnAddPergunta_Click);
            // 
            // btnAltPergunta
            // 
            this.btnAltPergunta.Enabled = false;
            this.btnAltPergunta.Location = new System.Drawing.Point(143, 14);
            this.btnAltPergunta.Margin = new System.Windows.Forms.Padding(5);
            this.btnAltPergunta.Name = "btnAltPergunta";
            this.btnAltPergunta.Size = new System.Drawing.Size(125, 37);
            this.btnAltPergunta.TabIndex = 6;
            this.btnAltPergunta.Text = "&Alterar";
            this.btnAltPergunta.UseVisualStyleBackColor = true;
            this.btnAltPergunta.Click += new System.EventHandler(this.btnAltPergunta_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnImportarCSV);
            this.groupBox1.Controls.Add(this.btnDelPergunta);
            this.groupBox1.Controls.Add(this.btnAddPergunta);
            this.groupBox1.Controls.Add(this.btnAltPergunta);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1408, 129);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // btnImportarCSV
            // 
            this.btnImportarCSV.Location = new System.Drawing.Point(461, 14);
            this.btnImportarCSV.Margin = new System.Windows.Forms.Padding(5);
            this.btnImportarCSV.Name = "btnImportarCSV";
            this.btnImportarCSV.Size = new System.Drawing.Size(125, 37);
            this.btnImportarCSV.TabIndex = 8;
            this.btnImportarCSV.Text = "&Importar CSV";
            this.btnImportarCSV.UseVisualStyleBackColor = true;
            this.btnImportarCSV.Click += new System.EventHandler(this.btnImportarCSV_Click);
            // 
            // btnDelPergunta
            // 
            this.btnDelPergunta.Enabled = false;
            this.btnDelPergunta.Location = new System.Drawing.Point(278, 14);
            this.btnDelPergunta.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelPergunta.Name = "btnDelPergunta";
            this.btnDelPergunta.Size = new System.Drawing.Size(125, 37);
            this.btnDelPergunta.TabIndex = 7;
            this.btnDelPergunta.Text = "&Deletar";
            this.btnDelPergunta.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 711);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1408, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dtPerguntas
            // 
            this.dtPerguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPerguntas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPergunta,
            this.colProduto,
            this.colAderencia,
            this.colJustificativa});
            this.dtPerguntas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtPerguntas.Location = new System.Drawing.Point(0, 129);
            this.dtPerguntas.MultiSelect = false;
            this.dtPerguntas.Name = "dtPerguntas";
            this.dtPerguntas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtPerguntas.Size = new System.Drawing.Size(1408, 582);
            this.dtPerguntas.TabIndex = 10;
            this.dtPerguntas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtPerguntas_CellContentClick);
            this.dtPerguntas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtPerguntas_CellFormatting);
            this.dtPerguntas.DoubleClick += new System.EventHandler(this.btnAltPergunta_Click);
            // 
            // colPergunta
            // 
            this.colPergunta.FillWeight = 73.3595F;
            this.colPergunta.HeaderText = "Pergunta";
            this.colPergunta.Name = "colPergunta";
            this.colPergunta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPergunta.Width = 400;
            // 
            // colProduto
            // 
            this.colProduto.FillWeight = 119.6079F;
            this.colProduto.HeaderText = "Produto";
            this.colProduto.Name = "colProduto";
            this.colProduto.Width = 120;
            // 
            // colAderencia
            // 
            this.colAderencia.FillWeight = 203.0457F;
            this.colAderencia.HeaderText = "Aderência";
            this.colAderencia.Name = "colAderencia";
            this.colAderencia.Width = 120;
            // 
            // colJustificativa
            // 
            this.colJustificativa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colJustificativa.FillWeight = 3.986931F;
            this.colJustificativa.HeaderText = "Justificativa";
            this.colJustificativa.Name = "colJustificativa";
            // 
            // txtPergunta
            // 
            this.txtPergunta.Location = new System.Drawing.Point(113, 26);
            this.txtPergunta.Name = "txtPergunta";
            this.txtPergunta.Size = new System.Drawing.Size(133, 27);
            this.txtPergunta.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnFiltrar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtJustificativa);
            this.groupBox2.Controls.Add(this.cmbAderencia);
            this.groupBox2.Controls.Add(this.cmbProduto);
            this.groupBox2.Controls.Add(this.txtPergunta);
            this.groupBox2.Location = new System.Drawing.Point(12, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1384, 64);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrar Por:";
            // 
            // cmbProduto
            // 
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(350, 26);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(126, 29);
            this.cmbProduto.TabIndex = 14;
            // 
            // cmbAderencia
            // 
            this.cmbAderencia.FormattingEnabled = true;
            this.cmbAderencia.Location = new System.Drawing.Point(606, 26);
            this.cmbAderencia.Name = "cmbAderencia";
            this.cmbAderencia.Size = new System.Drawing.Size(123, 29);
            this.cmbAderencia.TabIndex = 15;
            // 
            // txtJustificativa
            // 
            this.txtJustificativa.Location = new System.Drawing.Point(874, 26);
            this.txtJustificativa.Name = "txtJustificativa";
            this.txtJustificativa.Size = new System.Drawing.Size(166, 27);
            this.txtJustificativa.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Pergunta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Produto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(503, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Aderência:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(760, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "Justificativa:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(1116, 19);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(5);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(125, 37);
            this.btnFiltrar.TabIndex = 12;
            this.btnFiltrar.Text = "&Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1251, 19);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 37);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "&Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // EasyRFI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 733);
            this.Controls.Add(this.dtPerguntas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "EasyRFI";
            this.Text = "EasyRFI";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtPerguntas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imgPerg;
        private System.Windows.Forms.Button btnAddPergunta;
        private System.Windows.Forms.Button btnAltPergunta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnDelPergunta;
        private System.Windows.Forms.Button btnImportarCSV;
        private System.Windows.Forms.DataGridView dtPerguntas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPergunta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAderencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJustificativa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJustificativa;
        private System.Windows.Forms.ComboBox cmbAderencia;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.TextBox txtPergunta;
        private System.Windows.Forms.Button btnClear;
    }
}

