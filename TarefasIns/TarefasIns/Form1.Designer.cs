
namespace TarefasIns
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
            this.components = new System.ComponentModel.Container();
            this.dotoDataSet = new TarefasIns.dotoDataSet();
            this.tarefaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tarefaTableAdapter = new TarefasIns.dotoDataSetTableAdapters.tarefaTableAdapter();
            this.dgtodo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idTarefaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTarefaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoTarefaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativoTarefaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dotoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dotoDataSet
            // 
            this.dotoDataSet.DataSetName = "dotoDataSet";
            this.dotoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tarefaBindingSource
            // 
            this.tarefaBindingSource.DataMember = "tarefa";
            this.tarefaBindingSource.DataSource = this.dotoDataSet;
            // 
            // tarefaTableAdapter
            // 
            this.tarefaTableAdapter.ClearBeforeFill = true;
            // 
            // dgtodo
            // 
            this.dgtodo.AllowUserToOrderColumns = true;
            this.dgtodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtodo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgtodo.Location = new System.Drawing.Point(58, 303);
            this.dgtodo.Name = "dgtodo";
            this.dgtodo.Size = new System.Drawing.Size(685, 150);
            this.dgtodo.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTarefaDataGridViewTextBoxColumn,
            this.dataTarefaDataGridViewTextBoxColumn,
            this.descricaoTarefaDataGridViewTextBoxColumn,
            this.ativoTarefaDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tarefaBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(58, 51);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(717, 191);
            this.dataGridView2.TabIndex = 1;
            // 
            // idTarefaDataGridViewTextBoxColumn
            // 
            this.idTarefaDataGridViewTextBoxColumn.DataPropertyName = "idTarefa";
            this.idTarefaDataGridViewTextBoxColumn.HeaderText = "idTarefa";
            this.idTarefaDataGridViewTextBoxColumn.Name = "idTarefaDataGridViewTextBoxColumn";
            // 
            // dataTarefaDataGridViewTextBoxColumn
            // 
            this.dataTarefaDataGridViewTextBoxColumn.DataPropertyName = "dataTarefa";
            this.dataTarefaDataGridViewTextBoxColumn.HeaderText = "dataTarefa";
            this.dataTarefaDataGridViewTextBoxColumn.Name = "dataTarefaDataGridViewTextBoxColumn";
            // 
            // descricaoTarefaDataGridViewTextBoxColumn
            // 
            this.descricaoTarefaDataGridViewTextBoxColumn.DataPropertyName = "descricaoTarefa";
            this.descricaoTarefaDataGridViewTextBoxColumn.HeaderText = "descricaoTarefa";
            this.descricaoTarefaDataGridViewTextBoxColumn.Name = "descricaoTarefaDataGridViewTextBoxColumn";
            // 
            // ativoTarefaDataGridViewTextBoxColumn
            // 
            this.ativoTarefaDataGridViewTextBoxColumn.DataPropertyName = "ativoTarefa";
            this.ativoTarefaDataGridViewTextBoxColumn.HeaderText = "ativoTarefa";
            this.ativoTarefaDataGridViewTextBoxColumn.Name = "ativoTarefaDataGridViewTextBoxColumn";
            // 
            // Formtodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 535);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dgtodo);
            this.Name = "Formtodo";
            this.Text = "Todo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dotoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private dotoDataSet dotoDataSet;
        private System.Windows.Forms.BindingSource tarefaBindingSource;
        private dotoDataSetTableAdapters.tarefaTableAdapter tarefaTableAdapter;
        private System.Windows.Forms.DataGridView dgtodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTarefaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataTarefaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoTarefaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ativoTarefaDataGridViewTextBoxColumn;
    }
}

