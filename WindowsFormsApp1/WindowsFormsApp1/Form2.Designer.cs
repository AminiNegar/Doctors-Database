namespace WindowsFormsApp1
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.project2DataSet1 = new WindowsFormsApp1.project2DataSet1();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorTableAdapter = new WindowsFormsApp1.project2DataSet1TableAdapters.DoctorTableAdapter();
            this.sSNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearsOfExperienceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sSNDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.specialtyDataGridViewTextBoxColumn,
            this.yearsOfExperienceDataGridViewTextBoxColumn,
            this.phoneNumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.doctorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(954, 377);
            this.dataGridView1.TabIndex = 0;
            // 
            // project2DataSet1
            // 
            this.project2DataSet1.DataSetName = "project2DataSet1";
            this.project2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            this.doctorBindingSource.DataSource = this.project2DataSet1;
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // sSNDataGridViewTextBoxColumn
            // 
            this.sSNDataGridViewTextBoxColumn.DataPropertyName = "SSN";
            this.sSNDataGridViewTextBoxColumn.HeaderText = "SSN";
            this.sSNDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sSNDataGridViewTextBoxColumn.Name = "sSNDataGridViewTextBoxColumn";
            this.sSNDataGridViewTextBoxColumn.ReadOnly = true;
            this.sSNDataGridViewTextBoxColumn.Width = 150;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // specialtyDataGridViewTextBoxColumn
            // 
            this.specialtyDataGridViewTextBoxColumn.DataPropertyName = "Specialty";
            this.specialtyDataGridViewTextBoxColumn.HeaderText = "Specialty";
            this.specialtyDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.specialtyDataGridViewTextBoxColumn.Name = "specialtyDataGridViewTextBoxColumn";
            this.specialtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.specialtyDataGridViewTextBoxColumn.Width = 150;
            // 
            // yearsOfExperienceDataGridViewTextBoxColumn
            // 
            this.yearsOfExperienceDataGridViewTextBoxColumn.DataPropertyName = "YearsOfExperience";
            this.yearsOfExperienceDataGridViewTextBoxColumn.HeaderText = "YearsOfExperience";
            this.yearsOfExperienceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.yearsOfExperienceDataGridViewTextBoxColumn.Name = "yearsOfExperienceDataGridViewTextBoxColumn";
            this.yearsOfExperienceDataGridViewTextBoxColumn.ReadOnly = true;
            this.yearsOfExperienceDataGridViewTextBoxColumn.Width = 150;
            // 
            // phoneNumDataGridViewTextBoxColumn
            // 
            this.phoneNumDataGridViewTextBoxColumn.DataPropertyName = "PhoneNum";
            this.phoneNumDataGridViewTextBoxColumn.HeaderText = "PhoneNum";
            this.phoneNumDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phoneNumDataGridViewTextBoxColumn.Name = "phoneNumDataGridViewTextBoxColumn";
            this.phoneNumDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneNumDataGridViewTextBoxColumn.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(989, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private project2DataSet1 project2DataSet1;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private project2DataSet1TableAdapters.DoctorTableAdapter doctorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearsOfExperienceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}