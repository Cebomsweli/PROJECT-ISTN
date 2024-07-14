
namespace WindowsFormsApp1
{
    partial class viewbookings
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.g12Wst2024DataSet = new WindowsFormsApp1.G12Wst2024DataSet();
            this.bookingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingsTableAdapter = new WindowsFormsApp1.G12Wst2024DataSetTableAdapters.BookingsTableAdapter();
            this.bookidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.djidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.organisationnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booktypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g12Wst2024DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(527, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "List of All Bookings";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(107, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1242, 364);
            this.dataGridView1.TabIndex = 4;
            // 
            // g12Wst2024DataSet
            // 
            this.g12Wst2024DataSet.DataSetName = "G12Wst2024DataSet";
            this.g12Wst2024DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingsBindingSource
            // 
            this.bookingsBindingSource.DataMember = "Bookings";
            this.bookingsBindingSource.DataSource = this.g12Wst2024DataSet;
            // 
            // bookingsTableAdapter
            // 
            this.bookingsTableAdapter.ClearBeforeFill = true;
            // 
            // bookidDataGridViewTextBoxColumn
            // 
            this.bookidDataGridViewTextBoxColumn.DataPropertyName = "Book_id";
            this.bookidDataGridViewTextBoxColumn.HeaderText = "Book_id";
            this.bookidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookidDataGridViewTextBoxColumn.Name = "bookidDataGridViewTextBoxColumn";
            this.bookidDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookidDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientidDataGridViewTextBoxColumn
            // 
            this.clientidDataGridViewTextBoxColumn.DataPropertyName = "Client_id";
            this.clientidDataGridViewTextBoxColumn.HeaderText = "Client_id";
            this.clientidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientidDataGridViewTextBoxColumn.Name = "clientidDataGridViewTextBoxColumn";
            this.clientidDataGridViewTextBoxColumn.Width = 125;
            // 
            // djidDataGridViewTextBoxColumn
            // 
            this.djidDataGridViewTextBoxColumn.DataPropertyName = "Dj_id";
            this.djidDataGridViewTextBoxColumn.HeaderText = "Dj_id";
            this.djidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.djidDataGridViewTextBoxColumn.Name = "djidDataGridViewTextBoxColumn";
            this.djidDataGridViewTextBoxColumn.Width = 125;
            // 
            // eventidDataGridViewTextBoxColumn
            // 
            this.eventidDataGridViewTextBoxColumn.DataPropertyName = "Event_id";
            this.eventidDataGridViewTextBoxColumn.HeaderText = "Event_id";
            this.eventidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eventidDataGridViewTextBoxColumn.Name = "eventidDataGridViewTextBoxColumn";
            this.eventidDataGridViewTextBoxColumn.Width = 125;
            // 
            // eventdateDataGridViewTextBoxColumn
            // 
            this.eventdateDataGridViewTextBoxColumn.DataPropertyName = "Event_date";
            this.eventdateDataGridViewTextBoxColumn.HeaderText = "Event_date";
            this.eventdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eventdateDataGridViewTextBoxColumn.Name = "eventdateDataGridViewTextBoxColumn";
            this.eventdateDataGridViewTextBoxColumn.Width = 125;
            // 
            // eventtypeDataGridViewTextBoxColumn
            // 
            this.eventtypeDataGridViewTextBoxColumn.DataPropertyName = "Event_type";
            this.eventtypeDataGridViewTextBoxColumn.HeaderText = "Event_type";
            this.eventtypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eventtypeDataGridViewTextBoxColumn.Name = "eventtypeDataGridViewTextBoxColumn";
            this.eventtypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // eventtimeDataGridViewTextBoxColumn
            // 
            this.eventtimeDataGridViewTextBoxColumn.DataPropertyName = "Event_time";
            this.eventtimeDataGridViewTextBoxColumn.HeaderText = "Event_time";
            this.eventtimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eventtimeDataGridViewTextBoxColumn.Name = "eventtimeDataGridViewTextBoxColumn";
            this.eventtimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.durationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.Width = 125;
            // 
            // organisationnameDataGridViewTextBoxColumn
            // 
            this.organisationnameDataGridViewTextBoxColumn.DataPropertyName = "Organisation_name";
            this.organisationnameDataGridViewTextBoxColumn.HeaderText = "Organisation_name";
            this.organisationnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.organisationnameDataGridViewTextBoxColumn.Name = "organisationnameDataGridViewTextBoxColumn";
            this.organisationnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // locationtypeDataGridViewTextBoxColumn
            // 
            this.locationtypeDataGridViewTextBoxColumn.DataPropertyName = "Location_type";
            this.locationtypeDataGridViewTextBoxColumn.HeaderText = "Location_type";
            this.locationtypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locationtypeDataGridViewTextBoxColumn.Name = "locationtypeDataGridViewTextBoxColumn";
            this.locationtypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // venueDataGridViewTextBoxColumn
            // 
            this.venueDataGridViewTextBoxColumn.DataPropertyName = "venue";
            this.venueDataGridViewTextBoxColumn.HeaderText = "venue";
            this.venueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.venueDataGridViewTextBoxColumn.Name = "venueDataGridViewTextBoxColumn";
            this.venueDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactnumberDataGridViewTextBoxColumn
            // 
            this.contactnumberDataGridViewTextBoxColumn.DataPropertyName = "Contact_number";
            this.contactnumberDataGridViewTextBoxColumn.HeaderText = "Contact_number";
            this.contactnumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactnumberDataGridViewTextBoxColumn.Name = "contactnumberDataGridViewTextBoxColumn";
            this.contactnumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // booktypeDataGridViewTextBoxColumn
            // 
            this.booktypeDataGridViewTextBoxColumn.DataPropertyName = "Book_type";
            this.booktypeDataGridViewTextBoxColumn.HeaderText = "Book_type";
            this.booktypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.booktypeDataGridViewTextBoxColumn.Name = "booktypeDataGridViewTextBoxColumn";
            this.booktypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // companynameDataGridViewTextBoxColumn
            // 
            this.companynameDataGridViewTextBoxColumn.DataPropertyName = "Company_name";
            this.companynameDataGridViewTextBoxColumn.HeaderText = "Company_name";
            this.companynameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.companynameDataGridViewTextBoxColumn.Name = "companynameDataGridViewTextBoxColumn";
            this.companynameDataGridViewTextBoxColumn.Width = 125;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(260, 633);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewbookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.WhatsApp_Image_2024_05_19_at_14_13_22_0f4d60ed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1446, 743);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "viewbookings";
            this.Text = "viewbookings";
            this.Load += new System.EventHandler(this.viewbookings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g12Wst2024DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private G12Wst2024DataSet g12Wst2024DataSet;
        private System.Windows.Forms.BindingSource bookingsBindingSource;
        private G12Wst2024DataSetTableAdapters.BookingsTableAdapter bookingsTableAdapter;
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
        private System.Windows.Forms.Button button1;
    }
}