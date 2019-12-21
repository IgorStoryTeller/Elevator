namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.newUserGBox = new System.Windows.Forms.GroupBox();
            this.destFloorTextLabel = new System.Windows.Forms.Label();
            this.destFloorTextBox = new System.Windows.Forms.TextBox();
            this.weighTextLabel = new System.Windows.Forms.Label();
            this.initFloorTextLabel = new System.Windows.Forms.Label();
            this.initFloorTextBox = new System.Windows.Forms.TextBox();
            this.weighTextBox = new System.Windows.Forms.TextBox();
            this.nameTextLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addUsrBtn = new System.Windows.Forms.Button();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.timeElapsedStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.peopleCarriedStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.InitialDataGBox = new System.Windows.Forms.GroupBox();
            this.nofPeopleTextLabel = new System.Windows.Forms.Label();
            this.nofFloorsTextLabel = new System.Windows.Forms.Label();
            this.nofPeopleTextBox = new System.Windows.Forms.TextBox();
            this.nofFloorsTextBox = new System.Windows.Forms.TextBox();
            this.usrsInfGBox = new System.Windows.Forms.GroupBox();
            this.newUserGBox.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.InitialDataGBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // newUserGBox
            // 
            this.newUserGBox.BackColor = System.Drawing.SystemColors.Control;
            this.newUserGBox.Controls.Add(this.destFloorTextLabel);
            this.newUserGBox.Controls.Add(this.destFloorTextBox);
            this.newUserGBox.Controls.Add(this.weighTextLabel);
            this.newUserGBox.Controls.Add(this.initFloorTextLabel);
            this.newUserGBox.Controls.Add(this.initFloorTextBox);
            this.newUserGBox.Controls.Add(this.weighTextBox);
            this.newUserGBox.Controls.Add(this.nameTextLabel);
            this.newUserGBox.Controls.Add(this.nameTextBox);
            this.newUserGBox.Controls.Add(this.addUsrBtn);
            this.newUserGBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newUserGBox.Location = new System.Drawing.Point(29, 207);
            this.newUserGBox.Name = "newUserGBox";
            this.newUserGBox.Size = new System.Drawing.Size(230, 176);
            this.newUserGBox.TabIndex = 0;
            this.newUserGBox.TabStop = false;
            this.newUserGBox.Text = "New user";
            // 
            // destFloorTextLabel
            // 
            this.destFloorTextLabel.AutoSize = true;
            this.destFloorTextLabel.Location = new System.Drawing.Point(26, 100);
            this.destFloorTextLabel.Name = "destFloorTextLabel";
            this.destFloorTextLabel.Size = new System.Drawing.Size(81, 13);
            this.destFloorTextLabel.TabIndex = 5;
            this.destFloorTextLabel.Text = "destination floor";
            // 
            // destFloorTextBox
            // 
            this.destFloorTextBox.Location = new System.Drawing.Point(113, 97);
            this.destFloorTextBox.Name = "destFloorTextBox";
            this.destFloorTextBox.Size = new System.Drawing.Size(100, 20);
            this.destFloorTextBox.TabIndex = 4;
            // 
            // weighTextLabel
            // 
            this.weighTextLabel.AutoSize = true;
            this.weighTextLabel.Location = new System.Drawing.Point(69, 48);
            this.weighTextLabel.Name = "weighTextLabel";
            this.weighTextLabel.Size = new System.Drawing.Size(35, 13);
            this.weighTextLabel.TabIndex = 3;
            this.weighTextLabel.Text = "weigh";
            // 
            // initFloorTextLabel
            // 
            this.initFloorTextLabel.AutoSize = true;
            this.initFloorTextLabel.Location = new System.Drawing.Point(54, 74);
            this.initFloorTextLabel.Name = "initFloorTextLabel";
            this.initFloorTextLabel.Size = new System.Drawing.Size(53, 13);
            this.initFloorTextLabel.TabIndex = 4;
            this.initFloorTextLabel.Text = "initial floor";
            // 
            // initFloorTextBox
            // 
            this.initFloorTextBox.Location = new System.Drawing.Point(113, 71);
            this.initFloorTextBox.Name = "initFloorTextBox";
            this.initFloorTextBox.Size = new System.Drawing.Size(100, 20);
            this.initFloorTextBox.TabIndex = 3;
            // 
            // weighTextBox
            // 
            this.weighTextBox.Location = new System.Drawing.Point(113, 45);
            this.weighTextBox.Name = "weighTextBox";
            this.weighTextBox.Size = new System.Drawing.Size(100, 20);
            this.weighTextBox.TabIndex = 2;
            // 
            // nameTextLabel
            // 
            this.nameTextLabel.AutoSize = true;
            this.nameTextLabel.Location = new System.Drawing.Point(74, 22);
            this.nameTextLabel.Name = "nameTextLabel";
            this.nameTextLabel.Size = new System.Drawing.Size(33, 13);
            this.nameTextLabel.TabIndex = 2;
            this.nameTextLabel.Text = "name";
            this.nameTextLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(113, 19);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // addUsrBtn
            // 
            this.addUsrBtn.Location = new System.Drawing.Point(77, 133);
            this.addUsrBtn.Name = "addUsrBtn";
            this.addUsrBtn.Size = new System.Drawing.Size(75, 23);
            this.addUsrBtn.TabIndex = 1;
            this.addUsrBtn.Text = "add";
            this.addUsrBtn.UseVisualStyleBackColor = true;
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeElapsedStatusLabel,
            this.peopleCarriedStatusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 446);
            this.statusBar.Name = "statusBar";
            this.statusBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusBar.Size = new System.Drawing.Size(510, 22);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "StatusBar";
            // 
            // timeElapsedStatusLabel
            // 
            this.timeElapsedStatusLabel.Name = "timeElapsedStatusLabel";
            this.timeElapsedStatusLabel.Size = new System.Drawing.Size(77, 17);
            this.timeElapsedStatusLabel.Text = "Time elapsed";
            // 
            // peopleCarriedStatusLabel
            // 
            this.peopleCarriedStatusLabel.Name = "peopleCarriedStatusLabel";
            this.peopleCarriedStatusLabel.Size = new System.Drawing.Size(82, 17);
            this.peopleCarriedStatusLabel.Text = "people carried";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(77, 107);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 4;
            this.startBtn.Text = "start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.AllowDrop = true;
            this.stopBtn.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.stopBtn.Location = new System.Drawing.Point(106, 405);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 23);
            this.stopBtn.TabIndex = 5;
            this.stopBtn.Text = "stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // InitialDataGBox
            // 
            this.InitialDataGBox.Controls.Add(this.nofPeopleTextLabel);
            this.InitialDataGBox.Controls.Add(this.nofFloorsTextLabel);
            this.InitialDataGBox.Controls.Add(this.nofPeopleTextBox);
            this.InitialDataGBox.Controls.Add(this.nofFloorsTextBox);
            this.InitialDataGBox.Controls.Add(this.startBtn);
            this.InitialDataGBox.Location = new System.Drawing.Point(29, 22);
            this.InitialDataGBox.Name = "InitialDataGBox";
            this.InitialDataGBox.Size = new System.Drawing.Size(230, 147);
            this.InitialDataGBox.TabIndex = 6;
            this.InitialDataGBox.TabStop = false;
            this.InitialDataGBox.Text = "initial data";
            this.InitialDataGBox.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // nofPeopleTextLabel
            // 
            this.nofPeopleTextLabel.AutoSize = true;
            this.nofPeopleTextLabel.Location = new System.Drawing.Point(18, 65);
            this.nofPeopleTextLabel.Name = "nofPeopleTextLabel";
            this.nofPeopleTextLabel.Size = new System.Drawing.Size(89, 13);
            this.nofPeopleTextLabel.TabIndex = 7;
            this.nofPeopleTextLabel.Text = "number of people";
            // 
            // nofFloorsTextLabel
            // 
            this.nofFloorsTextLabel.AutoSize = true;
            this.nofFloorsTextLabel.Location = new System.Drawing.Point(25, 39);
            this.nofFloorsTextLabel.Name = "nofFloorsTextLabel";
            this.nofFloorsTextLabel.Size = new System.Drawing.Size(82, 13);
            this.nofFloorsTextLabel.TabIndex = 6;
            this.nofFloorsTextLabel.Text = "number of floors";
            // 
            // nofPeopleTextBox
            // 
            this.nofPeopleTextBox.Location = new System.Drawing.Point(113, 62);
            this.nofPeopleTextBox.Name = "nofPeopleTextBox";
            this.nofPeopleTextBox.Size = new System.Drawing.Size(100, 20);
            this.nofPeopleTextBox.TabIndex = 1;
            // 
            // nofFloorsTextBox
            // 
            this.nofFloorsTextBox.Location = new System.Drawing.Point(113, 36);
            this.nofFloorsTextBox.Name = "nofFloorsTextBox";
            this.nofFloorsTextBox.Size = new System.Drawing.Size(100, 20);
            this.nofFloorsTextBox.TabIndex = 0;
            // 
            // usrsInfGBox
            // 
            this.usrsInfGBox.Location = new System.Drawing.Point(277, 22);
            this.usrsInfGBox.Name = "usrsInfGBox";
            this.usrsInfGBox.Size = new System.Drawing.Size(221, 406);
            this.usrsInfGBox.TabIndex = 7;
            this.usrsInfGBox.TabStop = false;
            this.usrsInfGBox.Text = "users\' information";
            // 
            // Form1
            // 
            this.AccessibleName = "NAme";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 468);
            this.Controls.Add(this.usrsInfGBox);
            this.Controls.Add(this.InitialDataGBox);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.newUserGBox);
            this.Name = "Form1";
            this.Text = "Elevator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.newUserGBox.ResumeLayout(false);
            this.newUserGBox.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.InitialDataGBox.ResumeLayout(false);
            this.InitialDataGBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox newUserGBox;
        private System.Windows.Forms.TextBox destFloorTextBox;
        private System.Windows.Forms.TextBox initFloorTextBox;
        private System.Windows.Forms.TextBox weighTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button addUsrBtn;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.Label nameTextLabel;
        private System.Windows.Forms.Label weighTextLabel;
        private System.Windows.Forms.Label initFloorTextLabel;
        private System.Windows.Forms.Label destFloorTextLabel;
        private System.Windows.Forms.ToolStripStatusLabel timeElapsedStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel peopleCarriedStatusLabel;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.GroupBox InitialDataGBox;
        private System.Windows.Forms.Label nofPeopleTextLabel;
        private System.Windows.Forms.Label nofFloorsTextLabel;
        private System.Windows.Forms.TextBox nofPeopleTextBox;
        private System.Windows.Forms.TextBox nofFloorsTextBox;
        private System.Windows.Forms.GroupBox usrsInfGBox;
    }
}

