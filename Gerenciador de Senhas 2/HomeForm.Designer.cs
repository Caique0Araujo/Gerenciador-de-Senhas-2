namespace Gerenciador_de_Senhas_2
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.editarContaButton = new System.Windows.Forms.Button();
            this.restoreButton = new System.Windows.Forms.Button();
            this.exportarButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.editarButton = new System.Windows.Forms.Button();
            this.novoButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.infoButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::Gerenciador_de_Senhas_2.Properties.Resources.outline_logout_black_24dp;
            this.button1.Location = new System.Drawing.Point(520, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 24);
            this.button1.TabIndex = 5;
            this.ToolTip.SetToolTip(this.button1, "Sair da conta");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.SairConta);
            // 
            // editarContaButton
            // 
            this.editarContaButton.BackColor = System.Drawing.Color.Transparent;
            this.editarContaButton.FlatAppearance.BorderSize = 0;
            this.editarContaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarContaButton.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarContaButton.ForeColor = System.Drawing.Color.Transparent;
            this.editarContaButton.Image = global::Gerenciador_de_Senhas_2.Properties.Resources.outline_manage_accounts_black_24dp;
            this.editarContaButton.Location = new System.Drawing.Point(493, 3);
            this.editarContaButton.Name = "editarContaButton";
            this.editarContaButton.Size = new System.Drawing.Size(24, 24);
            this.editarContaButton.TabIndex = 6;
            this.ToolTip.SetToolTip(this.editarContaButton, "Editar conta");
            this.editarContaButton.UseVisualStyleBackColor = false;
            this.editarContaButton.Click += new System.EventHandler(this.EditarConta);
            // 
            // restoreButton
            // 
            this.restoreButton.BackColor = System.Drawing.Color.Transparent;
            this.restoreButton.FlatAppearance.BorderSize = 0;
            this.restoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restoreButton.ForeColor = System.Drawing.Color.Transparent;
            this.restoreButton.Image = global::Gerenciador_de_Senhas_2.Properties.Resources.outline_restore_black_36dp;
            this.restoreButton.Location = new System.Drawing.Point(4, 349);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(36, 36);
            this.restoreButton.TabIndex = 7;
            this.ToolTip.SetToolTip(this.restoreButton, "Restaurar a partir do Backup");
            this.restoreButton.UseVisualStyleBackColor = false;
            this.restoreButton.Click += new System.EventHandler(this.RestaurarBackup);
            // 
            // exportarButton
            // 
            this.exportarButton.BackColor = System.Drawing.Color.Transparent;
            this.exportarButton.FlatAppearance.BorderSize = 0;
            this.exportarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportarButton.ForeColor = System.Drawing.Color.Transparent;
            this.exportarButton.Image = global::Gerenciador_de_Senhas_2.Properties.Resources.outline_backup_black_36dp;
            this.exportarButton.Location = new System.Drawing.Point(4, 307);
            this.exportarButton.Name = "exportarButton";
            this.exportarButton.Size = new System.Drawing.Size(36, 36);
            this.exportarButton.TabIndex = 4;
            this.ToolTip.SetToolTip(this.exportarButton, "Fazer backup");
            this.exportarButton.UseVisualStyleBackColor = false;
            this.exportarButton.Click += new System.EventHandler(this.FazerBackup);
            // 
            // excluirButton
            // 
            this.excluirButton.BackColor = System.Drawing.Color.Transparent;
            this.excluirButton.FlatAppearance.BorderSize = 0;
            this.excluirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluirButton.ForeColor = System.Drawing.Color.Transparent;
            this.excluirButton.Image = global::Gerenciador_de_Senhas_2.Properties.Resources.outline_close_black_36dp;
            this.excluirButton.Location = new System.Drawing.Point(4, 84);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(36, 36);
            this.excluirButton.TabIndex = 3;
            this.ToolTip.SetToolTip(this.excluirButton, "Excluí a senha selecionada");
            this.excluirButton.UseVisualStyleBackColor = false;
            this.excluirButton.Click += new System.EventHandler(this.ExcluirSenha);
            // 
            // editarButton
            // 
            this.editarButton.BackColor = System.Drawing.Color.Transparent;
            this.editarButton.FlatAppearance.BorderSize = 0;
            this.editarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarButton.ForeColor = System.Drawing.Color.Transparent;
            this.editarButton.Image = global::Gerenciador_de_Senhas_2.Properties.Resources.outline_edit_black_36dp;
            this.editarButton.Location = new System.Drawing.Point(4, 42);
            this.editarButton.Name = "editarButton";
            this.editarButton.Size = new System.Drawing.Size(36, 36);
            this.editarButton.TabIndex = 2;
            this.ToolTip.SetToolTip(this.editarButton, "Edita a senha selecionada");
            this.editarButton.UseVisualStyleBackColor = false;
            this.editarButton.Click += new System.EventHandler(this.EditarSenha);
            // 
            // novoButton
            // 
            this.novoButton.BackColor = System.Drawing.Color.Transparent;
            this.novoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.novoButton.FlatAppearance.BorderSize = 0;
            this.novoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.novoButton.ForeColor = System.Drawing.Color.Transparent;
            this.novoButton.Image = global::Gerenciador_de_Senhas_2.Properties.Resources.outline_add_circle_black_36dp1;
            this.novoButton.Location = new System.Drawing.Point(4, 3);
            this.novoButton.Name = "novoButton";
            this.novoButton.Size = new System.Drawing.Size(36, 36);
            this.novoButton.TabIndex = 1;
            this.ToolTip.SetToolTip(this.novoButton, "Adiciona uma nova senha");
            this.novoButton.UseVisualStyleBackColor = false;
            this.novoButton.Click += new System.EventHandler(this.NovaSenha);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.minimizeButton);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 24);
            this.panel1.TabIndex = 8;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ArrastarJanela);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gerenciador_de_Senhas_2.Properties.Resources.baseline_pin_black_18dp;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 18);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senhas";
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.ForeColor = System.Drawing.Color.Black;
            this.minimizeButton.Image = global::Gerenciador_de_Senhas_2.Properties.Resources.outline_minimize_black_24dp;
            this.minimizeButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.minimizeButton.Location = new System.Drawing.Point(539, -1);
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
            this.closeButton.Location = new System.Drawing.Point(569, -1);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(24, 24);
            this.closeButton.TabIndex = 0;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.FecharJanela);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.restoreButton);
            this.panel2.Controls.Add(this.exportarButton);
            this.panel2.Controls.Add(this.excluirButton);
            this.panel2.Controls.Add(this.editarButton);
            this.panel2.Controls.Add(this.novoButton);
            this.panel2.Location = new System.Drawing.Point(3, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(47, 391);
            this.panel2.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(57, 65);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(536, 390);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.infoButton);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(598, 459);
            this.panel3.TabIndex = 12;
            // 
            // infoButton
            // 
            this.infoButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.infoButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.infoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoButton.ForeColor = System.Drawing.Color.Black;
            this.infoButton.Image = global::Gerenciador_de_Senhas_2.Properties.Resources.outline_info_black_24dp;
            this.infoButton.Location = new System.Drawing.Point(560, 28);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(32, 32);
            this.infoButton.TabIndex = 4;
            this.infoButton.UseVisualStyleBackColor = false;
            this.infoButton.Click += new System.EventHandler(this.AbrirInfo);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.labelUsuario);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.editarContaButton);
            this.panel4.Location = new System.Drawing.Point(3, 28);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(553, 32);
            this.panel4.TabIndex = 10;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(33, 7);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(83, 16);
            this.labelUsuario.TabIndex = 8;
            this.labelUsuario.Text = "Bem vindo, ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Gerenciador_de_Senhas_2.Properties.Resources.outline_account_box_black_24dp;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(598, 459);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Senhas";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button novoButton;
        private System.Windows.Forms.Button editarButton;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button exportarButton;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button editarContaButton;
        private System.Windows.Forms.Button restoreButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Button infoButton;
    }
}