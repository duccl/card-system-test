namespace acme_flight_system
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.incluir_button = new System.Windows.Forms.Button();
            this.excluir_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.data_label = new System.Windows.Forms.Label();
            this.custo_label = new System.Windows.Forms.Label();
            this.captura_label = new System.Windows.Forms.Label();
            this.distancia_label = new System.Windows.Forms.Label();
            this.nivelDor_label = new System.Windows.Forms.Label();
            this.salvar_button = new System.Windows.Forms.Button();
            this.cancelar_button = new System.Windows.Forms.Button();
            this.data_textBox = new System.Windows.Forms.TextBox();
            this.custo_textBox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.nao_checkBox = new System.Windows.Forms.CheckBox();
            this.sim_checkBox = new System.Windows.Forms.CheckBox();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.niveldorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capturapassaroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vooModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vooModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 511F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(704, 511);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataDataGridViewTextBoxColumn,
            this.niveldorDataGridViewTextBoxColumn,
            this.capturapassaroDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vooModelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 505);
            this.dataGridView1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(355, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.732673F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.26733F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(346, 505);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.incluir_button);
            this.flowLayoutPanel1.Controls.Add(this.excluir_button);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(233, 27);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // incluir_button
            // 
            this.incluir_button.Location = new System.Drawing.Point(3, 3);
            this.incluir_button.Name = "incluir_button";
            this.incluir_button.Size = new System.Drawing.Size(75, 23);
            this.incluir_button.TabIndex = 0;
            this.incluir_button.Text = "Incluir";
            this.incluir_button.UseVisualStyleBackColor = true;
            // 
            // excluir_button
            // 
            this.excluir_button.Location = new System.Drawing.Point(84, 3);
            this.excluir_button.Name = "excluir_button";
            this.excluir_button.Size = new System.Drawing.Size(75, 23);
            this.excluir_button.TabIndex = 1;
            this.excluir_button.Text = "Excluir";
            this.excluir_button.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sim_checkBox);
            this.panel1.Controls.Add(this.nao_checkBox);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.custo_textBox);
            this.panel1.Controls.Add(this.data_textBox);
            this.panel1.Controls.Add(this.cancelar_button);
            this.panel1.Controls.Add(this.salvar_button);
            this.panel1.Controls.Add(this.nivelDor_label);
            this.panel1.Controls.Add(this.distancia_label);
            this.panel1.Controls.Add(this.captura_label);
            this.panel1.Controls.Add(this.custo_label);
            this.panel1.Controls.Add(this.data_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 466);
            this.panel1.TabIndex = 1;
            // 
            // data_label
            // 
            this.data_label.AutoSize = true;
            this.data_label.Location = new System.Drawing.Point(27, 50);
            this.data_label.Name = "data_label";
            this.data_label.Size = new System.Drawing.Size(30, 13);
            this.data_label.TabIndex = 0;
            this.data_label.Text = "Data";
            // 
            // custo_label
            // 
            this.custo_label.AutoSize = true;
            this.custo_label.Location = new System.Drawing.Point(27, 96);
            this.custo_label.Name = "custo_label";
            this.custo_label.Size = new System.Drawing.Size(34, 13);
            this.custo_label.TabIndex = 1;
            this.custo_label.Text = "Custo";
            // 
            // captura_label
            // 
            this.captura_label.AutoSize = true;
            this.captura_label.Location = new System.Drawing.Point(27, 190);
            this.captura_label.Name = "captura_label";
            this.captura_label.Size = new System.Drawing.Size(44, 13);
            this.captura_label.TabIndex = 2;
            this.captura_label.Text = "Captura";
            // 
            // distancia_label
            // 
            this.distancia_label.AutoSize = true;
            this.distancia_label.Location = new System.Drawing.Point(27, 143);
            this.distancia_label.Name = "distancia_label";
            this.distancia_label.Size = new System.Drawing.Size(51, 13);
            this.distancia_label.TabIndex = 3;
            this.distancia_label.Text = "Distancia";
            // 
            // nivelDor_label
            // 
            this.nivelDor_label.AutoSize = true;
            this.nivelDor_label.Location = new System.Drawing.Point(27, 240);
            this.nivelDor_label.Name = "nivelDor_label";
            this.nivelDor_label.Size = new System.Drawing.Size(51, 13);
            this.nivelDor_label.TabIndex = 5;
            this.nivelDor_label.Text = "Nivel Dor";
            // 
            // salvar_button
            // 
            this.salvar_button.Location = new System.Drawing.Point(30, 309);
            this.salvar_button.Name = "salvar_button";
            this.salvar_button.Size = new System.Drawing.Size(75, 23);
            this.salvar_button.TabIndex = 6;
            this.salvar_button.Text = "Salvar";
            this.salvar_button.UseVisualStyleBackColor = true;
            // 
            // cancelar_button
            // 
            this.cancelar_button.Location = new System.Drawing.Point(158, 309);
            this.cancelar_button.Name = "cancelar_button";
            this.cancelar_button.Size = new System.Drawing.Size(75, 23);
            this.cancelar_button.TabIndex = 7;
            this.cancelar_button.Text = "Cancelar";
            this.cancelar_button.UseVisualStyleBackColor = true;
            // 
            // data_textBox
            // 
            this.data_textBox.Location = new System.Drawing.Point(99, 47);
            this.data_textBox.Name = "data_textBox";
            this.data_textBox.Size = new System.Drawing.Size(100, 20);
            this.data_textBox.TabIndex = 8;
            // 
            // custo_textBox
            // 
            this.custo_textBox.Location = new System.Drawing.Point(99, 93);
            this.custo_textBox.Name = "custo_textBox";
            this.custo_textBox.Size = new System.Drawing.Size(100, 20);
            this.custo_textBox.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(99, 140);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(99, 237);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 12;
            // 
            // nao_checkBox
            // 
            this.nao_checkBox.AutoSize = true;
            this.nao_checkBox.Location = new System.Drawing.Point(99, 190);
            this.nao_checkBox.Name = "nao_checkBox";
            this.nao_checkBox.Size = new System.Drawing.Size(46, 17);
            this.nao_checkBox.TabIndex = 13;
            this.nao_checkBox.Text = "Nao";
            this.nao_checkBox.UseVisualStyleBackColor = true;
            // 
            // sim_checkBox
            // 
            this.sim_checkBox.AutoSize = true;
            this.sim_checkBox.Location = new System.Drawing.Point(190, 189);
            this.sim_checkBox.Name = "sim_checkBox";
            this.sim_checkBox.Size = new System.Drawing.Size(43, 17);
            this.sim_checkBox.TabIndex = 14;
            this.sim_checkBox.Text = "Sim";
            this.sim_checkBox.UseVisualStyleBackColor = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // niveldorDataGridViewTextBoxColumn
            // 
            this.niveldorDataGridViewTextBoxColumn.DataPropertyName = "Nivel_dor";
            this.niveldorDataGridViewTextBoxColumn.HeaderText = "Nivel_dor";
            this.niveldorDataGridViewTextBoxColumn.Name = "niveldorDataGridViewTextBoxColumn";
            // 
            // capturapassaroDataGridViewTextBoxColumn
            // 
            this.capturapassaroDataGridViewTextBoxColumn.DataPropertyName = "Captura_passaro";
            this.capturapassaroDataGridViewTextBoxColumn.HeaderText = "Captura";
            this.capturapassaroDataGridViewTextBoxColumn.Name = "capturapassaroDataGridViewTextBoxColumn";
            // 
            // vooModelBindingSource
            // 
            this.vooModelBindingSource.DataSource = typeof(acme_flight_system.Models.VooModel);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 511);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "ACME FLIGHT MANAGER";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vooModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn niveldorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capturapassaroDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vooModelBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button incluir_button;
        private System.Windows.Forms.Button excluir_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox sim_checkBox;
        private System.Windows.Forms.CheckBox nao_checkBox;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox custo_textBox;
        private System.Windows.Forms.TextBox data_textBox;
        private System.Windows.Forms.Button cancelar_button;
        private System.Windows.Forms.Button salvar_button;
        private System.Windows.Forms.Label nivelDor_label;
        private System.Windows.Forms.Label distancia_label;
        private System.Windows.Forms.Label captura_label;
        private System.Windows.Forms.Label custo_label;
        private System.Windows.Forms.Label data_label;
    }
}

