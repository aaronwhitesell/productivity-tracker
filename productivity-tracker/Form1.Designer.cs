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
            this.groupBoxResults = new System.Windows.Forms.GroupBox();
            this.groupBoxTime = new System.Windows.Forms.GroupBox();
            this.textBoxLeisureTime = new System.Windows.Forms.TextBox();
            this.textBoxPersonalTime = new System.Windows.Forms.TextBox();
            this.textBoxWorkTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPersonalTime = new System.Windows.Forms.Label();
            this.labelWorkTime = new System.Windows.Forms.Label();
            this.groupBoxPercentage = new System.Windows.Forms.GroupBox();
            this.textBoxLeisurePercent = new System.Windows.Forms.TextBox();
            this.textBoxPersonalPercent = new System.Windows.Forms.TextBox();
            this.labelLeisurePercent = new System.Windows.Forms.Label();
            this.labelPersonalPercent = new System.Windows.Forms.Label();
            this.labelWorkPercent = new System.Windows.Forms.Label();
            this.textBoxWorkPercent = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.groupBoxHowFar = new System.Windows.Forms.GroupBox();
            this.radioButton1Year = new System.Windows.Forms.RadioButton();
            this.radioButton90Days = new System.Windows.Forms.RadioButton();
            this.radioButton30Days = new System.Windows.Forms.RadioButton();
            this.radioButton7Days = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelType.SuspendLayout();
            this.panelDuration.SuspendLayout();
            this.panelDescription.SuspendLayout();
            this.tabControlProductivityTracker.SuspendLayout();
            this.tabPageDataEntry.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageAnalysis.SuspendLayout();
            this.groupBoxResults.SuspendLayout();
            this.groupBoxTime.SuspendLayout();
            this.groupBoxPercentage.SuspendLayout();
            this.groupBoxHowFar.SuspendLayout();
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
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(604, 263);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
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
            this.tabPageAnalysis.Controls.Add(this.groupBoxResults);
            this.tabPageAnalysis.Controls.Add(this.buttonCalculate);
            this.tabPageAnalysis.Controls.Add(this.groupBoxHowFar);
            this.tabPageAnalysis.Location = new System.Drawing.Point(4, 22);
            this.tabPageAnalysis.Name = "tabPageAnalysis";
            this.tabPageAnalysis.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAnalysis.Size = new System.Drawing.Size(612, 427);
            this.tabPageAnalysis.TabIndex = 1;
            this.tabPageAnalysis.Text = "Analysis";
            this.tabPageAnalysis.UseVisualStyleBackColor = true;
            // 
            // groupBoxResults
            // 
            this.groupBoxResults.Controls.Add(this.groupBoxTime);
            this.groupBoxResults.Controls.Add(this.groupBoxPercentage);
            this.groupBoxResults.Location = new System.Drawing.Point(281, 24);
            this.groupBoxResults.Name = "groupBoxResults";
            this.groupBoxResults.Size = new System.Drawing.Size(306, 373);
            this.groupBoxResults.TabIndex = 7;
            this.groupBoxResults.TabStop = false;
            this.groupBoxResults.Text = "Results";
            // 
            // groupBoxTime
            // 
            this.groupBoxTime.Controls.Add(this.textBoxLeisureTime);
            this.groupBoxTime.Controls.Add(this.textBoxPersonalTime);
            this.groupBoxTime.Controls.Add(this.textBoxWorkTime);
            this.groupBoxTime.Controls.Add(this.label1);
            this.groupBoxTime.Controls.Add(this.labelPersonalTime);
            this.groupBoxTime.Controls.Add(this.labelWorkTime);
            this.groupBoxTime.Location = new System.Drawing.Point(80, 31);
            this.groupBoxTime.Name = "groupBoxTime";
            this.groupBoxTime.Size = new System.Drawing.Size(146, 145);
            this.groupBoxTime.TabIndex = 6;
            this.groupBoxTime.TabStop = false;
            this.groupBoxTime.Text = "DD:MM:HH";
            // 
            // textBoxLeisureTime
            // 
            this.textBoxLeisureTime.Enabled = false;
            this.textBoxLeisureTime.Location = new System.Drawing.Point(77, 105);
            this.textBoxLeisureTime.Name = "textBoxLeisureTime";
            this.textBoxLeisureTime.Size = new System.Drawing.Size(48, 20);
            this.textBoxLeisureTime.TabIndex = 10;
            // 
            // textBoxPersonalTime
            // 
            this.textBoxPersonalTime.Enabled = false;
            this.textBoxPersonalTime.Location = new System.Drawing.Point(77, 66);
            this.textBoxPersonalTime.Name = "textBoxPersonalTime";
            this.textBoxPersonalTime.Size = new System.Drawing.Size(48, 20);
            this.textBoxPersonalTime.TabIndex = 9;
            // 
            // textBoxWorkTime
            // 
            this.textBoxWorkTime.Enabled = false;
            this.textBoxWorkTime.Location = new System.Drawing.Point(77, 27);
            this.textBoxWorkTime.Name = "textBoxWorkTime";
            this.textBoxWorkTime.Size = new System.Drawing.Size(48, 20);
            this.textBoxWorkTime.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Leisure";
            // 
            // labelPersonalTime
            // 
            this.labelPersonalTime.AutoSize = true;
            this.labelPersonalTime.Location = new System.Drawing.Point(18, 70);
            this.labelPersonalTime.Name = "labelPersonalTime";
            this.labelPersonalTime.Size = new System.Drawing.Size(48, 13);
            this.labelPersonalTime.TabIndex = 7;
            this.labelPersonalTime.Text = "Personal";
            // 
            // labelWorkTime
            // 
            this.labelWorkTime.AutoSize = true;
            this.labelWorkTime.Location = new System.Drawing.Point(18, 31);
            this.labelWorkTime.Name = "labelWorkTime";
            this.labelWorkTime.Size = new System.Drawing.Size(33, 13);
            this.labelWorkTime.TabIndex = 6;
            this.labelWorkTime.Text = "Work";
            // 
            // groupBoxPercentage
            // 
            this.groupBoxPercentage.Controls.Add(this.textBoxLeisurePercent);
            this.groupBoxPercentage.Controls.Add(this.textBoxPersonalPercent);
            this.groupBoxPercentage.Controls.Add(this.labelLeisurePercent);
            this.groupBoxPercentage.Controls.Add(this.labelPersonalPercent);
            this.groupBoxPercentage.Controls.Add(this.labelWorkPercent);
            this.groupBoxPercentage.Controls.Add(this.textBoxWorkPercent);
            this.groupBoxPercentage.Location = new System.Drawing.Point(80, 199);
            this.groupBoxPercentage.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxPercentage.Name = "groupBoxPercentage";
            this.groupBoxPercentage.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxPercentage.Size = new System.Drawing.Size(146, 145);
            this.groupBoxPercentage.TabIndex = 2;
            this.groupBoxPercentage.TabStop = false;
            this.groupBoxPercentage.Text = "Percentage";
            // 
            // textBoxLeisurePercent
            // 
            this.textBoxLeisurePercent.Enabled = false;
            this.textBoxLeisurePercent.Location = new System.Drawing.Point(77, 105);
            this.textBoxLeisurePercent.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLeisurePercent.Name = "textBoxLeisurePercent";
            this.textBoxLeisurePercent.Size = new System.Drawing.Size(48, 20);
            this.textBoxLeisurePercent.TabIndex = 5;
            // 
            // textBoxPersonalPercent
            // 
            this.textBoxPersonalPercent.Enabled = false;
            this.textBoxPersonalPercent.Location = new System.Drawing.Point(77, 66);
            this.textBoxPersonalPercent.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPersonalPercent.Name = "textBoxPersonalPercent";
            this.textBoxPersonalPercent.Size = new System.Drawing.Size(48, 20);
            this.textBoxPersonalPercent.TabIndex = 4;
            // 
            // labelLeisurePercent
            // 
            this.labelLeisurePercent.AutoSize = true;
            this.labelLeisurePercent.Location = new System.Drawing.Point(18, 109);
            this.labelLeisurePercent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLeisurePercent.Name = "labelLeisurePercent";
            this.labelLeisurePercent.Size = new System.Drawing.Size(41, 13);
            this.labelLeisurePercent.TabIndex = 3;
            this.labelLeisurePercent.Text = "Leisure";
            // 
            // labelPersonalPercent
            // 
            this.labelPersonalPercent.AutoSize = true;
            this.labelPersonalPercent.Location = new System.Drawing.Point(18, 70);
            this.labelPersonalPercent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPersonalPercent.Name = "labelPersonalPercent";
            this.labelPersonalPercent.Size = new System.Drawing.Size(48, 13);
            this.labelPersonalPercent.TabIndex = 2;
            this.labelPersonalPercent.Text = "Personal";
            // 
            // labelWorkPercent
            // 
            this.labelWorkPercent.AutoSize = true;
            this.labelWorkPercent.Location = new System.Drawing.Point(18, 31);
            this.labelWorkPercent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWorkPercent.Name = "labelWorkPercent";
            this.labelWorkPercent.Size = new System.Drawing.Size(33, 13);
            this.labelWorkPercent.TabIndex = 1;
            this.labelWorkPercent.Text = "Work";
            // 
            // textBoxWorkPercent
            // 
            this.textBoxWorkPercent.Enabled = false;
            this.textBoxWorkPercent.Location = new System.Drawing.Point(77, 27);
            this.textBoxWorkPercent.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxWorkPercent.Name = "textBoxWorkPercent";
            this.textBoxWorkPercent.Size = new System.Drawing.Size(48, 20);
            this.textBoxWorkPercent.TabIndex = 0;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(93, 304);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(94, 28);
            this.buttonCalculate.TabIndex = 1;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // groupBoxHowFar
            // 
            this.groupBoxHowFar.Controls.Add(this.radioButton1Year);
            this.groupBoxHowFar.Controls.Add(this.radioButton90Days);
            this.groupBoxHowFar.Controls.Add(this.radioButton30Days);
            this.groupBoxHowFar.Controls.Add(this.radioButton7Days);
            this.groupBoxHowFar.Location = new System.Drawing.Point(93, 92);
            this.groupBoxHowFar.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxHowFar.Name = "groupBoxHowFar";
            this.groupBoxHowFar.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxHowFar.Size = new System.Drawing.Size(94, 185);
            this.groupBoxHowFar.TabIndex = 0;
            this.groupBoxHowFar.TabStop = false;
            this.groupBoxHowFar.Text = "How far back?";
            // 
            // radioButton1Year
            // 
            this.radioButton1Year.AutoSize = true;
            this.radioButton1Year.Location = new System.Drawing.Point(16, 142);
            this.radioButton1Year.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1Year.Name = "radioButton1Year";
            this.radioButton1Year.Size = new System.Drawing.Size(54, 17);
            this.radioButton1Year.TabIndex = 3;
            this.radioButton1Year.TabStop = true;
            this.radioButton1Year.Text = "1 year";
            this.radioButton1Year.UseVisualStyleBackColor = true;
            // 
            // radioButton90Days
            // 
            this.radioButton90Days.AutoSize = true;
            this.radioButton90Days.Location = new System.Drawing.Point(16, 105);
            this.radioButton90Days.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton90Days.Name = "radioButton90Days";
            this.radioButton90Days.Size = new System.Drawing.Size(62, 17);
            this.radioButton90Days.TabIndex = 2;
            this.radioButton90Days.TabStop = true;
            this.radioButton90Days.Text = "90 days";
            this.radioButton90Days.UseVisualStyleBackColor = true;
            // 
            // radioButton30Days
            // 
            this.radioButton30Days.AutoSize = true;
            this.radioButton30Days.Location = new System.Drawing.Point(16, 68);
            this.radioButton30Days.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton30Days.Name = "radioButton30Days";
            this.radioButton30Days.Size = new System.Drawing.Size(62, 17);
            this.radioButton30Days.TabIndex = 1;
            this.radioButton30Days.TabStop = true;
            this.radioButton30Days.Text = "30 days";
            this.radioButton30Days.UseVisualStyleBackColor = true;
            // 
            // radioButton7Days
            // 
            this.radioButton7Days.AutoSize = true;
            this.radioButton7Days.Location = new System.Drawing.Point(16, 31);
            this.radioButton7Days.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton7Days.Name = "radioButton7Days";
            this.radioButton7Days.Size = new System.Drawing.Size(56, 17);
            this.radioButton7Days.TabIndex = 0;
            this.radioButton7Days.TabStop = true;
            this.radioButton7Days.Text = "7 days";
            this.radioButton7Days.UseVisualStyleBackColor = true;
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
            this.tabPageAnalysis.ResumeLayout(false);
            this.groupBoxResults.ResumeLayout(false);
            this.groupBoxTime.ResumeLayout(false);
            this.groupBoxTime.PerformLayout();
            this.groupBoxPercentage.ResumeLayout(false);
            this.groupBoxPercentage.PerformLayout();
            this.groupBoxHowFar.ResumeLayout(false);
            this.groupBoxHowFar.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBoxHowFar;
        private System.Windows.Forms.RadioButton radioButton1Year;
        private System.Windows.Forms.RadioButton radioButton90Days;
        private System.Windows.Forms.RadioButton radioButton30Days;
        private System.Windows.Forms.RadioButton radioButton7Days;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.GroupBox groupBoxPercentage;
        private System.Windows.Forms.TextBox textBoxLeisurePercent;
        private System.Windows.Forms.TextBox textBoxPersonalPercent;
        private System.Windows.Forms.Label labelLeisurePercent;
        private System.Windows.Forms.Label labelPersonalPercent;
        private System.Windows.Forms.Label labelWorkPercent;
        private System.Windows.Forms.TextBox textBoxWorkPercent;
        private System.Windows.Forms.GroupBox groupBoxTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPersonalTime;
        private System.Windows.Forms.Label labelWorkTime;
        private System.Windows.Forms.TextBox textBoxLeisureTime;
        private System.Windows.Forms.TextBox textBoxPersonalTime;
        private System.Windows.Forms.TextBox textBoxWorkTime;
        private System.Windows.Forms.GroupBox groupBoxResults;
    }
}

