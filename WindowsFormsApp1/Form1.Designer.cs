namespace WindowsFormsApp1
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
            this.CargoTypes = new System.Windows.Forms.DataGridView();
            this.cargotypeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitmeasureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialconditionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARGOTYPEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transportLogisticDataSet = new WindowsFormsApp1.TransportLogisticDataSet();
            this.Deliveries = new System.Windows.Forms.DataGridView();
            this.routeidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dELIVERYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Drivers = new System.Windows.Forms.DataGridView();
            this.driveridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licensenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hiredateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dRIVERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Recipients = new System.Windows.Forms.DataGridView();
            this.recipientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactpersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rECIPIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Routes = new System.Windows.Forms.DataGridView();
            this.routeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departurepointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationpointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departuredateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivaldateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distancekmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routestatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOUTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rOUTETableAdapter = new WindowsFormsApp1.TransportLogisticDataSetTableAdapters.ROUTETableAdapter();
            this.cARGO_TYPETableAdapter = new WindowsFormsApp1.TransportLogisticDataSetTableAdapters.CARGO_TYPETableAdapter();
            this.dELIVERYTableAdapter = new WindowsFormsApp1.TransportLogisticDataSetTableAdapters.DELIVERYTableAdapter();
            this.rECIPIENTTableAdapter = new WindowsFormsApp1.TransportLogisticDataSetTableAdapters.RECIPIENTTableAdapter();
            this.dRIVERTableAdapter = new WindowsFormsApp1.TransportLogisticDataSetTableAdapters.DRIVERTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.редакторТаблицьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типиВантажуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.доставкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.водіїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.одержувачіToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.маршрутиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.постачальникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.транспортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запитиДоБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.CargoTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARGOTYPEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportLogisticDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Deliveries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dELIVERYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dRIVERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Recipients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rECIPIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Routes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOUTEBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CargoTypes
            // 
            this.CargoTypes.AutoGenerateColumns = false;
            this.CargoTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CargoTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cargotypeidDataGridViewTextBoxColumn,
            this.typenameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.unitmeasureDataGridViewTextBoxColumn,
            this.specialconditionsDataGridViewTextBoxColumn});
            this.CargoTypes.DataSource = this.cARGOTYPEBindingSource;
            this.CargoTypes.Location = new System.Drawing.Point(0, 27);
            this.CargoTypes.Name = "CargoTypes";
            this.CargoTypes.Size = new System.Drawing.Size(240, 150);
            this.CargoTypes.TabIndex = 0;
            // 
            // cargotypeidDataGridViewTextBoxColumn
            // 
            this.cargotypeidDataGridViewTextBoxColumn.DataPropertyName = "cargo_type_id";
            this.cargotypeidDataGridViewTextBoxColumn.HeaderText = "cargo_type_id";
            this.cargotypeidDataGridViewTextBoxColumn.Name = "cargotypeidDataGridViewTextBoxColumn";
            this.cargotypeidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typenameDataGridViewTextBoxColumn
            // 
            this.typenameDataGridViewTextBoxColumn.DataPropertyName = "type_name";
            this.typenameDataGridViewTextBoxColumn.HeaderText = "type_name";
            this.typenameDataGridViewTextBoxColumn.Name = "typenameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // unitmeasureDataGridViewTextBoxColumn
            // 
            this.unitmeasureDataGridViewTextBoxColumn.DataPropertyName = "unit_measure";
            this.unitmeasureDataGridViewTextBoxColumn.HeaderText = "unit_measure";
            this.unitmeasureDataGridViewTextBoxColumn.Name = "unitmeasureDataGridViewTextBoxColumn";
            // 
            // specialconditionsDataGridViewTextBoxColumn
            // 
            this.specialconditionsDataGridViewTextBoxColumn.DataPropertyName = "special_conditions";
            this.specialconditionsDataGridViewTextBoxColumn.HeaderText = "special_conditions";
            this.specialconditionsDataGridViewTextBoxColumn.Name = "specialconditionsDataGridViewTextBoxColumn";
            // 
            // cARGOTYPEBindingSource
            // 
            this.cARGOTYPEBindingSource.DataMember = "CARGO_TYPE";
            this.cARGOTYPEBindingSource.DataSource = this.transportLogisticDataSet;
            // 
            // transportLogisticDataSet
            // 
            this.transportLogisticDataSet.DataSetName = "TransportLogisticDataSet";
            this.transportLogisticDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Deliveries
            // 
            this.Deliveries.AutoGenerateColumns = false;
            this.Deliveries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Deliveries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.routeidDataGridViewTextBoxColumn1});
            this.Deliveries.DataSource = this.dELIVERYBindingSource;
            this.Deliveries.Location = new System.Drawing.Point(254, 27);
            this.Deliveries.Name = "Deliveries";
            this.Deliveries.Size = new System.Drawing.Size(240, 150);
            this.Deliveries.TabIndex = 1;
            // 
            // routeidDataGridViewTextBoxColumn1
            // 
            this.routeidDataGridViewTextBoxColumn1.DataPropertyName = "route_id";
            this.routeidDataGridViewTextBoxColumn1.HeaderText = "route_id";
            this.routeidDataGridViewTextBoxColumn1.Name = "routeidDataGridViewTextBoxColumn1";
            this.routeidDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dELIVERYBindingSource
            // 
            this.dELIVERYBindingSource.DataMember = "DELIVERY";
            this.dELIVERYBindingSource.DataSource = this.transportLogisticDataSet;
            // 
            // Drivers
            // 
            this.Drivers.AutoGenerateColumns = false;
            this.Drivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Drivers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.driveridDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.licensenumberDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn1,
            this.hiredateDataGridViewTextBoxColumn});
            this.Drivers.DataSource = this.dRIVERBindingSource;
            this.Drivers.Location = new System.Drawing.Point(254, 206);
            this.Drivers.Name = "Drivers";
            this.Drivers.Size = new System.Drawing.Size(240, 150);
            this.Drivers.TabIndex = 2;
            // 
            // driveridDataGridViewTextBoxColumn
            // 
            this.driveridDataGridViewTextBoxColumn.DataPropertyName = "driver_id";
            this.driveridDataGridViewTextBoxColumn.HeaderText = "driver_id";
            this.driveridDataGridViewTextBoxColumn.Name = "driveridDataGridViewTextBoxColumn";
            this.driveridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "first_name";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "last_name";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // licensenumberDataGridViewTextBoxColumn
            // 
            this.licensenumberDataGridViewTextBoxColumn.DataPropertyName = "license_number";
            this.licensenumberDataGridViewTextBoxColumn.HeaderText = "license_number";
            this.licensenumberDataGridViewTextBoxColumn.Name = "licensenumberDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn1
            // 
            this.phoneDataGridViewTextBoxColumn1.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn1.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn1.Name = "phoneDataGridViewTextBoxColumn1";
            // 
            // hiredateDataGridViewTextBoxColumn
            // 
            this.hiredateDataGridViewTextBoxColumn.DataPropertyName = "hire_date";
            this.hiredateDataGridViewTextBoxColumn.HeaderText = "hire_date";
            this.hiredateDataGridViewTextBoxColumn.Name = "hiredateDataGridViewTextBoxColumn";
            // 
            // dRIVERBindingSource
            // 
            this.dRIVERBindingSource.DataMember = "DRIVER";
            this.dRIVERBindingSource.DataSource = this.transportLogisticDataSet;
            // 
            // Recipients
            // 
            this.Recipients.AutoGenerateColumns = false;
            this.Recipients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Recipients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recipientidDataGridViewTextBoxColumn,
            this.companynameDataGridViewTextBoxColumn,
            this.contactpersonDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.Recipients.DataSource = this.rECIPIENTBindingSource;
            this.Recipients.Location = new System.Drawing.Point(0, 206);
            this.Recipients.Name = "Recipients";
            this.Recipients.Size = new System.Drawing.Size(240, 150);
            this.Recipients.TabIndex = 3;
            // 
            // recipientidDataGridViewTextBoxColumn
            // 
            this.recipientidDataGridViewTextBoxColumn.DataPropertyName = "recipient_id";
            this.recipientidDataGridViewTextBoxColumn.HeaderText = "recipient_id";
            this.recipientidDataGridViewTextBoxColumn.Name = "recipientidDataGridViewTextBoxColumn";
            this.recipientidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companynameDataGridViewTextBoxColumn
            // 
            this.companynameDataGridViewTextBoxColumn.DataPropertyName = "company_name";
            this.companynameDataGridViewTextBoxColumn.HeaderText = "company_name";
            this.companynameDataGridViewTextBoxColumn.Name = "companynameDataGridViewTextBoxColumn";
            // 
            // contactpersonDataGridViewTextBoxColumn
            // 
            this.contactpersonDataGridViewTextBoxColumn.DataPropertyName = "contact_person";
            this.contactpersonDataGridViewTextBoxColumn.HeaderText = "contact_person";
            this.contactpersonDataGridViewTextBoxColumn.Name = "contactpersonDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // rECIPIENTBindingSource
            // 
            this.rECIPIENTBindingSource.DataMember = "RECIPIENT";
            this.rECIPIENTBindingSource.DataSource = this.transportLogisticDataSet;
            // 
            // Routes
            // 
            this.Routes.AutoGenerateColumns = false;
            this.Routes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Routes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.routeidDataGridViewTextBoxColumn,
            this.vehicleidDataGridViewTextBoxColumn,
            this.departurepointDataGridViewTextBoxColumn,
            this.destinationpointDataGridViewTextBoxColumn,
            this.departuredateDataGridViewTextBoxColumn,
            this.arrivaldateDataGridViewTextBoxColumn,
            this.distancekmDataGridViewTextBoxColumn,
            this.routestatusDataGridViewTextBoxColumn});
            this.Routes.DataSource = this.rOUTEBindingSource;
            this.Routes.Location = new System.Drawing.Point(511, 27);
            this.Routes.Name = "Routes";
            this.Routes.Size = new System.Drawing.Size(240, 150);
            this.Routes.TabIndex = 4;
            // 
            // routeidDataGridViewTextBoxColumn
            // 
            this.routeidDataGridViewTextBoxColumn.DataPropertyName = "route_id";
            this.routeidDataGridViewTextBoxColumn.HeaderText = "route_id";
            this.routeidDataGridViewTextBoxColumn.Name = "routeidDataGridViewTextBoxColumn";
            this.routeidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vehicleidDataGridViewTextBoxColumn
            // 
            this.vehicleidDataGridViewTextBoxColumn.DataPropertyName = "vehicle_id";
            this.vehicleidDataGridViewTextBoxColumn.HeaderText = "vehicle_id";
            this.vehicleidDataGridViewTextBoxColumn.Name = "vehicleidDataGridViewTextBoxColumn";
            // 
            // departurepointDataGridViewTextBoxColumn
            // 
            this.departurepointDataGridViewTextBoxColumn.DataPropertyName = "departure_point";
            this.departurepointDataGridViewTextBoxColumn.HeaderText = "departure_point";
            this.departurepointDataGridViewTextBoxColumn.Name = "departurepointDataGridViewTextBoxColumn";
            // 
            // destinationpointDataGridViewTextBoxColumn
            // 
            this.destinationpointDataGridViewTextBoxColumn.DataPropertyName = "destination_point";
            this.destinationpointDataGridViewTextBoxColumn.HeaderText = "destination_point";
            this.destinationpointDataGridViewTextBoxColumn.Name = "destinationpointDataGridViewTextBoxColumn";
            // 
            // departuredateDataGridViewTextBoxColumn
            // 
            this.departuredateDataGridViewTextBoxColumn.DataPropertyName = "departure_date";
            this.departuredateDataGridViewTextBoxColumn.HeaderText = "departure_date";
            this.departuredateDataGridViewTextBoxColumn.Name = "departuredateDataGridViewTextBoxColumn";
            // 
            // arrivaldateDataGridViewTextBoxColumn
            // 
            this.arrivaldateDataGridViewTextBoxColumn.DataPropertyName = "arrival_date";
            this.arrivaldateDataGridViewTextBoxColumn.HeaderText = "arrival_date";
            this.arrivaldateDataGridViewTextBoxColumn.Name = "arrivaldateDataGridViewTextBoxColumn";
            // 
            // distancekmDataGridViewTextBoxColumn
            // 
            this.distancekmDataGridViewTextBoxColumn.DataPropertyName = "distance_km";
            this.distancekmDataGridViewTextBoxColumn.HeaderText = "distance_km";
            this.distancekmDataGridViewTextBoxColumn.Name = "distancekmDataGridViewTextBoxColumn";
            // 
            // routestatusDataGridViewTextBoxColumn
            // 
            this.routestatusDataGridViewTextBoxColumn.DataPropertyName = "route_status";
            this.routestatusDataGridViewTextBoxColumn.HeaderText = "route_status";
            this.routestatusDataGridViewTextBoxColumn.Name = "routestatusDataGridViewTextBoxColumn";
            // 
            // rOUTEBindingSource
            // 
            this.rOUTEBindingSource.DataMember = "ROUTE";
            this.rOUTEBindingSource.DataSource = this.transportLogisticDataSet;
            // 
            // rOUTETableAdapter
            // 
            this.rOUTETableAdapter.ClearBeforeFill = true;
            // 
            // cARGO_TYPETableAdapter
            // 
            this.cARGO_TYPETableAdapter.ClearBeforeFill = true;
            // 
            // dELIVERYTableAdapter
            // 
            this.dELIVERYTableAdapter.ClearBeforeFill = true;
            // 
            // rECIPIENTTableAdapter
            // 
            this.rECIPIENTTableAdapter.ClearBeforeFill = true;
            // 
            // dRIVERTableAdapter
            // 
            this.dRIVERTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редакторТаблицьToolStripMenuItem,
            this.запитиДоБДToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // редакторТаблицьToolStripMenuItem
            // 
            this.редакторТаблицьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.типиВантажуToolStripMenuItem,
            this.доставкиToolStripMenuItem,
            this.водіїToolStripMenuItem,
            this.одержувачіToolStripMenuItem,
            this.маршрутиToolStripMenuItem,
            this.постачальникиToolStripMenuItem,
            this.транспортToolStripMenuItem});
            this.редакторТаблицьToolStripMenuItem.Name = "редакторТаблицьToolStripMenuItem";
            this.редакторТаблицьToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.редакторТаблицьToolStripMenuItem.Text = "Робота з табицями";
            // 
            // типиВантажуToolStripMenuItem
            // 
            this.типиВантажуToolStripMenuItem.Name = "типиВантажуToolStripMenuItem";
            this.типиВантажуToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.типиВантажуToolStripMenuItem.Text = "Типи вантажу";
            this.типиВантажуToolStripMenuItem.Click += new System.EventHandler(this.типиВантажуToolStripMenuItem_Click);
            // 
            // доставкиToolStripMenuItem
            // 
            this.доставкиToolStripMenuItem.Name = "доставкиToolStripMenuItem";
            this.доставкиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.доставкиToolStripMenuItem.Text = "Доставки ";
            this.доставкиToolStripMenuItem.Click += new System.EventHandler(this.доставкиToolStripMenuItem_Click);
            // 
            // водіїToolStripMenuItem
            // 
            this.водіїToolStripMenuItem.Name = "водіїToolStripMenuItem";
            this.водіїToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.водіїToolStripMenuItem.Text = "Водії ";
            this.водіїToolStripMenuItem.Click += new System.EventHandler(this.водіїToolStripMenuItem_Click);
            // 
            // одержувачіToolStripMenuItem
            // 
            this.одержувачіToolStripMenuItem.Name = "одержувачіToolStripMenuItem";
            this.одержувачіToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.одержувачіToolStripMenuItem.Text = "Одержувачі ";
            this.одержувачіToolStripMenuItem.Click += new System.EventHandler(this.одержувачіToolStripMenuItem_Click);
            // 
            // маршрутиToolStripMenuItem
            // 
            this.маршрутиToolStripMenuItem.Name = "маршрутиToolStripMenuItem";
            this.маршрутиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.маршрутиToolStripMenuItem.Text = "Маршрути ";
            this.маршрутиToolStripMenuItem.Click += new System.EventHandler(this.маршрутиToolStripMenuItem_Click);
            // 
            // постачальникиToolStripMenuItem
            // 
            this.постачальникиToolStripMenuItem.Name = "постачальникиToolStripMenuItem";
            this.постачальникиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.постачальникиToolStripMenuItem.Text = "Постачальники";
            this.постачальникиToolStripMenuItem.Click += new System.EventHandler(this.постачальникиToolStripMenuItem_Click);
            // 
            // транспортToolStripMenuItem
            // 
            this.транспортToolStripMenuItem.Name = "транспортToolStripMenuItem";
            this.транспортToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.транспортToolStripMenuItem.Text = "Транспорт";
            this.транспортToolStripMenuItem.Click += new System.EventHandler(this.транспортToolStripMenuItem_Click);
            // 
            // запитиДоБДToolStripMenuItem
            // 
            this.запитиДоБДToolStripMenuItem.Name = "запитиДоБДToolStripMenuItem";
            this.запитиДоБДToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.запитиДоБДToolStripMenuItem.Text = "Запити до БД";
            this.запитиДоБДToolStripMenuItem.Click += new System.EventHandler(this.запитиДоБДToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Routes);
            this.Controls.Add(this.Recipients);
            this.Controls.Add(this.Drivers);
            this.Controls.Add(this.Deliveries);
            this.Controls.Add(this.CargoTypes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "База даних";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CargoTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARGOTYPEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportLogisticDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Deliveries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dELIVERYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dRIVERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Recipients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rECIPIENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Routes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOUTEBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CargoTypes;
        private System.Windows.Forms.DataGridView Deliveries;
        private System.Windows.Forms.DataGridView Drivers;
        private System.Windows.Forms.DataGridView Recipients;
        private System.Windows.Forms.DataGridView Routes;
        private TransportLogisticDataSet transportLogisticDataSet;
        private System.Windows.Forms.BindingSource rOUTEBindingSource;
        private TransportLogisticDataSetTableAdapters.ROUTETableAdapter rOUTETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departurepointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationpointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departuredateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivaldateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distancekmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routestatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cARGOTYPEBindingSource;
        private TransportLogisticDataSetTableAdapters.CARGO_TYPETableAdapter cARGO_TYPETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargotypeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitmeasureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialconditionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource dELIVERYBindingSource;
        private TransportLogisticDataSetTableAdapters.DELIVERYTableAdapter dELIVERYTableAdapter;
        private System.Windows.Forms.BindingSource rECIPIENTBindingSource;
        private TransportLogisticDataSetTableAdapters.RECIPIENTTableAdapter rECIPIENTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn recipientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactpersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dRIVERBindingSource;
        private TransportLogisticDataSetTableAdapters.DRIVERTableAdapter dRIVERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn driveridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licensenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hiredateDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem редакторТаблицьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типиВантажуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem доставкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem водіїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem одержувачіToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem маршрутиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem постачальникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem транспортToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запитиДоБДToolStripMenuItem;
    }
}

