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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.restoreButton = new System.Windows.Forms.Button();
            this.editarContaButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.exportarButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.editarButton = new System.Windows.Forms.Button();
            this.novoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView.Size = new System.Drawing.Size(539, 279);
            this.dataGridView.TabIndex = 0;
            // 
            // restoreButton
            // 
            this.restoreButton.BackColor = System.Drawing.Color.Transparent;
            this.restoreButton.FlatAppearance.BorderSize = 0;
            this.restoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restoreButton.ForeColor = System.Drawing.Color.Transparent;
            this.restoreButton.Image = global::Gerenciador_de_Senhas_2.Properties.Resources.outline_restore_black_36dp;
            this.restoreButton.Location = new System.Drawing.Point(258, 285);
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
            this.editarContaButton.Location = new System.Drawing.Point(436, 285);
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
            this.button1.Location = new System.Drawing.Point(478, 285);
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
            this.exportarButton.Location = new System.Drawing.Point(216, 285);
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
            this.excluirButton.Location = new System.Drawing.Point(84, 285);
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
            this.editarButton.Location = new System.Drawing.Point(42, 285);
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
            this.novoButton.Location = new System.Drawing.Point(0, 285);
            this.novoButton.Name = "novoButton";
            this.novoButton.Size = new System.Drawing.Size(36, 36);
            this.novoButton.TabIndex = 1;
            this.ToolTip.SetToolTip(this.novoButton, "Adiciona uma nova senha.");
            this.novoButton.UseVisualStyleBackColor = false;
            this.novoButton.Click += new System.EventHandler(this.novoButton_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(519, 325);
            this.Controls.Add(this.restoreButton);
            this.Controls.Add(this.editarContaButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exportarButton);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.editarButton);
            this.Controls.Add(this.novoButton);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Senhas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button novoButton;
        private System.Windows.Forms.Button editarButton;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button exportarButton;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button editarContaButton;
        private System.Windows.Forms.Button restoreButton;
    }
}