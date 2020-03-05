namespace process_simulation
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Lote 1");
            this.generateBtn = new System.Windows.Forms.Button();
            this.nProcessTextBox = new System.Windows.Forms.TextBox();
            this.qtyProcessLabel = new System.Windows.Forms.Label();
            this.batchCountLabel = new System.Windows.Forms.Label();
            this.standbyListView = new System.Windows.Forms.ListView();
            this.idColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MWTColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.processColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.batchColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.runningListView = new System.Windows.Forms.ListView();
            this.idRunColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameRunColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MWTRunColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.operationRunColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.finishedListView = new System.Windows.Forms.ListView();
            this.idFinishColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.operationFinishColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProcessTimer = new System.Windows.Forms.Timer(this.components);
            this.timerLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.finishedListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.interruptButton = new System.Windows.Forms.Button();
            this.errorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(183, 30);
            this.generateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(100, 28);
            this.generateBtn.TabIndex = 0;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // nProcessTextBox
            // 
            this.nProcessTextBox.Location = new System.Drawing.Point(104, 32);
            this.nProcessTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nProcessTextBox.Name = "nProcessTextBox";
            this.nProcessTextBox.Size = new System.Drawing.Size(56, 22);
            this.nProcessTextBox.TabIndex = 1;
            // 
            // qtyProcessLabel
            // 
            this.qtyProcessLabel.AutoSize = true;
            this.qtyProcessLabel.Location = new System.Drawing.Point(16, 36);
            this.qtyProcessLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.qtyProcessLabel.Name = "qtyProcessLabel";
            this.qtyProcessLabel.Size = new System.Drawing.Size(71, 17);
            this.qtyProcessLabel.TabIndex = 2;
            this.qtyProcessLabel.Text = "# Process";
            // 
            // batchCountLabel
            // 
            this.batchCountLabel.AutoSize = true;
            this.batchCountLabel.Location = new System.Drawing.Point(17, 11);
            this.batchCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.batchCountLabel.Name = "batchCountLabel";
            this.batchCountLabel.Size = new System.Drawing.Size(60, 17);
            this.batchCountLabel.TabIndex = 3;
            this.batchCountLabel.Text = "# Batch:";
            // 
            // standbyListView
            // 
            this.standbyListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumnHeader,
            this.nameColumnHeader,
            this.MWTColumnHeader,
            this.processColumnHeader,
            this.batchColumnHeader});
            this.standbyListView.HideSelection = false;
            this.standbyListView.Location = new System.Drawing.Point(16, 127);
            this.standbyListView.Margin = new System.Windows.Forms.Padding(4);
            this.standbyListView.Name = "standbyListView";
            this.standbyListView.ShowItemToolTips = true;
            this.standbyListView.Size = new System.Drawing.Size(611, 120);
            this.standbyListView.TabIndex = 4;
            this.standbyListView.UseCompatibleStateImageBehavior = false;
            this.standbyListView.View = System.Windows.Forms.View.Details;
            // 
            // idColumnHeader
            // 
            this.idColumnHeader.Text = "ID";
            this.idColumnHeader.Width = 29;
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Name";
            this.nameColumnHeader.Width = 57;
            // 
            // MWTColumnHeader
            // 
            this.MWTColumnHeader.Text = "Maximum Wating Time";
            this.MWTColumnHeader.Width = 151;
            // 
            // processColumnHeader
            // 
            this.processColumnHeader.Text = "Pending Process";
            this.processColumnHeader.Width = 131;
            // 
            // batchColumnHeader
            // 
            this.batchColumnHeader.Text = "Pending Batch";
            this.batchColumnHeader.Width = 116;
            // 
            // runningListView
            // 
            this.runningListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idRunColumnHeader,
            this.nameRunColumnHeader,
            this.MWTRunColumnHeader,
            this.operationRunColumnHeader});
            this.runningListView.HideSelection = false;
            this.runningListView.Location = new System.Drawing.Point(16, 319);
            this.runningListView.Margin = new System.Windows.Forms.Padding(4);
            this.runningListView.Name = "runningListView";
            this.runningListView.ShowItemToolTips = true;
            this.runningListView.Size = new System.Drawing.Size(611, 133);
            this.runningListView.TabIndex = 5;
            this.runningListView.UseCompatibleStateImageBehavior = false;
            this.runningListView.View = System.Windows.Forms.View.Details;
            // 
            // idRunColumnHeader
            // 
            this.idRunColumnHeader.Text = "ID";
            this.idRunColumnHeader.Width = 29;
            // 
            // nameRunColumnHeader
            // 
            this.nameRunColumnHeader.Text = "Name";
            this.nameRunColumnHeader.Width = 57;
            // 
            // MWTRunColumnHeader
            // 
            this.MWTRunColumnHeader.Text = "Maximum Wating Time";
            this.MWTRunColumnHeader.Width = 165;
            // 
            // operationRunColumnHeader
            // 
            this.operationRunColumnHeader.Text = "Operation";
            this.operationRunColumnHeader.Width = 91;
            // 
            // finishedListView
            // 
            this.finishedListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idFinishColumnHeader,
            this.operationFinishColumnHeader});
            this.finishedListView.HideSelection = false;
            listViewItem2.IndentCount = 1;
            this.finishedListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.finishedListView.Location = new System.Drawing.Point(842, 13);
            this.finishedListView.Margin = new System.Windows.Forms.Padding(4);
            this.finishedListView.Name = "finishedListView";
            this.finishedListView.ShowItemToolTips = true;
            this.finishedListView.Size = new System.Drawing.Size(15, 441);
            this.finishedListView.TabIndex = 6;
            this.finishedListView.UseCompatibleStateImageBehavior = false;
            this.finishedListView.View = System.Windows.Forms.View.Details;
            this.finishedListView.Visible = false;
            // 
            // idFinishColumnHeader
            // 
            this.idFinishColumnHeader.Text = "ID";
            // 
            // operationFinishColumnHeader
            // 
            this.operationFinishColumnHeader.Text = "Operation";
            this.operationFinishColumnHeader.Width = 102;
            // 
            // ProcessTimer
            // 
            this.ProcessTimer.Interval = 1000;
            this.ProcessTimer.Tick += new System.EventHandler(this.ProcessTimer_Tick);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Location = new System.Drawing.Point(435, 36);
            this.timerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(16, 17);
            this.timerLabel.TabIndex = 7;
            this.timerLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Elapsed Time:";
            // 
            // finishedListBox
            // 
            this.finishedListBox.FormattingEnabled = true;
            this.finishedListBox.ItemHeight = 16;
            this.finishedListBox.Location = new System.Drawing.Point(631, 80);
            this.finishedListBox.Name = "finishedListBox";
            this.finishedListBox.Size = new System.Drawing.Size(169, 372);
            this.finishedListBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(655, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Finished Process";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Standby process";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 298);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Running Process";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // interruptButton
            // 
            this.interruptButton.Location = new System.Drawing.Point(524, 255);
            this.interruptButton.Margin = new System.Windows.Forms.Padding(4);
            this.interruptButton.Name = "interruptButton";
            this.interruptButton.Size = new System.Drawing.Size(100, 28);
            this.interruptButton.TabIndex = 13;
            this.interruptButton.Text = "Interrupt";
            this.interruptButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.interruptButton.UseVisualStyleBackColor = true;
            this.interruptButton.Click += new System.EventHandler(this.interruptButton_Click);
            // 
            // errorButton
            // 
            this.errorButton.Location = new System.Drawing.Point(416, 255);
            this.errorButton.Margin = new System.Windows.Forms.Padding(4);
            this.errorButton.Name = "errorButton";
            this.errorButton.Size = new System.Drawing.Size(100, 28);
            this.errorButton.TabIndex = 14;
            this.errorButton.Text = "Error";
            this.errorButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.errorButton.UseVisualStyleBackColor = true;
            this.errorButton.Click += new System.EventHandler(this.errorButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 464);
            this.Controls.Add(this.errorButton);
            this.Controls.Add(this.interruptButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.finishedListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.finishedListView);
            this.Controls.Add(this.runningListView);
            this.Controls.Add(this.standbyListView);
            this.Controls.Add(this.batchCountLabel);
            this.Controls.Add(this.qtyProcessLabel);
            this.Controls.Add(this.nProcessTextBox);
            this.Controls.Add(this.generateBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.TextBox nProcessTextBox;
        private System.Windows.Forms.Label qtyProcessLabel;
        private System.Windows.Forms.Label batchCountLabel;
        private System.Windows.Forms.ListView standbyListView;
        private System.Windows.Forms.ColumnHeader idColumnHeader;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader MWTColumnHeader;
        private System.Windows.Forms.ColumnHeader processColumnHeader;
        private System.Windows.Forms.ColumnHeader batchColumnHeader;
        private System.Windows.Forms.ListView runningListView;
        private System.Windows.Forms.ColumnHeader idRunColumnHeader;
        private System.Windows.Forms.ColumnHeader nameRunColumnHeader;
        private System.Windows.Forms.ColumnHeader MWTRunColumnHeader;
        private System.Windows.Forms.ColumnHeader operationRunColumnHeader;
        private System.Windows.Forms.ListView finishedListView;
        private System.Windows.Forms.ColumnHeader idFinishColumnHeader;
        private System.Windows.Forms.ColumnHeader operationFinishColumnHeader;
        private System.Windows.Forms.Timer ProcessTimer;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox finishedListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button interruptButton;
        private System.Windows.Forms.Button errorButton;
    }
}

