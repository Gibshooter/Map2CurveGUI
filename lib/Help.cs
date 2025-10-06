using System;
using System.Drawing;
using System.Windows.Forms;

namespace Map2CurveGUI
{
	public partial class MainGUI : Form
	{

		// HELP METHODS / EVENTS
		private void help_Clear()
		{
			pictureBox_preview.Image = null;
			richTextBox_help.Clear();
		}

		private void richTextBox_help_TextChanged(object sender, EventArgs e)
		{
			richTextBox_help.SelectionStart = 0;
			richTextBox_help.ScrollToCaret();
		}

		private void help_Populate(object sender, EventArgs e)
		{
			help_Clear();
			Help Handler = new Help(sender, ref richTextBox_help, ref pictureBox_preview);
		}

		private void help_Focus(object sender, EventArgs e)
		{
			var Sender = (PictureBox)sender;

			if      (Sender.Name == "pictureBox_help_rad") textBox_rad.Focus();
			else if (Sender.Name == "pictureBox_help_offset") textBox_offset.Focus();
			else if (Sender.Name == "pictureBox_help_res") textBox_res.Focus();
			else if (Sender.Name == "pictureBox_help_type") comboBox_type.Focus();
			else if (Sender.Name == "pictureBox_help_flatcircle") checkBox_flatcircle.Focus();
			else if (Sender.Name == "pictureBox_help_range") textBox_range_start.Focus();
			else if (Sender.Name == "pictureBox_help_bounds") comboBox_bounds.Focus();
			else if (Sender.Name == "pictureBox_help_height") textBox_height.Focus();
			else if (Sender.Name == "pictureBox_help_heightmode") comboBox_heightmode.Focus();
			else if (Sender.Name == "pictureBox_help_ramp") checkBox_ramp.Focus();
			else if (Sender.Name == "pictureBox_help_texmode") comboBox_texmode.Focus();
			else if (Sender.Name == "pictureBox_help_shift") comboBox_shift.Focus();
			else if (Sender.Name == "pictureBox_help_hshiftsrc") comboBox_hshiftsrc.Focus();
			else if (Sender.Name == "pictureBox_help_hstretch") checkBox_hstretch.Focus();
			else if (Sender.Name == "pictureBox_help_hstretchamt") textBox_hstretchamt.Focus();
			else if (Sender.Name == "pictureBox_help_hshiftoffset") textBox_hshiftoffset.Focus();
			else if (Sender.Name == "pictureBox_help_tri") checkBox_tri.Focus();
			else if (Sender.Name == "pictureBox_help_transit_tri") checkBox_transit_tri.Focus();
			else if (Sender.Name == "pictureBox_help_round") checkBox_round.Focus();
			else if (Sender.Name == "pictureBox_help_transit_round") checkBox_transit_round.Focus();
			else if (Sender.Name == "pictureBox_help_nulltex") textBox_nulltex.Focus();
			else if (Sender.Name == "pictureBox_help_mapcarve") comboBox_mapcarve.Focus();
			else if (Sender.Name == "pictureBox_help_gaps") checkBox_gaps.Focus();
			else if (Sender.Name == "pictureBox_help_gaplen") textBox_gaplen.Focus();
			else if (Sender.Name == "pictureBox_help_spike_height") textBox_spike_height.Focus();
			else if (Sender.Name == "pictureBox_help_skipnull") checkBox_skipnull.Focus();
            else if (Sender.Name == "pictureBox_help_rot_src") textBox_rot_src_x.Focus();
            else if (Sender.Name == "pictureBox_help_rot") textBox_rot_x.Focus();
            else if (Sender.Name == "pictureBox_help_scale") textBox_scale.Focus();
            else if (Sender.Name == "pictureBox_help_scale_src") textBox_scale_src.Focus();
            else if (Sender.Name == "pictureBox_help_mirror") checkBox_mirror_x.Focus();
            else if (Sender.Name == "pictureBox_help_mirror_src") checkBox_mirror_src_x.Focus();
            else if (Sender.Name == "pictureBox_help_move") textBox_move_x.Focus();
            else if (Sender.Name == "pictureBox_help_c_enable") checkBox_c_enable.Focus();
            else if (Sender.Name == "pictureBox_help_append") checkBox_append.Focus();
            else if (Sender.Name == "pictureBox_help_target_2") checkBox_export_rmf.Focus();
            else if (Sender.Name == "pictureBox_help_gridsize") textBox_gridsize_x.Focus();
        }

        // Individuals
        private void pictureBox_help_source_Click(object sender, EventArgs e)
		{
			help_Populate(sender, e);
			tabControl1.SelectedTab = tabControl1.TabPages[7];
			tabControl_howto.SelectedTab = tabControl_howto.TabPages[0];
		}

	}


	internal class Help
	{
		public Help(object sender, ref RichTextBox Box, ref PictureBox PBox)
		{
			string name = "";
			int attachIndex;
			string name_txt = "";
			string name_img = "";

			if (sender is PictureBox)
			{
				PictureBox Sender = (PictureBox)sender;
				name = Sender.Name;
				name_txt = name.Substring(16, name.Length - 16);
				if (name_txt == "target_2") name_txt = "target";
			}
			else if (sender is TextBox)
			{
				TextBox Sender = (TextBox)sender;
				name = Sender.Name;
				name_txt = name.Substring(8, name.Length - 8);
				if (name_txt.Contains("range_")) name_txt = "range";
                else if (name_txt.Contains("rot_src_")) name_txt = "rot_src";
                else if (name_txt.Contains("rot_")) name_txt = "rot";
                else if (name_txt.Contains("move_")) name_txt = "move";
                else if (name_txt.Contains("gridsize_")) name_txt = "gridsize";
                else if (name_txt.Contains("p_scale_")) name_txt = "p_scale";
                else if (name_txt.Contains("d_scale_rand_")) name_txt = "d_scale_rand";
                else if (name_txt.Contains("d_rotz_rand_")) name_txt = "d_rotz_rand";
                else if (name_txt.Contains("d_movey_rand_")) name_txt = "d_movey_rand";
                else if (name_txt.Contains("d_pos_")) name_txt = "d_pos";
                name_img = name_txt;
			}
			else if (sender is CheckBox)
			{
				CheckBox Sender = (CheckBox)sender;
				name = Sender.Name;
				name_txt = name.Substring(9, name.Length - 9);
				if (name_txt == "export_map" || name_txt == "export_rmf" || name_txt == "export_obj") name_txt = "target";
                else if (name_txt.Contains("mirror_src_")) name_txt = "mirror_src";
                else if (name_txt.Contains("mirror_")) name_txt = "mirror";
                name_img = name_txt;
				if (Sender.Checked) name_img += 1; else name_img += 0;
			}
			else if (sender is ComboBox)
			{
				ComboBox Sender = (ComboBox)sender;
				name = Sender.Name;
				attachIndex = Sender.SelectedIndex;
				name_txt = name.Substring(9, name.Length - 9);
				name_img = name_txt;

				if (name == "comboBox_shift")
				{
					int a = attachIndex;
					if (a == 0 || a == 4) name_img += "0_4";
					else if (a == 2 || a == 3) name_img += "2_3";
					else name_img += a;
				}
                else if (name == "comboBox_mapcarve")
                {
                    int a = attachIndex;
                    if (a == 1 || a == 2) name_img += "1";
                    else name_img += a;
                }
                else name_img += attachIndex;
            }


            // Fill rich text box
            string resname = "help_rtf_" + name_txt;
			var ResFile = (string)Properties.Resources.ResourceManager.GetObject(resname);
			Box.SelectedRtf = ResFile;

			// Load preview image, if there is one
			string resname2 = "preview_" + name_img;

			var ResFile2 = (Bitmap)Properties.Resources.ResourceManager.GetObject(resname2);
			if (ResFile2 != null) PBox.Image = ResFile2; else PBox.Image = null;

			//MessageBox.Show("ResFile: " + resname + "\r\nResFile2: " + resname2);
		}
	}
}
