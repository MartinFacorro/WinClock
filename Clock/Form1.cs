using System;
using System.Globalization;
using System.Windows.Forms;

namespace Clock
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      timer1.Enabled = true;
    }

    private void Timer1_Tick(object sender, EventArgs e)
    {
      lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
      lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
    }
  }
}
