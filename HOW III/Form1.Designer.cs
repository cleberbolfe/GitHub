
namespace HOW_III
{
	partial class Confirme
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbTarefa1 = new System.Windows.Forms.CheckBox();
            this.tbTarefa2 = new System.Windows.Forms.CheckBox();
            this.tbTarefa3 = new System.Windows.Forms.CheckBox();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tbGravar = new System.Windows.Forms.Button();
            this.tbReset = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.dgConfirme = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcheck = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbDataSet = new HOW_III.dbDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dgConfirme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dateTimePicker1.Location = new System.Drawing.Point(573, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(231, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // tbTarefa1
            // 
            this.tbTarefa1.AutoSize = true;
            this.tbTarefa1.Location = new System.Drawing.Point(582, 73);
            this.tbTarefa1.Name = "tbTarefa1";
            this.tbTarefa1.Size = new System.Drawing.Size(15, 14);
            this.tbTarefa1.TabIndex = 1;
            this.tbTarefa1.UseVisualStyleBackColor = true;
            this.tbTarefa1.CheckedChanged += new System.EventHandler(this.tbTarefa1_CheckedChanged);
            // 
            // tbTarefa2
            // 
            this.tbTarefa2.AutoSize = true;
            this.tbTarefa2.Location = new System.Drawing.Point(582, 105);
            this.tbTarefa2.Name = "tbTarefa2";
            this.tbTarefa2.Size = new System.Drawing.Size(15, 14);
            this.tbTarefa2.TabIndex = 2;
            this.tbTarefa2.UseVisualStyleBackColor = true;
            // 
            // tbTarefa3
            // 
            this.tbTarefa3.AutoSize = true;
            this.tbTarefa3.Location = new System.Drawing.Point(582, 139);
            this.tbTarefa3.Name = "tbTarefa3";
            this.tbTarefa3.Size = new System.Drawing.Size(15, 14);
            this.tbTarefa3.TabIndex = 3;
            this.tbTarefa3.UseVisualStyleBackColor = true;
            // 
            // tbDescricao
            // 
            this.tbDescricao.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbDescricao.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tbDescricao.Location = new System.Drawing.Point(635, 70);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(169, 20);
            this.tbDescricao.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox2.Location = new System.Drawing.Point(635, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox3.Location = new System.Drawing.Point(635, 136);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(169, 20);
            this.textBox3.TabIndex = 6;
            // 
            // tbGravar
            // 
            this.tbGravar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbGravar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tbGravar.Location = new System.Drawing.Point(573, 346);
            this.tbGravar.Name = "tbGravar";
            this.tbGravar.Size = new System.Drawing.Size(75, 23);
            this.tbGravar.TabIndex = 7;
            this.tbGravar.Text = "Gravar";
            this.tbGravar.UseVisualStyleBackColor = false;
            this.tbGravar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tbReset
            // 
            this.tbReset.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tbReset.Location = new System.Drawing.Point(729, 346);
            this.tbReset.Name = "tbReset";
            this.tbReset.Size = new System.Drawing.Size(75, 23);
            this.tbReset.TabIndex = 8;
            this.tbReset.Text = "Reset";
            this.tbReset.UseVisualStyleBackColor = false;
            this.tbReset.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox4.Location = new System.Drawing.Point(635, 171);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(169, 20);
            this.textBox4.TabIndex = 9;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(582, 174);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox5.Location = new System.Drawing.Point(635, 206);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(169, 20);
            this.textBox5.TabIndex = 11;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(582, 209);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox6.Location = new System.Drawing.Point(635, 241);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(169, 20);
            this.textBox6.TabIndex = 13;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(582, 244);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 14;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // dgConfirme
            // 
            this.dgConfirme.AutoGenerateColumns = false;
            this.dgConfirme.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgConfirme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConfirme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.Descrição,
            this.colcheck});
            this.dgConfirme.DataSource = this.dbDataSetBindingSource;
            this.dgConfirme.Location = new System.Drawing.Point(369, 385);
            this.dgConfirme.Name = "dgConfirme";
            this.dgConfirme.Size = new System.Drawing.Size(696, 180);
            this.dgConfirme.TabIndex = 15;
            this.dgConfirme.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Data
            // 
            this.Data.HeaderText = "colData";
            this.Data.Name = "Data";
            this.Data.Width = 150;
            // 
            // Descrição
            // 
            this.Descrição.HeaderText = "coldescricao";
            this.Descrição.Name = "Descrição";
            this.Descrição.Width = 400;
            // 
            // colcheck
            // 
            this.colcheck.HeaderText = "colCheck";
            this.colcheck.Name = "colcheck";
            // 
            // dbDataSetBindingSource
            // 
            this.dbDataSetBindingSource.DataSource = this.dbDataSet;
            this.dbDataSetBindingSource.Position = 0;
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Confirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1441, 653);
            this.Controls.Add(this.dgConfirme);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.tbReset);
            this.Controls.Add(this.tbGravar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.tbTarefa3);
            this.Controls.Add(this.tbTarefa2);
            this.Controls.Add(this.tbTarefa1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Confirme";
            this.Text = "Lista de Tarefas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgConfirme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox tbTarefa1;
        private System.Windows.Forms.CheckBox tbTarefa2;
        private System.Windows.Forms.CheckBox tbTarefa3;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button tbGravar;
        private System.Windows.Forms.Button tbReset;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.DataGridView dgConfirme;
        private System.Windows.Forms.BindingSource dbDataSetBindingSource;
        private dbDataSet dbDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcheck;
    }
}

