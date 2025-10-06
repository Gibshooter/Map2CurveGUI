using System;
using System.Windows.Forms;



namespace Map2CurveGUI
{
	public partial class MainGUI : Form
	{
		// MEMBER VARIABLES
		CurveObject DefCurve = new CurveObject();



		// RESET UI BUTTONS
		private void button_resetAll_Click(object sender, EventArgs e)
		{
			bool TempChangeAll = ChangeAll;
			ChangeAll = false;

			SelCurveObj.setTab1(ref DefCurve);
			SelCurveObj.setTab2(ref DefCurve);
			SelCurveObj.setTab3(ref DefCurve, true);
			SelCurveObj.setTab4(ref DefCurve);
			SetBoxTabValues1(ref DefCurve);
			SetBoxTabValues2(ref DefCurve);
			SetBoxTabValues3(ref DefCurve);
			SetBoxTabValues4(ref DefCurve);

			// Update Settings Tab
			UpdatePresetTab();

			// Changes!!!
			changesTrue();

			// Clear Help Text and Image
			help_Clear();

			// splinefile textbox color reset
			textBox_splinefile.BackColor = ColEmpty;

			// hide splinefile warning
			label_splinefile.Visible = false;

			ChangeAll = TempChangeAll;
		}


		private void button_resetTab1_Click(object sender, EventArgs e)
		{
			bool TempChangeAll = ChangeAll;
			ChangeAll = false;

			SelCurveObj.setTab1(ref DefCurve);
			SetBoxTabValues1(ref DefCurve);

			// Changes!!!
			changesTrue();

			// Clear Help Text and Image
			help_Clear();

			ChangeAll = TempChangeAll;
		}

		private void button_resetTab2_Click(object sender, EventArgs e)
		{
			bool TempChangeAll = ChangeAll;
			ChangeAll = false;

			SelCurveObj.setTab2(ref DefCurve);
			SetBoxTabValues2(ref DefCurve);

			// Changes!!!
			changesTrue();

			// Clear Help Text and Image
			help_Clear();

			ChangeAll = TempChangeAll;
		}

		private void button_resetTab3_Click(object sender, EventArgs e)
		{
			bool TempChangeAll = ChangeAll;
			ChangeAll = false;

			SelCurveObj.setTab3(ref DefCurve, true);
			SetBoxTabValues3(ref DefCurve);

			// Changes!!!
			changesTrue();

			// Clear Help Text and Image
			help_Clear();

			// splinefile textbox color reset
			textBox_splinefile.BackColor = ColEmpty;

			// hide splinefile warning
			label_splinefile.Visible = false;

			ChangeAll = TempChangeAll;
		}

		private void button_resetTab4_Click(object sender, EventArgs e)
		{
			bool TempChangeAll = ChangeAll;
			ChangeAll = false;

			SelCurveObj.setTab4(ref DefCurve);
			SetBoxTabValues4(ref DefCurve);

			// Changes!!!
			changesTrue();

			// Clear Help Text and Image
			help_Clear();

			ChangeAll = TempChangeAll;
		}

		private void ResetColors()
		{
			textBox_input_file.BackColor = ColEmpty;
			textBox_output_folder.BackColor = ColEmpty;
			textBox_output_file_name.BackColor = ColEmpty;
			textBox_splinefile.BackColor = ColEmpty;
		}






		// SET METHODS

		public void SetBoxValues(ref CurveObject Curve, bool UpdateFilePaths = true)
		{
			bool temp_ChangesMade = ChangesMade;

			// textboxes strings
			if (UpdateFilePaths)
			{
				textBox_input_file.Text = Curve.inputFilePath;
				textBox_output_folder.Text = Curve.outputFolder;
				textBox_output_file_name.Text = Curve.outputFilename;
			}
			textBox_nulltex.Text = Curve.nulltex;
			textBox_splinefile.Text = Curve.cornerFilePath;

			// checkboxes
			checkBox_append.Checked = Curve.append;
			checkBox_export_map.Checked = Curve.map;
			checkBox_export_rmf.Checked = Curve.rmf;
			checkBox_export_obj.Checked = Curve.obj;
			checkBox_c_enable.Checked = Curve.c_enable;
			checkBox_gaps.Checked = Curve.gaps;

			// combo boxes
			comboBox_type.SelectedIndex = Curve.type;
			comboBox_heightmode.SelectedIndex = Curve.heightmode;
			comboBox_texmode.SelectedIndex = Curve.texmode;
			comboBox_shift.SelectedIndex = Curve.shift;
			comboBox_hshiftsrc.SelectedIndex = Curve.hshiftsrc;
			comboBox_bounds.SelectedIndex = Curve.bounds;
			comboBox_mapcarve.SelectedIndex = Curve.mapcarve;

			// check boxes
			checkBox_flatcircle.Checked = Curve.flatcircle;
			checkBox_ramp.Checked = Curve.ramp;
			checkBox_hstretch.Checked = Curve.hstretch;
			checkBox_tri.Checked = Curve.tri;
			checkBox_transit_tri.Checked = Curve.transit_tri;
			checkBox_round.Checked = Curve.round;
			checkBox_transit_round.Checked = Curve.transit_round;
			checkBox_p_split.Checked = Curve.p_split;
			checkBox_p_reverse.Checked = Curve.p_reverse;
			checkBox_p_cornerfix.Checked = Curve.p_cornerfix;
			checkBox_p_evenout.Checked = Curve.p_evenout;
			checkBox_d_separate.Checked = Curve.d_separate;
			checkBox_d_autoassign.Checked = Curve.d_autoassign;
			checkBox_d_carve.Checked = Curve.d_carve;
			checkBox_d_circlemode.Checked = Curve.d_circlemode;
			checkBox_d_autopitch.Checked = Curve.d_autopitch;
			checkBox_d_autoyaw.Checked = Curve.d_autoyaw;
			checkBox_d_autoname.Checked = Curve.d_autoname;
			checkBox_d_enable.Checked = Curve.d_enable;
			checkBox_d_draw_rand.Checked = Curve.d_draw_rand;
			checkBox_d_scale_rand.Checked = Curve.d_scale_rand;
			checkBox_d_movey_rand.Checked = Curve.d_movey_rand;
			checkBox_d_pos_rand.Checked = Curve.d_pos_rand;
			checkBox_d_rotz_rand.Checked = Curve.d_rotz_rand;
			checkBox_skipnull.Checked = Curve.skipnull;
            checkBox_mirror_x.Checked = Curve.mirror[0];
            checkBox_mirror_y.Checked = Curve.mirror[1];
            checkBox_mirror_z.Checked = Curve.mirror[2];
            checkBox_mirror_src_x.Checked = Curve.mirror_src[0];
            checkBox_mirror_src_y.Checked = Curve.mirror_src[1];
            checkBox_mirror_src_z.Checked = Curve.mirror_src[2];

            // textboxes numbers
            textBox_rad.Text = Curve.rad.ToString();
			textBox_offset.Text = Curve.offset.ToString();
			textBox_res.Text = Curve.res.ToString();
			textBox_d_draw.Text = Curve.d_draw.ToString();
			textBox_d_skip.Text = Curve.d_skip.ToString();
			textBox_d_pos.Text = Curve.d_pos.ToString();
			textBox_range_start.Text = Curve.range_start.ToString();
			textBox_range_end.Text = Curve.range_end.ToString();
			textBox_height.Text = Curve.height.ToString();
			textBox_hshiftoffset.Text = Curve.hshiftoffset.ToString();
			textBox_hstretchamt.Text = Curve.hstretchamt.ToString();
			textBox_spike_height.Text = Curve.spike_height.ToString();
			textBox_scale_src.Text = Curve.scale_src.ToString();
			textBox_rot_src_x.Text = Curve.rot_src[0].ToString();
			textBox_rot_src_y.Text = Curve.rot_src[1].ToString();
			textBox_rot_src_z.Text = Curve.rot_src[2].ToString();
			textBox_scale.Text = Curve.scale.ToString();
			textBox_rot_x.Text = Curve.rot[0].ToString();
			textBox_rot_y.Text = Curve.rot[1].ToString();
			textBox_rot_z.Text = Curve.rot[2].ToString();
			textBox_move_x.Text = Curve.move[0].ToString();
			textBox_move_y.Text = Curve.move[1].ToString();
			textBox_move_z.Text = Curve.move[2].ToString();
			textBox_p_expand.Text = Curve.p_expand.ToString();
			textBox_p_scale_x.Text = Curve.p_scale[0].ToString();
			textBox_p_scale_y.Text = Curve.p_scale[1].ToString();
			textBox_p_scale_z.Text = Curve.p_scale[2].ToString();
			textBox_d_scale_rand_min.Text = Curve.d_scale_rand_mm[0].ToString();
			textBox_d_scale_rand_max.Text = Curve.d_scale_rand_mm[1].ToString();
			textBox_d_rotz_rand_min.Text = Curve.d_rotz_rand_mm[0].ToString();
			textBox_d_rotz_rand_max.Text = Curve.d_rotz_rand_mm[1].ToString();
			textBox_d_movey_rand_min.Text = Curve.d_movey_rand_mm[0].ToString();
			textBox_d_movey_rand_max.Text = Curve.d_movey_rand_mm[1].ToString();
			textBox_d_pos_min.Text = Curve.d_pos_rand_mm[0].ToString();
			textBox_d_pos_max.Text = Curve.d_pos_rand_mm[1].ToString();
			textBox_gridsize_x.Text = Curve.gridsize[0].ToString();
			textBox_gridsize_y.Text = Curve.gridsize[1].ToString();
			textBox_gridsize_z.Text = Curve.gridsize[2].ToString();
			textBox_gaplen.Text = Curve.gaplen.ToString();

			if (temp_ChangesMade) changesTrue();
			else changesFalse();
		}

		public void SetBoxTabValues1(ref CurveObject Curve)
		{
			// checkboxes
			checkBox_append.Checked = Curve.append;
			checkBox_export_map.Checked = Curve.map;
			checkBox_export_rmf.Checked = Curve.rmf;
			checkBox_export_obj.Checked = Curve.obj;
			checkBox_c_enable.Checked = Curve.c_enable;

			// combo boxes
			comboBox_type.SelectedIndex = Curve.type;
			comboBox_heightmode.SelectedIndex = Curve.heightmode;
			comboBox_texmode.SelectedIndex = Curve.texmode;
			comboBox_shift.SelectedIndex = Curve.shift;
			comboBox_hshiftsrc.SelectedIndex = Curve.hshiftsrc;
			comboBox_bounds.SelectedIndex = Curve.bounds;
			comboBox_mapcarve.SelectedIndex = Curve.mapcarve;

			// check boxes
			checkBox_flatcircle.Checked = Curve.flatcircle;
			checkBox_ramp.Checked = Curve.ramp;
			checkBox_hstretch.Checked = Curve.hstretch;

			// textboxes numbers
			textBox_rad.Text = Curve.rad.ToString();
			textBox_offset.Text = Curve.offset.ToString();
			textBox_res.Text = Curve.res.ToString();
			textBox_range_start.Text = Curve.range_start.ToString();
			textBox_range_end.Text = Curve.range_end.ToString();
			textBox_height.Text = Curve.height.ToString();
			textBox_hshiftoffset.Text = Curve.hshiftoffset.ToString();
			textBox_hstretchamt.Text = Curve.hstretchamt.ToString();
		}


		public void SetBoxTabValues2(ref CurveObject Curve)
		{
			// textboxes strings
			textBox_nulltex.Text = Curve.nulltex;
            textBox_gaplen.Text = Curve.gaplen.ToString();

            // check boxes
            checkBox_tri.Checked = Curve.tri;
			checkBox_transit_tri.Checked = Curve.transit_tri;
			checkBox_round.Checked = Curve.round;
			checkBox_transit_round.Checked = Curve.transit_round;
			checkBox_skipnull.Checked = Curve.skipnull;
            checkBox_gaps.Checked = Curve.gaps;
            checkBox_mirror_x.Checked = Curve.mirror[0];
            checkBox_mirror_y.Checked = Curve.mirror[1];
            checkBox_mirror_z.Checked = Curve.mirror[2];
            checkBox_mirror_src_x.Checked = Curve.mirror_src[0];
            checkBox_mirror_src_y.Checked = Curve.mirror_src[1];
            checkBox_mirror_src_z.Checked = Curve.mirror_src[2];

            // textboxes numbers
            textBox_spike_height.Text = Curve.spike_height.ToString();
			textBox_scale_src.Text = Curve.scale_src.ToString();
			textBox_rot_src_x.Text = Curve.rot_src[0].ToString();
			textBox_rot_src_y.Text = Curve.rot_src[1].ToString();
			textBox_rot_src_z.Text = Curve.rot_src[2].ToString();
			textBox_scale.Text = Curve.scale.ToString();
			textBox_rot_x.Text = Curve.rot[0].ToString();
			textBox_rot_y.Text = Curve.rot[1].ToString();
			textBox_rot_z.Text = Curve.rot[2].ToString();
			textBox_move_x.Text = Curve.move[0].ToString();
			textBox_move_y.Text = Curve.move[1].ToString();
			textBox_move_z.Text = Curve.move[2].ToString();
			textBox_gridsize_x.Text = Curve.gridsize[0].ToString();
			textBox_gridsize_y.Text = Curve.gridsize[1].ToString();
			textBox_gridsize_z.Text = Curve.gridsize[2].ToString();
		}

		public void SetBoxTabValues3(ref CurveObject Curve)
		{
			// strings
			textBox_splinefile.Text = Curve.cornerFilePath;

			// check boxes
			checkBox_p_split.Checked = Curve.p_split;
			checkBox_p_reverse.Checked = Curve.p_reverse;
			checkBox_p_cornerfix.Checked = Curve.p_cornerfix;
			checkBox_p_evenout.Checked = Curve.p_evenout;

			// textboxes numbers
			textBox_p_expand.Text = Curve.p_expand.ToString();
			textBox_p_scale_x.Text = Curve.p_scale[0].ToString();
			textBox_p_scale_y.Text = Curve.p_scale[1].ToString();
			textBox_p_scale_z.Text = Curve.p_scale[2].ToString();
		}

		public void SetBoxTabValues4(ref CurveObject Curve)
		{
			// textboxes numbers
			textBox_d_draw.Text = Curve.d_draw.ToString();
			textBox_d_skip.Text = Curve.d_skip.ToString();
			textBox_d_pos.Text = Curve.d_pos.ToString();

			// check boxes
			checkBox_d_separate.Checked = Curve.d_separate;
			checkBox_d_autoassign.Checked = Curve.d_autoassign;
			checkBox_d_carve.Checked = Curve.d_carve;
			checkBox_d_circlemode.Checked = Curve.d_circlemode;
			checkBox_d_autopitch.Checked = Curve.d_autopitch;
			checkBox_d_autoyaw.Checked = Curve.d_autoyaw;
			checkBox_d_autoname.Checked = Curve.d_autoname;
			checkBox_d_enable.Checked = Curve.d_enable;
			checkBox_d_draw_rand.Checked = Curve.d_draw_rand;
			checkBox_d_scale_rand.Checked = Curve.d_scale_rand;
			checkBox_d_movey_rand.Checked = Curve.d_movey_rand;
			checkBox_d_pos_rand.Checked = Curve.d_pos_rand;
			checkBox_d_rotz_rand.Checked = Curve.d_rotz_rand;

			// textboxes numbers
			textBox_d_scale_rand_min.Text = Curve.d_scale_rand_mm[0].ToString();
			textBox_d_scale_rand_max.Text = Curve.d_scale_rand_mm[1].ToString();
			textBox_d_rotz_rand_min.Text = Curve.d_rotz_rand_mm[0].ToString();
			textBox_d_rotz_rand_max.Text = Curve.d_rotz_rand_mm[1].ToString();
			textBox_d_movey_rand_min.Text = Curve.d_movey_rand_mm[0].ToString();
			textBox_d_movey_rand_max.Text = Curve.d_movey_rand_mm[1].ToString();
			textBox_d_pos_min.Text = Curve.d_pos_rand_mm[0].ToString();
			textBox_d_pos_max.Text = Curve.d_pos_rand_mm[1].ToString();
		}

	}
}