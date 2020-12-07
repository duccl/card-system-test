namespace acme_flight_system
{
    partial class AcmeForm
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
            this.mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.flightDataGridView = new System.Windows.Forms.DataGridView();
            this.datavooDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.niveldorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vooModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formFlightTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.actionFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.incluir_button = new System.Windows.Forms.Button();
            this.excluir_button = new System.Windows.Forms.Button();
            this.dataFormPanel = new System.Windows.Forms.Panel();
            this.nivelDor_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.distancia_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.custo_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dataVoo_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sim_checkBox = new System.Windows.Forms.CheckBox();
            this.nao_checkBox = new System.Windows.Forms.CheckBox();
            this.cancelar_button = new System.Windows.Forms.Button();
            this.salvar_button = new System.Windows.Forms.Button();
            this.nivelDor_label = new System.Windows.Forms.Label();
            this.distancia_label = new System.Windows.Forms.Label();
            this.captura_label = new System.Windows.Forms.Label();
            this.custo_label = new System.Windows.Forms.Label();
            this.data_label = new System.Windows.Forms.Label();
            this.mainLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vooModelBindingSource)).BeginInit();
            this.formFlightTableLayoutPanel.SuspendLayout();
            this.actionFlowLayoutPanel.SuspendLayout();
            this.dataFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nivelDor_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distancia_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custo_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.ColumnCount = 2;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayoutPanel.Controls.Add(this.flightDataGridView, 0, 0);
            this.mainLayoutPanel.Controls.Add(this.formFlightTableLayoutPanel, 1, 0);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.RowCount = 1;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 511F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(704, 511);
            this.mainLayoutPanel.TabIndex = 0;
            // 
            // flightDataGridView
            // 
            this.flightDataGridView.AllowUserToAddRows = false;
            this.flightDataGridView.AllowUserToDeleteRows = false;
            this.flightDataGridView.AutoGenerateColumns = false;
            this.flightDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flightDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datavooDataGridViewTextBoxColumn,
            this.niveldorDataGridViewTextBoxColumn,
            this.capturaDataGridViewTextBoxColumn});
            this.flightDataGridView.DataSource = this.vooModelBindingSource;
            this.flightDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flightDataGridView.Location = new System.Drawing.Point(3, 3);
            this.flightDataGridView.Name = "flightDataGridView";
            this.flightDataGridView.ReadOnly = true;
            this.flightDataGridView.Size = new System.Drawing.Size(346, 505);
            this.flightDataGridView.TabIndex = 0;
            // 
            // datavooDataGridViewTextBoxColumn
            // 
            this.datavooDataGridViewTextBoxColumn.DataPropertyName = "Data_voo";
            this.datavooDataGridViewTextBoxColumn.HeaderText = "Data_voo";
            this.datavooDataGridViewTextBoxColumn.Name = "datavooDataGridViewTextBoxColumn";
            this.datavooDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // niveldorDataGridViewTextBoxColumn
            // 
            this.niveldorDataGridViewTextBoxColumn.DataPropertyName = "Nivel_dor";
            this.niveldorDataGridViewTextBoxColumn.HeaderText = "Nivel_dor";
            this.niveldorDataGridViewTextBoxColumn.Name = "niveldorDataGridViewTextBoxColumn";
            this.niveldorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // capturaDataGridViewTextBoxColumn
            // 
            this.capturaDataGridViewTextBoxColumn.DataPropertyName = "Captura";
            this.capturaDataGridViewTextBoxColumn.HeaderText = "Captura";
            this.capturaDataGridViewTextBoxColumn.Name = "capturaDataGridViewTextBoxColumn";
            this.capturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vooModelBindingSource
            // 
            this.vooModelBindingSource.DataSource = typeof(acme_flight_system.Models.VooModel);
            // 
            // formFlightTableLayoutPanel
            // 
            this.formFlightTableLayoutPanel.ColumnCount = 1;
            this.formFlightTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.formFlightTableLayoutPanel.Controls.Add(this.actionFlowLayoutPanel, 0, 0);
            this.formFlightTableLayoutPanel.Controls.Add(this.dataFormPanel, 0, 1);
            this.formFlightTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formFlightTableLayoutPanel.Location = new System.Drawing.Point(355, 3);
            this.formFlightTableLayoutPanel.Name = "formFlightTableLayoutPanel";
            this.formFlightTableLayoutPanel.RowCount = 2;
            this.formFlightTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.732673F));
            this.formFlightTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.26733F));
            this.formFlightTableLayoutPanel.Size = new System.Drawing.Size(346, 505);
            this.formFlightTableLayoutPanel.TabIndex = 1;
            // 
            // actionFlowLayoutPanel
            // 
            this.actionFlowLayoutPanel.Controls.Add(this.incluir_button);
            this.actionFlowLayoutPanel.Controls.Add(this.excluir_button);
            this.actionFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.actionFlowLayoutPanel.Name = "actionFlowLayoutPanel";
            this.actionFlowLayoutPanel.Size = new System.Drawing.Size(233, 27);
            this.actionFlowLayoutPanel.TabIndex = 0;
            // 
            // incluir_button
            // 
            this.incluir_button.Location = new System.Drawing.Point(3, 3);
            this.incluir_button.Name = "incluir_button";
            this.incluir_button.Size = new System.Drawing.Size(75, 23);
            this.incluir_button.TabIndex = 0;
            this.incluir_button.Text = "Incluir";
            this.incluir_button.UseVisualStyleBackColor = true;
            this.incluir_button.Click += new System.EventHandler(this.incluir_button_Click);
            // 
            // excluir_button
            // 
            this.excluir_button.Enabled = false;
            this.excluir_button.Location = new System.Drawing.Point(84, 3);
            this.excluir_button.Name = "excluir_button";
            this.excluir_button.Size = new System.Drawing.Size(75, 23);
            this.excluir_button.TabIndex = 1;
            this.excluir_button.Text = "Excluir";
            this.excluir_button.UseVisualStyleBackColor = true;
            // 
            // dataFormPanel
            // 
            this.dataFormPanel.Controls.Add(this.nivelDor_numericUpDown);
            this.dataFormPanel.Controls.Add(this.distancia_numericUpDown);
            this.dataFormPanel.Controls.Add(this.custo_numericUpDown);
            this.dataFormPanel.Controls.Add(this.dataVoo_dateTimePicker);
            this.dataFormPanel.Controls.Add(this.sim_checkBox);
            this.dataFormPanel.Controls.Add(this.nao_checkBox);
            this.dataFormPanel.Controls.Add(this.cancelar_button);
            this.dataFormPanel.Controls.Add(this.salvar_button);
            this.dataFormPanel.Controls.Add(this.nivelDor_label);
            this.dataFormPanel.Controls.Add(this.distancia_label);
            this.dataFormPanel.Controls.Add(this.captura_label);
            this.dataFormPanel.Controls.Add(this.custo_label);
            this.dataFormPanel.Controls.Add(this.data_label);
            this.dataFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataFormPanel.Location = new System.Drawing.Point(3, 36);
            this.dataFormPanel.Name = "dataFormPanel";
            this.dataFormPanel.Size = new System.Drawing.Size(340, 466);
            this.dataFormPanel.TabIndex = 1;
            // 
            // nivelDor_numericUpDown
            // 
            this.nivelDor_numericUpDown.Location = new System.Drawing.Point(99, 240);
            this.nivelDor_numericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nivelDor_numericUpDown.Name = "nivelDor_numericUpDown";
            this.nivelDor_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.nivelDor_numericUpDown.TabIndex = 18;
            // 
            // distancia_numericUpDown
            // 
            this.distancia_numericUpDown.DecimalPlaces = 2;
            this.distancia_numericUpDown.Location = new System.Drawing.Point(99, 143);
            this.distancia_numericUpDown.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.distancia_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.distancia_numericUpDown.Name = "distancia_numericUpDown";
            this.distancia_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.distancia_numericUpDown.TabIndex = 17;
            this.distancia_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // custo_numericUpDown
            // 
            this.custo_numericUpDown.DecimalPlaces = 2;
            this.custo_numericUpDown.Location = new System.Drawing.Point(99, 96);
            this.custo_numericUpDown.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.custo_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.custo_numericUpDown.Name = "custo_numericUpDown";
            this.custo_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.custo_numericUpDown.TabIndex = 16;
            this.custo_numericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // dataVoo_dateTimePicker
            // 
            this.dataVoo_dateTimePicker.Location = new System.Drawing.Point(99, 50);
            this.dataVoo_dateTimePicker.Name = "dataVoo_dateTimePicker";
            this.dataVoo_dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataVoo_dateTimePicker.TabIndex = 15;
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
            // cancelar_button
            // 
            this.cancelar_button.Enabled = false;
            this.cancelar_button.Location = new System.Drawing.Point(158, 309);
            this.cancelar_button.Name = "cancelar_button";
            this.cancelar_button.Size = new System.Drawing.Size(75, 23);
            this.cancelar_button.TabIndex = 7;
            this.cancelar_button.Text = "Cancelar";
            this.cancelar_button.UseVisualStyleBackColor = true;
            // 
            // salvar_button
            // 
            this.salvar_button.Enabled = false;
            this.salvar_button.Location = new System.Drawing.Point(30, 309);
            this.salvar_button.Name = "salvar_button";
            this.salvar_button.Size = new System.Drawing.Size(75, 23);
            this.salvar_button.TabIndex = 6;
            this.salvar_button.Text = "Salvar";
            this.salvar_button.UseVisualStyleBackColor = true;
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
            // distancia_label
            // 
            this.distancia_label.AutoSize = true;
            this.distancia_label.Location = new System.Drawing.Point(27, 143);
            this.distancia_label.Name = "distancia_label";
            this.distancia_label.Size = new System.Drawing.Size(51, 13);
            this.distancia_label.TabIndex = 3;
            this.distancia_label.Text = "Distancia";
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
            // custo_label
            // 
            this.custo_label.AutoSize = true;
            this.custo_label.Location = new System.Drawing.Point(27, 96);
            this.custo_label.Name = "custo_label";
            this.custo_label.Size = new System.Drawing.Size(34, 13);
            this.custo_label.TabIndex = 1;
            this.custo_label.Text = "Custo";
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
            // AcmeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 511);
            this.Controls.Add(this.mainLayoutPanel);
            this.Name = "AcmeForm";
            this.Text = "ACME FLIGHT MANAGER";
            this.mainLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flightDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vooModelBindingSource)).EndInit();
            this.formFlightTableLayoutPanel.ResumeLayout(false);
            this.actionFlowLayoutPanel.ResumeLayout(false);
            this.dataFormPanel.ResumeLayout(false);
            this.dataFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nivelDor_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distancia_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custo_numericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayoutPanel;
        private System.Windows.Forms.DataGridView flightDataGridView;
        private System.Windows.Forms.BindingSource vooModelBindingSource;
        private System.Windows.Forms.TableLayoutPanel formFlightTableLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel actionFlowLayoutPanel;
        private System.Windows.Forms.Button incluir_button;
        private System.Windows.Forms.Button excluir_button;
        private System.Windows.Forms.Panel dataFormPanel;
        private System.Windows.Forms.CheckBox sim_checkBox;
        private System.Windows.Forms.CheckBox nao_checkBox;
        private System.Windows.Forms.Button cancelar_button;
        private System.Windows.Forms.Button salvar_button;
        private System.Windows.Forms.Label nivelDor_label;
        private System.Windows.Forms.Label distancia_label;
        private System.Windows.Forms.Label captura_label;
        private System.Windows.Forms.Label custo_label;
        private System.Windows.Forms.Label data_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn datavooDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn niveldorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dataVoo_dateTimePicker;
        private System.Windows.Forms.NumericUpDown custo_numericUpDown;
        private System.Windows.Forms.NumericUpDown nivelDor_numericUpDown;
        private System.Windows.Forms.NumericUpDown distancia_numericUpDown;
    }
}

