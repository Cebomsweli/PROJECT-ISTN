
namespace WindowsFormsApp1
{
    partial class ViewDJ
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
            this.djidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.djnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stagenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localIndoorRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localOutDoorRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internationalIndoorRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internationalOutDoorRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instagramAccountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faceBookAccountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xAccountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.djimageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dJStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dJsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.g12Wst2024DataSet = new WindowsFormsApp1.G12Wst2024DataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.dJsTableAdapter = new WindowsFormsApp1.G12Wst2024DataSetTableAdapters.DJsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dJsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g12Wst2024DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(615, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "List of All DJS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.djidDataGridViewTextBoxColumn,
            this.djnameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.stagenameDataGridViewTextBoxColumn,
            this.sAIDDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telephoneNoDataGridViewTextBoxColumn,
            this.localIndoorRateDataGridViewTextBoxColumn,
            this.localOutDoorRateDataGridViewTextBoxColumn,
            this.internationalIndoorRateDataGridViewTextBoxColumn,
            this.internationalOutDoorRateDataGridViewTextBoxColumn,
            this.instagramAccountDataGridViewTextBoxColumn,
            this.faceBookAccountDataGridViewTextBoxColumn,
            this.xAccountDataGridViewTextBoxColumn,
            this.djimageDataGridViewTextBoxColumn,
            this.dJStatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dJsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(49, 90);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1315, 337);
            this.dataGridView1.TabIndex = 3;
            // 
            // djidDataGridViewTextBoxColumn
            // 
            this.djidDataGridViewTextBoxColumn.DataPropertyName = "Dj_id";
            this.djidDataGridViewTextBoxColumn.HeaderText = "Dj_id";
            this.djidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.djidDataGridViewTextBoxColumn.Name = "djidDataGridViewTextBoxColumn";
            this.djidDataGridViewTextBoxColumn.ReadOnly = true;
            this.djidDataGridViewTextBoxColumn.Width = 125;
            // 
            // djnameDataGridViewTextBoxColumn
            // 
            this.djnameDataGridViewTextBoxColumn.DataPropertyName = "Dj_name";
            this.djnameDataGridViewTextBoxColumn.HeaderText = "Dj_name";
            this.djnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.djnameDataGridViewTextBoxColumn.Name = "djnameDataGridViewTextBoxColumn";
            this.djnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // stagenameDataGridViewTextBoxColumn
            // 
            this.stagenameDataGridViewTextBoxColumn.DataPropertyName = "Stage_name";
            this.stagenameDataGridViewTextBoxColumn.HeaderText = "Stage_name";
            this.stagenameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stagenameDataGridViewTextBoxColumn.Name = "stagenameDataGridViewTextBoxColumn";
            this.stagenameDataGridViewTextBoxColumn.Width = 125;
            // 
            // sAIDDataGridViewTextBoxColumn
            // 
            this.sAIDDataGridViewTextBoxColumn.DataPropertyName = "SAID";
            this.sAIDDataGridViewTextBoxColumn.HeaderText = "SAID";
            this.sAIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sAIDDataGridViewTextBoxColumn.Name = "sAIDDataGridViewTextBoxColumn";
            this.sAIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // telephoneNoDataGridViewTextBoxColumn
            // 
            this.telephoneNoDataGridViewTextBoxColumn.DataPropertyName = "TelephoneNo";
            this.telephoneNoDataGridViewTextBoxColumn.HeaderText = "TelephoneNo";
            this.telephoneNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telephoneNoDataGridViewTextBoxColumn.Name = "telephoneNoDataGridViewTextBoxColumn";
            this.telephoneNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // localIndoorRateDataGridViewTextBoxColumn
            // 
            this.localIndoorRateDataGridViewTextBoxColumn.DataPropertyName = "LocalIndoorRate";
            this.localIndoorRateDataGridViewTextBoxColumn.HeaderText = "LocalIndoorRate";
            this.localIndoorRateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.localIndoorRateDataGridViewTextBoxColumn.Name = "localIndoorRateDataGridViewTextBoxColumn";
            this.localIndoorRateDataGridViewTextBoxColumn.Width = 125;
            // 
            // localOutDoorRateDataGridViewTextBoxColumn
            // 
            this.localOutDoorRateDataGridViewTextBoxColumn.DataPropertyName = "LocalOutDoorRate";
            this.localOutDoorRateDataGridViewTextBoxColumn.HeaderText = "LocalOutDoorRate";
            this.localOutDoorRateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.localOutDoorRateDataGridViewTextBoxColumn.Name = "localOutDoorRateDataGridViewTextBoxColumn";
            this.localOutDoorRateDataGridViewTextBoxColumn.Width = 125;
            // 
            // internationalIndoorRateDataGridViewTextBoxColumn
            // 
            this.internationalIndoorRateDataGridViewTextBoxColumn.DataPropertyName = "InternationalIndoorRate";
            this.internationalIndoorRateDataGridViewTextBoxColumn.HeaderText = "InternationalIndoorRate";
            this.internationalIndoorRateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.internationalIndoorRateDataGridViewTextBoxColumn.Name = "internationalIndoorRateDataGridViewTextBoxColumn";
            this.internationalIndoorRateDataGridViewTextBoxColumn.Width = 125;
            // 
            // internationalOutDoorRateDataGridViewTextBoxColumn
            // 
            this.internationalOutDoorRateDataGridViewTextBoxColumn.DataPropertyName = "InternationalOutDoorRate";
            this.internationalOutDoorRateDataGridViewTextBoxColumn.HeaderText = "InternationalOutDoorRate";
            this.internationalOutDoorRateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.internationalOutDoorRateDataGridViewTextBoxColumn.Name = "internationalOutDoorRateDataGridViewTextBoxColumn";
            this.internationalOutDoorRateDataGridViewTextBoxColumn.Width = 125;
            // 
            // instagramAccountDataGridViewTextBoxColumn
            // 
            this.instagramAccountDataGridViewTextBoxColumn.DataPropertyName = "InstagramAccount";
            this.instagramAccountDataGridViewTextBoxColumn.HeaderText = "InstagramAccount";
            this.instagramAccountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.instagramAccountDataGridViewTextBoxColumn.Name = "instagramAccountDataGridViewTextBoxColumn";
            this.instagramAccountDataGridViewTextBoxColumn.Width = 125;
            // 
            // faceBookAccountDataGridViewTextBoxColumn
            // 
            this.faceBookAccountDataGridViewTextBoxColumn.DataPropertyName = "FaceBookAccount";
            this.faceBookAccountDataGridViewTextBoxColumn.HeaderText = "FaceBookAccount";
            this.faceBookAccountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.faceBookAccountDataGridViewTextBoxColumn.Name = "faceBookAccountDataGridViewTextBoxColumn";
            this.faceBookAccountDataGridViewTextBoxColumn.Width = 125;
            // 
            // xAccountDataGridViewTextBoxColumn
            // 
            this.xAccountDataGridViewTextBoxColumn.DataPropertyName = "XAccount";
            this.xAccountDataGridViewTextBoxColumn.HeaderText = "XAccount";
            this.xAccountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.xAccountDataGridViewTextBoxColumn.Name = "xAccountDataGridViewTextBoxColumn";
            this.xAccountDataGridViewTextBoxColumn.Width = 125;
            // 
            // djimageDataGridViewTextBoxColumn
            // 
            this.djimageDataGridViewTextBoxColumn.DataPropertyName = "dj_image";
            this.djimageDataGridViewTextBoxColumn.HeaderText = "dj_image";
            this.djimageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.djimageDataGridViewTextBoxColumn.Name = "djimageDataGridViewTextBoxColumn";
            this.djimageDataGridViewTextBoxColumn.Width = 125;
            // 
            // dJStatusDataGridViewTextBoxColumn
            // 
            this.dJStatusDataGridViewTextBoxColumn.DataPropertyName = "DJ_Status";
            this.dJStatusDataGridViewTextBoxColumn.HeaderText = "DJ_Status";
            this.dJStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dJStatusDataGridViewTextBoxColumn.Name = "dJStatusDataGridViewTextBoxColumn";
            this.dJStatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // dJsBindingSource
            // 
            this.dJsBindingSource.DataMember = "DJs";
            this.dJsBindingSource.DataSource = this.g12Wst2024DataSet;
            // 
            // g12Wst2024DataSet
            // 
            this.g12Wst2024DataSet.DataSetName = "G12Wst2024DataSet";
            this.g12Wst2024DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(361, 460);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dJsTableAdapter
            // 
            this.dJsTableAdapter.ClearBeforeFill = true;
            // 
            // ViewDJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.WhatsApp_Image_2024_05_19_at_14_13_22_0f4d60ed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1519, 527);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ViewDJ";
            this.Text = "ViewDJ";
            this.Load += new System.EventHandler(this.ViewDJ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dJsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g12Wst2024DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private G12Wst2024DataSet g12Wst2024DataSet;
        private System.Windows.Forms.BindingSource dJsBindingSource;
        private G12Wst2024DataSetTableAdapters.DJsTableAdapter dJsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn djidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn djnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stagenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localIndoorRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localOutDoorRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn internationalIndoorRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn internationalOutDoorRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instagramAccountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faceBookAccountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xAccountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn djimageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dJStatusDataGridViewTextBoxColumn;
    }
}