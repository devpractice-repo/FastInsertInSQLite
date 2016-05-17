namespace SQLiteFastInsert
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
            this.lbTimeOfExper = new System.Windows.Forms.Label();
            this.tbTimeOfExperiment = new System.Windows.Forms.TextBox();
            this.lbCIIT = new System.Windows.Forms.Label();
            this.tbInsCount = new System.Windows.Forms.TextBox();
            this.btStart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.lbInsPerSec = new System.Windows.Forms.Label();
            this.lbInsPerSecValue = new System.Windows.Forms.Label();
            this.timerDb = new System.Windows.Forms.Timer(this.components);
            this.lbCountOfInserts = new System.Windows.Forms.Label();
            this.lbCountOfInsertsValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTimeOfExper
            // 
            this.lbTimeOfExper.AutoSize = true;
            this.lbTimeOfExper.Location = new System.Drawing.Point(42, 15);
            this.lbTimeOfExper.Name = "lbTimeOfExper";
            this.lbTimeOfExper.Size = new System.Drawing.Size(119, 13);
            this.lbTimeOfExper.TabIndex = 0;
            this.lbTimeOfExper.Text = "Time of experiment, sec";
            // 
            // tbTimeOfExperiment
            // 
            this.tbTimeOfExperiment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTimeOfExperiment.Location = new System.Drawing.Point(167, 11);
            this.tbTimeOfExperiment.Name = "tbTimeOfExperiment";
            this.tbTimeOfExperiment.Size = new System.Drawing.Size(100, 20);
            this.tbTimeOfExperiment.TabIndex = 1;
            // 
            // lbCIIT
            // 
            this.lbCIIT.AutoSize = true;
            this.lbCIIT.Location = new System.Drawing.Point(12, 49);
            this.lbCIIT.Name = "lbCIIT";
            this.lbCIIT.Size = new System.Drawing.Size(149, 13);
            this.lbCIIT.TabIndex = 2;
            this.lbCIIT.Text = "Count INSERTs in transaction";
            // 
            // tbInsCount
            // 
            this.tbInsCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbInsCount.Location = new System.Drawing.Point(167, 45);
            this.tbInsCount.Name = "tbInsCount";
            this.tbInsCount.Size = new System.Drawing.Size(100, 20);
            this.tbInsCount.TabIndex = 3;
            // 
            // btStart
            // 
            this.btStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btStart.Location = new System.Drawing.Point(15, 81);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 23);
            this.btStart.TabIndex = 4;
            this.btStart.Text = "START";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btStop
            // 
            this.btStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btStop.Location = new System.Drawing.Point(96, 81);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(75, 23);
            this.btStop.TabIndex = 5;
            this.btStop.Text = "STOP";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // lbInsPerSec
            // 
            this.lbInsPerSec.AutoSize = true;
            this.lbInsPerSec.Location = new System.Drawing.Point(12, 125);
            this.lbInsPerSec.Name = "lbInsPerSec";
            this.lbInsPerSec.Size = new System.Drawing.Size(111, 13);
            this.lbInsPerSec.TabIndex = 6;
            this.lbInsPerSec.Text = "INSERTs per second:";
            // 
            // lbInsPerSecValue
            // 
            this.lbInsPerSecValue.AutoSize = true;
            this.lbInsPerSecValue.Location = new System.Drawing.Point(124, 125);
            this.lbInsPerSecValue.Name = "lbInsPerSecValue";
            this.lbInsPerSecValue.Size = new System.Drawing.Size(28, 13);
            this.lbInsPerSecValue.TabIndex = 7;
            this.lbInsPerSecValue.Text = "-------";
            // 
            // timerDb
            // 
            this.timerDb.Tick += new System.EventHandler(this.timerDb_Tick);
            // 
            // lbCountOfInserts
            // 
            this.lbCountOfInserts.AutoSize = true;
            this.lbCountOfInserts.Location = new System.Drawing.Point(12, 150);
            this.lbCountOfInserts.Name = "lbCountOfInserts";
            this.lbCountOfInserts.Size = new System.Drawing.Size(98, 13);
            this.lbCountOfInserts.TabIndex = 8;
            this.lbCountOfInserts.Text = "Count of INSERTs:";
            // 
            // lbCountOfInsertsValue
            // 
            this.lbCountOfInsertsValue.AutoSize = true;
            this.lbCountOfInsertsValue.Location = new System.Drawing.Point(124, 150);
            this.lbCountOfInsertsValue.Name = "lbCountOfInsertsValue";
            this.lbCountOfInsertsValue.Size = new System.Drawing.Size(28, 13);
            this.lbCountOfInsertsValue.TabIndex = 9;
            this.lbCountOfInsertsValue.Text = "-------";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 181);
            this.Controls.Add(this.lbCountOfInsertsValue);
            this.Controls.Add(this.lbCountOfInserts);
            this.Controls.Add(this.lbInsPerSecValue);
            this.Controls.Add(this.lbInsPerSec);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.tbInsCount);
            this.Controls.Add(this.lbCIIT);
            this.Controls.Add(this.tbTimeOfExperiment);
            this.Controls.Add(this.lbTimeOfExper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "SQLite Fast INSERT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTimeOfExper;
        private System.Windows.Forms.TextBox tbTimeOfExperiment;
        private System.Windows.Forms.Label lbCIIT;
        private System.Windows.Forms.TextBox tbInsCount;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Label lbInsPerSec;
        private System.Windows.Forms.Label lbInsPerSecValue;
        private System.Windows.Forms.Timer timerDb;
        private System.Windows.Forms.Label lbCountOfInserts;
        private System.Windows.Forms.Label lbCountOfInsertsValue;
    }
}

