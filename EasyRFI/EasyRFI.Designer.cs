
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
            this.lstProdutos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgProd = new System.Windows.Forms.ImageList(this.components);
            this.btnAddProduto = new System.Windows.Forms.Button();
            this.btnAltProduto = new System.Windows.Forms.Button();
            this.btnDelProduto = new System.Windows.Forms.Button();
            this.imgPerg = new System.Windows.Forms.ImageList(this.components);
            this.btnAddPergunta = new System.Windows.Forms.Button();
            this.btnAltPergunta = new System.Windows.Forms.Button();
            this.lstPerguntas = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstProdutos
            // 
            this.lstProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstProdutos.FullRowSelect = true;
            this.lstProdutos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstProdutos.HideSelection = false;
            this.lstProdutos.Location = new System.Drawing.Point(12, 12);
            this.lstProdutos.Name = "lstProdutos";
            this.lstProdutos.Size = new System.Drawing.Size(237, 81);
            this.lstProdutos.SmallImageList = this.imgProd;
            this.lstProdutos.TabIndex = 0;
            this.lstProdutos.UseCompatibleStateImageBehavior = false;
            this.lstProdutos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 195;
            // 
            // imgProd
            // 
            this.imgProd.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgProd.ImageStream")));
            this.imgProd.TransparentColor = System.Drawing.Color.Transparent;
            this.imgProd.Images.SetKeyName(0, "hammer2.png");
            // 
            // btnAddProduto
            // 
            this.btnAddProduto.Location = new System.Drawing.Point(255, 12);
            this.btnAddProduto.Name = "btnAddProduto";
            this.btnAddProduto.Size = new System.Drawing.Size(75, 23);
            this.btnAddProduto.TabIndex = 1;
            this.btnAddProduto.Text = "Adicionar";
            this.btnAddProduto.UseVisualStyleBackColor = true;
            this.btnAddProduto.Click += new System.EventHandler(this.btnAddProduto_Click);
            // 
            // btnAltProduto
            // 
            this.btnAltProduto.Enabled = false;
            this.btnAltProduto.Location = new System.Drawing.Point(255, 41);
            this.btnAltProduto.Name = "btnAltProduto";
            this.btnAltProduto.Size = new System.Drawing.Size(75, 23);
            this.btnAltProduto.TabIndex = 2;
            this.btnAltProduto.Text = "Alterar";
            this.btnAltProduto.UseVisualStyleBackColor = true;
            // 
            // btnDelProduto
            // 
            this.btnDelProduto.Enabled = false;
            this.btnDelProduto.Location = new System.Drawing.Point(255, 70);
            this.btnDelProduto.Name = "btnDelProduto";
            this.btnDelProduto.Size = new System.Drawing.Size(75, 23);
            this.btnDelProduto.TabIndex = 3;
            this.btnDelProduto.Text = "Deletar";
            this.btnDelProduto.UseVisualStyleBackColor = true;
            // 
            // imgPerg
            // 
            this.imgPerg.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgPerg.ImageStream")));
            this.imgPerg.TransparentColor = System.Drawing.Color.Transparent;
            this.imgPerg.Images.SetKeyName(0, "help2.png");
            // 
            // btnAddPergunta
            // 
            this.btnAddPergunta.Location = new System.Drawing.Point(601, 81);
            this.btnAddPergunta.Name = "btnAddPergunta";
            this.btnAddPergunta.Size = new System.Drawing.Size(75, 23);
            this.btnAddPergunta.TabIndex = 5;
            this.btnAddPergunta.Text = "Adicionar";
            this.btnAddPergunta.UseVisualStyleBackColor = true;
            this.btnAddPergunta.Click += new System.EventHandler(this.btnAddPergunta_Click);
            // 
            // btnAltPergunta
            // 
            this.btnAltPergunta.Enabled = false;
            this.btnAltPergunta.Location = new System.Drawing.Point(682, 81);
            this.btnAltPergunta.Name = "btnAltPergunta";
            this.btnAltPergunta.Size = new System.Drawing.Size(75, 23);
            this.btnAltPergunta.TabIndex = 6;
            this.btnAltPergunta.Text = "Alterar";
            this.btnAltPergunta.UseVisualStyleBackColor = true;
            this.btnAltPergunta.Click += new System.EventHandler(this.btnAltPergunta_Click);
            // 
            // lstPerguntas
            // 
            this.lstPerguntas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPerguntas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstPerguntas.FullRowSelect = true;
            this.lstPerguntas.HideSelection = false;
            this.lstPerguntas.Location = new System.Drawing.Point(12, 115);
            this.lstPerguntas.Name = "lstPerguntas";
            this.lstPerguntas.Size = new System.Drawing.Size(798, 432);
            this.lstPerguntas.SmallImageList = this.imgPerg;
            this.lstPerguntas.TabIndex = 7;
            this.lstPerguntas.UseCompatibleStateImageBehavior = false;
            this.lstPerguntas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Pergunta";
            this.columnHeader2.Width = 222;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Produto";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Aderência";
            this.columnHeader4.Width = 105;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Justificativa";
            this.columnHeader5.Width = 221;
            // 
            // EasyRFI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 559);
            this.Controls.Add(this.lstPerguntas);
            this.Controls.Add(this.btnAltPergunta);
            this.Controls.Add(this.btnAddPergunta);
            this.Controls.Add(this.btnDelProduto);
            this.Controls.Add(this.btnAltProduto);
            this.Controls.Add(this.btnAddProduto);
            this.Controls.Add(this.lstProdutos);
            this.Name = "EasyRFI";
            this.Text = "EasyRFI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstProdutos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnAddProduto;
        private System.Windows.Forms.Button btnAltProduto;
        private System.Windows.Forms.Button btnDelProduto;
        private System.Windows.Forms.ImageList imgProd;
        private System.Windows.Forms.ImageList imgPerg;
        private System.Windows.Forms.Button btnAddPergunta;
        private System.Windows.Forms.Button btnAltPergunta;
        private System.Windows.Forms.ListView lstPerguntas;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;

    }
}

