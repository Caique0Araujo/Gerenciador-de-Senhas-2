using System.Windows.Forms;

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
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.criarContaBttn = new System.Windows.Forms.Button();
            this.loginBttn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usuarioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usuarioTextBox.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioTextBox.Location = new System.Drawing.Point(111, 155);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(138, 22);
            this.usuarioTextBox.TabIndex = 1;
            this.toolTip.SetToolTip(this.usuarioTextBox, "Campo para inserir usuário.");
// 
            // senhaTextBox
            // 
            this.senhaTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.senhaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.senhaTextBox.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaTextBox.Location = new System.Drawing.Point(111, 183);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(138, 22);
            this.senhaTextBox.TabIndex = 2;
            this.toolTip.SetToolTip(this.senhaTextBox, "Campo para inserir a senha.");
            this.senhaTextBox.UseSystemPasswordChar = true;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox.Location = new System.Drawing.Point(81, 213);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(116, 20);
            this.checkBox.TabIndex = 3;
            this.checkBox.Text = "Salvar credenciais";
            this.toolTip.SetToolTip(this.checkBox, "Opção para manter a conta salva para próximos logins.");
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // criarContaBttn
            // 
            this.criarContaBttn.BackColor = System.Drawing.Color.DarkGray;
            this.criarContaBttn.FlatAppearance.BorderSize = 0;
            this.criarContaBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.criarContaBttn.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criarContaBttn.ForeColor = System.Drawing.Color.Black;
            this.criarContaBttn.Location = new System.Drawing.Point(170, 263);
            this.criarContaBttn.Margin = new System.Windows.Forms.Padding(0);
            this.criarContaBttn.Name = "criarContaBttn";
            this.criarContaBttn.Size = new System.Drawing.Size(79, 24);
            this.criarContaBttn.TabIndex = 5;
            this.criarContaBttn.Text = "Criar conta";
            this.toolTip.SetToolTip(this.criarContaBttn, "Criar nova conta.");
            this.criarContaBttn.UseVisualStyleBackColor = false;
            this.criarContaBttn.Click += new System.EventHandler(this.CriarConta);
            // 
            // loginBttn
            // 
            this.loginBttn.BackColor = System.Drawing.Color.DimGray;
            this.loginBttn.FlatAppearance.BorderSize = 0;
            this.loginBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBttn.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBttn.ForeColor = System.Drawing.Color.Transparent;
            this.loginBttn.Location = new System.Drawing.Point(81, 262);
            this.loginBttn.Name = "loginBttn";
            this.loginBttn.Size = new System.Drawing.Size(73, 24);
            this.loginBttn.TabIndex = 4;
            this.loginBttn.Text = "Login";
            this.toolTip.SetToolTip(this.loginBttn, "Efetuar login.");
            this.loginBttn.UseVisualStyleBackColor = false;
            this.loginBttn.Click += new System.EventHandler(this.FazerLogin);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("DejaVu Sans Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(118, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Desenvolvido por \r\nCaique Araújo";
            this.toolTip.SetToolTip(this.label3, "Clique aqui para acessar o Linkedin");
            this.label3.Click += new System.EventHandler(this.AbrirLinkedin);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 371);
            this.panel1.TabIndex = 7;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ArrastarJanela);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("DejaVu Sans Condensed", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 187);
            this.label1.MinimumSize = new System.Drawing.Size(0, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 100);
            this.label1.TabIndex = 5;
            this.label1.Text = "       Bem vindo ao                                    \r\nGerenciador de Senhas !\r" +
    "\n     \r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("DejaVu Sans Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(33, 77);
            this.label2.MinimumSize = new System.Drawing.Size(0, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Faça login para continuar.";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.minimizeButton);
            this.panel2.Controls.Add(this.checkBox);
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Controls.Add(this.criarContaBttn);
            this.panel2.Controls.Add(this.loginBttn);
            this.panel2.Controls.Add(this.senhaTextBox);
            this.panel2.Controls.Add(this.usuarioTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(209, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 371);
            this.panel2.TabIndex = 10;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ArrastarJanela);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gerenciador_de_Senhas_2.Properties.Resources.baseline_lock_white_48dp;
            this.pictureBox1.Location = new System.Drawing.Point(55, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Gerenciador_de_Senhas_2.Properties.Resources.baseline_key_black_24dp1;
            this.pictureBox3.Location = new System.Drawing.Point(81, 181);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Gerenciador_de_Senhas_2.Properties.Resources.outline_account_box_black_24dp;
            this.pictureBox2.Location = new System.Drawing.Point(81, 153);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.ForeColor = System.Drawing.Color.Black;
            this.minimizeButton.Image = global::Gerenciador_de_Senhas_2.Properties.Resources.outline_minimize_black_24dp;
            this.minimizeButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.minimizeButton.Location = new System.Drawing.Point(245, 2);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(24, 24);
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.MinimizarJanela);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Image = global::Gerenciador_de_Senhas_2.Properties.Resources.outline_close_black_24dp;
            this.closeButton.Location = new System.Drawing.Point(275, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(24, 24);
            this.closeButton.TabIndex = 0;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.FecharJanela);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(512, 371);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FechandoJanela);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.Button loginBttn;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Button criarContaBttn;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
    }
}

