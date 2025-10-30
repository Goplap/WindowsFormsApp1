namespace WindowsFormsApp1
{
    partial class FormQueries
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
            this.groupBoxSort = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTable = new System.Windows.Forms.ComboBox();
            this.cARGOTYPEBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.transportLogisticDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.transportLogisticDataSet = new WindowsFormsApp1.TransportLogisticDataSet();
            this.transportLogisticDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cARGOTYPEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cARGO_TYPETableAdapter = new WindowsFormsApp1.TransportLogisticDataSetTableAdapters.CARGO_TYPETableAdapter();
            this.cARGOTYPEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.transportLogisticDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cARGOTYPEBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSortField = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSortOrder = new System.Windows.Forms.ComboBox();
            this.buttonSort = new System.Windows.Forms.Button();
            this.checkBoxTop10 = new System.Windows.Forms.CheckBox();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.cARGOTYPEBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportLogisticDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportLogisticDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportLogisticDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARGOTYPEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARGOTYPEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportLogisticDataSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARGOTYPEBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSort
            // 
            this.groupBoxSort.Location = new System.Drawing.Point(0, 0);
            this.groupBoxSort.Name = "groupBoxSort";
            this.groupBoxSort.Size = new System.Drawing.Size(544, 259);
            this.groupBoxSort.TabIndex = 0;
            this.groupBoxSort.TabStop = false;
            this.groupBoxSort.Text = "Сортування даних";
            this.groupBoxSort.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(550, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Таблиця";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxTable
            // 
            this.comboBoxTable.FormattingEnabled = true;
            this.comboBoxTable.Items.AddRange(new object[] {
            "Cargo type",
            "Delivery",
            "Driver",
            "Recipient",
            "Route",
            "Supplier",
            "Transport vehicle"});
            this.comboBoxTable.Location = new System.Drawing.Point(553, 25);
            this.comboBoxTable.Name = "comboBoxTable";
            this.comboBoxTable.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTable.TabIndex = 1;
            this.comboBoxTable.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cARGOTYPEBindingSource2
            // 
            this.cARGOTYPEBindingSource2.DataMember = "CARGO_TYPE";
            this.cARGOTYPEBindingSource2.DataSource = this.transportLogisticDataSetBindingSource1;
            // 
            // transportLogisticDataSetBindingSource1
            // 
            this.transportLogisticDataSetBindingSource1.DataSource = this.transportLogisticDataSet;
            this.transportLogisticDataSetBindingSource1.Position = 0;
            // 
            // transportLogisticDataSet
            // 
            this.transportLogisticDataSet.DataSetName = "TransportLogisticDataSet";
            this.transportLogisticDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transportLogisticDataSetBindingSource
            // 
            this.transportLogisticDataSetBindingSource.DataSource = this.transportLogisticDataSet;
            this.transportLogisticDataSetBindingSource.Position = 0;
            // 
            // cARGOTYPEBindingSource
            // 
            this.cARGOTYPEBindingSource.DataMember = "CARGO_TYPE";
            this.cARGOTYPEBindingSource.DataSource = this.transportLogisticDataSet;
            // 
            // cARGO_TYPETableAdapter
            // 
            this.cARGO_TYPETableAdapter.ClearBeforeFill = true;
            // 
            // cARGOTYPEBindingSource1
            // 
            this.cARGOTYPEBindingSource1.DataMember = "CARGO_TYPE";
            this.cARGOTYPEBindingSource1.DataSource = this.transportLogisticDataSetBindingSource;
            // 
            // transportLogisticDataSetBindingSource2
            // 
            this.transportLogisticDataSetBindingSource2.DataSource = this.transportLogisticDataSet;
            this.transportLogisticDataSetBindingSource2.Position = 0;
            // 
            // cARGOTYPEBindingSource3
            // 
            this.cARGOTYPEBindingSource3.DataMember = "CARGO_TYPE";
            this.cARGOTYPEBindingSource3.DataSource = this.transportLogisticDataSetBindingSource2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(550, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Поле для сортування";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBoxSortField
            // 
            this.comboBoxSortField.FormattingEnabled = true;
            this.comboBoxSortField.Location = new System.Drawing.Point(553, 88);
            this.comboBoxSortField.Name = "comboBoxSortField";
            this.comboBoxSortField.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSortField.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(553, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Порядок сортування";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBoxSortOrder
            // 
            this.comboBoxSortOrder.FormattingEnabled = true;
            this.comboBoxSortOrder.Location = new System.Drawing.Point(553, 148);
            this.comboBoxSortOrder.Name = "comboBoxSortOrder";
            this.comboBoxSortOrder.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSortOrder.TabIndex = 5;
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(556, 187);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(128, 23);
            this.buttonSort.TabIndex = 6;
            this.buttonSort.Text = "Виконати сортування";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxTop10
            // 
            this.checkBoxTop10.AutoSize = true;
            this.checkBoxTop10.Location = new System.Drawing.Point(550, 226);
            this.checkBoxTop10.Name = "checkBoxTop10";
            this.checkBoxTop10.Size = new System.Drawing.Size(191, 17);
            this.checkBoxTop10.TabIndex = 7;
            this.checkBoxTop10.Text = "Показати лише перші 10 записів";
            this.checkBoxTop10.UseVisualStyleBackColor = true;
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Location = new System.Drawing.Point(0, 265);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.Size = new System.Drawing.Size(544, 183);
            this.dataGridViewResult.TabIndex = 8;
            // 
            // FormQueries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewResult);
            this.Controls.Add(this.checkBoxTop10);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.comboBoxSortOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxSortField);
            this.Controls.Add(this.comboBoxTable);
            this.Controls.Add(this.groupBoxSort);
            this.Name = "FormQueries";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormQueries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cARGOTYPEBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportLogisticDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportLogisticDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportLogisticDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARGOTYPEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARGOTYPEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportLogisticDataSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARGOTYPEBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTable;
        private System.Windows.Forms.BindingSource transportLogisticDataSetBindingSource;
        private TransportLogisticDataSet transportLogisticDataSet;
        private System.Windows.Forms.BindingSource cARGOTYPEBindingSource;
        private TransportLogisticDataSetTableAdapters.CARGO_TYPETableAdapter cARGO_TYPETableAdapter;
        private System.Windows.Forms.BindingSource cARGOTYPEBindingSource2;
        private System.Windows.Forms.BindingSource transportLogisticDataSetBindingSource1;
        private System.Windows.Forms.BindingSource cARGOTYPEBindingSource1;
        private System.Windows.Forms.BindingSource transportLogisticDataSetBindingSource2;
        private System.Windows.Forms.BindingSource cARGOTYPEBindingSource3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSortField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSortOrder;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.CheckBox checkBoxTop10;
        private System.Windows.Forms.DataGridView dataGridViewResult;
    }
}