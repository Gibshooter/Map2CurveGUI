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
	public partial class About : Form
	{
		public About()
		{
			InitializeComponent();

			SetVersion();
		}

		private void SetVersion ()
		{
			var Version = System.Windows.Forms.Application.ProductVersion;
			label_aboutVersion.Text = String.Format("{0}", Version);
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("http://www.gibshooter.com/map2curve/");
		}

		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("mailto:totac@web.de");
		}

		private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://discord.gg/AWZHf87R5R");
		}
	}
}
