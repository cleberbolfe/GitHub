
namespace TarefasInsert
{
    partial class Formtodo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAtivo = new System.Windows.Forms.TextBox();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.dgtodo = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAtivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btInserir = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.tbData = new System.Windows.Forms.MaskedTextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgtodo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "DATA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "DESCRIÇÃO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(584, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 39);
            this.label4.TabIndex = 3;
            this.label4.Text = "ATIVO:";
            // 
            // tbAtivo
            // 
            this.tbAtivo.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.tbAtivo.Location = new System.Drawing.Point(711, 9);
            this.tbAtivo.Name = "tbAtivo";
            this.tbAtivo.Size = new System.Drawing.Size(74, 47);
            this.tbAtivo.TabIndex = 6;
            // 
            // tbDescricao
            // 
            this.tbDescricao.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.tbDescricao.Location = new System.Drawing.Point(231, 71);
            this.tbDescricao.MaximumSize = new System.Drawing.Size(554, 200);
            this.tbDescricao.MinimumSize = new System.Drawing.Size(554, 200);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(554, 200);
            this.tbDescricao.TabIndex = 7;
            // 
            // dgtodo
            // 
            this.dgtodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtodo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colData,
            this.coldescricao,
            this.colAtivo});
            this.dgtodo.Location = new System.Drawing.Point(19, 444);
            this.dgtodo.Name = "dgtodo";
            this.dgtodo.Size = new System.Drawing.Size(758, 199);
            this.dgtodo.TabIndex = 8;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            // 
            // colData
            // 
            this.colData.HeaderText = "DATA";
            this.colData.Name = "colData";
            this.colData.Width = 120;
            // 
            // coldescricao
            // 
            this.coldescricao.HeaderText = "DESCRIÇÃO";
            this.coldescricao.Name = "coldescricao";
            this.coldescricao.Width = 400;
            // 
            // colAtivo
            // 
            this.colAtivo.HeaderText = "ATIVO";
            this.colAtivo.Name = "colAtivo";
            // 
            // btInserir
            // 
            this.btInserir.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.btInserir.Location = new System.Drawing.Point(297, 306);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(179, 59);
            this.btInserir.TabIndex = 9;
            this.btInserir.Text = "INSERIR";
            this.btInserir.UseVisualStyleBackColor = true;
            this.btInserir.Click += new System.EventHandler(this.button2_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.btLimpar.Location = new System.Drawing.Point(526, 306);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(179, 59);
            this.btLimpar.TabIndex = 10;
            this.btLimpar.Text = "LIMPAR";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbData
            // 
            this.tbData.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.tbData.Location = new System.Drawing.Point(372, 9);
            this.tbData.Mask = "00/00/0000";
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(164, 47);
            this.tbData.TabIndex = 13;
            this.tbData.ValidatingType = typeof(System.DateTime);
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.tbID.Location = new System.Drawing.Point(76, 9);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(62, 47);
            this.tbID.TabIndex = 14;
            // 
            // Formtodo
            // 
            this.ClientSize = new System.Drawing.Size(803, 660);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btInserir);
            this.Controls.Add(this.dgtodo);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.tbAtivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Formtodo";
            this.Text = "To-do";
            this.Load += new System.EventHandler(this.Formtodo_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgtodo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAtivo;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.DataGridView dgtodo;
        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.MaskedTextBox tbData;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAtivo;
    }
}

