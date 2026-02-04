namespace Clock
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
      this.components = new System.ComponentModel.Container();
      this.lblTime = new System.Windows.Forms.Label();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.lblDate = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lblTime
      // 
      this.lblTime.AutoSize = true;
      this.lblTime.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
      this.lblTime.Location = new System.Drawing.Point(35, 15);
      this.lblTime.Name = "lblTime";
      this.lblTime.Size = new System.Drawing.Size(167, 51);
      this.lblTime.TabIndex = 0;
      this.lblTime.Text = "00:00:00";
      this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // timer1
      // 
      this.timer1.Enabled = true;
      this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
      // 
      // lblDate
      // 
      this.lblDate.AutoSize = true;
      this.lblDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
      this.lblDate.Location = new System.Drawing.Point(60, 70);
      this.lblDate.Name = "lblDate";
      this.lblDate.Size = new System.Drawing.Size(97, 21);
      this.lblDate.TabIndex = 1;
      this.lblDate.Text = "01/01/2024";
      this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
      this.ClientSize = new System.Drawing.Size(280, 110);
      this.Controls.Add(this.lblDate);
      this.Controls.Add(this.lblTime);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "Form1";
      this.Opacity = 0.95D;
      this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
      this.Text = "Clock Widget";
      this.TopMost = true;
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblTime;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Label lblDate;
  }
}

