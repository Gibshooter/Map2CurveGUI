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
	public partial class Wizard : Form
	{
		CurveObject Curve;
		int selIndex = -1;

		public Wizard()
		{
			InitializeComponent();
		}
		public Wizard(ref CurveObject cCurve, int sel)
		{
			Curve = cCurve;
			selIndex = sel;
			InitializeComponent();
		}


		private void wiz_tab_select(object sender, EventArgs e)
		{
			PictureBox PB = (PictureBox)sender;
			int sel = Int32.Parse(PB.Name.Substring(10, 1)) - 1;
			wiz_tabControl.SelectTab(sel);
		}


		private void button_preset_select(object sender, EventArgs e)
		{
			CurveObject Defaults = new CurveObject();
			Curve.setAllTabs(ref Defaults, false);

			// selected wizard button
			Button PB = (Button)sender;
			int sel = wiz_tabControl.SelectedIndex;

			// load curve settings to currently selected curve object
			if (sel == 0)
			{
				Curve.curveObjName = "Simple Arc I";
				Curve.range_end = 25;
				Curve.res = 48;
				Curve.hstretch = true;
			}
			else if (sel == 1)
			{
				Curve.curveObjName = "Simple Arc II";
				Curve.range_end = 25;
				Curve.res = 64;
				Curve.hstretch = true;
				Curve.hstretchamt = 1;
				Curve.hshiftsrc = 0;
				Curve.tri = true;
				Curve.bounds = 1;
				Curve.texmode = 1;
			}
			else if (sel == 2)
			{
				Curve.curveObjName = "Circle Duplication";
				Curve.d_carve = true;
				Curve.d_autoassign = true;
				Curve.flatcircle = true;
			}
			else if (sel == 3)
			{
				Curve.curveObjName = "Path Extrusion Simple";
				Curve.type = 2;
				Curve.ramp = true;
				Curve.texmode = 1;
				Curve.p_split = true;
				Curve.heightmode = 1;
			}
			else if (sel == 4)
			{
				Curve.curveObjName = "Path Extrusion Precise";
				Curve.type = 3;
				Curve.tri = true;
				Curve.texmode = 1;
				Curve.hshiftsrc = 0;
			}
			var mainForm = Application.OpenForms.OfType<MainGUI>().Single();
			mainForm.wizardClose(selIndex);

			this.Close();
		}



		private void pictureBox_wiz_circle_0_MouseEnter(object sender, EventArgs e)
		{
			PictureBox PB = (PictureBox)sender;
			PB.Image = Resources.Wizard_Circle_Texmode0;
		}
		private void pictureBox_wiz_circle_0_MouseLeave(object sender, EventArgs e)
		{
			PictureBox PB = (PictureBox)sender;
			PB.Image = Resources.Wizard_Circle_Texmode0_2;
		}



		private void pictureBox_wiz_circle_1_MouseEnter(object sender, EventArgs e)
		{
			PictureBox PB = (PictureBox)sender;
			PB.Image = Resources.Wizard_Circle_Texmode1;
		}
		private void pictureBox_wiz_circle_1_MouseLeave(object sender, EventArgs e)
		{
			PictureBox PB = (PictureBox)sender;
			PB.Image = Resources.Wizard_Circle_Texmode1_2;
		}



		private void pictureBox_wiz_circleDup_MouseEnter(object sender, EventArgs e)
		{
			PictureBox PB = (PictureBox)sender;
			PB.Image = Resources.Wizard_Duplicate;
		}
		private void pictureBox_wiz_circleDup_MouseLeave(object sender, EventArgs e)
		{
			PictureBox PB = (PictureBox)sender;
			PB.Image = Resources.Wizard_Duplicate_2;
		}






		private void pictureBox_wiz_corner_0_MouseEnter(object sender, EventArgs e)
		{
			PictureBox PB = (PictureBox)sender;
			PB.Image = Resources.Wizard_PathCorner0;
		}
		private void pictureBox_wiz_corner_0_MouseLeave(object sender, EventArgs e)
		{
			PictureBox PB = (PictureBox)sender;
			PB.Image = Resources.Wizard_PathCorner0_2;
		}




		private void pictureBox_wiz_corner_1_MouseEnter(object sender, EventArgs e)
		{
			PictureBox PB = (PictureBox)sender;
			PB.Image = Resources.Wizard_PathCorner1;
		}
		private void pictureBox_wiz_corner_1_MouseLeave(object sender, EventArgs e)
		{
			PictureBox PB = (PictureBox)sender;
			PB.Image = Resources.Wizard_PathCorner1_2;
		}





		private void button_input_file_select_Click(object sender, EventArgs e)
		{
			var mainForm = Application.OpenForms.OfType<MainGUI>().Single();
			mainForm.button_input_file_select_Click(sender, e);
		}

		private void button_splinefile_Click(object sender, EventArgs e)
		{
			var mainForm = Application.OpenForms.OfType<MainGUI>().Single();
			mainForm.button_splinefile_Click(sender, e);
		}
	}
}

