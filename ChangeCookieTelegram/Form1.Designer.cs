namespace ChangeCookieTelegram
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
            this.txtPathFolder = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.rtcLog = new System.Windows.Forms.RichTextBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.cb30phut = new System.Windows.Forms.CheckBox();
            this.cb60phut = new System.Windows.Forms.CheckBox();
            this.cb120phut = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtPathFolder
            // 
            this.txtPathFolder.Location = new System.Drawing.Point(84, 12);
            this.txtPathFolder.Multiline = true;
            this.txtPathFolder.Name = "txtPathFolder";
            this.txtPathFolder.Size = new System.Drawing.Size(316, 32);
            this.txtPathFolder.TabIndex = 0;
            this.txtPathFolder.Text = "D:\\GameTele\\ToolCsharp\\ChangeCookiesTelegram\\ChangeCookieTelegram\\bin\\Debug\\UrlGa" +
    "meTele.txt";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(19, 12);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(59, 32);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(406, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(93, 34);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // rtcLog
            // 
            this.rtcLog.Location = new System.Drawing.Point(19, 100);
            this.rtcLog.Name = "rtcLog";
            this.rtcLog.Size = new System.Drawing.Size(474, 273);
            this.rtcLog.TabIndex = 3;
            this.rtcLog.Text = "";
            this.rtcLog.TextChanged += new System.EventHandler(this.rtcLog_TextChanged);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(408, 60);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(0, 13);
            this.lbTime.TabIndex = 4;
            // 
            // cb30phut
            // 
            this.cb30phut.AutoSize = true;
            this.cb30phut.Location = new System.Drawing.Point(85, 60);
            this.cb30phut.Name = "cb30phut";
            this.cb30phut.Size = new System.Drawing.Size(62, 17);
            this.cb30phut.TabIndex = 5;
            this.cb30phut.Text = "30 phút";
            this.cb30phut.UseVisualStyleBackColor = true;
            this.cb30phut.CheckedChanged += new System.EventHandler(this.cb30phut_CheckedChanged);
            // 
            // cb60phut
            // 
            this.cb60phut.AutoSize = true;
            this.cb60phut.Location = new System.Drawing.Point(171, 60);
            this.cb60phut.Name = "cb60phut";
            this.cb60phut.Size = new System.Drawing.Size(62, 17);
            this.cb60phut.TabIndex = 6;
            this.cb60phut.Text = "60 phút";
            this.cb60phut.UseVisualStyleBackColor = true;
            this.cb60phut.CheckedChanged += new System.EventHandler(this.cb60phut_CheckedChanged);
            // 
            // cb120phut
            // 
            this.cb120phut.AutoSize = true;
            this.cb120phut.Location = new System.Drawing.Point(275, 60);
            this.cb120phut.Name = "cb120phut";
            this.cb120phut.Size = new System.Drawing.Size(58, 17);
            this.cb120phut.TabIndex = 7;
            this.cb120phut.Text = "2 tiếng";
            this.cb120phut.UseVisualStyleBackColor = true;
            this.cb120phut.CheckedChanged += new System.EventHandler(this.cb120phut_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 385);
            this.Controls.Add(this.cb120phut);
            this.Controls.Add(this.cb60phut);
            this.Controls.Add(this.cb30phut);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.rtcLog);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtPathFolder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPathFolder;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RichTextBox rtcLog;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.CheckBox cb30phut;
        private System.Windows.Forms.CheckBox cb60phut;
        private System.Windows.Forms.CheckBox cb120phut;
    }
}

