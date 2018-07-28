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
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonLoadTweets = new System.Windows.Forms.Button();
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.buttonHelp = new System.Windows.Forms.Button();
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
            this.panelLog.Location = new System.Drawing.Point(0, 345);
            this.panelLog.Name = "panelLog";
            this.panelLog.Size = new System.Drawing.Size(704, 96);
            this.panelLog.TabIndex = 0;
            // 
            // textBoxLog
            // 
            this.textBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLog.Location = new System.Drawing.Point(0, 0);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(704, 96);
            this.textBoxLog.TabIndex = 0;
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.buttonHelp);
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
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(0, 139);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(704, 15);
            this.progressBar1.TabIndex = 5;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.buttonLoadTweets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadTweets.Location = new System.Drawing.Point(594, 72);
            this.buttonLoadTweets.Name = "buttonLoadTweets";
            this.buttonLoadTweets.Size = new System.Drawing.Size(98, 23);
            this.buttonLoadTweets.TabIndex = 1;
            this.buttonLoadTweets.Text = "Load archive";
            this.buttonLoadTweets.UseVisualStyleBackColor = true;
            this.buttonLoadTweets.Click += new System.EventHandler(this.buttonLoadTweets_Click);
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.Controls.Add(this.label2);
            this.groupBoxFilters.Controls.Add(this.label1);
            this.groupBoxFilters.Controls.Add(this.buttonSelectTweets);
            this.groupBoxFilters.Controls.Add(this.dateTimePickerEnd);
            this.groupBoxFilters.Controls.Add(this.dateTimePickerStart);
            this.groupBoxFilters.Controls.Add(this.textBoxKeywords);
            this.groupBoxFilters.Controls.Add(this.labelKeywords);
            this.groupBoxFilters.Location = new System.Drawing.Point(13, 13);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Size = new System.Drawing.Size(534, 120);
            this.groupBoxFilters.TabIndex = 0;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "Filters";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "End date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Start date";
            // 
            // buttonSelectTweets
            // 
            this.buttonSelectTweets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectTweets.Location = new System.Drawing.Point(411, 20);
            this.buttonSelectTweets.Name = "buttonSelectTweets";
            this.buttonSelectTweets.Size = new System.Drawing.Size(108, 91);
            this.buttonSelectTweets.TabIndex = 4;
            this.buttonSelectTweets.Text = "Select tweets";
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
            this.labelKeywords.Size = new System.Drawing.Size(127, 13);
            this.labelKeywords.TabIndex = 0;
            this.labelKeywords.Text = "Text (Regular expression)";
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
            this.dataGridViewTweets.Size = new System.Drawing.Size(704, 188);
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
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(594, 43);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(98, 23);
            this.buttonHelp.TabIndex = 7;
            this.buttonHelp.Text = "Help/About";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
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
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.OpenFileDialog openFileDialogTweets;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonHelp;
    }
}

