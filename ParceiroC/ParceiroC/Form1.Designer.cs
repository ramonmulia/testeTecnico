namespace ParceiroC
{
    partial class Form1
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
            this.dtGridView = new System.Windows.Forms.DataGridView();
            this.Cliente_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefoneResidencial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefoneCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTelCel = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblTelefoneResidencial = new System.Windows.Forms.Label();
            this.txtTelefoneResidencial = new System.Windows.Forms.TextBox();
            this.txtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefoneCelular = new System.Windows.Forms.MaskedTextBox();
            this.lblErros = new System.Windows.Forms.Label();
            this.lblErros2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGridView
            // 
            this.dtGridView.AllowUserToAddRows = false;
            this.dtGridView.AllowUserToDeleteRows = false;
            this.dtGridView.AllowUserToResizeColumns = false;
            this.dtGridView.ColumnHeadersHeight = 40;
            this.dtGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cliente_id,
            this.Nome,
            this.TelefoneResidencial,
            this.Endereco,
            this.DataNascimento,
            this.TelefoneCelular});
            this.dtGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtGridView.Location = new System.Drawing.Point(20, 12);
            this.dtGridView.MultiSelect = false;
            this.dtGridView.Name = "dtGridView";
            this.dtGridView.ReadOnly = true;
            this.dtGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridView.ShowCellErrors = false;
            this.dtGridView.ShowCellToolTips = false;
            this.dtGridView.ShowEditingIcon = false;
            this.dtGridView.ShowRowErrors = false;
            this.dtGridView.Size = new System.Drawing.Size(794, 150);
            this.dtGridView.TabIndex = 0;
            this.dtGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridView_CellClick);
            // 
            // Cliente_id
            // 
            this.Cliente_id.HeaderText = "Cliente_Id";
            this.Cliente_id.Name = "Cliente_id";
            this.Cliente_id.ReadOnly = true;
            this.Cliente_id.Visible = false;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 150;
            // 
            // TelefoneResidencial
            // 
            this.TelefoneResidencial.HeaderText = "Telefone Residencial";
            this.TelefoneResidencial.Name = "TelefoneResidencial";
            this.TelefoneResidencial.ReadOnly = true;
            this.TelefoneResidencial.Width = 150;
            // 
            // Endereco
            // 
            this.Endereco.HeaderText = "Endereço";
            this.Endereco.Name = "Endereco";
            this.Endereco.ReadOnly = true;
            this.Endereco.Width = 150;
            // 
            // DataNascimento
            // 
            this.DataNascimento.HeaderText = "Data de Nascimento";
            this.DataNascimento.Name = "DataNascimento";
            this.DataNascimento.ReadOnly = true;
            this.DataNascimento.Width = 150;
            // 
            // TelefoneCelular
            // 
            this.TelefoneCelular.HeaderText = "Telefone Celular";
            this.TelefoneCelular.Name = "TelefoneCelular";
            this.TelefoneCelular.ReadOnly = true;
            this.TelefoneCelular.Width = 150;
            // 
            // lblTelCel
            // 
            this.lblTelCel.AutoSize = true;
            this.lblTelCel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelCel.Location = new System.Drawing.Point(9, 123);
            this.lblTelCel.Name = "lblTelCel";
            this.lblTelCel.Size = new System.Drawing.Size(94, 21);
            this.lblTelCel.TabIndex = 3;
            this.lblTelCel.Text = "Tel Celular:";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimento.Location = new System.Drawing.Point(377, 123);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(164, 21);
            this.lblDataNascimento.TabIndex = 4;
            this.lblDataNascimento.Text = "Data de Nascimento:";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Enabled = false;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(632, 178);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(130, 37);
            this.btnAtualizar.TabIndex = 5;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(41, 37);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(59, 21);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(114, 34);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(228, 29);
            this.txtNome.TabIndex = 0;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(15, 83);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(85, 21);
            this.lblEndereco.TabIndex = 9;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(114, 75);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.ReadOnly = true;
            this.txtEndereco.Size = new System.Drawing.Size(648, 29);
            this.txtEndereco.TabIndex = 8;
            // 
            // lblTelefoneResidencial
            // 
            this.lblTelefoneResidencial.AutoSize = true;
            this.lblTelefoneResidencial.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneResidencial.Location = new System.Drawing.Point(410, 34);
            this.lblTelefoneResidencial.Name = "lblTelefoneResidencial";
            this.lblTelefoneResidencial.Size = new System.Drawing.Size(127, 21);
            this.lblTelefoneResidencial.TabIndex = 11;
            this.lblTelefoneResidencial.Text = "Tel Residencial:";
            // 
            // txtTelefoneResidencial
            // 
            this.txtTelefoneResidencial.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefoneResidencial.Location = new System.Drawing.Point(543, 32);
            this.txtTelefoneResidencial.Name = "txtTelefoneResidencial";
            this.txtTelefoneResidencial.ReadOnly = true;
            this.txtTelefoneResidencial.Size = new System.Drawing.Size(219, 29);
            this.txtTelefoneResidencial.TabIndex = 10;
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataNascimento.Location = new System.Drawing.Point(547, 118);
            this.txtDataNascimento.Mask = "00/00/0000";
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(215, 29);
            this.txtDataNascimento.TabIndex = 1;
            this.txtDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // txtTelefoneCelular
            // 
            this.txtTelefoneCelular.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefoneCelular.Location = new System.Drawing.Point(114, 118);
            this.txtTelefoneCelular.Mask = "(99) 9999-9999";
            this.txtTelefoneCelular.Name = "txtTelefoneCelular";
            this.txtTelefoneCelular.Size = new System.Drawing.Size(215, 29);
            this.txtTelefoneCelular.TabIndex = 0;
            // 
            // lblErros
            // 
            this.lblErros.AutoSize = true;
            this.lblErros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErros.ForeColor = System.Drawing.Color.Red;
            this.lblErros.Location = new System.Drawing.Point(110, 167);
            this.lblErros.Name = "lblErros";
            this.lblErros.Size = new System.Drawing.Size(51, 20);
            this.lblErros.TabIndex = 12;
            this.lblErros.Text = "label1";
            this.lblErros.Visible = false;
            // 
            // lblErros2
            // 
            this.lblErros2.AutoSize = true;
            this.lblErros2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErros2.ForeColor = System.Drawing.Color.Red;
            this.lblErros2.Location = new System.Drawing.Point(110, 192);
            this.lblErros2.Name = "lblErros2";
            this.lblErros2.Size = new System.Drawing.Size(51, 20);
            this.lblErros2.TabIndex = 13;
            this.lblErros2.Text = "label1";
            this.lblErros2.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDataNascimento);
            this.groupBox1.Controls.Add(this.lblErros2);
            this.groupBox1.Controls.Add(this.lblTelCel);
            this.groupBox1.Controls.Add(this.lblErros);
            this.groupBox1.Controls.Add(this.lblDataNascimento);
            this.groupBox1.Controls.Add(this.txtTelefoneCelular);
            this.groupBox1.Controls.Add(this.btnAtualizar);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.lblTelefoneResidencial);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.txtTelefoneResidencial);
            this.groupBox1.Controls.Add(this.txtEndereco);
            this.groupBox1.Controls.Add(this.lblEndereco);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 249);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Atualize os dados do cliente";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 455);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefoneResidencial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefoneCelular;
        private System.Windows.Forms.Label lblTelCel;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblTelefoneResidencial;
        private System.Windows.Forms.TextBox txtTelefoneResidencial;
        private System.Windows.Forms.MaskedTextBox txtDataNascimento;
        private System.Windows.Forms.MaskedTextBox txtTelefoneCelular;
        private System.Windows.Forms.Label lblErros;
        private System.Windows.Forms.Label lblErros2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

