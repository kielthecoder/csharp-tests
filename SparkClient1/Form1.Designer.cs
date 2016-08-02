namespace SparkClient1
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
            this.lblAuth = new System.Windows.Forms.Label();
            this.txtAuth = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lstRooms = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAuth
            // 
            this.lblAuth.AutoSize = true;
            this.lblAuth.Location = new System.Drawing.Point(12, 16);
            this.lblAuth.Name = "lblAuth";
            this.lblAuth.Size = new System.Drawing.Size(71, 13);
            this.lblAuth.TabIndex = 0;
            this.lblAuth.Text = "Authorization:";
            // 
            // txtAuth
            // 
            this.txtAuth.Location = new System.Drawing.Point(90, 13);
            this.txtAuth.Name = "txtAuth";
            this.txtAuth.Size = new System.Drawing.Size(350, 20);
            this.txtAuth.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(446, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(114, 21);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lstRooms
            // 
            this.lstRooms.FormattingEnabled = true;
            this.lstRooms.Location = new System.Drawing.Point(15, 68);
            this.lstRooms.Name = "lstRooms";
            this.lstRooms.Size = new System.Drawing.Size(113, 186);
            this.lstRooms.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rooms:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 276);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstRooms);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtAuth);
            this.Controls.Add(this.lblAuth);
            this.Name = "Form1";
            this.Text = "Cisco Spark Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAuth;
        private System.Windows.Forms.TextBox txtAuth;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ListBox lstRooms;
        private System.Windows.Forms.Label label1;
    }
}

