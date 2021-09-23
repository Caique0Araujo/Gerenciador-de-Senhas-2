namespace Gerenciador_de_Senhas_2
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.criarContaBttn = new System.Windows.Forms.Button();
            this.loginBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usuarioTextBox.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioTextBox.Location = new System.Drawing.Point(69, 27);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(144, 22);
            this.usuarioTextBox.TabIndex = 1;
            this.toolTip.SetToolTip(this.usuarioTextBox, "Campo para inserir usuário.");
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.senhaTextBox.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaTextBox.Location = new System.Drawing.Point(61, 66);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(152, 22);
            this.senhaTextBox.TabIndex = 2;
            this.toolTip.SetToolTip(this.senhaTextBox, "Campo para inserir a senha.");
            this.senhaTextBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Senha:";
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox.Location = new System.Drawing.Point(7, 112);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(125, 20);
            this.checkBox.TabIndex = 3;
            this.checkBox.Text = "Manter conectado";
            this.toolTip.SetToolTip(this.checkBox, "Opção para manter a conta salva para próximos logins.");
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // criarContaBttn
            // 
            this.criarContaBttn.BackColor = System.Drawing.Color.Transparent;
            this.criarContaBttn.FlatAppearance.BorderSize = 0;
            this.criarContaBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.criarContaBttn.ForeColor = System.Drawing.Color.Transparent;
            this.criarContaBttn.Image = global::Gerenciador_de_Senhas_2.Properties.Resources.round_assignment_ind_black_36dp;
            this.criarContaBttn.Location = new System.Drawing.Point(177, 103);
            this.criarContaBttn.Margin = new System.Windows.Forms.Padding(0);
            this.criarContaBttn.Name = "criarContaBttn";
            this.criarContaBttn.Size = new System.Drawing.Size(36, 38);
            this.criarContaBttn.TabIndex = 5;
            this.toolTip.SetToolTip(this.criarContaBttn, "Criar nova conta.");
            this.criarContaBttn.UseVisualStyleBackColor = false;
            this.criarContaBttn.Click += new System.EventHandler(this.criarContaBttn_Click);
            // 
            // loginBttn
            // 
            this.loginBttn.BackColor = System.Drawing.Color.Transparent;
            this.loginBttn.FlatAppearance.BorderSize = 0;
            this.loginBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBttn.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBttn.ForeColor = System.Drawing.Color.Transparent;
            this.loginBttn.Image = global::Gerenciador_de_Senhas_2.Properties.Resources.round_login_black_36dp;
            this.loginBttn.Location = new System.Drawing.Point(138, 103);
            this.loginBttn.Name = "loginBttn";
            this.loginBttn.Size = new System.Drawing.Size(36, 36);
            this.loginBttn.TabIndex = 4;
            this.toolTip.SetToolTip(this.loginBttn, "Efetuar login.");
            this.loginBttn.UseVisualStyleBackColor = false;
            this.loginBttn.Click += new System.EventHandler(this.loginBttn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(225, 146);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.criarContaBttn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginBttn);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(this.usuarioTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.Button loginBttn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Button criarContaBttn;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

