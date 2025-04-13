namespace CacaNiquel
{
    partial class frmCacaNiquel
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
            this.components = new System.ComponentModel.Container();
            this.btnGirar = new System.Windows.Forms.Button();
            this.btnJogar = new System.Windows.Forms.Button();
            this.lblNiquel1 = new System.Windows.Forms.Label();
            this.lblNiquel2 = new System.Windows.Forms.Label();
            this.lblNiquel3 = new System.Windows.Forms.Label();
            this.lstNiquel = new System.Windows.Forms.ListBox();
            this.tmrNiquel = new System.Windows.Forms.Timer(this.components);
            this.tmrSorteioGeral = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnGirar
            // 
            this.btnGirar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGirar.Location = new System.Drawing.Point(65, 188);
            this.btnGirar.Name = "btnGirar";
            this.btnGirar.Size = new System.Drawing.Size(87, 33);
            this.btnGirar.TabIndex = 0;
            this.btnGirar.Text = "&Girar";
            this.btnGirar.UseVisualStyleBackColor = true;
            this.btnGirar.Click += new System.EventHandler(this.btnGirar_Click);
            // 
            // btnJogar
            // 
            this.btnJogar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogar.Location = new System.Drawing.Point(180, 188);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(87, 33);
            this.btnJogar.TabIndex = 1;
            this.btnJogar.Text = "&Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // lblNiquel1
            // 
            this.lblNiquel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNiquel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNiquel1.Location = new System.Drawing.Point(47, 80);
            this.lblNiquel1.Name = "lblNiquel1";
            this.lblNiquel1.Size = new System.Drawing.Size(59, 58);
            this.lblNiquel1.TabIndex = 2;
            this.lblNiquel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNiquel2
            // 
            this.lblNiquel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNiquel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNiquel2.Location = new System.Drawing.Point(142, 80);
            this.lblNiquel2.Name = "lblNiquel2";
            this.lblNiquel2.Size = new System.Drawing.Size(59, 58);
            this.lblNiquel2.TabIndex = 3;
            this.lblNiquel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNiquel3
            // 
            this.lblNiquel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNiquel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNiquel3.Location = new System.Drawing.Point(236, 80);
            this.lblNiquel3.Name = "lblNiquel3";
            this.lblNiquel3.Size = new System.Drawing.Size(59, 58);
            this.lblNiquel3.TabIndex = 4;
            this.lblNiquel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstNiquel
            // 
            this.lstNiquel.FormattingEnabled = true;
            this.lstNiquel.Location = new System.Drawing.Point(99, 264);
            this.lstNiquel.Name = "lstNiquel";
            this.lstNiquel.Size = new System.Drawing.Size(120, 95);
            this.lstNiquel.TabIndex = 5;
            // 
            // tmrNiquel
            // 
            this.tmrNiquel.Tick += new System.EventHandler(this.tmrNiquel_Tick);
            // 
            // tmrSorteioGeral
            // 
            this.tmrSorteioGeral.Tick += new System.EventHandler(this.tmrSorteioGeral_Tick);
            // 
            // frmCacaNiquel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 403);
            this.Controls.Add(this.lstNiquel);
            this.Controls.Add(this.lblNiquel3);
            this.Controls.Add(this.lblNiquel2);
            this.Controls.Add(this.lblNiquel1);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.btnGirar);
            this.Name = "frmCacaNiquel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caça Níquel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGirar;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Label lblNiquel1;
        private System.Windows.Forms.Label lblNiquel2;
        private System.Windows.Forms.Label lblNiquel3;
        private System.Windows.Forms.ListBox lstNiquel;
        private System.Windows.Forms.Timer tmrNiquel;
        private System.Windows.Forms.Timer tmrSorteioGeral;
    }
}

