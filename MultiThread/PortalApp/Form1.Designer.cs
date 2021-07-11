
namespace PortalApp
{
    partial class frm_Portal
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
            this.label1 = new System.Windows.Forms.Label();
            this.frm_OneThread = new System.Windows.Forms.Button();
            this.btn_ManyThread = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Portal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_OneThread
            // 
            this.frm_OneThread.Location = new System.Drawing.Point(12, 89);
            this.frm_OneThread.Name = "frm_OneThread";
            this.frm_OneThread.Size = new System.Drawing.Size(116, 39);
            this.frm_OneThread.TabIndex = 1;
            this.frm_OneThread.Text = "One Thread";
            this.frm_OneThread.UseVisualStyleBackColor = true;
            this.frm_OneThread.Click += new System.EventHandler(this.frm_OneThread_Click);
            // 
            // btn_ManyThread
            // 
            this.btn_ManyThread.Location = new System.Drawing.Point(12, 134);
            this.btn_ManyThread.Name = "btn_ManyThread";
            this.btn_ManyThread.Size = new System.Drawing.Size(116, 39);
            this.btn_ManyThread.TabIndex = 2;
            this.btn_ManyThread.Text = "Many Thread";
            this.btn_ManyThread.UseVisualStyleBackColor = true;
            this.btn_ManyThread.Click += new System.EventHandler(this.btn_ManyThread_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(134, 89);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 355);
            this.listBox1.TabIndex = 3;
            // 
            // frm_Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_ManyThread);
            this.Controls.Add(this.frm_OneThread);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frm_Portal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Portal App";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button frm_OneThread;
        private System.Windows.Forms.Button btn_ManyThread;
        private System.Windows.Forms.ListBox listBox1;
    }
}

