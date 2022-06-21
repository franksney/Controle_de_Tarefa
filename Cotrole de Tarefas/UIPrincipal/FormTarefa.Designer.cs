
namespace UIPrincipal
{
    partial class FormTarefa
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
            this.tarefaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tarefaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAdicionarTarefa = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxbuscar = new System.Windows.Forms.TextBox();
            this.ButtonExcluir = new System.Windows.Forms.Button();
            this.comentarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comentarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAdicionarComentaro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comentarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comentarioDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tarefaBindingSource
            // 
            this.tarefaBindingSource.DataSource = typeof(Model.Tarefa);
            this.tarefaBindingSource.CurrentChanged += new System.EventHandler(this.tarefaBindingSource_CurrentChanged);
            // 
            // tarefaDataGridView
            // 
            this.tarefaDataGridView.AllowUserToAddRows = false;
            this.tarefaDataGridView.AllowUserToDeleteRows = false;
            this.tarefaDataGridView.AllowUserToOrderColumns = true;
            this.tarefaDataGridView.AutoGenerateColumns = false;
            this.tarefaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tarefaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.Estatus});
            this.tarefaDataGridView.DataSource = this.tarefaBindingSource;
            this.tarefaDataGridView.Location = new System.Drawing.Point(12, 71);
            this.tarefaDataGridView.Name = "tarefaDataGridView";
            this.tarefaDataGridView.ReadOnly = true;
            this.tarefaDataGridView.Size = new System.Drawing.Size(678, 210);
            this.tarefaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Estatus
            // 
            this.Estatus.DataPropertyName = "Estatus";
            this.Estatus.HeaderText = "Estatus";
            this.Estatus.Name = "Estatus";
            this.Estatus.ReadOnly = true;
            // 
            // buttonAdicionarTarefa
            // 
            this.buttonAdicionarTarefa.Location = new System.Drawing.Point(12, 42);
            this.buttonAdicionarTarefa.Name = "buttonAdicionarTarefa";
            this.buttonAdicionarTarefa.Size = new System.Drawing.Size(123, 23);
            this.buttonAdicionarTarefa.TabIndex = 2;
            this.buttonAdicionarTarefa.Text = "Adicionar tarefa";
            this.buttonAdicionarTarefa.UseVisualStyleBackColor = true;
            this.buttonAdicionarTarefa.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(615, 16);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 3;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxbuscar
            // 
            this.textBoxbuscar.Location = new System.Drawing.Point(12, 18);
            this.textBoxbuscar.Name = "textBoxbuscar";
            this.textBoxbuscar.Size = new System.Drawing.Size(567, 20);
            this.textBoxbuscar.TabIndex = 4;
            // 
            // ButtonExcluir
            // 
            this.ButtonExcluir.Location = new System.Drawing.Point(141, 44);
            this.ButtonExcluir.Name = "ButtonExcluir";
            this.ButtonExcluir.Size = new System.Drawing.Size(75, 23);
            this.ButtonExcluir.TabIndex = 5;
            this.ButtonExcluir.Text = "Excluir";
            this.ButtonExcluir.UseVisualStyleBackColor = true;
            // 
            // comentarioBindingSource
            // 
            this.comentarioBindingSource.DataSource = typeof(Model.Comentario);
            // 
            // comentarioDataGridView
            // 
            this.comentarioDataGridView.AllowUserToAddRows = false;
            this.comentarioDataGridView.AllowUserToDeleteRows = false;
            this.comentarioDataGridView.AllowUserToOrderColumns = true;
            this.comentarioDataGridView.AutoGenerateColumns = false;
            this.comentarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.comentarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6});
            this.comentarioDataGridView.DataSource = this.comentarioBindingSource;
            this.comentarioDataGridView.Location = new System.Drawing.Point(12, 287);
            this.comentarioDataGridView.Name = "comentarioDataGridView";
            this.comentarioDataGridView.ReadOnly = true;
            this.comentarioDataGridView.Size = new System.Drawing.Size(678, 180);
            this.comentarioDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn6.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // buttonAdicionarComentaro
            // 
            this.buttonAdicionarComentaro.Location = new System.Drawing.Point(12, 473);
            this.buttonAdicionarComentaro.Name = "buttonAdicionarComentaro";
            this.buttonAdicionarComentaro.Size = new System.Drawing.Size(156, 23);
            this.buttonAdicionarComentaro.TabIndex = 6;
            this.buttonAdicionarComentaro.Text = "Adicionar comentario";
            this.buttonAdicionarComentaro.UseVisualStyleBackColor = true;
            this.buttonAdicionarComentaro.Click += new System.EventHandler(this.buttonAdicionarComentaro_Click);
            // 
            // FormTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 499);
            this.Controls.Add(this.buttonAdicionarComentaro);
            this.Controls.Add(this.comentarioDataGridView);
            this.Controls.Add(this.ButtonExcluir);
            this.Controls.Add(this.textBoxbuscar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonAdicionarTarefa);
            this.Controls.Add(this.tarefaDataGridView);
            this.Name = "FormTarefa";
            this.Text = "Controle de tarefas";
            this.Load += new System.EventHandler(this.TelaInicial_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comentarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comentarioDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tarefaBindingSource;
        private System.Windows.Forms.DataGridView tarefaDataGridView;
        private System.Windows.Forms.Button buttonAdicionarTarefa;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxbuscar;
        private System.Windows.Forms.Button ButtonExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
        private System.Windows.Forms.BindingSource comentarioBindingSource;
        private System.Windows.Forms.DataGridView comentarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button buttonAdicionarComentaro;
    }
}

