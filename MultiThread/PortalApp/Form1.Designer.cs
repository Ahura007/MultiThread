
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
            this.btn_OneSyncRequest = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lst_Result = new System.Windows.Forms.ListBox();
            this.btn_AsyncRequest = new System.Windows.Forms.Button();
            this.btn_ConfigureAwait = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(581, 73);
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
            // btn_OneSyncRequest
            // 
            this.btn_OneSyncRequest.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_OneSyncRequest.Location = new System.Drawing.Point(134, 89);
            this.btn_OneSyncRequest.Name = "btn_OneSyncRequest";
            this.btn_OneSyncRequest.Size = new System.Drawing.Size(123, 39);
            this.btn_OneSyncRequest.TabIndex = 3;
            this.btn_OneSyncRequest.Text = "Sync Request";
            this.btn_OneSyncRequest.UseVisualStyleBackColor = true;
            this.btn_OneSyncRequest.Click += new System.EventHandler(this.btn_OneSyncRequest_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lst_Result);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(261, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(320, 364);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Api Result";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(5, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(310, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Clear List Box";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lst_Result
            // 
            this.lst_Result.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lst_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_Result.FormattingEnabled = true;
            this.lst_Result.ItemHeight = 18;
            this.lst_Result.Location = new System.Drawing.Point(5, 67);
            this.lst_Result.Name = "lst_Result";
            this.lst_Result.Size = new System.Drawing.Size(310, 292);
            this.lst_Result.TabIndex = 0;
            // 
            // btn_AsyncRequest
            // 
            this.btn_AsyncRequest.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_AsyncRequest.Location = new System.Drawing.Point(134, 134);
            this.btn_AsyncRequest.Name = "btn_AsyncRequest";
            this.btn_AsyncRequest.Size = new System.Drawing.Size(123, 39);
            this.btn_AsyncRequest.TabIndex = 5;
            this.btn_AsyncRequest.Text = "Async Request";
            this.btn_AsyncRequest.UseVisualStyleBackColor = true;
            this.btn_AsyncRequest.Click += new System.EventHandler(this.btn_AsyncRequest_Click);
            // 
            // btn_ConfigureAwait
            // 
            this.btn_ConfigureAwait.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_ConfigureAwait.Location = new System.Drawing.Point(12, 199);
            this.btn_ConfigureAwait.Name = "btn_ConfigureAwait";
            this.btn_ConfigureAwait.Size = new System.Drawing.Size(116, 39);
            this.btn_ConfigureAwait.TabIndex = 6;
            this.btn_ConfigureAwait.Text = "ConfigureAwait";
            this.btn_ConfigureAwait.UseVisualStyleBackColor = true;
            this.btn_ConfigureAwait.Click += new System.EventHandler(this.btn_ConfigureAwait_Click);
            // 
            // frm_Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 437);
            this.Controls.Add(this.btn_ConfigureAwait);
            this.Controls.Add(this.btn_AsyncRequest);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_OneSyncRequest);
            this.Controls.Add(this.btn_ManyThread);
            this.Controls.Add(this.frm_OneThread);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frm_Portal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Portal App";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button frm_OneThread;
        private System.Windows.Forms.Button btn_ManyThread;
        private System.Windows.Forms.Button btn_OneSyncRequest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lst_Result;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_AsyncRequest;
        private System.Windows.Forms.Button btn_ConfigureAwait;
    }
}

