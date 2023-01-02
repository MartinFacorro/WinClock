
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
      this.lblTime.Font = new System.Drawing.Font("JetBrains Mono", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTime.ForeColor = System.Drawing.Color.LightSteelBlue;
      this.lblTime.Location = new System.Drawing.Point(41, 9);
      this.lblTime.Name = "lblTime";
      this.lblTime.Size = new System.Drawing.Size(167, 47);
      this.lblTime.TabIndex = 0;
      this.lblTime.Text = "lblTime";
      // 
      // timer1
      // 
      this.timer1.Enabled = true;
      this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
      // 
      // lblDate
      // 
      this.lblDate.AutoSize = true;
      this.lblDate.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblDate.ForeColor = System.Drawing.Color.Orange;
      this.lblDate.Location = new System.Drawing.Point(76, 80);
      this.lblDate.Name = "lblDate";
      this.lblDate.Size = new System.Drawing.Size(89, 25);
      this.lblDate.TabIndex = 1;
      this.lblDate.Text = "lblDate";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
      this.ClientSize = new System.Drawing.Size(267, 120);
      this.Controls.Add(this.lblDate);
      this.Controls.Add(this.lblTime);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "Form1";
      this.Opacity = 0.95D;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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

