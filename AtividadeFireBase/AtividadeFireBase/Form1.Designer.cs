namespace AtividadeFireBase
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNomeCadastro = new System.Windows.Forms.TextBox();
            this.groupBoxCadastrar = new System.Windows.Forms.GroupBox();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.textBoxTelefoneCadastro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEmailCadastro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxUpdate = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxIDAtualizar = new System.Windows.Forms.TextBox();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.textBoxTelefoneAtualizar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxEmailAtualizar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxNomeAtualizar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBoxVisualizar = new System.Windows.Forms.GroupBox();
            this.buttonVisualizar = new System.Windows.Forms.Button();
            this.dataGridViewVisualizar = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDeletar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxTabelaDeletar = new System.Windows.Forms.TextBox();
            this.comboBoxTabelaSelecionar = new System.Windows.Forms.ComboBox();
            this.groupBoxCadastrar.SuspendLayout();
            this.groupBoxUpdate.SuspendLayout();
            this.groupBoxVisualizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisualizar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(539, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "C# CRUD FIREBASE";
            // 
            // textBoxNomeCadastro
            // 
            this.textBoxNomeCadastro.Location = new System.Drawing.Point(101, 94);
            this.textBoxNomeCadastro.Name = "textBoxNomeCadastro";
            this.textBoxNomeCadastro.Size = new System.Drawing.Size(286, 27);
            this.textBoxNomeCadastro.TabIndex = 1;
            // 
            // groupBoxCadastrar
            // 
            this.groupBoxCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCadastrar.BackColor = System.Drawing.Color.White;
            this.groupBoxCadastrar.Controls.Add(this.buttonCadastrar);
            this.groupBoxCadastrar.Controls.Add(this.textBoxTelefoneCadastro);
            this.groupBoxCadastrar.Controls.Add(this.label5);
            this.groupBoxCadastrar.Controls.Add(this.textBoxEmailCadastro);
            this.groupBoxCadastrar.Controls.Add(this.label4);
            this.groupBoxCadastrar.Controls.Add(this.label3);
            this.groupBoxCadastrar.Controls.Add(this.label2);
            this.groupBoxCadastrar.Controls.Add(this.textBoxNomeCadastro);
            this.groupBoxCadastrar.Location = new System.Drawing.Point(65, 179);
            this.groupBoxCadastrar.Name = "groupBoxCadastrar";
            this.groupBoxCadastrar.Size = new System.Drawing.Size(428, 297);
            this.groupBoxCadastrar.TabIndex = 2;
            this.groupBoxCadastrar.TabStop = false;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCadastrar.Location = new System.Drawing.Point(293, 247);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(94, 29);
            this.buttonCadastrar.TabIndex = 8;
            this.buttonCadastrar.Text = "Enviar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // textBoxTelefoneCadastro
            // 
            this.textBoxTelefoneCadastro.Location = new System.Drawing.Point(101, 179);
            this.textBoxTelefoneCadastro.Name = "textBoxTelefoneCadastro";
            this.textBoxTelefoneCadastro.Size = new System.Drawing.Size(286, 27);
            this.textBoxTelefoneCadastro.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telefone:";
            // 
            // textBoxEmailCadastro
            // 
            this.textBoxEmailCadastro.Location = new System.Drawing.Point(101, 135);
            this.textBoxEmailCadastro.Name = "textBoxEmailCadastro";
            this.textBoxEmailCadastro.Size = new System.Drawing.Size(286, 27);
            this.textBoxEmailCadastro.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(33, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(42, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(165, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cadastro";
            // 
            // groupBoxUpdate
            // 
            this.groupBoxUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxUpdate.Controls.Add(this.label12);
            this.groupBoxUpdate.Controls.Add(this.textBoxIDAtualizar);
            this.groupBoxUpdate.Controls.Add(this.buttonAtualizar);
            this.groupBoxUpdate.Controls.Add(this.textBoxTelefoneAtualizar);
            this.groupBoxUpdate.Controls.Add(this.label6);
            this.groupBoxUpdate.Controls.Add(this.textBoxEmailAtualizar);
            this.groupBoxUpdate.Controls.Add(this.label7);
            this.groupBoxUpdate.Controls.Add(this.label8);
            this.groupBoxUpdate.Controls.Add(this.label9);
            this.groupBoxUpdate.Controls.Add(this.textBoxNomeAtualizar);
            this.groupBoxUpdate.Location = new System.Drawing.Point(566, 482);
            this.groupBoxUpdate.Name = "groupBoxUpdate";
            this.groupBoxUpdate.Size = new System.Drawing.Size(756, 282);
            this.groupBoxUpdate.TabIndex = 3;
            this.groupBoxUpdate.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(62, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "ID:";
            // 
            // textBoxIDAtualizar
            // 
            this.textBoxIDAtualizar.Enabled = false;
            this.textBoxIDAtualizar.Location = new System.Drawing.Point(103, 60);
            this.textBoxIDAtualizar.Name = "textBoxIDAtualizar";
            this.textBoxIDAtualizar.Size = new System.Drawing.Size(636, 27);
            this.textBoxIDAtualizar.TabIndex = 17;
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAtualizar.Location = new System.Drawing.Point(287, 238);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(94, 29);
            this.buttonAtualizar.TabIndex = 16;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // textBoxTelefoneAtualizar
            // 
            this.textBoxTelefoneAtualizar.Location = new System.Drawing.Point(103, 192);
            this.textBoxTelefoneAtualizar.Name = "textBoxTelefoneAtualizar";
            this.textBoxTelefoneAtualizar.Size = new System.Drawing.Size(636, 27);
            this.textBoxTelefoneAtualizar.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(8, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Telefone:";
            // 
            // textBoxEmailAtualizar
            // 
            this.textBoxEmailAtualizar.Location = new System.Drawing.Point(103, 148);
            this.textBoxEmailAtualizar.Name = "textBoxEmailAtualizar";
            this.textBoxEmailAtualizar.Size = new System.Drawing.Size(636, 27);
            this.textBoxEmailAtualizar.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(34, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(42, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Nome:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(169, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 28);
            this.label9.TabIndex = 10;
            this.label9.Text = "Atualizar";
            // 
            // textBoxNomeAtualizar
            // 
            this.textBoxNomeAtualizar.Location = new System.Drawing.Point(103, 107);
            this.textBoxNomeAtualizar.Name = "textBoxNomeAtualizar";
            this.textBoxNomeAtualizar.Size = new System.Drawing.Size(636, 27);
            this.textBoxNomeAtualizar.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(65, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 23);
            this.label10.TabIndex = 13;
            this.label10.Text = "TabelaID:";
            // 
            // groupBoxVisualizar
            // 
            this.groupBoxVisualizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxVisualizar.Controls.Add(this.buttonVisualizar);
            this.groupBoxVisualizar.Controls.Add(this.dataGridViewVisualizar);
            this.groupBoxVisualizar.Controls.Add(this.label11);
            this.groupBoxVisualizar.Location = new System.Drawing.Point(566, 179);
            this.groupBoxVisualizar.Name = "groupBoxVisualizar";
            this.groupBoxVisualizar.Size = new System.Drawing.Size(756, 297);
            this.groupBoxVisualizar.TabIndex = 14;
            this.groupBoxVisualizar.TabStop = false;
            // 
            // buttonVisualizar
            // 
            this.buttonVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVisualizar.Location = new System.Drawing.Point(12, 247);
            this.buttonVisualizar.Name = "buttonVisualizar";
            this.buttonVisualizar.Size = new System.Drawing.Size(94, 29);
            this.buttonVisualizar.TabIndex = 9;
            this.buttonVisualizar.Text = "Visualizar";
            this.buttonVisualizar.UseVisualStyleBackColor = true;
            this.buttonVisualizar.Click += new System.EventHandler(this.buttonVisualizar_Click);
            // 
            // dataGridViewVisualizar
            // 
            this.dataGridViewVisualizar.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewVisualizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVisualizar.GridColor = System.Drawing.Color.White;
            this.dataGridViewVisualizar.Location = new System.Drawing.Point(12, 54);
            this.dataGridViewVisualizar.Name = "dataGridViewVisualizar";
            this.dataGridViewVisualizar.RowHeadersWidth = 51;
            this.dataGridViewVisualizar.RowTemplate.Height = 29;
            this.dataGridViewVisualizar.Size = new System.Drawing.Size(727, 180);
            this.dataGridViewVisualizar.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(321, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 28);
            this.label11.TabIndex = 11;
            this.label11.Text = "Visualizar";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.buttonDeletar);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.textBoxTabelaDeletar);
            this.groupBox2.Location = new System.Drawing.Point(65, 482);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 282);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // buttonDeletar
            // 
            this.buttonDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeletar.Location = new System.Drawing.Point(12, 238);
            this.buttonDeletar.Name = "buttonDeletar";
            this.buttonDeletar.Size = new System.Drawing.Size(94, 29);
            this.buttonDeletar.TabIndex = 16;
            this.buttonDeletar.Text = "Deletar";
            this.buttonDeletar.UseVisualStyleBackColor = true;
            this.buttonDeletar.Click += new System.EventHandler(this.buttonDeletar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(170, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 20);
            this.label13.TabIndex = 11;
            this.label13.Text = "TabelaID:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(170, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 28);
            this.label14.TabIndex = 10;
            this.label14.Text = "Deletar";
            // 
            // textBoxTabelaDeletar
            // 
            this.textBoxTabelaDeletar.Location = new System.Drawing.Point(32, 117);
            this.textBoxTabelaDeletar.Name = "textBoxTabelaDeletar";
            this.textBoxTabelaDeletar.Size = new System.Drawing.Size(355, 27);
            this.textBoxTabelaDeletar.TabIndex = 9;
            // 
            // comboBoxTabelaSelecionar
            // 
            this.comboBoxTabelaSelecionar.FormattingEnabled = true;
            this.comboBoxTabelaSelecionar.Location = new System.Drawing.Point(65, 120);
            this.comboBoxTabelaSelecionar.Name = "comboBoxTabelaSelecionar";
            this.comboBoxTabelaSelecionar.Size = new System.Drawing.Size(283, 28);
            this.comboBoxTabelaSelecionar.TabIndex = 16;
            this.comboBoxTabelaSelecionar.TextChanged += new System.EventHandler(this.comboBoxTabelaSelecionar_TextChanged);
            this.comboBoxTabelaSelecionar.MouseLeave += new System.EventHandler(this.comboBoxTabelaSelecionar_MouseLeave);
            this.comboBoxTabelaSelecionar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.comboBoxTabelaSelecionar_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1371, 776);
            this.Controls.Add(this.comboBoxTabelaSelecionar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxVisualizar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBoxUpdate);
            this.Controls.Add(this.groupBoxCadastrar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Atividade";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxCadastrar.ResumeLayout(false);
            this.groupBoxCadastrar.PerformLayout();
            this.groupBoxUpdate.ResumeLayout(false);
            this.groupBoxUpdate.PerformLayout();
            this.groupBoxVisualizar.ResumeLayout(false);
            this.groupBoxVisualizar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisualizar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxNomeCadastro;
        private GroupBox groupBoxCadastrar;
        private Button buttonCadastrar;
        private TextBox textBoxTelefoneCadastro;
        private Label label5;
        private TextBox textBoxEmailCadastro;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBoxUpdate;
        private Button buttonAtualizar;
        private TextBox textBoxTelefoneAtualizar;
        private Label label6;
        private TextBox textBoxEmailAtualizar;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBoxNomeAtualizar;
        private Label label10;
        private GroupBox groupBoxVisualizar;
        private DataGridView dataGridViewVisualizar;
        private Label label11;
        private GroupBox groupBox2;
        private Button buttonDeletar;
        private Label label13;
        private Label label14;
        private TextBox textBoxTabelaDeletar;
        private Button buttonVisualizar;
        private ComboBox comboBoxTabelaSelecionar;
        private Label label12;
        private TextBox textBoxIDAtualizar;
    }
}