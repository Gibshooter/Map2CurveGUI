using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Map2CurveGUI
{
	public partial class MainGUI : Form
	{
		
		public class ControlTag
		{
			cVar VarType = 0;
			public ControlTag(cVar T)
			{
				VarType = T;
			}
		}

		public void SetAllControlTags()
		{
			checkBox_export_map.Tag = new ControlTag(cVar.map);
			checkBox_export_rmf.Tag = new ControlTag(cVar.rmf);
			checkBox_export_obj.Tag = new ControlTag(cVar.obj);
		}



		// TAB -> PATH_CORNER
		private void button_RemoveCornerFile(object sender, EventArgs e)
		{
            CurveHandler CH = new CurveHandler();
            CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.cornerFilePath, "");

            textBox_splinefile.Text = "";

			// splinefile textbox color reset
			textBox_splinefile.BackColor = ColEmpty;

			// hide splinefile warning
			label_splinefile.Visible = false;
		}

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (tabControl1.SelectedTab.Name == "tabPage_path_corner")
				CheckCornerFileValidity(SelCurveObj.cornerFilePath);
		}

		// Input Path_Corner File Dialog
		public void button_splinefile_Click(object sender, EventArgs e)
		{
			var OF = new Ookii.Dialogs.WinForms.VistaOpenFileDialog() { };
			OF.Filter = "map files (*.map)|*.map";
			OF.InitialDirectory = DIR_ROOT;
			OF.RestoreDirectory = true;

			if (OF.ShowDialog(this) == DialogResult.OK)
			{
				textBox_splinefile.Text = OF.FileName;

                CurveHandler CH = new CurveHandler();
                CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.cornerFilePath, OF.FileName);

                //SelCurveObj.cornerFilePath = OF.FileName; // BAK

                CheckCornerFileValidity(OF.FileName);

				changesTrue();
			}
		}

		private void CheckCornerFileValidity(string FileName)
		{
			try
			{
				if (FileName.Length > 0 && FileName != "UNSET")
				{
					if (File.Exists(FileName))
					{
						string contents = File.ReadAllText(FileName);

						// simple check for at least 2 path_corner entities
						int c1 = contents.IndexOf("path_corner");
						int c2 = contents.LastIndexOf("path_corner");
						if (c1 == -1 || (c1 != -1 && c2 == c1)) label_splinefile.Visible = true;
						else label_splinefile.Visible = false;

					}
					CheckPathValidity(new int[] { 2 });
				}
				else
				{
					label_splinefile.Visible = false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("There was a Problem reading the Path_Corner Map File!\r\n" + ex);
			}
		}






        // CHECK BOXES
        private void checkBox_mirror_CheckedChanged(object sender, EventArgs e)
        {
            var Sender = (CheckBox)sender;
			cVar VarType = cVar.mirror_x;
			bool							   B = checkBox_mirror_x.Checked;
            if      (Sender.Name[16] == 'y') { B = checkBox_mirror_y.Checked; VarType = cVar.mirror_y; }
            else if (Sender.Name[16] == 'z') { B = checkBox_mirror_z.Checked; VarType = cVar.mirror_z; }

            CurveHandler CH = new CurveHandler();
            CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, VarType, B);

            changesTrue();
            help_Populate(sender, e);
        }
        private void checkBox_mirror_src_CheckedChanged(object sender, EventArgs e)
        {
            var Sender = (CheckBox)sender;
			cVar VarType = cVar.mirror_src_x;
			bool							   B = checkBox_mirror_src_x.Checked;
            if      (Sender.Name[20] == 'y') { B = checkBox_mirror_src_y.Checked; VarType = cVar.mirror_src_y; }
            else if (Sender.Name[20] == 'z') { B = checkBox_mirror_src_z.Checked; VarType = cVar.mirror_src_z; }

            CurveHandler CH = new CurveHandler();
            CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, VarType, B);

            changesTrue();
            help_Populate(sender, e);
        }

        private void checkBox_gaps_CheckedChanged(object sender, EventArgs e)
		{
            CurveHandler CH = new CurveHandler();
            CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.gaps, checkBox_gaps.Checked);

            changesTrue();
            help_Populate(sender, e);
        }
        private void checkBox_append_CheckedChanged(object sender, EventArgs e)
		{
            CurveHandler CH = new CurveHandler();
            CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.append, checkBox_append.Checked);

            //SelCurveObj.append = checkBox_append.Checked;
            changesTrue();
            help_Populate(sender, e);
        }
        private void checkBox_export_map_CheckedChanged(object sender, EventArgs e)
		{
            CurveHandler CH = new CurveHandler();
            CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.map, checkBox_export_map.Checked);

            //SelCurveObj.map = checkBox_export_map.Checked;
            changesTrue();
            help_Populate(sender, e);
        }
        private void checkBox_export_rmf_CheckedChanged(object sender, EventArgs e)
		{
            CurveHandler CH = new CurveHandler();
            CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.rmf, checkBox_export_rmf.Checked);

            //SelCurveObj.rmf = checkBox_export_rmf.Checked;
            changesTrue();
            help_Populate(sender, e);
        }
        private void checkBox_export_obj_CheckedChanged(object sender, EventArgs e)
		{
            CurveHandler CH = new CurveHandler();
            CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.obj, checkBox_export_obj.Checked);

            //SelCurveObj.obj = checkBox_export_obj.Checked;
            changesTrue();
            help_Populate(sender, e);
        }
        private void checkBox_c_enable_CheckedChanged(object sender, EventArgs e)
		{
            CurveHandler CH = new CurveHandler();
            CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.c_enable, checkBox_c_enable.Checked);

            //SelCurveObj.c_enable = checkBox_c_enable.Checked;
            changesTrue();
            help_Populate(sender, e);
        }
        private void checkBox_flatten_CheckedChanged(object sender, EventArgs e)
		{
            CurveHandler CH = new CurveHandler();
            CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.flatcircle, checkBox_flatcircle.Checked);

            //SelCurveObj.flatcircle = checkBox_flatcircle.Checked;
            changesTrue();
            help_Populate(sender, e);
        }
        private void checkBox_ramp_CheckedChanged(object sender, EventArgs e)
		{
            CurveHandler CH = new CurveHandler();
            CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.ramp, checkBox_ramp.Checked);

            //SelCurveObj.ramp = checkBox_ramp.Checked;
            changesTrue();
            help_Populate(sender, e);
        }
        private void checkBox_hstretch_CheckedChanged(object sender, EventArgs e)
		{
            CurveHandler CH = new CurveHandler();
            CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.hstretch, checkBox_hstretch.Checked);

            //SelCurveObj.hstretch = checkBox_hstretch.Checked;
            changesTrue();
            help_Populate(sender, e);
        }
        private void checkBox_skipnull_CheckedChanged(object sender, EventArgs e)
		{
            CurveHandler CH = new CurveHandler();
            CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.skipnull, checkBox_skipnull.Checked);

            //SelCurveObj.skipnull = checkBox_skipnull.Checked;
            changesTrue();
		}
		private void checkBox_tri_CheckedChanged(object sender, EventArgs e)
		{
            CurveHandler CH = new CurveHandler();
            CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.tri, checkBox_tri.Checked);

            //SelCurveObj.tri = checkBox_tri.Checked;
            changesTrue();
            help_Populate(sender, e);
        }
        private void checkBox_transit_tri_CheckedChanged(object sender, EventArgs e)
		{
            CurveHandler CH = new CurveHandler();
            CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.transit_tri, checkBox_transit_tri.Checked);

            //SelCurveObj.transit_tri = checkBox_transit_tri.Checked;
            changesTrue();
            help_Populate(sender, e);
        }
        private void checkBox_round_CheckedChanged(object sender, EventArgs e)
		{
            CurveHandler CH = new CurveHandler();
            CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.round, checkBox_round.Checked);

            //SelCurveObj.round = checkBox_round.Checked;
            changesTrue();
            help_Populate(sender, e);
        }
        private void checkBox_transit_round_CheckedChanged(object sender, EventArgs e)
		{
            CurveHandler CH = new CurveHandler();
            CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.transit_round, checkBox_transit_round.Checked);

            //SelCurveObj.transit_round = checkBox_transit_round.Checked;
            changesTrue();
            help_Populate(sender, e);
        }
        private void checkBox_p_split_CheckedChanged(object sender, EventArgs e)
		{
            CurveHandler CH = new CurveHandler();
            CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.p_split, checkBox_p_split.Checked);

            //SelCurveObj.p_split = checkBox_p_split.Checked;
            changesTrue();
		}
		private void checkBox_p_reverse_CheckedChanged(object sender, EventArgs e)
		{
            CurveHandler CH = new CurveHandler();
            CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.p_reverse, checkBox_p_reverse.Checked);

            //SelCurveObj.p_reverse = checkBox_p_reverse.Checked;
            changesTrue();
		}
		private void checkBox_p_evenout_CheckedChanged(object sender, EventArgs e)
		{
            CurveHandler CH = new CurveHandler();
            CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.p_evenout, checkBox_p_evenout.Checked);

            //SelCurveObj.p_evenout = checkBox_p_evenout.Checked;
            changesTrue();
		}
		private void checkBox_p_cornerfix_CheckedChanged(object sender, EventArgs e)
		{
            CurveHandler CH = new CurveHandler();
            CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.p_cornerfix, checkBox_p_cornerfix.Checked);

            //SelCurveObj.p_cornerfix = checkBox_p_cornerfix.Checked;
            changesTrue();
		}
		private void checkBox_d_separate_CheckedChanged(object sender, EventArgs e)
		{
            CurveHandler CH = new CurveHandler();
            CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.d_separate, checkBox_d_separate.Checked);

            //SelCurveObj.d_separate = checkBox_d_separate.Checked;
            changesTrue();
		}
		private void checkBox_d_autoassign_CheckedChanged(object sender, EventArgs e)
		{
            CurveHandler CH = new CurveHandler();
            CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.d_autoassign, checkBox_d_autoassign.Checked);

            //SelCurveObj.d_autoassign = checkBox_d_autoassign.Checked;
            changesTrue();
		}
		private void checkBox_d_carve_CheckedChanged(object sender, EventArgs e)
		{
            CurveHandler CH = new CurveHandler();
            CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.d_carve, checkBox_d_carve.Checked);

            //SelCurveObj.d_carve = checkBox_d_carve.Checked;
            changesTrue();
		}
		private void checkBox_d_autopitch_CheckedChanged(object sender, EventArgs e)
		{
            CurveHandler CH = new CurveHandler();
            CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.d_autopitch, checkBox_d_autopitch.Checked);

            //SelCurveObj.d_autopitch = checkBox_d_autopitch.Checked;
            changesTrue();
		}
		private void checkBox_d_autoyaw_CheckedChanged(object sender, EventArgs e)
		{
            CurveHandler CH = new CurveHandler();
            CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.d_autoyaw, checkBox_d_autoyaw.Checked);

            //SelCurveObj.d_autoyaw = checkBox_d_autoyaw.Checked;
			changesTrue();
		}
		private void checkBox_d_autoname_CheckedChanged(object sender, EventArgs e)
		{
            CurveHandler CH = new CurveHandler();
            CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.d_autoname, checkBox_d_autoname.Checked);

            //SelCurveObj.d_autoname = checkBox_d_autoname.Checked;
			changesTrue();
		}
		private void checkBox_d_enable_CheckedChanged(object sender, EventArgs e)
		{
            CurveHandler CH = new CurveHandler();
            CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.d_enable, checkBox_d_enable.Checked);

            //SelCurveObj.d_enable = checkBox_d_enable.Checked;
			changesTrue();
		}
		private void checkBox_d_scale_rand_CheckedChanged(object sender, EventArgs e)
		{
            CurveHandler CH = new CurveHandler();
            CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.d_scale_rand, checkBox_d_scale_rand.Checked);

            //SelCurveObj.d_scale_rand = checkBox_d_scale_rand.Checked;
			changesTrue();
		}
		private void checkBox_d_rotz_rand_CheckedChanged(object sender, EventArgs e)
		{
            CurveHandler CH = new CurveHandler();
            CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.d_rotz_rand, checkBox_d_rotz_rand.Checked);

            //SelCurveObj.d_rotz_rand = checkBox_d_rotz_rand.Checked;
            changesTrue();
		}
		private void checkBox_d_movey_rand_CheckedChanged(object sender, EventArgs e)
		{
            CurveHandler CH = new CurveHandler();
            CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.d_movey_rand, checkBox_d_movey_rand.Checked);

            //SelCurveObj.d_movey_rand = checkBox_d_movey_rand.Checked;
            changesTrue();
		}
		private void checkBox_d_pos_CheckedChanged(object sender, EventArgs e)
		{
            CurveHandler CH = new CurveHandler();
            CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.d_pos_rand, checkBox_d_pos_rand.Checked);

            //SelCurveObj.d_pos_rand = checkBox_d_pos_rand.Checked;
            changesTrue();
		}
		private void checkBox_d_circlemode_CheckedChanged(object sender, EventArgs e)
		{
            CurveHandler CH = new CurveHandler();
            CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.d_circlemode, checkBox_d_circlemode.Checked);

            //SelCurveObj.d_circlemode = checkBox_d_circlemode.Checked;
			changesTrue();
		}
		private void checkBox_d_draw_rand_CheckedChanged(object sender, EventArgs e)
		{
            CurveHandler CH = new CurveHandler();
            CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.d_draw_rand, checkBox_d_draw_rand.Checked);

            //SelCurveObj.d_draw_rand = checkBox_d_draw_rand.Checked;
			changesTrue();
		}



		// COMBO BOXES
		private void comboBox_mapcarve_SelectedIndexChanged(object sender, EventArgs e)
		{
            CurveHandler CH = new CurveHandler();
            CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.mapcarve, comboBox_mapcarve.SelectedIndex);

            //SelCurveObj.mapcarve = comboBox_mapcarve.SelectedIndex;
			changesTrue();
            help_Populate(sender, e);
        }

        private void comboBox_type_SelectedIndexChanged(object sender, EventArgs e)
		{
            CurveHandler CH = new CurveHandler();
            CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.type, comboBox_type.SelectedIndex);

            //SelCurveObj.type = comboBox_type.SelectedIndex;

			// gray out some options depending on selected type
			if (comboBox_type.SelectedIndex == 0)
			{
				checkBox_flatcircle.ForeColor = ColEmpty;
				checkBox_d_carve.ForeColor = ColEmpty;
			}
			else
			{
				checkBox_flatcircle.ForeColor = Color.LightGray;
				checkBox_d_carve.ForeColor = Color.LightGray;
			}
			changesTrue();
            help_Populate(sender, e);
        }
        private void comboBox_texmode_SelectedIndexChanged(object sender, EventArgs e)
		{
            CurveHandler CH = new CurveHandler();
            CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.texmode, comboBox_texmode.SelectedIndex);
            
			//SelCurveObj.texmode = comboBox_texmode.SelectedIndex;
			changesTrue();
            help_Populate(sender, e);
        }
        private void comboBox_heightmode_SelectedIndexChanged(object sender, EventArgs e)
		{
            CurveHandler CH = new CurveHandler();
            CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.heightmode, comboBox_heightmode.SelectedIndex);

            //SelCurveObj.heightmode = comboBox_heightmode.SelectedIndex;
            changesTrue();
            help_Populate(sender, e);
        }
        private void comboBox_shift_SelectedIndexChanged(object sender, EventArgs e)
		{
            CurveHandler CH = new CurveHandler();
            CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.shift, comboBox_shift.SelectedIndex);

            //SelCurveObj.shift = comboBox_shift.SelectedIndex;
			changesTrue();
			help_Populate(sender, e);
		}
		private void comboBox_hshiftsrc_SelectedIndexChanged(object sender, EventArgs e)
		{
            CurveHandler CH = new CurveHandler();
            CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.hshiftsrc, comboBox_hshiftsrc.SelectedIndex);

            //SelCurveObj.hshiftsrc = comboBox_hshiftsrc.SelectedIndex;
			changesTrue();
			help_Populate(sender, e);
		}
		private void comboBox_bounds_SelectedIndexChanged(object sender, EventArgs e)
		{
            CurveHandler CH = new CurveHandler();
            CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.bounds, comboBox_bounds.SelectedIndex);

            //SelCurveObj.bounds = comboBox_bounds.SelectedIndex;
			changesTrue();
			help_Populate(sender, e);
		}






		// TEXT BOXES
		private void textBox_gaplen_Leave(object sender, EventArgs e)
		{
			float temp;
			try
			{
				temp = Int32.Parse(textBox_gaplen.Text);
				if (temp < 0)
				{
					temp = 0;
					textBox_gaplen.Text = "0";
				}
				else if (temp > 131072)
				{
					temp = 131072;
					textBox_gaplen.Text = "131072";
				}
				else
				{
					textBox_gaplen.Text = temp.ToString();
				}
				if (SelCurveObj.gaplen != temp)
				{
                    CurveHandler CH = new CurveHandler();
                    CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.gaplen, temp);

                    //SelCurveObj.gaplen = temp;
					changesTrue();
				}
			}
			catch { textBox_gaplen.Text = SelCurveObj.gaplen.ToString(); }
		}
		private void textBox_radius_Leave(object sender, EventArgs e)
		{
			float temp;
			try
			{
				temp = Int32.Parse(textBox_rad.Text);
				if (temp < 0)
				{
					temp = 0;
					textBox_rad.Text = "0";
				}
				else if (temp > 131072)
				{
					temp = 131072;
					textBox_rad.Text = "131072";
				}
				else
				{
					textBox_rad.Text = temp.ToString();
				}
				if (SelCurveObj.rad != temp)
				{
                    CurveHandler CH = new CurveHandler();
                    CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.rad, temp);

                    //SelCurveObj.rad = temp;
					changesTrue();
				}
			}
			catch { textBox_rad.Text = SelCurveObj.rad.ToString(); }
		}


		private void textBox_offset_Leave(object sender, EventArgs e)
		{
			float temp;
			try
			{
				temp = float.Parse(textBox_offset.Text);
				if (temp < -131072)
				{
					temp = -131072;
					textBox_offset.Text = "-131072";
				}
				else if (temp > 131072)
				{
					temp = 131072;
					textBox_offset.Text = "131072";
				}
				else
				{
					textBox_offset.Text = temp.ToString();
				}
				if (SelCurveObj.offset != temp)
				{
                    CurveHandler CH = new CurveHandler();
                    CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.offset, temp);

                    //SelCurveObj.offset = temp;
					changesTrue();
				}
			}
			catch { textBox_offset.Text = SelCurveObj.offset.ToString(); }
		}


		private void textBox_res_Leave(object sender, EventArgs e)
		{
			int temp;
			try
			{
				temp = Int32.Parse(textBox_res.Text);
				if (temp > 384)
				{
					temp = 384;
					textBox_res.Text = "384";
				}
				else if (temp < 0)
				{
					temp = 0;
					textBox_res.Text = "0";
				}
				else
				{
					textBox_res.Text = temp.ToString();
				}
				if (SelCurveObj.res != temp)
				{
                    CurveHandler CH = new CurveHandler();
                    CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.res, temp);

                    //SelCurveObj.res = temp;
                    changesTrue();
				}
			}
			catch { textBox_res.Text = SelCurveObj.res.ToString(); } //Console.WriteLine($"Unable to parse '{content}'");
		}


		private void textBox_range_start_Leave(object sender, EventArgs e)
		{
			float temp;
			ref float ST = ref SelCurveObj.range_start;
			try
			{
				temp = float.Parse(textBox_range_start.Text);
				if (temp < 0 || temp >= SelCurveObj.range_end)
				{
					temp = 0;
					textBox_range_start.Text = "0";
				}
				else
				{
					textBox_range_start.Text = temp.ToString();
				}
				if (ST != temp)
				{
                    CurveHandler CH = new CurveHandler();
                    CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.range_start, temp);

                    //ST = temp;
                    changesTrue();
				}
			}
			catch { textBox_range_start.Text = ST.ToString(); }
		}


		private void textBox_range_end_Leave(object sender, EventArgs e)
		{
			float temp;
			ref float ST = ref SelCurveObj.range_end;
			try
			{
				temp = float.Parse(textBox_range_end.Text);
				if (temp > 100 || temp <= SelCurveObj.range_start)
				{
					temp = 100;
					textBox_range_end.Text = "100";
				}
				else { textBox_range_end.Text = temp.ToString(); }
				if (ST != temp)
				{
                    CurveHandler CH = new CurveHandler();
                    CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.range_end, temp);

                    //ST = temp;
                    changesTrue();
				}
			}
			catch { textBox_range_end.Text = ST.ToString(); }
		}

		private void textBox_height_Leave(object sender, EventArgs e)
		{
			ref float ST = ref SelCurveObj.height;
			float temp;
			try { temp = float.Parse(textBox_height.Text);
				if (temp != ST)
				{
                    CurveHandler CH = new CurveHandler();
                    CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.height, temp);

                    //ST = temp;
                    changesTrue();
				} }
			catch { textBox_height.Text = ST.ToString(); }
		}

		private void textBox_hshiftoffset_Leave(object sender, EventArgs e)
		{
			ref float ST = ref SelCurveObj.hshiftoffset;
			float temp;
			try { temp = float.Parse(textBox_hshiftoffset.Text); if (temp != ST) {
                    CurveHandler CH = new CurveHandler();
                    CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.hshiftoffset, temp);

                    //ST = temp;
                    changesTrue();
				} }
			catch { textBox_hshiftoffset.Text = ST.ToString(); }
		}

		private void textBox_hstretchamt_Leave(object sender, EventArgs e)
		{
			float temp;
			ref float ST = ref SelCurveObj.hstretchamt;
			try
			{
				temp = float.Parse(textBox_hstretchamt.Text);
				if (temp < 0) { temp = ST; textBox_hstretchamt.Text = ST.ToString(); }
				if (ST != temp) {
                    CurveHandler CH = new CurveHandler();
                    CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.hstretchamt, temp);

                    //ST = temp;
					changesTrue();
				}
			}
			catch { textBox_hstretchamt.Text = ST.ToString(); }
		}

		private void textBox_nulltex_Leave(object sender, EventArgs e)
		{
			string temp = textBox_nulltex.Text;
			if (temp != SelCurveObj.nulltex)
			{
                CurveHandler CH = new CurveHandler();
                CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.nulltex, temp);

                //SelCurveObj.nulltex = textBox_nulltex.Text;
				changesTrue();
			}
		}

		private void textBox_spike_height_Leave(object sender, EventArgs e)
		{
			float temp;
			ref float ST = ref SelCurveObj.spike_height;
			try
			{
				temp = float.Parse(textBox_spike_height.Text);
				if (temp < 0) { temp = ST; textBox_spike_height.Text = ST.ToString(); }
				if (ST != temp) {
                    CurveHandler CH = new CurveHandler();
                    CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.spike_height, temp);

                    //ST = temp;
					changesTrue();
				}
			}
			catch { textBox_spike_height.Text = ST.ToString(); }
		}

		private void textBox_scale_src_Leave(object sender, EventArgs e)
		{
			float temp;
			ref float ST = ref SelCurveObj.scale_src;
			try
			{
				temp = float.Parse(textBox_scale_src.Text);
				if (temp < 0) { temp = ST; textBox_scale_src.Text = ST.ToString(); }
				if (ST != temp) {
                    CurveHandler CH = new CurveHandler();
                    CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.scale_src, temp);

                    //ST = temp;
					changesTrue();
				}
			}
			catch { textBox_scale_src.Text = ST.ToString(); }
		}
		private void textBox_gridsize_Leave(object sender, EventArgs e)
		{
			TextBox Sender = (TextBox)sender;
			string name = Sender.Name;
			int a = 0;
			cVar VarType = cVar.gridsize_x;

            if		(name[17] == 'y') { a = 1; VarType = cVar.gridsize_y; }
			else if (name[17] == 'z') { a = 2; VarType = cVar.gridsize_z; }

			float temp;
			ref float ST = ref SelCurveObj.gridsize[a];
			ref TextBox textBox = ref textBox_gridsize_x;
			if (a==1)	textBox = ref textBox_gridsize_y;
			if (a==2)	textBox = ref textBox_gridsize_z;
			try
			{
				temp = float.Parse(textBox.Text);
				if (ST != temp) {
                    CurveHandler CH = new CurveHandler();
                    CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, VarType, temp);

                    //ST = temp;
					changesTrue();
				}
			}
			catch {
				textBox.Text = ST.ToString();
			}
		}

		private void textBox_rot_src_x_Leave(object sender, EventArgs e)
		{
			float temp;
			ref float ST = ref SelCurveObj.rot_src[0];
			try
			{
				temp = float.Parse(textBox_rot_src_x.Text);
				if (ST != temp) {
                    CurveHandler CH = new CurveHandler();
                    CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.rot_src_x, temp);

                    //ST = temp;
					changesTrue();
				}
			}
			catch { textBox_rot_src_x.Text = ST.ToString(); }
		}

		private void textBox_rot_src_y_Leave(object sender, EventArgs e)
		{
			float temp;
			ref float ST = ref SelCurveObj.rot_src[1];
			try
			{
				temp = float.Parse(textBox_rot_src_y.Text);
				if (ST != temp) {
                    CurveHandler CH = new CurveHandler();
                    CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.rot_src_y, temp);

                    //ST = temp;
					changesTrue();
				}
			}
			catch { textBox_rot_src_y.Text = ST.ToString(); }
		}

		private void textBox_rot_src_z_Leave(object sender, EventArgs e)
		{
			float temp;
			ref float ST = ref SelCurveObj.rot_src[2];
			try
			{
				temp = float.Parse(textBox_rot_src_z.Text);
				if (ST != temp) {
                    CurveHandler CH = new CurveHandler();
                    CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.rot_src_z, temp);

                    //ST = temp;
                    changesTrue();
				}
			}
			catch { textBox_rot_src_z.Text = ST.ToString(); }
		}

		private void textBox_scale_Leave(object sender, EventArgs e)
		{
			float temp;
			ref float ST = ref SelCurveObj.scale;
			try
			{
				temp = float.Parse(textBox_scale.Text);
				if (temp < 0) { temp = ST; textBox_scale.Text = ST.ToString(); }
				if (ST != temp) {
                    CurveHandler CH = new CurveHandler();
                    CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.scale, temp);

                    //ST = temp;
                    changesTrue();
				}
			}
			catch { textBox_scale.Text = ST.ToString(); }
		}

		private void textBox_rot_x_Leave(object sender, EventArgs e)
		{
			float temp;
			ref float ST = ref SelCurveObj.rot[0];
			try
			{
				temp = float.Parse(textBox_rot_x.Text);
				if (ST != temp) {
                    CurveHandler CH = new CurveHandler();
                    CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.rot_x, temp);

                    //ST = temp;
                    changesTrue();
				}
			}
			catch { textBox_rot_x.Text = ST.ToString(); }
		}

		private void textBox_rot_y_Leave(object sender, EventArgs e)
		{
			float temp;
			ref float ST = ref SelCurveObj.rot[1];
			try
			{
				temp = float.Parse(textBox_rot_y.Text);
				if (ST != temp) {
                    CurveHandler CH = new CurveHandler();
                    CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.rot_y, temp);

                    //ST = temp;
                    changesTrue();
				}
			}
			catch { textBox_rot_y.Text = ST.ToString(); }
		}

		private void textBox_rot_z_Leave(object sender, EventArgs e)
		{
			float temp;
			ref float ST = ref SelCurveObj.rot[2];
			try
			{
				temp = float.Parse(textBox_rot_z.Text);
				if (ST != temp) {
                    CurveHandler CH = new CurveHandler();
                    CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.rot_z, temp);

                    //ST = temp;
                    changesTrue();
				}
			}
			catch { textBox_rot_z.Text = ST.ToString(); }
		}

		private void textBox_move_x_Leave(object sender, EventArgs e)
		{
			float temp;
			ref float ST = ref SelCurveObj.move[0];
			try
			{
				temp = float.Parse(textBox_move_x.Text);
				if (ST != temp) {
                    CurveHandler CH = new CurveHandler();
                    CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.move_x, temp);

                    //ST = temp;
					changesTrue();
				}
			}
			catch { textBox_move_x.Text = ST.ToString(); }
		}

		private void textBox_move_y_Leave(object sender, EventArgs e)
		{
			float temp;
			ref float ST = ref SelCurveObj.move[1];
			try
			{
				temp = float.Parse(textBox_move_y.Text);
				if (ST != temp) {
                    CurveHandler CH = new CurveHandler();
                    CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.move_y, temp);

                    //ST = temp;
                    changesTrue();
				}
			}
			catch { textBox_move_y.Text = ST.ToString(); }
		}

		private void textBox_move_z_Leave(object sender, EventArgs e)
		{
			float temp;
			ref float ST = ref SelCurveObj.move[2];
			try
			{
				temp = float.Parse(textBox_move_z.Text);
				if (ST != temp) {
                    CurveHandler CH = new CurveHandler();
                    CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.move_z, temp);

                    //ST = temp;
					changesTrue();
				}
			}
			catch { textBox_move_z.Text = ST.ToString(); }
		}

		private void textBox_p_expand_Leave(object sender, EventArgs e)
		{
			float temp;
			ref float ST = ref SelCurveObj.p_expand;
			try
			{
				temp = float.Parse(textBox_p_expand.Text);
				if (temp < 0) { temp = ST; textBox_p_expand.Text = ST.ToString(); }
				if (ST != temp) {
                    CurveHandler CH = new CurveHandler();
                    CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.p_expand, temp);

                    //ST = temp;
					changesTrue();
				}
			}
			catch { textBox_p_expand.Text = ST.ToString(); }
		}

		private void textBox_p_scale_x_Leave(object sender, EventArgs e)
		{
			float temp;
			ref float ST = ref SelCurveObj.p_scale[0];
			try
			{
				temp = float.Parse(textBox_p_scale_x.Text);
				if (ST != temp) {
                    CurveHandler CH = new CurveHandler();
                    CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.p_scale_x, temp);

                    //ST = temp;
					changesTrue();
				}
			}
			catch { textBox_p_scale_x.Text = ST.ToString(); }
		}

		private void textBox_p_scale_y_Leave(object sender, EventArgs e)
		{
			float temp;
			ref float ST = ref SelCurveObj.p_scale[1];
			try
			{
				temp = float.Parse(textBox_p_scale_y.Text);
				if (ST != temp) {
                    CurveHandler CH = new CurveHandler();
                    CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.p_scale_y, temp);

                    //ST = temp;
					changesTrue();
				}
			}
			catch { textBox_p_scale_y.Text = ST.ToString(); }
		}

		private void textBox_p_scale_z_Leave(object sender, EventArgs e)
		{
			float temp;
			ref float ST = ref SelCurveObj.p_scale[2];
			try
			{
				temp = float.Parse(textBox_p_scale_z.Text);
				if (ST != temp) {
                    CurveHandler CH = new CurveHandler();
                    CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.p_scale_z, temp);

                    //ST = temp;
					changesTrue();
				}
			}
			catch { textBox_p_scale_z.Text = ST.ToString(); }
		}

		private void textBox_d_pos_Leave(object sender, EventArgs e)
		{
			ref float ST = ref SelCurveObj.d_pos;
			float temp;
			try
			{
				temp = float.Parse(textBox_d_pos.Text);
				if (temp > 1)
				{
					temp = 1;
					textBox_d_pos.Text = "1";
				}
				else if (temp < 0)
				{
					temp = 0;
					textBox_d_pos.Text = "0";
				}
				else
				{
					textBox_d_pos.Text = temp.ToString();
				}
				if (ST != temp) {
                    CurveHandler CH = new CurveHandler();
                    CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.d_pos, temp);

                    //ST = temp;
					changesTrue();
				}
			}
			catch { textBox_d_pos.Text = SelCurveObj.d_pos.ToString(); }
		}

		private void textBox_d_draw_Leave(object sender, EventArgs e)
		{
			int temp;
			ref int ST = ref SelCurveObj.d_draw;
			try
			{
				temp = Int32.Parse(textBox_d_draw.Text);
				if (temp < 0) { temp = ST; textBox_d_draw.Text = ST.ToString(); }
				if (ST != temp) {
                    CurveHandler CH = new CurveHandler();
                    CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.d_draw, temp);

                    //ST = temp;
					changesTrue();
				}
			}
			catch { textBox_d_draw.Text = ST.ToString(); }
		}

		private void textBox_d_skip_Leave(object sender, EventArgs e)
		{
			int temp;
			ref int ST = ref SelCurveObj.d_skip;
			try
			{
				temp = Int32.Parse(textBox_d_skip.Text);
				if (temp < 0) { temp = ST; textBox_d_skip.Text = ST.ToString(); }
				if (ST != temp) {
                    CurveHandler CH = new CurveHandler();
                    CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.d_skip, temp);

                    //ST = temp;
                    changesTrue();
				}
			}
			catch { textBox_d_skip.Text = ST.ToString(); }
		}

		private void textBox_d_scale_rand_min_Leave(object sender, EventArgs e)
		{
			float temp;
			ref float ST = ref SelCurveObj.d_scale_rand_mm[0];
			try
			{
				temp = float.Parse(textBox_d_scale_rand_min.Text);
				if (temp < 0) { temp = ST; textBox_d_scale_rand_min.Text = ST.ToString(); }
				if (ST != temp) {
                    CurveHandler CH = new CurveHandler();
                    CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.d_scale_rand_mm_min, temp);

                    //ST = temp;
					changesTrue();
				}
			}
			catch { textBox_d_scale_rand_min.Text = ST.ToString(); }
		}

		private void textBox_d_scale_rand_max_Leave(object sender, EventArgs e)
		{
			float temp;
			ref float ST = ref SelCurveObj.d_scale_rand_mm[1];
			try
			{
				temp = float.Parse(textBox_d_scale_rand_max.Text);
				if (temp < 0) { temp = ST; textBox_d_scale_rand_max.Text = ST.ToString(); }
				if (ST != temp) {
                    CurveHandler CH = new CurveHandler();
                    CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.d_scale_rand_mm_max, temp);

                    //ST = temp;
					changesTrue();
				}
			}
			catch { textBox_d_scale_rand_max.Text = ST.ToString(); }
		}

		private void textBox_d_rotz_rand_min_Leave(object sender, EventArgs e)
		{
			float temp;
			ref float ST = ref SelCurveObj.d_rotz_rand_mm[0];
			try
			{
				temp = float.Parse(textBox_d_rotz_rand_min.Text);
				if (ST != temp) {
                    CurveHandler CH = new CurveHandler();
                    CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.d_rotz_rand_mm_min, temp);

                    //ST = temp;
					changesTrue();
				}
			}
			catch { textBox_d_rotz_rand_min.Text = ST.ToString(); }
		}

		private void textBox_d_rotz_rand_max_Leave(object sender, EventArgs e)
		{
			float temp;
			ref float ST = ref SelCurveObj.d_rotz_rand_mm[1];
			try
			{
				temp = float.Parse(textBox_d_rotz_rand_max.Text);
				if (ST != temp) {
                    CurveHandler CH = new CurveHandler();
                    CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.d_rotz_rand_mm_max, temp);

                    //ST = temp;
					changesTrue();
				}
			}
			catch { textBox_d_rotz_rand_max.Text = ST.ToString(); }
		}

		private void textBox_d_movey_rand_min_Leave(object sender, EventArgs e)
		{
			float temp;
			ref float ST = ref SelCurveObj.d_movey_rand_mm[0];
			try
			{
				temp = float.Parse(textBox_d_movey_rand_min.Text);
				if (ST != temp) {
                    CurveHandler CH = new CurveHandler();
                    CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.d_movey_rand_mm_min, temp);

                    //ST = temp;
					changesTrue();
				}
			}
			catch { textBox_d_movey_rand_min.Text = ST.ToString(); }
		}

		private void textBox_d_movey_rand_max_Leave(object sender, EventArgs e)
		{
			float temp;
			ref float ST = ref SelCurveObj.d_movey_rand_mm[1];
			try
			{
				temp = float.Parse(textBox_d_movey_rand_max.Text);
				if (ST != temp) {
                    CurveHandler CH = new CurveHandler();
                    CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.d_movey_rand_mm_max, temp);

                    //ST = temp;
					changesTrue();
				}
			}
			catch { textBox_d_movey_rand_max.Text = ST.ToString(); }
		}

		private void textBox_d_pos_min_Leave(object sender, EventArgs e)
		{
			float temp;
			ref float ST = ref SelCurveObj.d_pos_rand_mm[0];
			try
			{
				temp = float.Parse(textBox_d_pos_min.Text);
				if (temp > 1)
				{
					temp = 1;
					textBox_d_pos_min.Text = "1";
				}
				else if (temp < 0)
				{
					temp = 0;
					textBox_d_pos_min.Text = "0";
				}
				else
				{
					textBox_d_pos_min.Text = temp.ToString();
				}
				if (ST != temp) {
                    CurveHandler CH = new CurveHandler();
                    CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.d_pos_rand_mm_min, temp);

                    //ST = temp;
					changesTrue(); }
			}
			catch { textBox_d_pos_min.Text = ST.ToString(); }
		}

		private void textBox_d_pos_max_Leave(object sender, EventArgs e)
		{
			float temp;
			ref float ST = ref SelCurveObj.d_pos_rand_mm[1];
			try
			{
				temp = float.Parse(textBox_d_pos_max.Text);
				if (temp > 1)
				{
					temp = 1;
					textBox_d_pos_max.Text = "1";
				}
				else if (temp < 0)
				{
					temp = 0;
					textBox_d_pos_max.Text = "0";
				}
				else
				{
					textBox_d_pos_max.Text = temp.ToString();
				}
				if (ST != temp) {
                    CurveHandler CH = new CurveHandler();
                    CH.CurveObjListChangeValue(ref CurveList, ref sender, ChangeAll, SelCurveID, cVar.d_pos_rand_mm_max, temp);

                    //ST = temp;
					changesTrue(); }
			}
			catch { textBox_d_pos_max.Text = ST.ToString(); }
		}


	}

}
