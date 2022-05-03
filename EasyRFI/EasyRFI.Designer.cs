
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
            this.lstPerguntas = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnImportarCSV = new System.Windows.Forms.Button();
            this.btnDelPergunta = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dtPerguntas = new System.Windows.Forms.DataGridView();
            this.colPergunta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAderencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJustificativa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtPerguntas)).BeginInit();
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
            // lstPerguntas
            // 
            this.lstPerguntas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstPerguntas.FullRowSelect = true;
            this.lstPerguntas.GridLines = true;
            this.lstPerguntas.HideSelection = false;
            this.lstPerguntas.Location = new System.Drawing.Point(0, 355);
            this.lstPerguntas.Margin = new System.Windows.Forms.Padding(5);
            this.lstPerguntas.Name = "lstPerguntas";
            this.lstPerguntas.Size = new System.Drawing.Size(1372, 356);
            this.lstPerguntas.SmallImageList = this.imgPerg;
            this.lstPerguntas.TabIndex = 7;
            this.lstPerguntas.UseCompatibleStateImageBehavior = false;
            this.lstPerguntas.View = System.Windows.Forms.View.Details;
            this.lstPerguntas.SelectedIndexChanged += new System.EventHandler(this.lstPerguntas_SelectedIndexChanged);
            this.lstPerguntas.DoubleClick += new System.EventHandler(this.btnAltPergunta_Click);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Pergunta";
            this.columnHeader2.Width = 382;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Produto";
            this.columnHeader3.Width = 166;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Aderência";
            this.columnHeader4.Width = 192;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Justificativa";
            this.columnHeader5.Width = 526;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnImportarCSV);
            this.groupBox1.Controls.Add(this.btnDelPergunta);
            this.groupBox1.Controls.Add(this.btnAddPergunta);
            this.groupBox1.Controls.Add(this.btnAltPergunta);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1408, 59);
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
            this.dtPerguntas.Location = new System.Drawing.Point(21, 99);
            this.dtPerguntas.Name = "dtPerguntas";
            this.dtPerguntas.Size = new System.Drawing.Size(1161, 199);
            this.dtPerguntas.TabIndex = 10;
            // 
            // colPergunta
            // 
            this.colPergunta.HeaderText = "Pergunta";
            this.colPergunta.Name = "colPergunta";
            this.colPergunta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPergunta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colPergunta.Width = 300;
            // 
            // colProduto
            // 
            this.colProduto.HeaderText = "Produto";
            this.colProduto.Name = "colProduto";
            this.colProduto.Width = 150;
            // 
            // colAderencia
            // 
            this.colAderencia.HeaderText = "Aderência";
            this.colAderencia.Name = "colAderencia";
            this.colAderencia.Width = 200;
            // 
            // colJustificativa
            // 
            this.colJustificativa.HeaderText = "Justificativa";
            this.colJustificativa.Name = "colJustificativa";
            this.colJustificativa.Width = 300;
            // 
            // EasyRFI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 733);
            this.Controls.Add(this.dtPerguntas);
            this.Controls.Add(this.lstPerguntas);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "EasyRFI";
            this.Text = "EasyRFI";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtPerguntas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imgPerg;
        private System.Windows.Forms.Button btnAddPergunta;
        private System.Windows.Forms.Button btnAltPergunta;
        private System.Windows.Forms.ListView lstPerguntas;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnDelPergunta;
        private System.Windows.Forms.Button btnImportarCSV;
        private System.Windows.Forms.DataGridView dtPerguntas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPergunta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAderencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJustificativa;
    }
}

