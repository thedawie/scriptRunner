namespace scriptRunner
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
            this.btnGetScripts = new System.Windows.Forms.Button();
            this.lblScripts = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbConnections = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkScripts = new System.Windows.Forms.CheckedListBox();
            this.btnRunScripts = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetScripts
            // 
            this.btnGetScripts.Enabled = false;
            this.btnGetScripts.Location = new System.Drawing.Point(272, 48);
            this.btnGetScripts.Name = "btnGetScripts";
            this.btnGetScripts.Size = new System.Drawing.Size(236, 49);
            this.btnGetScripts.TabIndex = 0;
            this.btnGetScripts.Text = "Get Scripts";
            this.btnGetScripts.UseVisualStyleBackColor = true;
            this.btnGetScripts.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblScripts
            // 
            this.lblScripts.AutoSize = true;
            this.lblScripts.Location = new System.Drawing.Point(15, 14);
            this.lblScripts.Name = "lblScripts";
            this.lblScripts.Size = new System.Drawing.Size(0, 26);
            this.lblScripts.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lblScripts);
            this.panel1.Location = new System.Drawing.Point(569, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 661);
            this.panel1.TabIndex = 3;
            // 
            // cbConnections
            // 
            this.cbConnections.FormattingEnabled = true;
            this.cbConnections.Location = new System.Drawing.Point(272, 12);
            this.cbConnections.Name = "cbConnections";
            this.cbConnections.Size = new System.Drawing.Size(236, 33);
            this.cbConnections.TabIndex = 4;
            this.cbConnections.SelectedIndexChanged += new System.EventHandler(this.cbConnections_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose Connecton";
            // 
            // chkScripts
            // 
            this.chkScripts.FormattingEnabled = true;
            this.chkScripts.Location = new System.Drawing.Point(13, 124);
            this.chkScripts.Name = "chkScripts";
            this.chkScripts.Size = new System.Drawing.Size(495, 602);
            this.chkScripts.TabIndex = 6;
            // 
            // btnRunScripts
            // 
            this.btnRunScripts.Location = new System.Drawing.Point(569, 22);
            this.btnRunScripts.Name = "btnRunScripts";
            this.btnRunScripts.Size = new System.Drawing.Size(682, 50);
            this.btnRunScripts.TabIndex = 7;
            this.btnRunScripts.Text = "Run Scripts";
            this.btnRunScripts.UseVisualStyleBackColor = true;
            this.btnRunScripts.Click += new System.EventHandler(this.btnRunScripts_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 751);
            this.Controls.Add(this.btnRunScripts);
            this.Controls.Add(this.chkScripts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetScripts);
            this.Controls.Add(this.cbConnections);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Script runner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetScripts;
        private System.Windows.Forms.Label lblScripts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbConnections;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox chkScripts;
        private System.Windows.Forms.Button btnRunScripts;
    }
}

