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
            this.restoreButton = new System.Windows.Forms.Button();
            this.editarContaButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.exportarButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.editarButton = new System.Windows.Forms.Button();
            this.novoButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // restoreButton
            // 
            this.restoreButton.BackColor = System.Drawing.Color.Transparent;
            this.restoreButton.FlatAppearance.BorderSize = 0;
            this.restoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restoreButton.ForeColor = System.Drawing.Color.Transparent;
            this.restoreButton.Image = global::Gerenciador_de_Senhas_2.Properties.Resources.outline_restore_black_36dp;
            this.restoreButton.Location = new System.Drawing.Point(360, -1);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(36, 36);
            this.restoreButton.TabIndex = 7;
            this.ToolTip.SetToolTip(this.restoreButton, "Restaurar a partir do Backup");
            this.restoreButton.UseVisualStyleBackColor = false;
            this.restoreButton.Click += new System.EventHandler(this.restoreButton_Click);
            // 
            // editarContaButton
            // 
            this.editarContaButton.BackColor = System.Drawing.Color.Transparent;
            this.editarContaButton.FlatAppearance.BorderSize = 0;
            this.editarContaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarContaButton.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarContaButton.ForeColor = System.Drawing.Color.Transparent;
            this.editarContaButton.Image = global::Gerenciador_de_Senhas_2.Properties.Resources.outline_border_color_black_36dp;
            this.editarContaButton.Location = new System.Drawing.Point(617, -1);
            this.editarContaButton.Name = "editarContaButton";
            this.editarContaButton.Size = new System.Drawing.Size(36, 36);
            this.editarContaButton.TabIndex = 6;
            this.ToolTip.SetToolTip(this.editarContaButton, "Editar conta");
            this.editarContaButton.UseVisualStyleBackColor = false;
            this.editarContaButton.Click += new System.EventHandler(this.editarContaButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::Gerenciador_de_Senhas_2.Properties.Resources.outline_logout_black_36dp;
            this.button1.Location = new System.Drawing.Point(659, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 36);
            this.button1.TabIndex = 5;
            this.ToolTip.SetToolTip(this.button1, "Sair da conta");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exportarButton
            // 
            this.exportarButton.BackColor = System.Drawing.Color.Transparent;
            this.exportarButton.FlatAppearance.BorderSize = 0;
            this.exportarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportarButton.ForeColor = System.Drawing.Color.Transparent;
            this.exportarButton.Image = global::Gerenciador_de_Senhas_2.Properties.Resources.outline_backup_black_36dp;
            this.exportarButton.Location = new System.Drawing.Point(318, -1);
            this.exportarButton.Name = "exportarButton";
            this.exportarButton.Size = new System.Drawing.Size(36, 36);
            this.exportarButton.TabIndex = 4;
            this.ToolTip.SetToolTip(this.exportarButton, "Fazer backup");
            this.exportarButton.UseVisualStyleBackColor = false;
            this.exportarButton.Click += new System.EventHandler(this.exportarButton_Click);
            // 
            // excluirButton
            // 
            this.excluirButton.BackColor = System.Drawing.Color.Transparent;
            this.excluirButton.FlatAppearance.BorderSize = 0;
            this.excluirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluirButton.ForeColor = System.Drawing.Color.Transparent;
            this.excluirButton.Image = global::Gerenciador_de_Senhas_2.Properties.Resources.outline_close_black_36dp;
            this.excluirButton.Location = new System.Drawing.Point(84, -1);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(36, 36);
            this.excluirButton.TabIndex = 3;
            this.ToolTip.SetToolTip(this.excluirButton, "Excluí a senha selecionada.");
            this.excluirButton.UseVisualStyleBackColor = false;
            this.excluirButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // editarButton
            // 
            this.editarButton.BackColor = System.Drawing.Color.Transparent;
            this.editarButton.FlatAppearance.BorderSize = 0;
            this.editarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarButton.ForeColor = System.Drawing.Color.Transparent;
            this.editarButton.Image = global::Gerenciador_de_Senhas_2.Properties.Resources.outline_edit_black_36dp;
            this.editarButton.Location = new System.Drawing.Point(42, -1);
            this.editarButton.Name = "editarButton";
            this.editarButton.Size = new System.Drawing.Size(36, 36);
            this.editarButton.TabIndex = 2;
            this.ToolTip.SetToolTip(this.editarButton, "Edita a senha selecionada.");
            this.editarButton.UseVisualStyleBackColor = false;
            this.editarButton.Click += new System.EventHandler(this.editarButton_Click);
            // 
            // novoButton
            // 
            this.novoButton.BackColor = System.Drawing.Color.Transparent;
            this.novoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.novoButton.FlatAppearance.BorderSize = 0;
            this.novoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.novoButton.ForeColor = System.Drawing.Color.Transparent;
            this.novoButton.Image = global::Gerenciador_de_Senhas_2.Properties.Resources.outline_add_circle_black_36dp1;
            this.novoButton.Location = new System.Drawing.Point(0, -1);
            this.novoButton.Name = "novoButton";
            this.novoButton.Size = new System.Drawing.Size(36, 36);
            this.novoButton.TabIndex = 1;
            this.ToolTip.SetToolTip(this.novoButton, "Adiciona uma nova senha.");
            this.novoButton.UseVisualStyleBackColor = false;
            this.novoButton.Click += new System.EventHandler(this.novoButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.minimizeButton);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 24);
            this.panel1.TabIndex = 8;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 3);
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
            this.minimizeButton.Location = new System.Drawing.Point(641, -1);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(24, 24);
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Image = global::Gerenciador_de_Senhas_2.Properties.Resources.outline_close_black_24dp;
            this.closeButton.Location = new System.Drawing.Point(671, -1);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(24, 24);
            this.closeButton.TabIndex = 0;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.restoreButton);
            this.panel2.Controls.Add(this.editarContaButton);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.exportarButton);
            this.panel2.Controls.Add(this.excluirButton);
            this.panel2.Controls.Add(this.editarButton);
            this.panel2.Controls.Add(this.novoButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 364);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 36);
            this.panel2.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 23);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(700, 339);
            this.flowLayoutPanel1.TabIndex = 11;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Senhas";
            this.Load += new System.EventHandler(this.HomeForm_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
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
    }
}