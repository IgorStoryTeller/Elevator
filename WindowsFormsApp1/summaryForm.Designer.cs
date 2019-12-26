namespace WindowsFormsApp1
{
    partial class summaryForm
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
            this.nofRidesLabel = new System.Windows.Forms.Label();
            this.nofBlankRidesLabel = new System.Windows.Forms.Label();
            this.totalWeighLabel = new System.Windows.Forms.Label();
            this.nofAddedPeopleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nofRidesLabel
            // 
            this.nofRidesLabel.AutoSize = true;
            this.nofRidesLabel.Location = new System.Drawing.Point(73, 37);
            this.nofRidesLabel.Name = "nofRidesLabel";
            this.nofRidesLabel.Size = new System.Drawing.Size(79, 13);
            this.nofRidesLabel.TabIndex = 0;
            this.nofRidesLabel.Text = "number of rides";
            // 
            // nofBlankRidesLabel
            // 
            this.nofBlankRidesLabel.AutoSize = true;
            this.nofBlankRidesLabel.Location = new System.Drawing.Point(44, 67);
            this.nofBlankRidesLabel.Name = "nofBlankRidesLabel";
            this.nofBlankRidesLabel.Size = new System.Drawing.Size(108, 13);
            this.nofBlankRidesLabel.TabIndex = 1;
            this.nofBlankRidesLabel.Text = "number of blank rides";
            // 
            // totalWeighLabel
            // 
            this.totalWeighLabel.AutoSize = true;
            this.totalWeighLabel.Location = new System.Drawing.Point(94, 97);
            this.totalWeighLabel.Name = "totalWeighLabel";
            this.totalWeighLabel.Size = new System.Drawing.Size(58, 13);
            this.totalWeighLabel.TabIndex = 2;
            this.totalWeighLabel.Text = "total weigh";
            // 
            // nofAddedPeopleLabel
            // 
            this.nofAddedPeopleLabel.AutoSize = true;
            this.nofAddedPeopleLabel.Location = new System.Drawing.Point(30, 127);
            this.nofAddedPeopleLabel.Name = "nofAddedPeopleLabel";
            this.nofAddedPeopleLabel.Size = new System.Drawing.Size(122, 13);
            this.nofAddedPeopleLabel.TabIndex = 3;
            this.nofAddedPeopleLabel.Text = "number of added people";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 7;
            // 
            // summaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 190);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nofAddedPeopleLabel);
            this.Controls.Add(this.totalWeighLabel);
            this.Controls.Add(this.nofBlankRidesLabel);
            this.Controls.Add(this.nofRidesLabel);
            this.Name = "summaryForm";
            this.Text = "summaryForm";
            this.Load += new System.EventHandler(this.summaryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nofRidesLabel;
        private System.Windows.Forms.Label nofBlankRidesLabel;
        private System.Windows.Forms.Label totalWeighLabel;
        private System.Windows.Forms.Label nofAddedPeopleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}