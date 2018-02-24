namespace SqLiteTesteDefi1 {
     public partial class TelaInicial {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.butCadastrar = new System.Windows.Forms.Button();
            this.butSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textInputNome = new System.Windows.Forms.TextBox();
            this.textInputEndereco = new System.Windows.Forms.TextBox();
            this.textInputTelefone = new System.Windows.Forms.TextBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.butExibirDados = new System.Windows.Forms.Button();
            this.TextInputEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.butAtualizarDados = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textInputID = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.butExcluir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butCadastrar
            // 
            this.butCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.butCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.butCadastrar.FlatAppearance.BorderSize = 10;
            this.butCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCadastrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.butCadastrar.Location = new System.Drawing.Point(12, 286);
            this.butCadastrar.Name = "butCadastrar";
            this.butCadastrar.Size = new System.Drawing.Size(118, 38);
            this.butCadastrar.TabIndex = 0;
            this.butCadastrar.Text = "Cadastrar";
            this.butCadastrar.UseVisualStyleBackColor = false;
            this.butCadastrar.Click += new System.EventHandler(this.butCadastrar_Click);
            // 
            // butSair
            // 
            this.butSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butSair.BackColor = System.Drawing.Color.IndianRed;
            this.butSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSair.ForeColor = System.Drawing.SystemColors.ControlText;
            this.butSair.Location = new System.Drawing.Point(12, 631);
            this.butSair.Name = "butSair";
            this.butSair.Size = new System.Drawing.Size(67, 38);
            this.butSair.TabIndex = 1;
            this.butSair.Text = "Sair";
            this.butSair.UseVisualStyleBackColor = false;
            this.butSair.Click += new System.EventHandler(this.butSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(7, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(7, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Endereço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(3, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefone:";
            // 
            // textInputNome
            // 
            this.textInputNome.Location = new System.Drawing.Point(151, 93);
            this.textInputNome.Name = "textInputNome";
            this.textInputNome.Size = new System.Drawing.Size(423, 20);
            this.textInputNome.TabIndex = 5;
            this.textInputNome.TextChanged += new System.EventHandler(this.textInputNome_TextChanged);
            // 
            // textInputEndereco
            // 
            this.textInputEndereco.Location = new System.Drawing.Point(151, 143);
            this.textInputEndereco.Name = "textInputEndereco";
            this.textInputEndereco.Size = new System.Drawing.Size(423, 20);
            this.textInputEndereco.TabIndex = 6;
            this.textInputEndereco.TextChanged += new System.EventHandler(this.textInputEndereco_TextChanged);
            // 
            // textInputTelefone
            // 
            this.textInputTelefone.Location = new System.Drawing.Point(151, 188);
            this.textInputTelefone.Name = "textInputTelefone";
            this.textInputTelefone.Size = new System.Drawing.Size(423, 20);
            this.textInputTelefone.TabIndex = 7;
            this.textInputTelefone.TextChanged += new System.EventHandler(this.textInputTelefone_TextChanged);
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(644, 96);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.Size = new System.Drawing.Size(608, 573);
            this.dgvDados.TabIndex = 10;
            this.dgvDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // butExibirDados
            // 
            this.butExibirDados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butExibirDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butExibirDados.Location = new System.Drawing.Point(644, 46);
            this.butExibirDados.Name = "butExibirDados";
            this.butExibirDados.Size = new System.Drawing.Size(147, 34);
            this.butExibirDados.TabIndex = 9;
            this.butExibirDados.Text = "Exibir Dados";
            this.butExibirDados.UseVisualStyleBackColor = true;
            this.butExibirDados.Click += new System.EventHandler(this.butExibirDados_Click);
            // 
            // TextInputEmail
            // 
            this.TextInputEmail.Location = new System.Drawing.Point(151, 237);
            this.TextInputEmail.Name = "TextInputEmail";
            this.TextInputEmail.Size = new System.Drawing.Size(423, 20);
            this.TextInputEmail.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Email:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // butAtualizarDados
            // 
            this.butAtualizarDados.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.butAtualizarDados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butAtualizarDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAtualizarDados.Location = new System.Drawing.Point(151, 286);
            this.butAtualizarDados.Name = "butAtualizarDados";
            this.butAtualizarDados.Size = new System.Drawing.Size(148, 38);
            this.butAtualizarDados.TabIndex = 12;
            this.butAtualizarDados.Text = "Atualizar Dados";
            this.butAtualizarDados.UseVisualStyleBackColor = false;
            this.butAtualizarDados.Click += new System.EventHandler(this.butAtualizarDados_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "ID:";
            // 
            // textInputID
            // 
            this.textInputID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textInputID.Location = new System.Drawing.Point(49, 46);
            this.textInputID.Name = "textInputID";
            this.textInputID.ReadOnly = true;
            this.textInputID.Size = new System.Drawing.Size(49, 20);
            this.textInputID.TabIndex = 14;
            this.textInputID.TextChanged += new System.EventHandler(this.textInputID_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(964, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(871, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Procurar:";
            // 
            // butExcluir
            // 
            this.butExcluir.BackColor = System.Drawing.Color.Red;
            this.butExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butExcluir.ForeColor = System.Drawing.SystemColors.Info;
            this.butExcluir.Location = new System.Drawing.Point(493, 286);
            this.butExcluir.Name = "butExcluir";
            this.butExcluir.Size = new System.Drawing.Size(81, 38);
            this.butExcluir.TabIndex = 17;
            this.butExcluir.Text = "Excluir";
            this.butExcluir.UseVisualStyleBackColor = false;
            this.butExcluir.Click += new System.EventHandler(this.butExcluir_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(118, 180);
            this.panel1.TabIndex = 18;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.butExcluir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textInputID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.butAtualizarDados);
            this.Controls.Add(this.TextInputEmail);
            this.Controls.Add(this.butExibirDados);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.textInputTelefone);
            this.Controls.Add(this.textInputEndereco);
            this.Controls.Add(this.textInputNome);
            this.Controls.Add(this.butSair);
            this.Controls.Add(this.butCadastrar);
            this.Name = "TelaInicial";
            this.Text = "Registro v.0.2.1";
            this.Load += new System.EventHandler(this.TelaInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butCadastrar;
        private System.Windows.Forms.Button butSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textInputNome;
        private System.Windows.Forms.TextBox textInputEndereco;
        private System.Windows.Forms.TextBox textInputTelefone;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button butExibirDados;
        private System.Windows.Forms.TextBox TextInputEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butAtualizarDados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textInputID;
        public  System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button butExcluir;
        private System.Windows.Forms.Panel panel1;
    }
}