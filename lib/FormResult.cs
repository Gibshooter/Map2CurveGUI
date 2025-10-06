using Map2CurveGUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Map2CurveGUI
{
	public partial class Result : Form
	{
		public Result(string message, int type=0)
		{
			InitializeComponent();
			FormResult_tbox.Text = message;
			if (type==0)
			{
				FormResult_pbox.Image = Resources.Sign_Success;
			}
			else if (type==1)
			{
				FormResult_pbox.Image = Resources.Sign_Error;
			}
			else if (type==2)
			{
				FormResult_pbox.Image = Resources.Sign_Warning;
			}
			this.ActiveControl = button1;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
