namespace Gerenciador_de_Senhas_2
{
    partial class SenhaCard
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelNome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelLink = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonCopiar = new System.Windows.Forms.Button();
            this.buttonSenha = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(93, 14);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(54, 19);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Nome";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(87, 83);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel2.Controls.Add(this.pictureBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(87, 83);
            this.panel2.TabIndex = 1;
            this.panel2.Click += new System.EventHandler(this.SenhaCard_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Gerenciador_de_Senhas_2.Properties.Resources.outline_password_black_48dp;
            this.pictureBox.Location = new System.Drawing.Point(21, 14);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(48, 48);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // labelLink
            // 
            this.labelLink.AutoSize = true;
            this.labelLink.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLink.Location = new System.Drawing.Point(94, 33);
            this.labelLink.Name = "labelLink";
            this.labelLink.Size = new System.Drawing.Size(30, 15);
            this.labelLink.TabIndex = 3;
            this.labelLink.Text = "Link";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenha.Location = new System.Drawing.Point(94, 48);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(43, 15);
            this.labelSenha.TabIndex = 4;
            this.labelSenha.Text = "Senha";
            // 
            // buttonCopiar
            // 
            this.buttonCopiar.BackColor = System.Drawing.Color.Transparent;
            this.buttonCopiar.FlatAppearance.BorderSize = 0;
            this.buttonCopiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCopiar.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonCopiar.Image = global::Gerenciador_de_Senhas_2.Properties.Resources.outline_content_copy_black_18dp;
            this.buttonCopiar.Location = new System.Drawing.Point(228, 3);
            this.buttonCopiar.Name = "buttonCopiar";
            this.buttonCopiar.Size = new System.Drawing.Size(18, 18);
            this.buttonCopiar.TabIndex = 6;
            this.toolTip1.SetToolTip(this.buttonCopiar, "Copiar senha para área de tranferência(CTRL-C)");
            this.buttonCopiar.UseVisualStyleBackColor = false;
            this.buttonCopiar.Click += new System.EventHandler(this.buttonCopiar_Click);
            // 
            // buttonSenha
            // 
            this.buttonSenha.BackColor = System.Drawing.Color.Transparent;
            this.buttonSenha.FlatAppearance.BorderSize = 0;
            this.buttonSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSenha.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonSenha.Image = global::Gerenciador_de_Senhas_2.Properties.Resources.outline_visibility_black_24dp;
            this.buttonSenha.Location = new System.Drawing.Point(222, 57);
            this.buttonSenha.Name = "buttonSenha";
            this.buttonSenha.Size = new System.Drawing.Size(24, 24);
            this.buttonSenha.TabIndex = 5;
            this.toolTip1.SetToolTip(this.buttonSenha, "Alternar visibilidade da senha.");
            this.buttonSenha.UseVisualStyleBackColor = false;
            this.buttonSenha.Click += new System.EventHandler(this.buttonSenha_Click);
            // 
            // SenhaCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.buttonCopiar);
            this.Controls.Add(this.buttonSenha);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelLink);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.panel1);
            this.Name = "SenhaCard";
            this.Size = new System.Drawing.Size(251, 83);
            this.Click += new System.EventHandler(this.SenhaCard_Click);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelLink;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Button buttonSenha;
        private System.Windows.Forms.Button buttonCopiar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panel2;
    }
}
