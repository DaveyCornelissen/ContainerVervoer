namespace ContainerTransport
{
    partial class FmContainer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnSetShip = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbShipMaxWeight = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbContainerSection7 = new System.Windows.Forms.ListBox();
            this.lbContainerSection8 = new System.Windows.Forms.ListBox();
            this.lbContainerSection5 = new System.Windows.Forms.ListBox();
            this.lbContainerSection6 = new System.Windows.Forms.ListBox();
            this.lbContainerSection3 = new System.Windows.Forms.ListBox();
            this.lbContainerSection4 = new System.Windows.Forms.ListBox();
            this.lbContainerSection2 = new System.Windows.Forms.ListBox();
            this.lbContainerSection1 = new System.Windows.Forms.ListBox();
            this.gpContainerAdd = new System.Windows.Forms.GroupBox();
            this.btnAddContainer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSetContainerWeight = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbContainerList = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbProgramLog = new System.Windows.Forms.ListBox();
            this.rbStandard = new System.Windows.Forms.RadioButton();
            this.rbValuable = new System.Windows.Forms.RadioButton();
            this.rbCooled = new System.Windows.Forms.RadioButton();
            this.lbShipInfo = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gpContainerAdd.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.btnClearAll);
            this.groupBox1.Controls.Add(this.btnSetShip);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbShipMaxWeight);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Ship";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Action:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(149, 47);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(68, 47);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 23);
            this.btnClearAll.TabIndex = 4;
            this.btnClearAll.Text = "Clear all";
            this.btnClearAll.UseVisualStyleBackColor = true;
            // 
            // btnSetShip
            // 
            this.btnSetShip.Location = new System.Drawing.Point(206, 17);
            this.btnSetShip.Name = "btnSetShip";
            this.btnSetShip.Size = new System.Drawing.Size(49, 20);
            this.btnSetShip.TabIndex = 3;
            this.btnSetShip.Text = "Set";
            this.btnSetShip.UseVisualStyleBackColor = true;
            this.btnSetShip.Click += new System.EventHandler(this.btnSetShip_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Weight kg:";
            // 
            // tbShipMaxWeight
            // 
            this.tbShipMaxWeight.Location = new System.Drawing.Point(68, 17);
            this.tbShipMaxWeight.Name = "tbShipMaxWeight";
            this.tbShipMaxWeight.Size = new System.Drawing.Size(132, 20);
            this.tbShipMaxWeight.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbContainerSection7);
            this.groupBox2.Controls.Add(this.lbContainerSection8);
            this.groupBox2.Controls.Add(this.lbContainerSection5);
            this.groupBox2.Controls.Add(this.lbContainerSection6);
            this.groupBox2.Controls.Add(this.lbContainerSection3);
            this.groupBox2.Controls.Add(this.lbContainerSection4);
            this.groupBox2.Controls.Add(this.lbContainerSection2);
            this.groupBox2.Controls.Add(this.lbContainerSection1);
            this.groupBox2.Location = new System.Drawing.Point(12, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(846, 288);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ship";
            // 
            // lbContainerSection7
            // 
            this.lbContainerSection7.FormattingEnabled = true;
            this.lbContainerSection7.Location = new System.Drawing.Point(631, 19);
            this.lbContainerSection7.Name = "lbContainerSection7";
            this.lbContainerSection7.Size = new System.Drawing.Size(201, 121);
            this.lbContainerSection7.TabIndex = 0;
            // 
            // lbContainerSection8
            // 
            this.lbContainerSection8.FormattingEnabled = true;
            this.lbContainerSection8.Location = new System.Drawing.Point(631, 146);
            this.lbContainerSection8.Name = "lbContainerSection8";
            this.lbContainerSection8.Size = new System.Drawing.Size(201, 121);
            this.lbContainerSection8.TabIndex = 0;
            // 
            // lbContainerSection5
            // 
            this.lbContainerSection5.FormattingEnabled = true;
            this.lbContainerSection5.Location = new System.Drawing.Point(424, 19);
            this.lbContainerSection5.Name = "lbContainerSection5";
            this.lbContainerSection5.Size = new System.Drawing.Size(201, 121);
            this.lbContainerSection5.TabIndex = 0;
            // 
            // lbContainerSection6
            // 
            this.lbContainerSection6.FormattingEnabled = true;
            this.lbContainerSection6.Location = new System.Drawing.Point(424, 146);
            this.lbContainerSection6.Name = "lbContainerSection6";
            this.lbContainerSection6.Size = new System.Drawing.Size(201, 121);
            this.lbContainerSection6.TabIndex = 0;
            // 
            // lbContainerSection3
            // 
            this.lbContainerSection3.FormattingEnabled = true;
            this.lbContainerSection3.Location = new System.Drawing.Point(217, 19);
            this.lbContainerSection3.Name = "lbContainerSection3";
            this.lbContainerSection3.Size = new System.Drawing.Size(201, 121);
            this.lbContainerSection3.TabIndex = 0;
            // 
            // lbContainerSection4
            // 
            this.lbContainerSection4.FormattingEnabled = true;
            this.lbContainerSection4.Location = new System.Drawing.Point(217, 146);
            this.lbContainerSection4.Name = "lbContainerSection4";
            this.lbContainerSection4.Size = new System.Drawing.Size(201, 121);
            this.lbContainerSection4.TabIndex = 0;
            // 
            // lbContainerSection2
            // 
            this.lbContainerSection2.BackColor = System.Drawing.SystemColors.Window;
            this.lbContainerSection2.FormattingEnabled = true;
            this.lbContainerSection2.Location = new System.Drawing.Point(10, 146);
            this.lbContainerSection2.Name = "lbContainerSection2";
            this.lbContainerSection2.Size = new System.Drawing.Size(201, 121);
            this.lbContainerSection2.TabIndex = 0;
            // 
            // lbContainerSection1
            // 
            this.lbContainerSection1.BackColor = System.Drawing.SystemColors.Window;
            this.lbContainerSection1.FormattingEnabled = true;
            this.lbContainerSection1.Location = new System.Drawing.Point(10, 19);
            this.lbContainerSection1.Name = "lbContainerSection1";
            this.lbContainerSection1.Size = new System.Drawing.Size(201, 121);
            this.lbContainerSection1.TabIndex = 0;
            // 
            // gpContainerAdd
            // 
            this.gpContainerAdd.Controls.Add(this.rbCooled);
            this.gpContainerAdd.Controls.Add(this.rbValuable);
            this.gpContainerAdd.Controls.Add(this.rbStandard);
            this.gpContainerAdd.Controls.Add(this.btnAddContainer);
            this.gpContainerAdd.Controls.Add(this.label2);
            this.gpContainerAdd.Controls.Add(this.tbSetContainerWeight);
            this.gpContainerAdd.Location = new System.Drawing.Point(12, 100);
            this.gpContainerAdd.Name = "gpContainerAdd";
            this.gpContainerAdd.Size = new System.Drawing.Size(292, 118);
            this.gpContainerAdd.TabIndex = 2;
            this.gpContainerAdd.TabStop = false;
            this.gpContainerAdd.Text = "Create Container";
            // 
            // btnAddContainer
            // 
            this.btnAddContainer.Location = new System.Drawing.Point(211, 89);
            this.btnAddContainer.Name = "btnAddContainer";
            this.btnAddContainer.Size = new System.Drawing.Size(75, 23);
            this.btnAddContainer.TabIndex = 4;
            this.btnAddContainer.Text = "Add";
            this.btnAddContainer.UseVisualStyleBackColor = true;
            this.btnAddContainer.Click += new System.EventHandler(this.btnAddContainer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Weight in kg:";
            // 
            // tbSetContainerWeight
            // 
            this.tbSetContainerWeight.Location = new System.Drawing.Point(10, 37);
            this.tbSetContainerWeight.Name = "tbSetContainerWeight";
            this.tbSetContainerWeight.Size = new System.Drawing.Size(245, 20);
            this.tbSetContainerWeight.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbContainerList);
            this.groupBox4.Location = new System.Drawing.Point(310, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(247, 206);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Current Containers";
            // 
            // lbContainerList
            // 
            this.lbContainerList.FormattingEnabled = true;
            this.lbContainerList.HorizontalScrollbar = true;
            this.lbContainerList.Location = new System.Drawing.Point(6, 19);
            this.lbContainerList.Name = "lbContainerList";
            this.lbContainerList.Size = new System.Drawing.Size(235, 173);
            this.lbContainerList.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbShipInfo);
            this.groupBox5.Controls.Add(this.lbProgramLog);
            this.groupBox5.Location = new System.Drawing.Point(563, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(295, 205);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Program Log";
            // 
            // lbProgramLog
            // 
            this.lbProgramLog.FormattingEnabled = true;
            this.lbProgramLog.Location = new System.Drawing.Point(7, 109);
            this.lbProgramLog.Name = "lbProgramLog";
            this.lbProgramLog.Size = new System.Drawing.Size(282, 82);
            this.lbProgramLog.TabIndex = 0;
            // 
            // rbStandard
            // 
            this.rbStandard.AutoSize = true;
            this.rbStandard.Location = new System.Drawing.Point(10, 68);
            this.rbStandard.Name = "rbStandard";
            this.rbStandard.Size = new System.Drawing.Size(68, 17);
            this.rbStandard.TabIndex = 6;
            this.rbStandard.TabStop = true;
            this.rbStandard.Text = "Standard";
            this.rbStandard.UseVisualStyleBackColor = true;
            // 
            // rbValuable
            // 
            this.rbValuable.AutoSize = true;
            this.rbValuable.Location = new System.Drawing.Point(101, 68);
            this.rbValuable.Name = "rbValuable";
            this.rbValuable.Size = new System.Drawing.Size(66, 17);
            this.rbValuable.TabIndex = 6;
            this.rbValuable.TabStop = true;
            this.rbValuable.Text = "Valuable";
            this.rbValuable.UseVisualStyleBackColor = true;
            // 
            // rbCooled
            // 
            this.rbCooled.AutoSize = true;
            this.rbCooled.Location = new System.Drawing.Point(192, 68);
            this.rbCooled.Name = "rbCooled";
            this.rbCooled.Size = new System.Drawing.Size(58, 17);
            this.rbCooled.TabIndex = 6;
            this.rbCooled.TabStop = true;
            this.rbCooled.Text = "Cooled";
            this.rbCooled.UseVisualStyleBackColor = true;
            // 
            // lbShipInfo
            // 
            this.lbShipInfo.FormattingEnabled = true;
            this.lbShipInfo.Location = new System.Drawing.Point(7, 19);
            this.lbShipInfo.Name = "lbShipInfo";
            this.lbShipInfo.Size = new System.Drawing.Size(282, 82);
            this.lbShipInfo.TabIndex = 0;
            // 
            // FmContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(870, 524);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gpContainerAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FmContainer";
            this.Text = "Container Transportation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.gpContainerAdd.ResumeLayout(false);
            this.gpContainerAdd.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbShipMaxWeight;
        private System.Windows.Forms.Button btnSetShip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbContainerSection1;
        private System.Windows.Forms.ListBox lbContainerSection3;
        private System.Windows.Forms.ListBox lbContainerSection4;
        private System.Windows.Forms.ListBox lbContainerSection2;
        private System.Windows.Forms.ListBox lbContainerSection7;
        private System.Windows.Forms.ListBox lbContainerSection8;
        private System.Windows.Forms.ListBox lbContainerSection5;
        private System.Windows.Forms.ListBox lbContainerSection6;
        private System.Windows.Forms.GroupBox gpContainerAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSetContainerWeight;
        private System.Windows.Forms.Button btnAddContainer;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lbContainerList;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox lbProgramLog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.RadioButton rbCooled;
        private System.Windows.Forms.RadioButton rbValuable;
        private System.Windows.Forms.RadioButton rbStandard;
        private System.Windows.Forms.ListBox lbShipInfo;
    }
}

