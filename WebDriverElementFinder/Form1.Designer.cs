namespace WebDriverElementFinder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnOpenBrowser = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtLocator = new System.Windows.Forms.TextBox();
            this.btnHighlight = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblElementCount = new System.Windows.Forms.Label();
            this.cmbBySelector = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbBySelectorChild = new System.Windows.Forms.ComboBox();
            this.txtLocatorChild = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.btn_HighlightChild = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQuitBrowser = new System.Windows.Forms.Button();
            this.btn_RemoveHighlight = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_executeCode = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLogs = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenBrowser
            // 
            this.btnOpenBrowser.Location = new System.Drawing.Point(332, 42);
            this.btnOpenBrowser.Name = "btnOpenBrowser";
            this.btnOpenBrowser.Size = new System.Drawing.Size(100, 23);
            this.btnOpenBrowser.TabIndex = 0;
            this.btnOpenBrowser.Text = "Open Browser";
            this.btnOpenBrowser.UseVisualStyleBackColor = true;
            this.btnOpenBrowser.Click += new System.EventHandler(this.btnOpenBrowser_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(33, 42);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(293, 20);
            this.txtURL.TabIndex = 1;
            this.txtURL.Text = "http://google.com";
            // 
            // txtLocator
            // 
            this.txtLocator.Location = new System.Drawing.Point(210, 173);
            this.txtLocator.Name = "txtLocator";
            this.txtLocator.Size = new System.Drawing.Size(282, 20);
            this.txtLocator.TabIndex = 2;
            // 
            // btnHighlight
            // 
            this.btnHighlight.Location = new System.Drawing.Point(498, 173);
            this.btnHighlight.Name = "btnHighlight";
            this.btnHighlight.Size = new System.Drawing.Size(74, 23);
            this.btnHighlight.TabIndex = 3;
            this.btnHighlight.Text = "Highlight";
            this.btnHighlight.UseVisualStyleBackColor = true;
            this.btnHighlight.Click += new System.EventHandler(this.btnHighlight_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Step1: Enter the URL and Open Firefox Browser";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(370, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Step2: Manually Navigate to the page where you want to identify the element";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(500, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Step3: Select By Condition from Drop Down and Enter the locator in text box and p" +
    "ress highlight element.\r\n\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Element(s) found";
            // 
            // lblElementCount
            // 
            this.lblElementCount.AutoSize = true;
            this.lblElementCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElementCount.Location = new System.Drawing.Point(110, 316);
            this.lblElementCount.Name = "lblElementCount";
            this.lblElementCount.Size = new System.Drawing.Size(22, 31);
            this.lblElementCount.TabIndex = 8;
            this.lblElementCount.Text = ".";
            // 
            // cmbBySelector
            // 
            this.cmbBySelector.FormattingEnabled = true;
            this.cmbBySelector.Items.AddRange(new object[] {
            "Id",
            "Name",
            "ClassName",
            "CSSSelector",
            "XPath",
            "LinkText",
            "PartialLinkText",
            "TagName"});
            this.cmbBySelector.Location = new System.Drawing.Point(63, 172);
            this.cmbBySelector.Name = "cmbBySelector";
            this.cmbBySelector.Size = new System.Drawing.Size(141, 21);
            this.cmbBySelector.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Result";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(50, 7);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(10, 13);
            this.lblResult.TabIndex = 11;
            this.lblResult.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "By";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(21, 437);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(636, 40);
            this.txtResult.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(132, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "By";
            // 
            // cmbBySelectorChild
            // 
            this.cmbBySelectorChild.FormattingEnabled = true;
            this.cmbBySelectorChild.Items.AddRange(new object[] {
            "Id",
            "Name",
            "ClassName",
            "CSSSelector",
            "XPath",
            "LinkText",
            "PartialLinkText",
            "TagName"});
            this.cmbBySelectorChild.Location = new System.Drawing.Point(157, 45);
            this.cmbBySelectorChild.Name = "cmbBySelectorChild";
            this.cmbBySelectorChild.Size = new System.Drawing.Size(141, 21);
            this.cmbBySelectorChild.TabIndex = 15;
            // 
            // txtLocatorChild
            // 
            this.txtLocatorChild.Location = new System.Drawing.Point(313, 45);
            this.txtLocatorChild.Name = "txtLocatorChild";
            this.txtLocatorChild.Size = new System.Drawing.Size(141, 20);
            this.txtLocatorChild.TabIndex = 14;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(41, 204);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(49, 13);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "AddChild";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtIndex);
            this.groupBox1.Controls.Add(this.btn_HighlightChild);
            this.groupBox1.Controls.Add(this.txtLocatorChild);
            this.groupBox1.Controls.Add(this.cmbBySelectorChild);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(28, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 97);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Child Element";
            this.groupBox1.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Index";
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(70, 45);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(34, 20);
            this.txtIndex.TabIndex = 20;
            this.txtIndex.Text = "0";
            // 
            // btn_HighlightChild
            // 
            this.btn_HighlightChild.Location = new System.Drawing.Point(470, 31);
            this.btn_HighlightChild.Name = "btn_HighlightChild";
            this.btn_HighlightChild.Size = new System.Drawing.Size(149, 47);
            this.btn_HighlightChild.TabIndex = 19;
            this.btn_HighlightChild.Text = "Highlight Child Elements";
            this.btn_HighlightChild.UseVisualStyleBackColor = true;
            this.btn_HighlightChild.Click += new System.EventHandler(this.btn_HighlightChild_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(508, 483);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(117, 23);
            this.btnCopy.TabIndex = 19;
            this.btnCopy.Text = "Copy To ClipBoard";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "WebDriver Code";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblResult);
            this.panel1.Location = new System.Drawing.Point(21, 356);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 55);
            this.panel1.TabIndex = 21;
            // 
            // btnQuitBrowser
            // 
            this.btnQuitBrowser.Enabled = false;
            this.btnQuitBrowser.Location = new System.Drawing.Point(452, 42);
            this.btnQuitBrowser.Name = "btnQuitBrowser";
            this.btnQuitBrowser.Size = new System.Drawing.Size(100, 23);
            this.btnQuitBrowser.TabIndex = 22;
            this.btnQuitBrowser.Text = "Close Browser";
            this.btnQuitBrowser.UseVisualStyleBackColor = true;
            this.btnQuitBrowser.Click += new System.EventHandler(this.btnQuitBrowser_Click);
            // 
            // btn_RemoveHighlight
            // 
            this.btn_RemoveHighlight.Location = new System.Drawing.Point(583, 154);
            this.btn_RemoveHighlight.Name = "btn_RemoveHighlight";
            this.btn_RemoveHighlight.Size = new System.Drawing.Size(87, 42);
            this.btn_RemoveHighlight.TabIndex = 23;
            this.btn_RemoveHighlight.Text = "Remove Highlight";
            this.btn_RemoveHighlight.UseVisualStyleBackColor = true;
            this.btn_RemoveHighlight.Click += new System.EventHandler(this.btn_RemoveHighlight_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1081, 575);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn_RemoveHighlight);
            this.tabPage1.Controls.Add(this.btnOpenBrowser);
            this.tabPage1.Controls.Add(this.btnQuitBrowser);
            this.tabPage1.Controls.Add(this.txtURL);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.txtLocator);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.btnHighlight);
            this.tabPage1.Controls.Add(this.btnCopy);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.linkLabel1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtResult);
            this.tabPage1.Controls.Add(this.lblElementCount);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.cmbBySelector);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1073, 549);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ElementLocator";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txtLogs);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.btn_executeCode);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1073, 549);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Script Test";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(6, 35);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(843, 226);
            this.textBox1.TabIndex = 5;
            // 
            // btn_executeCode
            // 
            this.btn_executeCode.Location = new System.Drawing.Point(705, 281);
            this.btn_executeCode.Name = "btn_executeCode";
            this.btn_executeCode.Size = new System.Drawing.Size(144, 23);
            this.btn_executeCode.TabIndex = 3;
            this.btn_executeCode.Text = "Execute Code";
            this.btn_executeCode.UseVisualStyleBackColor = true;
            this.btn_executeCode.Click += new System.EventHandler(this.btn_executeCode_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(229, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Write code here without declaring any variable.";
            // 
            // txtLogs
            // 
            this.txtLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogs.Location = new System.Drawing.Point(6, 281);
            this.txtLogs.Multiline = true;
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.Size = new System.Drawing.Size(693, 133);
            this.txtLogs.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 265);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Result:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(855, 8);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(210, 535);
            this.textBox2.TabIndex = 26;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 580);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Selenium Element Highlighter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenBrowser;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txtLocator;
        private System.Windows.Forms.Button btnHighlight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblElementCount;
        private System.Windows.Forms.ComboBox cmbBySelector;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbBySelectorChild;
        private System.Windows.Forms.TextBox txtLocatorChild;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_HighlightChild;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Button btnQuitBrowser;
        private System.Windows.Forms.Button btn_RemoveHighlight;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_executeCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLogs;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox2;
    }
}

