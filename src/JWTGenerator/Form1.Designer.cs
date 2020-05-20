namespace JWTGenerator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtProject = new System.Windows.Forms.TextBox();
            this.TxtIssue = new System.Windows.Forms.DateTimePicker();
            this.TxtExpired = new System.Windows.Forms.DateTimePicker();
            this.TxtPrivateKey = new System.Windows.Forms.TextBox();
            this.TxtToken = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.TxtProject, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxtIssue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtExpired, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TxtPrivateKey, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TxtToken, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(527, 287);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Issue At";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Expired";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Private Key";
            // 
            // TxtProject
            // 
            this.TxtProject.Location = new System.Drawing.Point(266, 3);
            this.TxtProject.Name = "TxtProject";
            this.TxtProject.Size = new System.Drawing.Size(200, 23);
            this.TxtProject.TabIndex = 4;
            // 
            // TxtIssue
            // 
            this.TxtIssue.Location = new System.Drawing.Point(266, 33);
            this.TxtIssue.Name = "TxtIssue";
            this.TxtIssue.Size = new System.Drawing.Size(200, 23);
            this.TxtIssue.TabIndex = 5;
            // 
            // TxtExpired
            // 
            this.TxtExpired.Location = new System.Drawing.Point(266, 63);
            this.TxtExpired.Name = "TxtExpired";
            this.TxtExpired.Size = new System.Drawing.Size(200, 23);
            this.TxtExpired.TabIndex = 6;
            // 
            // TxtPrivateKey
            // 
            this.TxtPrivateKey.Location = new System.Drawing.Point(266, 93);
            this.TxtPrivateKey.Multiline = true;
            this.TxtPrivateKey.Name = "TxtPrivateKey";
            this.TxtPrivateKey.Size = new System.Drawing.Size(258, 73);
            this.TxtPrivateKey.TabIndex = 7;
            // 
            // TxtToken
            // 
            this.TxtToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtToken.Location = new System.Drawing.Point(266, 223);
            this.TxtToken.Multiline = true;
            this.TxtToken.Name = "TxtToken";
            this.TxtToken.Size = new System.Drawing.Size(258, 61);
            this.TxtToken.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(557, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Token";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 319);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtProject;
        private System.Windows.Forms.DateTimePicker TxtIssue;
        private System.Windows.Forms.DateTimePicker TxtExpired;
        private System.Windows.Forms.TextBox TxtPrivateKey;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox TxtToken;
        private System.Windows.Forms.Label label5;
    }
}

