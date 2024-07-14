namespace WindowsFormsApp1
{
    partial class Report
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
            this.bookingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.g12Report = new WindowsFormsApp1.G12Report();
            this.dJs1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookingsTableAdapter = new WindowsFormsApp1.G12ReportTableAdapters.BookingsTableAdapter();
            this.dJsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dJs1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dJs1TableAdapter = new WindowsFormsApp1.G12ReportTableAdapters.DJs1TableAdapter();
            this.g12Wst2024DataSet = new WindowsFormsApp1.G12Wst2024DataSet();
            this.reviewsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reviewsTableAdapter = new WindowsFormsApp1.G12Wst2024DataSetTableAdapters.ReviewsTableAdapter();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stagenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.djnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.djidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booktypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.organisationnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.djidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g12Report)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dJs1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dJsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dJs1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g12Wst2024DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewsBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookingsBindingSource
            // 
            this.bookingsBindingSource.DataMember = "Bookings";
            this.bookingsBindingSource.DataSource = this.g12Report;
            // 
            // g12Report
            // 
            this.g12Report.DataSetName = "G12Report";
            this.g12Report.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dJs1BindingSource1
            // 
            this.dJs1BindingSource1.DataMember = "DJs1";
            this.dJs1BindingSource1.DataSource = this.g12Report;
            // 
            // bookingsTableAdapter
            // 
            this.bookingsTableAdapter.ClearBeforeFill = true;
            // 
            // dJsBindingSource
            // 
            this.dJsBindingSource.DataMember = "DJs";
            this.dJsBindingSource.DataSource = this.g12Report;
            // 
            // dJs1BindingSource
            // 
            this.dJs1BindingSource.DataMember = "DJs1";
            this.dJs1BindingSource.DataSource = this.g12Report;
            // 
            // dJs1TableAdapter
            // 
            this.dJs1TableAdapter.ClearBeforeFill = true;
            // 
            // g12Wst2024DataSet
            // 
            this.g12Wst2024DataSet.DataSetName = "G12Wst2024DataSet";
            this.g12Wst2024DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reviewsBindingSource
            // 
            this.reviewsBindingSource.DataMember = "Reviews";
            this.reviewsBindingSource.DataSource = this.g12Wst2024DataSet;
            // 
            // reviewsTableAdapter
            // 
            this.reviewsTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.WhatsApp_Image_2024_05_19_at_14_13_22_0f4d60ed;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1689, 597);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Most BOOKED DJS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(413, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "TOP Most booked DJS";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.djidDataGridViewTextBoxColumn1,
            this.djnameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.stagenameDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.dJs1BindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(76, 130);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(996, 342);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "total_bookings";
            this.dataGridViewTextBoxColumn1.HeaderText = "total_bookings";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // stagenameDataGridViewTextBoxColumn
            // 
            this.stagenameDataGridViewTextBoxColumn.DataPropertyName = "Stage_name";
            this.stagenameDataGridViewTextBoxColumn.HeaderText = "Stage_name";
            this.stagenameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stagenameDataGridViewTextBoxColumn.Name = "stagenameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // djnameDataGridViewTextBoxColumn
            // 
            this.djnameDataGridViewTextBoxColumn.DataPropertyName = "Dj_name";
            this.djnameDataGridViewTextBoxColumn.HeaderText = "Dj_name";
            this.djnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.djnameDataGridViewTextBoxColumn.Name = "djnameDataGridViewTextBoxColumn";
            // 
            // djidDataGridViewTextBoxColumn1
            // 
            this.djidDataGridViewTextBoxColumn1.DataPropertyName = "Dj_id";
            this.djidDataGridViewTextBoxColumn1.HeaderText = "Dj_id";
            this.djidDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.djidDataGridViewTextBoxColumn1.Name = "djidDataGridViewTextBoxColumn1";
            this.djidDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(909, 508);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "Done";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.WhatsApp_Image_2024_05_19_at_14_13_22_0f4d60ed;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dateTimePicker2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1689, 597);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View Bookings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Silver;
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(27, 96);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(476, 45);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookidDataGridViewTextBoxColumn,
            this.clientidDataGridViewTextBoxColumn,
            this.djidDataGridViewTextBoxColumn,
            this.eventidDataGridViewTextBoxColumn,
            this.eventdateDataGridViewTextBoxColumn,
            this.eventtypeDataGridViewTextBoxColumn,
            this.eventtimeDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.organisationnameDataGridViewTextBoxColumn,
            this.locationtypeDataGridViewTextBoxColumn,
            this.venueDataGridViewTextBoxColumn,
            this.contactnumberDataGridViewTextBoxColumn,
            this.booktypeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.companynameDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookingsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(8, 170);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1675, 293);
            this.dataGridView1.TabIndex = 1;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // companynameDataGridViewTextBoxColumn
            // 
            this.companynameDataGridViewTextBoxColumn.DataPropertyName = "Company_name";
            this.companynameDataGridViewTextBoxColumn.HeaderText = "Company_name";
            this.companynameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.companynameDataGridViewTextBoxColumn.Name = "companynameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // booktypeDataGridViewTextBoxColumn
            // 
            this.booktypeDataGridViewTextBoxColumn.DataPropertyName = "Book_type";
            this.booktypeDataGridViewTextBoxColumn.HeaderText = "Book_type";
            this.booktypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.booktypeDataGridViewTextBoxColumn.Name = "booktypeDataGridViewTextBoxColumn";
            // 
            // contactnumberDataGridViewTextBoxColumn
            // 
            this.contactnumberDataGridViewTextBoxColumn.DataPropertyName = "Contact_number";
            this.contactnumberDataGridViewTextBoxColumn.HeaderText = "Contact_number";
            this.contactnumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.contactnumberDataGridViewTextBoxColumn.Name = "contactnumberDataGridViewTextBoxColumn";
            // 
            // venueDataGridViewTextBoxColumn
            // 
            this.venueDataGridViewTextBoxColumn.DataPropertyName = "venue";
            this.venueDataGridViewTextBoxColumn.HeaderText = "venue";
            this.venueDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.venueDataGridViewTextBoxColumn.Name = "venueDataGridViewTextBoxColumn";
            // 
            // locationtypeDataGridViewTextBoxColumn
            // 
            this.locationtypeDataGridViewTextBoxColumn.DataPropertyName = "Location_type";
            this.locationtypeDataGridViewTextBoxColumn.HeaderText = "Location_type";
            this.locationtypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.locationtypeDataGridViewTextBoxColumn.Name = "locationtypeDataGridViewTextBoxColumn";
            // 
            // organisationnameDataGridViewTextBoxColumn
            // 
            this.organisationnameDataGridViewTextBoxColumn.DataPropertyName = "Organisation_name";
            this.organisationnameDataGridViewTextBoxColumn.HeaderText = "Organisation_name";
            this.organisationnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.organisationnameDataGridViewTextBoxColumn.Name = "organisationnameDataGridViewTextBoxColumn";
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.durationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            // 
            // eventtimeDataGridViewTextBoxColumn
            // 
            this.eventtimeDataGridViewTextBoxColumn.DataPropertyName = "Event_time";
            this.eventtimeDataGridViewTextBoxColumn.HeaderText = "Event_time";
            this.eventtimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.eventtimeDataGridViewTextBoxColumn.Name = "eventtimeDataGridViewTextBoxColumn";
            // 
            // eventtypeDataGridViewTextBoxColumn
            // 
            this.eventtypeDataGridViewTextBoxColumn.DataPropertyName = "Event_type";
            this.eventtypeDataGridViewTextBoxColumn.HeaderText = "Event_type";
            this.eventtypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.eventtypeDataGridViewTextBoxColumn.Name = "eventtypeDataGridViewTextBoxColumn";
            // 
            // eventdateDataGridViewTextBoxColumn
            // 
            this.eventdateDataGridViewTextBoxColumn.DataPropertyName = "Event_date";
            this.eventdateDataGridViewTextBoxColumn.HeaderText = "Event_date";
            this.eventdateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.eventdateDataGridViewTextBoxColumn.Name = "eventdateDataGridViewTextBoxColumn";
            // 
            // eventidDataGridViewTextBoxColumn
            // 
            this.eventidDataGridViewTextBoxColumn.DataPropertyName = "Event_id";
            this.eventidDataGridViewTextBoxColumn.HeaderText = "Event_id";
            this.eventidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.eventidDataGridViewTextBoxColumn.Name = "eventidDataGridViewTextBoxColumn";
            // 
            // djidDataGridViewTextBoxColumn
            // 
            this.djidDataGridViewTextBoxColumn.DataPropertyName = "Dj_id";
            this.djidDataGridViewTextBoxColumn.HeaderText = "Dj_id";
            this.djidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.djidDataGridViewTextBoxColumn.Name = "djidDataGridViewTextBoxColumn";
            // 
            // clientidDataGridViewTextBoxColumn
            // 
            this.clientidDataGridViewTextBoxColumn.DataPropertyName = "Client_id";
            this.clientidDataGridViewTextBoxColumn.HeaderText = "Client_id";
            this.clientidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.clientidDataGridViewTextBoxColumn.Name = "clientidDataGridViewTextBoxColumn";
            // 
            // bookidDataGridViewTextBoxColumn
            // 
            this.bookidDataGridViewTextBoxColumn.DataPropertyName = "Book_id";
            this.bookidDataGridViewTextBoxColumn.HeaderText = "Book_id";
            this.bookidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bookidDataGridViewTextBoxColumn.Name = "bookidDataGridViewTextBoxColumn";
            this.bookidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(752, 96);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(489, 45);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select START DATE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(745, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select END DATE";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(908, 507);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "GET REPORT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(69, 507);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 33);
            this.button3.TabIndex = 6;
            this.button3.Text = "Menu";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1697, 635);
            this.tabControl1.TabIndex = 0;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1697, 635);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g12Report)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dJs1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dJsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dJs1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g12Wst2024DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewsBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private G12Report g12Report;
        private System.Windows.Forms.BindingSource bookingsBindingSource;
        private G12ReportTableAdapters.BookingsTableAdapter bookingsTableAdapter;
        private System.Windows.Forms.BindingSource dJsBindingSource;
        private System.Windows.Forms.BindingSource dJs1BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalbookingsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dJs1BindingSource1;
        private G12ReportTableAdapters.DJs1TableAdapter dJs1TableAdapter;
        private G12Wst2024DataSet g12Wst2024DataSet;
        private System.Windows.Forms.BindingSource reviewsBindingSource;
        private G12Wst2024DataSetTableAdapters.ReviewsTableAdapter reviewsTableAdapter;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn djidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn djnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stagenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn djidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn organisationnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn booktypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}