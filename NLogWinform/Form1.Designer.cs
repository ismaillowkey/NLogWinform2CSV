
namespace NLogWinform
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
            this.BtnLogLevelTrace = new System.Windows.Forms.Button();
            this.BtnLogLevelDebug = new System.Windows.Forms.Button();
            this.BtnLogLevelInfo = new System.Windows.Forms.Button();
            this.BtnLogLevelWarn = new System.Windows.Forms.Button();
            this.BtnLogLevelError = new System.Windows.Forms.Button();
            this.BtnLogLevelFatal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnLogLevelTrace
            // 
            this.BtnLogLevelTrace.Location = new System.Drawing.Point(18, 19);
            this.BtnLogLevelTrace.Name = "BtnLogLevelTrace";
            this.BtnLogLevelTrace.Size = new System.Drawing.Size(128, 23);
            this.BtnLogLevelTrace.TabIndex = 1;
            this.BtnLogLevelTrace.Text = "LogLevel.Trace";
            this.BtnLogLevelTrace.UseVisualStyleBackColor = true;
            this.BtnLogLevelTrace.Click += new System.EventHandler(this.BtnLogLevelTrace_Click);
            // 
            // BtnLogLevelDebug
            // 
            this.BtnLogLevelDebug.Location = new System.Drawing.Point(18, 48);
            this.BtnLogLevelDebug.Name = "BtnLogLevelDebug";
            this.BtnLogLevelDebug.Size = new System.Drawing.Size(128, 23);
            this.BtnLogLevelDebug.TabIndex = 2;
            this.BtnLogLevelDebug.Text = "LogLevel.Debug";
            this.BtnLogLevelDebug.UseVisualStyleBackColor = true;
            this.BtnLogLevelDebug.Click += new System.EventHandler(this.BtnLogLevelDebug_Click);
            // 
            // BtnLogLevelInfo
            // 
            this.BtnLogLevelInfo.Location = new System.Drawing.Point(18, 77);
            this.BtnLogLevelInfo.Name = "BtnLogLevelInfo";
            this.BtnLogLevelInfo.Size = new System.Drawing.Size(128, 23);
            this.BtnLogLevelInfo.TabIndex = 3;
            this.BtnLogLevelInfo.Text = "LogLevel.Info";
            this.BtnLogLevelInfo.UseVisualStyleBackColor = true;
            this.BtnLogLevelInfo.Click += new System.EventHandler(this.BtnLogLevelInfo_Click);
            // 
            // BtnLogLevelWarn
            // 
            this.BtnLogLevelWarn.Location = new System.Drawing.Point(18, 106);
            this.BtnLogLevelWarn.Name = "BtnLogLevelWarn";
            this.BtnLogLevelWarn.Size = new System.Drawing.Size(128, 23);
            this.BtnLogLevelWarn.TabIndex = 4;
            this.BtnLogLevelWarn.Text = "LogLevel.Warn";
            this.BtnLogLevelWarn.UseVisualStyleBackColor = true;
            this.BtnLogLevelWarn.Click += new System.EventHandler(this.BtnLogLevelWarn_Click);
            // 
            // BtnLogLevelError
            // 
            this.BtnLogLevelError.Location = new System.Drawing.Point(18, 135);
            this.BtnLogLevelError.Name = "BtnLogLevelError";
            this.BtnLogLevelError.Size = new System.Drawing.Size(128, 23);
            this.BtnLogLevelError.TabIndex = 5;
            this.BtnLogLevelError.Text = "LogLevel.Error";
            this.BtnLogLevelError.UseVisualStyleBackColor = true;
            this.BtnLogLevelError.Click += new System.EventHandler(this.BtnLogLevelError_Click);
            // 
            // BtnLogLevelFatal
            // 
            this.BtnLogLevelFatal.Location = new System.Drawing.Point(18, 164);
            this.BtnLogLevelFatal.Name = "BtnLogLevelFatal";
            this.BtnLogLevelFatal.Size = new System.Drawing.Size(128, 23);
            this.BtnLogLevelFatal.TabIndex = 6;
            this.BtnLogLevelFatal.Text = "LogLevel.Fatal";
            this.BtnLogLevelFatal.UseVisualStyleBackColor = true;
            this.BtnLogLevelFatal.Click += new System.EventHandler(this.BtnLogLevelFatal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnLogLevelTrace);
            this.groupBox1.Controls.Add(this.BtnLogLevelFatal);
            this.groupBox1.Controls.Add(this.BtnLogLevelWarn);
            this.groupBox1.Controls.Add(this.BtnLogLevelDebug);
            this.groupBox1.Controls.Add(this.BtnLogLevelInfo);
            this.groupBox1.Controls.Add(this.BtnLogLevelError);
            this.groupBox1.Location = new System.Drawing.Point(22, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 199);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LogLevel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnLogLevelTrace;
        private System.Windows.Forms.Button BtnLogLevelDebug;
        private System.Windows.Forms.Button BtnLogLevelInfo;
        private System.Windows.Forms.Button BtnLogLevelWarn;
        private System.Windows.Forms.Button BtnLogLevelError;
        private System.Windows.Forms.Button BtnLogLevelFatal;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

