namespace productivity_tracker
{
    partial class FormProductivityTracker
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.radioButtonWork = new System.Windows.Forms.RadioButton();
            this.panelType = new System.Windows.Forms.Panel();
            this.radioButtonLeisure = new System.Windows.Forms.RadioButton();
            this.radioButtonPersonal = new System.Windows.Forms.RadioButton();
            this.dateTimePickerDuration = new System.Windows.Forms.DateTimePicker();
            this.panelDuration = new System.Windows.Forms.Panel();
            this.panelDescription = new System.Windows.Forms.Panel();
            this.dateTimePickerStartTime = new System.Windows.Forms.DateTimePicker();
            this.checkBoxStartTime = new System.Windows.Forms.CheckBox();
            this.tabControlProductivityTracker = new System.Windows.Forms.TabControl();
            this.tabPageDataEntry = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabPageAnalysis = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelType.SuspendLayout();
            this.panelDuration.SuspendLayout();
            this.panelDescription.SuspendLayout();
            this.tabControlProductivityTracker.SuspendLayout();
            this.tabPageDataEntry.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(45, 359);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(489, 359);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 5);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(604, 263);
            this.dataGridView1.TabIndex = 3;
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(4, 4);
            this.textBoxDesc.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDesc.MaxLength = 100;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(578, 20);
            this.textBoxDesc.TabIndex = 4;
            // 
            // radioButtonWork
            // 
            this.radioButtonWork.AutoSize = true;
            this.radioButtonWork.Location = new System.Drawing.Point(6, 3);
            this.radioButtonWork.Name = "radioButtonWork";
            this.radioButtonWork.Size = new System.Drawing.Size(51, 17);
            this.radioButtonWork.TabIndex = 6;
            this.radioButtonWork.Text = "Work";
            this.radioButtonWork.UseVisualStyleBackColor = true;
            // 
            // panelType
            // 
            this.panelType.Controls.Add(this.radioButtonLeisure);
            this.panelType.Controls.Add(this.radioButtonPersonal);
            this.panelType.Controls.Add(this.radioButtonWork);
            this.panelType.Location = new System.Drawing.Point(186, 11);
            this.panelType.Name = "panelType";
            this.panelType.Size = new System.Drawing.Size(78, 69);
            this.panelType.TabIndex = 7;
            // 
            // radioButtonLeisure
            // 
            this.radioButtonLeisure.AutoSize = true;
            this.radioButtonLeisure.Location = new System.Drawing.Point(6, 48);
            this.radioButtonLeisure.Name = "radioButtonLeisure";
            this.radioButtonLeisure.Size = new System.Drawing.Size(59, 17);
            this.radioButtonLeisure.TabIndex = 8;
            this.radioButtonLeisure.Text = "Leisure";
            this.radioButtonLeisure.UseVisualStyleBackColor = true;
            // 
            // radioButtonPersonal
            // 
            this.radioButtonPersonal.AutoSize = true;
            this.radioButtonPersonal.Location = new System.Drawing.Point(6, 25);
            this.radioButtonPersonal.Name = "radioButtonPersonal";
            this.radioButtonPersonal.Size = new System.Drawing.Size(66, 17);
            this.radioButtonPersonal.TabIndex = 7;
            this.radioButtonPersonal.Text = "Personal";
            this.radioButtonPersonal.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDuration
            // 
            this.dateTimePickerDuration.Location = new System.Drawing.Point(3, 4);
            this.dateTimePickerDuration.Name = "dateTimePickerDuration";
            this.dateTimePickerDuration.Size = new System.Drawing.Size(55, 20);
            this.dateTimePickerDuration.TabIndex = 9;
            // 
            // panelDuration
            // 
            this.panelDuration.Controls.Add(this.dateTimePickerDuration);
            this.panelDuration.Location = new System.Drawing.Point(34, 47);
            this.panelDuration.Name = "panelDuration";
            this.panelDuration.Size = new System.Drawing.Size(60, 28);
            this.panelDuration.TabIndex = 11;
            // 
            // panelDescription
            // 
            this.panelDescription.Controls.Add(this.textBoxDesc);
            this.panelDescription.Location = new System.Drawing.Point(13, 283);
            this.panelDescription.Name = "panelDescription";
            this.panelDescription.Size = new System.Drawing.Size(587, 28);
            this.panelDescription.TabIndex = 12;
            // 
            // dateTimePickerStartTime
            // 
            this.dateTimePickerStartTime.Location = new System.Drawing.Point(34, 17);
            this.dateTimePickerStartTime.Name = "dateTimePickerStartTime";
            this.dateTimePickerStartTime.Size = new System.Drawing.Size(122, 20);
            this.dateTimePickerStartTime.TabIndex = 13;
            // 
            // checkBoxStartTime
            // 
            this.checkBoxStartTime.AutoSize = true;
            this.checkBoxStartTime.Location = new System.Drawing.Point(14, 20);
            this.checkBoxStartTime.Name = "checkBoxStartTime";
            this.checkBoxStartTime.Size = new System.Drawing.Size(15, 14);
            this.checkBoxStartTime.TabIndex = 14;
            this.checkBoxStartTime.UseVisualStyleBackColor = true;
            // 
            // tabControlProductivityTracker
            // 
            this.tabControlProductivityTracker.Controls.Add(this.tabPageDataEntry);
            this.tabControlProductivityTracker.Controls.Add(this.tabPageAnalysis);
            this.tabControlProductivityTracker.Location = new System.Drawing.Point(12, 12);
            this.tabControlProductivityTracker.Name = "tabControlProductivityTracker";
            this.tabControlProductivityTracker.SelectedIndex = 0;
            this.tabControlProductivityTracker.Size = new System.Drawing.Size(620, 453);
            this.tabControlProductivityTracker.TabIndex = 15;
            // 
            // tabPageDataEntry
            // 
            this.tabPageDataEntry.Controls.Add(this.groupBox1);
            this.tabPageDataEntry.Controls.Add(this.buttonDelete);
            this.tabPageDataEntry.Controls.Add(this.buttonAdd);
            this.tabPageDataEntry.Controls.Add(this.panelDescription);
            this.tabPageDataEntry.Controls.Add(this.dataGridView1);
            this.tabPageDataEntry.Location = new System.Drawing.Point(4, 22);
            this.tabPageDataEntry.Name = "tabPageDataEntry";
            this.tabPageDataEntry.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDataEntry.Size = new System.Drawing.Size(612, 427);
            this.tabPageDataEntry.TabIndex = 0;
            this.tabPageDataEntry.Text = "Data Entry";
            this.tabPageDataEntry.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelType);
            this.groupBox1.Controls.Add(this.checkBoxStartTime);
            this.groupBox1.Controls.Add(this.dateTimePickerStartTime);
            this.groupBox1.Controls.Add(this.panelDuration);
            this.groupBox1.Location = new System.Drawing.Point(166, 323);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 86);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // tabPageAnalysis
            // 
            this.tabPageAnalysis.Location = new System.Drawing.Point(4, 22);
            this.tabPageAnalysis.Name = "tabPageAnalysis";
            this.tabPageAnalysis.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAnalysis.Size = new System.Drawing.Size(612, 427);
            this.tabPageAnalysis.TabIndex = 1;
            this.tabPageAnalysis.Text = "Analysis";
            this.tabPageAnalysis.UseVisualStyleBackColor = true;
            // 
            // FormProductivityTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 477);
            this.Controls.Add(this.tabControlProductivityTracker);
            this.Name = "FormProductivityTracker";
            this.Text = "Productivity Tracker";
            this.Load += new System.EventHandler(this.FormProductivityTracker_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelType.ResumeLayout(false);
            this.panelType.PerformLayout();
            this.panelDuration.ResumeLayout(false);
            this.panelDescription.ResumeLayout(false);
            this.panelDescription.PerformLayout();
            this.tabControlProductivityTracker.ResumeLayout(false);
            this.tabPageDataEntry.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.RadioButton radioButtonWork;
        private System.Windows.Forms.Panel panelType;
        private System.Windows.Forms.RadioButton radioButtonLeisure;
        private System.Windows.Forms.RadioButton radioButtonPersonal;
        private System.Windows.Forms.DateTimePicker dateTimePickerDuration;
        private System.Windows.Forms.Panel panelDuration;
        private System.Windows.Forms.Panel panelDescription;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartTime;
        private System.Windows.Forms.CheckBox checkBoxStartTime;
        private System.Windows.Forms.TabControl tabControlProductivityTracker;
        private System.Windows.Forms.TabPage tabPageDataEntry;
        private System.Windows.Forms.TabPage tabPageAnalysis;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

