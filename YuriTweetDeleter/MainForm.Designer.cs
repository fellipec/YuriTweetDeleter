namespace YuriTweetDeleter
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelLog = new System.Windows.Forms.Panel();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.panelControls = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonLoadTweets = new System.Windows.Forms.Button();
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.buttonSelectDates = new System.Windows.Forms.Button();
            this.buttonSelectTweets = new System.Windows.Forms.Button();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.textBoxKeywords = new System.Windows.Forms.TextBox();
            this.labelKeywords = new System.Windows.Forms.Label();
            this.dataGridViewTweets = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialogTweets = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogTweets = new System.Windows.Forms.OpenFileDialog();
            this.dataSet1 = new System.Data.DataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.panelLog.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.groupBoxFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTweets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLog
            // 
            this.panelLog.Controls.Add(this.textBoxLog);
            this.panelLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLog.Location = new System.Drawing.Point(0, 281);
            this.panelLog.Name = "panelLog";
            this.panelLog.Size = new System.Drawing.Size(704, 160);
            this.panelLog.TabIndex = 0;
            // 
            // textBoxLog
            // 
            this.textBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLog.Location = new System.Drawing.Point(0, 0);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(704, 160);
            this.textBoxLog.TabIndex = 0;
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.button1);
            this.panelControls.Controls.Add(this.progressBar1);
            this.panelControls.Controls.Add(this.buttonDelete);
            this.panelControls.Controls.Add(this.buttonLoadTweets);
            this.panelControls.Controls.Add(this.groupBoxFilters);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControls.Location = new System.Drawing.Point(0, 0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(704, 157);
            this.panelControls.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(3, 139);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(698, 18);
            this.progressBar1.TabIndex = 5;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Location = new System.Drawing.Point(594, 101);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(98, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete Tweets";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonLoadTweets
            // 
            this.buttonLoadTweets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoadTweets.Location = new System.Drawing.Point(594, 72);
            this.buttonLoadTweets.Name = "buttonLoadTweets";
            this.buttonLoadTweets.Size = new System.Drawing.Size(98, 23);
            this.buttonLoadTweets.TabIndex = 1;
            this.buttonLoadTweets.Text = "Load Tweets";
            this.buttonLoadTweets.UseVisualStyleBackColor = true;
            this.buttonLoadTweets.Click += new System.EventHandler(this.buttonLoadTweets_Click);
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.Controls.Add(this.buttonSelectDates);
            this.groupBoxFilters.Controls.Add(this.buttonSelectTweets);
            this.groupBoxFilters.Controls.Add(this.dateTimePickerEnd);
            this.groupBoxFilters.Controls.Add(this.dateTimePickerStart);
            this.groupBoxFilters.Controls.Add(this.textBoxKeywords);
            this.groupBoxFilters.Controls.Add(this.labelKeywords);
            this.groupBoxFilters.Location = new System.Drawing.Point(13, 13);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Size = new System.Drawing.Size(534, 127);
            this.groupBoxFilters.TabIndex = 0;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "Filters";
            // 
            // buttonSelectDates
            // 
            this.buttonSelectDates.Location = new System.Drawing.Point(414, 88);
            this.buttonSelectDates.Name = "buttonSelectDates";
            this.buttonSelectDates.Size = new System.Drawing.Size(98, 23);
            this.buttonSelectDates.TabIndex = 5;
            this.buttonSelectDates.Text = "Select dates";
            this.buttonSelectDates.UseVisualStyleBackColor = true;
            this.buttonSelectDates.Click += new System.EventHandler(this.buttonSelectDates_Click);
            // 
            // buttonSelectTweets
            // 
            this.buttonSelectTweets.Location = new System.Drawing.Point(414, 29);
            this.buttonSelectTweets.Name = "buttonSelectTweets";
            this.buttonSelectTweets.Size = new System.Drawing.Size(98, 23);
            this.buttonSelectTweets.TabIndex = 4;
            this.buttonSelectTweets.Text = "Select keywords";
            this.buttonSelectTweets.UseVisualStyleBackColor = true;
            this.buttonSelectTweets.Click += new System.EventHandler(this.buttonSelectTweets_Click);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(184, 91);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(154, 20);
            this.dateTimePickerEnd.TabIndex = 3;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStart.Location = new System.Drawing.Point(10, 91);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(154, 20);
            this.dateTimePickerStart.TabIndex = 2;
            // 
            // textBoxKeywords
            // 
            this.textBoxKeywords.Location = new System.Drawing.Point(10, 37);
            this.textBoxKeywords.Name = "textBoxKeywords";
            this.textBoxKeywords.Size = new System.Drawing.Size(328, 20);
            this.textBoxKeywords.TabIndex = 1;
            // 
            // labelKeywords
            // 
            this.labelKeywords.AutoSize = true;
            this.labelKeywords.Location = new System.Drawing.Point(7, 20);
            this.labelKeywords.Name = "labelKeywords";
            this.labelKeywords.Size = new System.Drawing.Size(53, 13);
            this.labelKeywords.TabIndex = 0;
            this.labelKeywords.Text = "Keywords";
            // 
            // dataGridViewTweets
            // 
            this.dataGridViewTweets.AllowUserToAddRows = false;
            this.dataGridViewTweets.AllowUserToDeleteRows = false;
            this.dataGridViewTweets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTweets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTweets.Location = new System.Drawing.Point(0, 157);
            this.dataGridViewTweets.Name = "dataGridViewTweets";
            this.dataGridViewTweets.ReadOnly = true;
            this.dataGridViewTweets.Size = new System.Drawing.Size(704, 124);
            this.dataGridViewTweets.TabIndex = 2;
            // 
            // saveFileDialogTweets
            // 
            this.saveFileDialogTweets.DefaultExt = "csv";
            this.saveFileDialogTweets.Filter = "CSV Files|*.csv";
            this.saveFileDialogTweets.Title = "Save tweets";
            // 
            // openFileDialogTweets
            // 
            this.openFileDialogTweets.DefaultExt = "csv";
            this.openFileDialogTweets.Filter = "CSV|*.csv|All files|*.*";
            this.openFileDialogTweets.SupportMultiDottedExtensions = true;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(594, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Authenticate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.dataGridViewTweets);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.panelLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Yuri Tweet Deleter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.panelLog.ResumeLayout(false);
            this.panelLog.PerformLayout();
            this.panelControls.ResumeLayout(false);
            this.groupBoxFilters.ResumeLayout(false);
            this.groupBoxFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTweets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLog;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.GroupBox groupBoxFilters;
        private System.Windows.Forms.Label labelKeywords;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.TextBox textBoxKeywords;
        private System.Windows.Forms.Button buttonLoadTweets;
        private System.Windows.Forms.DataGridView dataGridViewTweets;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTweets;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Button buttonSelectTweets;
        private System.Windows.Forms.Button buttonSelectDates;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.OpenFileDialog openFileDialogTweets;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.Button button1;
    }
}

