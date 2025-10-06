namespace Map2CurveGUI
{
	partial class MainGUI
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGUI));
			this.button_input_file_select = new System.Windows.Forms.Button();
			this.label_output_file_name = new System.Windows.Forms.Label();
			this.textBox_output_file_name = new System.Windows.Forms.TextBox();
			this.textBox_output_folder = new System.Windows.Forms.TextBox();
			this.textBox_input_file = new System.Windows.Forms.TextBox();
			this.button_output_folder_select = new System.Windows.Forms.Button();
			this.toolStripMenu_file = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenu_Close = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenu_load = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenu_save = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenu_save_as = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenu_MRU = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenu_help = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenu_tutorials = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenu_tuts_0 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenu_tuts_1 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenu_tuts_2 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenu_tuts_3 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenu_onlineDoc = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenu_about = new System.Windows.Forms.ToolStripMenuItem();
			this.button_resetAll = new System.Windows.Forms.Button();
			this.button_Output_File_Open = new System.Windows.Forms.Button();
			this.label_hint_saveChanges = new System.Windows.Forms.Label();
			this.toolTip_general = new System.Windows.Forms.ToolTip(this.components);
			this.button_generate = new System.Windows.Forms.Button();
			this.button_resetTab4 = new System.Windows.Forms.Button();
			this.button_resetTab2 = new System.Windows.Forms.Button();
			this.button_resetTab1 = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage_general = new System.Windows.Forms.TabPage();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.pictureBox_help_mapcarve = new System.Windows.Forms.PictureBox();
			this.comboBox_mapcarve = new System.Windows.Forms.ComboBox();
			this.label_mapcarve = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.groupBox_output_file_settings = new System.Windows.Forms.GroupBox();
			this.pictureBox_help_target_2 = new System.Windows.Forms.PictureBox();
			this.pictureBox_help_append = new System.Windows.Forms.PictureBox();
			this.checkBox_export_map = new System.Windows.Forms.CheckBox();
			this.checkBox_export_obj = new System.Windows.Forms.CheckBox();
			this.checkBox_append = new System.Windows.Forms.CheckBox();
			this.checkBox_export_rmf = new System.Windows.Forms.CheckBox();
			this.groupBox_curve_settings = new System.Windows.Forms.GroupBox();
			this.pictureBox_help_bounds = new System.Windows.Forms.PictureBox();
			this.pictureBox_help_range = new System.Windows.Forms.PictureBox();
			this.pictureBox_help_flatcircle = new System.Windows.Forms.PictureBox();
			this.pictureBox_help_type = new System.Windows.Forms.PictureBox();
			this.pictureBox_help_res = new System.Windows.Forms.PictureBox();
			this.pictureBox_help_offset = new System.Windows.Forms.PictureBox();
			this.pictureBox_help_rad = new System.Windows.Forms.PictureBox();
			this.pictureBox_help_c_enable = new System.Windows.Forms.PictureBox();
			this.comboBox_bounds = new System.Windows.Forms.ComboBox();
			this.label_bounds = new System.Windows.Forms.Label();
			this.checkBox_c_enable = new System.Windows.Forms.CheckBox();
			this.textBox_range_end = new System.Windows.Forms.TextBox();
			this.checkBox_flatcircle = new System.Windows.Forms.CheckBox();
			this.label_range_end = new System.Windows.Forms.Label();
			this.label_type = new System.Windows.Forms.Label();
			this.label_range_start = new System.Windows.Forms.Label();
			this.comboBox_type = new System.Windows.Forms.ComboBox();
			this.textBox_range_start = new System.Windows.Forms.TextBox();
			this.label_res = new System.Windows.Forms.Label();
			this.textBox_res = new System.Windows.Forms.TextBox();
			this.textBox_rad = new System.Windows.Forms.TextBox();
			this.label_offset = new System.Windows.Forms.Label();
			this.textBox_offset = new System.Windows.Forms.TextBox();
			this.label_radius = new System.Windows.Forms.Label();
			this.groupBox_height_ramp = new System.Windows.Forms.GroupBox();
			this.pictureBox_help_ramp = new System.Windows.Forms.PictureBox();
			this.pictureBox_help_heightmode = new System.Windows.Forms.PictureBox();
			this.pictureBox_help_height = new System.Windows.Forms.PictureBox();
			this.checkBox_ramp = new System.Windows.Forms.CheckBox();
			this.label_heightmode = new System.Windows.Forms.Label();
			this.comboBox_heightmode = new System.Windows.Forms.ComboBox();
			this.textBox_height = new System.Windows.Forms.TextBox();
			this.label_height = new System.Windows.Forms.Label();
			this.groupBox_texture_settings = new System.Windows.Forms.GroupBox();
			this.pictureBox_help_hstretchamt = new System.Windows.Forms.PictureBox();
			this.pictureBox_help_hstretch = new System.Windows.Forms.PictureBox();
			this.pictureBox_help_hshiftoffset = new System.Windows.Forms.PictureBox();
			this.pictureBox_help_hshiftsrc = new System.Windows.Forms.PictureBox();
			this.pictureBox_help_shift = new System.Windows.Forms.PictureBox();
			this.pictureBox_help_texmode = new System.Windows.Forms.PictureBox();
			this.label_shift = new System.Windows.Forms.Label();
			this.comboBox_shift = new System.Windows.Forms.ComboBox();
			this.textBox_hstretchamt = new System.Windows.Forms.TextBox();
			this.label_hstretchamt = new System.Windows.Forms.Label();
			this.checkBox_hstretch = new System.Windows.Forms.CheckBox();
			this.label_hshiftsrc = new System.Windows.Forms.Label();
			this.comboBox_hshiftsrc = new System.Windows.Forms.ComboBox();
			this.label_texmode = new System.Windows.Forms.Label();
			this.comboBox_texmode = new System.Windows.Forms.ComboBox();
			this.label_hshiftoffset = new System.Windows.Forms.Label();
			this.textBox_hshiftoffset = new System.Windows.Forms.TextBox();
			this.tabPage_general2 = new System.Windows.Forms.TabPage();
			this.groupBox_middle_sections = new System.Windows.Forms.GroupBox();
			this.pictureBox_help_gaplen = new System.Windows.Forms.PictureBox();
			this.pictureBox_help_gaps = new System.Windows.Forms.PictureBox();
			this.label_gaplen = new System.Windows.Forms.Label();
			this.checkBox_gaps = new System.Windows.Forms.CheckBox();
			this.textBox_gaplen = new System.Windows.Forms.TextBox();
			this.groupBox_grid = new System.Windows.Forms.GroupBox();
			this.label_gridsize_sep_v1 = new System.Windows.Forms.Label();
			this.label_gridsize_sep_v2 = new System.Windows.Forms.Label();
			this.label34 = new System.Windows.Forms.Label();
			this.pictureBox_help_gridsize = new System.Windows.Forms.PictureBox();
			this.label35 = new System.Windows.Forms.Label();
			this.textBox_gridsize_z = new System.Windows.Forms.TextBox();
			this.label37 = new System.Windows.Forms.Label();
			this.label_gridsize = new System.Windows.Forms.Label();
			this.textBox_gridsize_x = new System.Windows.Forms.TextBox();
			this.textBox_gridsize_y = new System.Windows.Forms.TextBox();
			this.pictureBox_help_transit_round = new System.Windows.Forms.PictureBox();
			this.checkBox_round = new System.Windows.Forms.CheckBox();
			this.pictureBox_help_round = new System.Windows.Forms.PictureBox();
			this.checkBox_transit_round = new System.Windows.Forms.CheckBox();
			this.label_gridsize_sep_h = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.groupBox_transforms_src = new System.Windows.Forms.GroupBox();
			this.checkBox_mirror_src_z = new System.Windows.Forms.CheckBox();
			this.checkBox_mirror_src_y = new System.Windows.Forms.CheckBox();
			this.checkBox_mirror_src_x = new System.Windows.Forms.CheckBox();
			this.label_mirror_src = new System.Windows.Forms.Label();
			this.pictureBox_help_mirror_src = new System.Windows.Forms.PictureBox();
			this.label43 = new System.Windows.Forms.Label();
			this.label_rot_src_y = new System.Windows.Forms.Label();
			this.label_transsrc_sep_v1 = new System.Windows.Forms.Label();
			this.label_transsrc_sep_v2 = new System.Windows.Forms.Label();
			this.label_transsrc_sep_h = new System.Windows.Forms.Label();
			this.label38 = new System.Windows.Forms.Label();
			this.pictureBox_help_rot_src = new System.Windows.Forms.PictureBox();
			this.label39 = new System.Windows.Forms.Label();
			this.pictureBox_help_scale_src = new System.Windows.Forms.PictureBox();
			this.label40 = new System.Windows.Forms.Label();
			this.textBox_scale_src = new System.Windows.Forms.TextBox();
			this.textBox_rot_src_z = new System.Windows.Forms.TextBox();
			this.label_rot_src = new System.Windows.Forms.Label();
			this.textBox_rot_src_x = new System.Windows.Forms.TextBox();
			this.textBox_rot_src_y = new System.Windows.Forms.TextBox();
			this.label_scale_src = new System.Windows.Forms.Label();
			this.groupBox_triangulation = new System.Windows.Forms.GroupBox();
			this.pictureBox_help_transit_tri = new System.Windows.Forms.PictureBox();
			this.pictureBox_help_tri = new System.Windows.Forms.PictureBox();
			this.checkBox_transit_tri = new System.Windows.Forms.CheckBox();
			this.checkBox_tri = new System.Windows.Forms.CheckBox();
			this.groupBox_transforms = new System.Windows.Forms.GroupBox();
			this.label_transfin_sep_v1 = new System.Windows.Forms.Label();
			this.label_transfin_sep_v2 = new System.Windows.Forms.Label();
			this.checkBox_mirror_z = new System.Windows.Forms.CheckBox();
			this.checkBox_mirror_y = new System.Windows.Forms.CheckBox();
			this.checkBox_mirror_x = new System.Windows.Forms.CheckBox();
			this.label_mirror = new System.Windows.Forms.Label();
			this.pictureBox_help_mirror = new System.Windows.Forms.PictureBox();
			this.label_rot = new System.Windows.Forms.Label();
			this.pictureBox_help_move = new System.Windows.Forms.PictureBox();
			this.pictureBox_help_rot = new System.Windows.Forms.PictureBox();
			this.pictureBox_help_scale = new System.Windows.Forms.PictureBox();
			this.textBox_rot_z = new System.Windows.Forms.TextBox();
			this.label_transfin_z = new System.Windows.Forms.Label();
			this.textBox_rot_y = new System.Windows.Forms.TextBox();
			this.label_transfin_y = new System.Windows.Forms.Label();
			this.textBox_move_z = new System.Windows.Forms.TextBox();
			this.textBox_move_y = new System.Windows.Forms.TextBox();
			this.textBox_move_x = new System.Windows.Forms.TextBox();
			this.label_move = new System.Windows.Forms.Label();
			this.textBox_rot_x = new System.Windows.Forms.TextBox();
			this.label_scale = new System.Windows.Forms.Label();
			this.textBox_scale = new System.Windows.Forms.TextBox();
			this.label_transfin_x = new System.Windows.Forms.Label();
			this.label_transfin_sep_h = new System.Windows.Forms.Label();
			this.groupBox_null_brushes = new System.Windows.Forms.GroupBox();
			this.pictureBox_help_skipnull = new System.Windows.Forms.PictureBox();
			this.pictureBox_help_spike_height = new System.Windows.Forms.PictureBox();
			this.pictureBox_help_nulltex = new System.Windows.Forms.PictureBox();
			this.textBox_spike_height = new System.Windows.Forms.TextBox();
			this.label_nulltex = new System.Windows.Forms.Label();
			this.checkBox_skipnull = new System.Windows.Forms.CheckBox();
			this.textBox_nulltex = new System.Windows.Forms.TextBox();
			this.label_spike_height = new System.Windows.Forms.Label();
			this.tabPage_path_corner = new System.Windows.Forms.TabPage();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.button_splinefile = new System.Windows.Forms.Button();
			this.label_splinefile = new System.Windows.Forms.Label();
			this.pictureBox_help_splinefile = new System.Windows.Forms.PictureBox();
			this.checkBox_p_cornerfix = new System.Windows.Forms.CheckBox();
			this.button5 = new System.Windows.Forms.Button();
			this.checkBox_p_reverse = new System.Windows.Forms.CheckBox();
			this.checkBox_p_split = new System.Windows.Forms.CheckBox();
			this.pictureBox_help_p_scale = new System.Windows.Forms.PictureBox();
			this.label_p_expand = new System.Windows.Forms.Label();
			this.pictureBox_help_p_expand = new System.Windows.Forms.PictureBox();
			this.checkBox_p_evenout = new System.Windows.Forms.CheckBox();
			this.pictureBox_help_p_cornerfix = new System.Windows.Forms.PictureBox();
			this.label_p_scale_y = new System.Windows.Forms.Label();
			this.pictureBox_help_p_evenout = new System.Windows.Forms.PictureBox();
			this.label_p_scale_x = new System.Windows.Forms.Label();
			this.pictureBox_help_p_reverse = new System.Windows.Forms.PictureBox();
			this.label_p_scale_z = new System.Windows.Forms.Label();
			this.pictureBox_help_p_split = new System.Windows.Forms.PictureBox();
			this.textBox_splinefile = new System.Windows.Forms.TextBox();
			this.textBox_p_expand = new System.Windows.Forms.TextBox();
			this.textBox_p_scale_y = new System.Windows.Forms.TextBox();
			this.textBox_p_scale_z = new System.Windows.Forms.TextBox();
			this.textBox_p_scale_x = new System.Windows.Forms.TextBox();
			this.label29 = new System.Windows.Forms.Label();
			this.button_resetTab3 = new System.Windows.Forms.Button();
			this.tabPage_detail_objects = new System.Windows.Forms.TabPage();
			this.label30 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.pictureBox_help_d_skip = new System.Windows.Forms.PictureBox();
			this.pictureBox_help_d_draw = new System.Windows.Forms.PictureBox();
			this.pictureBox_help_d_draw_rand = new System.Windows.Forms.PictureBox();
			this.pictureBox_help_d_enable = new System.Windows.Forms.PictureBox();
			this.checkBox_d_enable = new System.Windows.Forms.CheckBox();
			this.checkBox_d_draw_rand = new System.Windows.Forms.CheckBox();
			this.label10 = new System.Windows.Forms.Label();
			this.textBox_d_skip = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.textBox_d_draw = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.pictureBox_help_d_pos = new System.Windows.Forms.PictureBox();
			this.pictureBox_help_d_autoname = new System.Windows.Forms.PictureBox();
			this.pictureBox_help_d_autoyaw = new System.Windows.Forms.PictureBox();
			this.pictureBox_help_d_autopitch = new System.Windows.Forms.PictureBox();
			this.label_d_pos = new System.Windows.Forms.Label();
			this.textBox_d_pos = new System.Windows.Forms.TextBox();
			this.checkBox_d_autoyaw = new System.Windows.Forms.CheckBox();
			this.checkBox_d_autoname = new System.Windows.Forms.CheckBox();
			this.checkBox_d_autopitch = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.pictureBox_help_d_pos_rand = new System.Windows.Forms.PictureBox();
			this.pictureBox_help_d_movey_rand = new System.Windows.Forms.PictureBox();
			this.pictureBox_help_d_rotz_rand = new System.Windows.Forms.PictureBox();
			this.pictureBox_help_d_scale_rand = new System.Windows.Forms.PictureBox();
			this.textBox_d_pos_max = new System.Windows.Forms.TextBox();
			this.label_d_pos_max = new System.Windows.Forms.Label();
			this.label_d_pos_min = new System.Windows.Forms.Label();
			this.textBox_d_pos_min = new System.Windows.Forms.TextBox();
			this.checkBox_d_pos_rand = new System.Windows.Forms.CheckBox();
			this.checkBox_d_scale_rand = new System.Windows.Forms.CheckBox();
			this.textBox_d_movey_rand_max = new System.Windows.Forms.TextBox();
			this.textBox_d_scale_rand_min = new System.Windows.Forms.TextBox();
			this.label_d_movey_rand_max = new System.Windows.Forms.Label();
			this.checkBox_d_rotz_rand = new System.Windows.Forms.CheckBox();
			this.label_d_movey_rand_min = new System.Windows.Forms.Label();
			this.label_d_scale_rand_min = new System.Windows.Forms.Label();
			this.textBox_d_movey_rand_min = new System.Windows.Forms.TextBox();
			this.checkBox_d_movey_rand = new System.Windows.Forms.CheckBox();
			this.textBox_d_rotz_rand_max = new System.Windows.Forms.TextBox();
			this.label_d_scale_rand_max = new System.Windows.Forms.Label();
			this.label_d_rotz_rand_max = new System.Windows.Forms.Label();
			this.textBox_d_scale_rand_max = new System.Windows.Forms.TextBox();
			this.label_d_rotz_rand_min = new System.Windows.Forms.Label();
			this.textBox_d_rotz_rand_min = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pictureBox_help_d_circlemode = new System.Windows.Forms.PictureBox();
			this.pictureBox_help_d_carve = new System.Windows.Forms.PictureBox();
			this.pictureBox_help_d_autoassign = new System.Windows.Forms.PictureBox();
			this.pictureBox_help_d_separate = new System.Windows.Forms.PictureBox();
			this.checkBox_d_circlemode = new System.Windows.Forms.CheckBox();
			this.checkBox_d_carve = new System.Windows.Forms.CheckBox();
			this.checkBox_d_autoassign = new System.Windows.Forms.CheckBox();
			this.checkBox_d_separate = new System.Windows.Forms.CheckBox();
			this.tabPage_preset = new System.Windows.Forms.TabPage();
			this.label31 = new System.Windows.Forms.Label();
			this.preset_shower = new System.Windows.Forms.TextBox();
			this.tabPage_WAD = new System.Windows.Forms.TabPage();
			this.label32 = new System.Windows.Forms.Label();
			this.label_WADList = new System.Windows.Forms.Label();
			this.button_WAD_remove = new System.Windows.Forms.Button();
			this.button_WAD_add = new System.Windows.Forms.Button();
			this.listBox_WAD_list = new System.Windows.Forms.ListBox();
			this.tabPage_settings = new System.Windows.Forms.TabPage();
			this.label33 = new System.Windows.Forms.Label();
			this.groupBox_Preset_Settings = new System.Windows.Forms.GroupBox();
			this.checkBox_Preset_Inherit = new System.Windows.Forms.CheckBox();
			this.checkBox_ForceAllToPreset = new System.Windows.Forms.CheckBox();
			this.label_btn_settings_saved = new System.Windows.Forms.Label();
			this.button_saveSettings = new System.Windows.Forms.Button();
			this.groupBox_Editor_Settings = new System.Windows.Forms.GroupBox();
			this.checkBox_OpenFileInEditor = new System.Windows.Forms.CheckBox();
			this.textBox_M2C_exe_path = new System.Windows.Forms.TextBox();
			this.textBox_Editor_exe_path = new System.Windows.Forms.TextBox();
			this.button_M2C_exe_select = new System.Windows.Forms.Button();
			this.button_Editor_exe_select = new System.Windows.Forms.Button();
			this.groupBox_M2C_Settings = new System.Windows.Forms.GroupBox();
			this.checkBox_M2C_log = new System.Windows.Forms.CheckBox();
			this.checkBox_M2C_dev = new System.Windows.Forms.CheckBox();
			this.checkBox_M2C_autoclose = new System.Windows.Forms.CheckBox();
			this.tabPage_howto = new System.Windows.Forms.TabPage();
			this.tabControl_howto = new System.Windows.Forms.TabControl();
			this.tabPage_howto_1 = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tabPage_howto_2 = new System.Windows.Forms.TabPage();
			this.label8 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.tabPage_howto_3 = new System.Windows.Forms.TabPage();
			this.label11 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.tabPage_howto_4 = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label27 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.pictureBox13 = new System.Windows.Forms.PictureBox();
			this.label25 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			this.label22 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.label15 = new System.Windows.Forms.Label();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.tabPage_temp = new System.Windows.Forms.TabPage();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.label_temp_path_h = new System.Windows.Forms.Label();
			this.label_temp_name = new System.Windows.Forms.Label();
			this.label_temp_name_h = new System.Windows.Forms.Label();
			this.label_temp_type_h = new System.Windows.Forms.Label();
			this.label_temp_path = new System.Windows.Forms.Label();
			this.label_temp_type = new System.Windows.Forms.Label();
			this.label_temp = new System.Windows.Forms.Label();
			this.pictureBox_tempR = new System.Windows.Forms.PictureBox();
			this.listView_templates = new System.Windows.Forms.ListView();
			this.temp_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.temp_framework = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.temp_filepath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.templateIcons = new System.Windows.Forms.ImageList(this.components);
			this.pictureBox_tempL = new System.Windows.Forms.PictureBox();
			this.button_temp_Load = new System.Windows.Forms.Button();
			this.label36 = new System.Windows.Forms.Label();
			this.tabPage_log = new System.Windows.Forms.TabPage();
			this.textBox_log = new System.Windows.Forms.TextBox();
			this.label41 = new System.Windows.Forms.Label();
			this.tabIcons = new System.Windows.Forms.ImageList(this.components);
			this.comboBox_CurveObj = new System.Windows.Forms.ComboBox();
			this.button_CurveObj_Add = new System.Windows.Forms.Button();
			this.button_CurveObj_Remove = new System.Windows.Forms.Button();
			this.button_CurveObj_Rename = new System.Windows.Forms.Button();
			this.button_CurveObj_prev = new System.Windows.Forms.Button();
			this.button_CurveObj_next = new System.Windows.Forms.Button();
			this.button_CurveObj_Clone = new System.Windows.Forms.Button();
			this.checkBox_CurveObj_ChangeAll = new System.Windows.Forms.CheckBox();
			this.button_Input_File_Open = new System.Windows.Forms.Button();
			this.button_Output_Folder_Open = new System.Windows.Forms.Button();
			this.pictureBox_preview = new System.Windows.Forms.PictureBox();
			this.richTextBox_help = new System.Windows.Forms.RichTextBox();
			this.pictureBox_help_source = new System.Windows.Forms.PictureBox();
			this.pictureBox_help_target = new System.Windows.Forms.PictureBox();
			this.label_CurveObj = new System.Windows.Forms.Label();
			this.menuStrip2 = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenu_reloadPreset = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenu_MRU2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.generateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
			this.templatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenu_Temp_0 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenu_Temp_1 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenu_Temp_2 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenu_Temp_3 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenu_Temp_4 = new System.Windows.Forms.ToolStripMenuItem();
			this.tutorialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenu_Tuto_0 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenu_Tuto_1 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenu_Tuto_2 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenu_Tuto_3 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControl1.SuspendLayout();
			this.tabPage_general.SuspendLayout();
			this.groupBox8.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_mapcarve)).BeginInit();
			this.groupBox_output_file_settings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_target_2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_append)).BeginInit();
			this.groupBox_curve_settings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_bounds)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_range)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_flatcircle)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_type)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_res)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_offset)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_rad)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_c_enable)).BeginInit();
			this.groupBox_height_ramp.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_ramp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_heightmode)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_height)).BeginInit();
			this.groupBox_texture_settings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_hstretchamt)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_hstretch)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_hshiftoffset)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_hshiftsrc)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_shift)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_texmode)).BeginInit();
			this.tabPage_general2.SuspendLayout();
			this.groupBox_middle_sections.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_gaplen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_gaps)).BeginInit();
			this.groupBox_grid.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_gridsize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_transit_round)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_round)).BeginInit();
			this.groupBox_transforms_src.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_mirror_src)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_rot_src)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_scale_src)).BeginInit();
			this.groupBox_triangulation.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_transit_tri)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_tri)).BeginInit();
			this.groupBox_transforms.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_mirror)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_move)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_rot)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_scale)).BeginInit();
			this.groupBox_null_brushes.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_skipnull)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_spike_height)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_nulltex)).BeginInit();
			this.tabPage_path_corner.SuspendLayout();
			this.groupBox6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_splinefile)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_p_scale)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_p_expand)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_p_cornerfix)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_p_evenout)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_p_reverse)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_p_split)).BeginInit();
			this.tabPage_detail_objects.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_d_skip)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_d_draw)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_d_draw_rand)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_d_enable)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_d_pos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_d_autoname)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_d_autoyaw)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_d_autopitch)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_d_pos_rand)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_d_movey_rand)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_d_rotz_rand)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_d_scale_rand)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_d_circlemode)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_d_carve)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_d_autoassign)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_d_separate)).BeginInit();
			this.tabPage_preset.SuspendLayout();
			this.tabPage_WAD.SuspendLayout();
			this.tabPage_settings.SuspendLayout();
			this.groupBox_Preset_Settings.SuspendLayout();
			this.groupBox_Editor_Settings.SuspendLayout();
			this.groupBox_M2C_Settings.SuspendLayout();
			this.tabPage_howto.SuspendLayout();
			this.tabControl_howto.SuspendLayout();
			this.tabPage_howto_1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tabPage_howto_2.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.tabPage_howto_3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
			this.tabPage_howto_4.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
			this.tabPage_temp.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_tempR)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_tempL)).BeginInit();
			this.tabPage_log.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_preview)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_source)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_target)).BeginInit();
			this.menuStrip2.SuspendLayout();
			this.SuspendLayout();
			// 
			// button_input_file_select
			// 
			this.button_input_file_select.Location = new System.Drawing.Point(12, 27);
			this.button_input_file_select.Name = "button_input_file_select";
			this.button_input_file_select.Size = new System.Drawing.Size(79, 23);
			this.button_input_file_select.TabIndex = 1;
			this.button_input_file_select.Text = "Input File";
			this.button_input_file_select.UseVisualStyleBackColor = true;
			this.button_input_file_select.Click += new System.EventHandler(this.button_input_file_select_Click);
			// 
			// label_output_file_name
			// 
			this.label_output_file_name.AutoSize = true;
			this.label_output_file_name.Location = new System.Drawing.Point(360, 92);
			this.label_output_file_name.Name = "label_output_file_name";
			this.label_output_file_name.Size = new System.Drawing.Size(73, 13);
			this.label_output_file_name.TabIndex = 34;
			this.label_output_file_name.Text = "Output Name:";
			// 
			// textBox_output_file_name
			// 
			this.textBox_output_file_name.Location = new System.Drawing.Point(439, 88);
			this.textBox_output_file_name.Name = "textBox_output_file_name";
			this.textBox_output_file_name.Size = new System.Drawing.Size(160, 20);
			this.textBox_output_file_name.TabIndex = 7;
			this.textBox_output_file_name.Leave += new System.EventHandler(this.textBox_output_file_name_Leave);
			// 
			// textBox_output_folder
			// 
			this.textBox_output_folder.Location = new System.Drawing.Point(96, 57);
			this.textBox_output_folder.Name = "textBox_output_folder";
			this.textBox_output_folder.ReadOnly = true;
			this.textBox_output_folder.Size = new System.Drawing.Size(503, 20);
			this.textBox_output_folder.TabIndex = 5;
			// 
			// textBox_input_file
			// 
			this.textBox_input_file.Location = new System.Drawing.Point(96, 28);
			this.textBox_input_file.Name = "textBox_input_file";
			this.textBox_input_file.ReadOnly = true;
			this.textBox_input_file.Size = new System.Drawing.Size(503, 20);
			this.textBox_input_file.TabIndex = 2;
			// 
			// button_output_folder_select
			// 
			this.button_output_folder_select.Location = new System.Drawing.Point(12, 56);
			this.button_output_folder_select.Name = "button_output_folder_select";
			this.button_output_folder_select.Size = new System.Drawing.Size(79, 23);
			this.button_output_folder_select.TabIndex = 4;
			this.button_output_folder_select.Text = "Output Folder";
			this.button_output_folder_select.UseVisualStyleBackColor = true;
			this.button_output_folder_select.Click += new System.EventHandler(this.button_output_folder_select_Click);
			// 
			// toolStripMenu_file
			// 
			this.toolStripMenu_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenu_Close,
            this.toolStripMenu_load,
            this.toolStripMenu_save,
            this.toolStripMenu_save_as,
            this.toolStripSeparator2,
            this.toolStripMenu_MRU,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
			this.toolStripMenu_file.Name = "toolStripMenu_file";
			this.toolStripMenu_file.Size = new System.Drawing.Size(37, 20);
			this.toolStripMenu_file.Text = "File";
			// 
			// toolStripMenu_Close
			// 
			this.toolStripMenu_Close.Name = "toolStripMenu_Close";
			this.toolStripMenu_Close.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.toolStripMenu_Close.Size = new System.Drawing.Size(272, 22);
			this.toolStripMenu_Close.Text = "New Preset";
			this.toolStripMenu_Close.Click += new System.EventHandler(this.toolStripMenu_NewPreset_Click);
			// 
			// toolStripMenu_load
			// 
			this.toolStripMenu_load.Name = "toolStripMenu_load";
			this.toolStripMenu_load.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.toolStripMenu_load.Size = new System.Drawing.Size(272, 22);
			this.toolStripMenu_load.Text = "Open Preset";
			this.toolStripMenu_load.Click += new System.EventHandler(this.toolStripMenu_load_Click);
			// 
			// toolStripMenu_save
			// 
			this.toolStripMenu_save.Name = "toolStripMenu_save";
			this.toolStripMenu_save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.toolStripMenu_save.Size = new System.Drawing.Size(272, 22);
			this.toolStripMenu_save.Text = "Save Preset";
			this.toolStripMenu_save.Click += new System.EventHandler(this.toolStripMenu_save_Click);
			// 
			// toolStripMenu_save_as
			// 
			this.toolStripMenu_save_as.Name = "toolStripMenu_save_as";
			this.toolStripMenu_save_as.ShortcutKeyDisplayString = "";
			this.toolStripMenu_save_as.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
			this.toolStripMenu_save_as.Size = new System.Drawing.Size(272, 22);
			this.toolStripMenu_save_as.Text = "Save Preset as";
			this.toolStripMenu_save_as.Click += new System.EventHandler(this.toolStripMenu_save_as_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(269, 6);
			// 
			// toolStripMenu_MRU
			// 
			this.toolStripMenu_MRU.Name = "toolStripMenu_MRU";
			this.toolStripMenu_MRU.Size = new System.Drawing.Size(272, 22);
			this.toolStripMenu_MRU.Text = "Recent Files";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(269, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenu_Exit_Click);
			// 
			// generateToolStripMenuItem
			// 
			this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
			this.generateToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
			this.generateToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
			this.generateToolStripMenuItem.Text = "Generate";
			this.generateToolStripMenuItem.Click += new System.EventHandler(this.button_generate_Click);
			// 
			// ToolStripMenu_help
			// 
			this.ToolStripMenu_help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenu_tutorials,
            this.ToolStripMenu_onlineDoc,
            this.ToolStripMenu_about});
			this.ToolStripMenu_help.Name = "ToolStripMenu_help";
			this.ToolStripMenu_help.Size = new System.Drawing.Size(44, 20);
			this.ToolStripMenu_help.Text = "Help";
			// 
			// ToolStripMenu_tutorials
			// 
			this.ToolStripMenu_tutorials.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenu_tuts_0,
            this.ToolStripMenu_tuts_1,
            this.ToolStripMenu_tuts_2,
            this.ToolStripMenu_tuts_3});
			this.ToolStripMenu_tutorials.Name = "ToolStripMenu_tutorials";
			this.ToolStripMenu_tutorials.Size = new System.Drawing.Size(197, 22);
			this.ToolStripMenu_tutorials.Text = "Tutorials";
			// 
			// ToolStripMenu_tuts_0
			// 
			this.ToolStripMenu_tuts_0.Name = "ToolStripMenu_tuts_0";
			this.ToolStripMenu_tuts_0.Size = new System.Drawing.Size(190, 22);
			this.ToolStripMenu_tuts_0.Text = "Input Scene Example";
			this.ToolStripMenu_tuts_0.Click += new System.EventHandler(this.button_template_Click);
			// 
			// ToolStripMenu_tuts_1
			// 
			this.ToolStripMenu_tuts_1.Name = "ToolStripMenu_tuts_1";
			this.ToolStripMenu_tuts_1.Size = new System.Drawing.Size(190, 22);
			this.ToolStripMenu_tuts_1.Text = "Triangulation";
			this.ToolStripMenu_tuts_1.Click += new System.EventHandler(this.button_template_Click);
			// 
			// ToolStripMenu_tuts_2
			// 
			this.ToolStripMenu_tuts_2.Name = "ToolStripMenu_tuts_2";
			this.ToolStripMenu_tuts_2.Size = new System.Drawing.Size(190, 22);
			this.ToolStripMenu_tuts_2.Text = "Path_Corner Extrusion";
			this.ToolStripMenu_tuts_2.Click += new System.EventHandler(this.button_template_Click);
			// 
			// ToolStripMenu_tuts_3
			// 
			this.ToolStripMenu_tuts_3.Name = "ToolStripMenu_tuts_3";
			this.ToolStripMenu_tuts_3.Size = new System.Drawing.Size(190, 22);
			this.ToolStripMenu_tuts_3.Text = "Detail Objects";
			this.ToolStripMenu_tuts_3.Click += new System.EventHandler(this.button_template_Click);
			// 
			// ToolStripMenu_onlineDoc
			// 
			this.ToolStripMenu_onlineDoc.Name = "ToolStripMenu_onlineDoc";
			this.ToolStripMenu_onlineDoc.Size = new System.Drawing.Size(197, 22);
			this.ToolStripMenu_onlineDoc.Text = "Online-Documentation";
			this.ToolStripMenu_onlineDoc.Click += new System.EventHandler(this.ToolStripMenu_onlineDoc_Click);
			// 
			// ToolStripMenu_about
			// 
			this.ToolStripMenu_about.Name = "ToolStripMenu_about";
			this.ToolStripMenu_about.Size = new System.Drawing.Size(197, 22);
			this.ToolStripMenu_about.Text = "About";
			this.ToolStripMenu_about.Click += new System.EventHandler(this.ToolStripMenu_about_Click);
			// 
			// button_resetAll
			// 
			this.button_resetAll.Location = new System.Drawing.Point(651, 646);
			this.button_resetAll.Name = "button_resetAll";
			this.button_resetAll.Size = new System.Drawing.Size(95, 23);
			this.button_resetAll.TabIndex = 19;
			this.button_resetAll.Text = "Reset all Tabs";
			this.toolTip_general.SetToolTip(this.button_resetAll, "Resets all curve settings of all 4 tabs at once");
			this.button_resetAll.UseVisualStyleBackColor = true;
			this.button_resetAll.Click += new System.EventHandler(this.button_resetAll_Click);
			// 
			// button_Output_File_Open
			// 
			this.button_Output_File_Open.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button_Output_File_Open.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button_Output_File_Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.button_Output_File_Open.Image = global::Map2CurveGUI.Properties.Resources.ico20_editor;
			this.button_Output_File_Open.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_Output_File_Open.Location = new System.Drawing.Point(626, 84);
			this.button_Output_File_Open.Margin = new System.Windows.Forms.Padding(0);
			this.button_Output_File_Open.Name = "button_Output_File_Open";
			this.button_Output_File_Open.Size = new System.Drawing.Size(120, 28);
			this.button_Output_File_Open.TabIndex = 8;
			this.button_Output_File_Open.Text = "Open in Editor";
			this.button_Output_File_Open.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button_Output_File_Open.UseVisualStyleBackColor = false;
			this.button_Output_File_Open.Click += new System.EventHandler(this.button_OpenOutputFileInEditor_Click);
			// 
			// label_hint_saveChanges
			// 
			this.label_hint_saveChanges.AutoSize = true;
			this.label_hint_saveChanges.ForeColor = System.Drawing.Color.Red;
			this.label_hint_saveChanges.Location = new System.Drawing.Point(818, 84);
			this.label_hint_saveChanges.MaximumSize = new System.Drawing.Size(150, 0);
			this.label_hint_saveChanges.Name = "label_hint_saveChanges";
			this.label_hint_saveChanges.Size = new System.Drawing.Size(132, 26);
			this.label_hint_saveChanges.TabIndex = 39;
			this.label_hint_saveChanges.Text = "Save your changes before generating a new curve!";
			this.label_hint_saveChanges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label_hint_saveChanges.Visible = false;
			// 
			// toolTip_general
			// 
			this.toolTip_general.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.toolTip_general.ToolTipTitle = "Info";
			this.toolTip_general.UseAnimation = false;
			this.toolTip_general.UseFading = false;
			// 
			// button_generate
			// 
			this.button_generate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button_generate.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button_generate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_generate.ForeColor = System.Drawing.Color.DimGray;
			this.button_generate.Image = global::Map2CurveGUI.Properties.Resources.Ico32;
			this.button_generate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button_generate.Location = new System.Drawing.Point(793, 27);
			this.button_generate.Name = "button_generate";
			this.button_generate.Size = new System.Drawing.Size(182, 50);
			this.button_generate.TabIndex = 9;
			this.button_generate.Text = "Generate";
			this.button_generate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip_general.SetToolTip(this.button_generate, "Save your latest changes before clicking this button!");
			this.button_generate.UseVisualStyleBackColor = false;
			this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
			// 
			// button_resetTab4
			// 
			this.button_resetTab4.Location = new System.Drawing.Point(649, 432);
			this.button_resetTab4.Name = "button_resetTab4";
			this.button_resetTab4.Size = new System.Drawing.Size(75, 23);
			this.button_resetTab4.TabIndex = 60;
			this.button_resetTab4.Text = "Reset Tab";
			this.toolTip_general.SetToolTip(this.button_resetTab4, "Resets all curve settings of the current tab");
			this.button_resetTab4.UseVisualStyleBackColor = true;
			this.button_resetTab4.Click += new System.EventHandler(this.button_resetTab4_Click);
			// 
			// button_resetTab2
			// 
			this.button_resetTab2.Location = new System.Drawing.Point(649, 432);
			this.button_resetTab2.Name = "button_resetTab2";
			this.button_resetTab2.Size = new System.Drawing.Size(75, 23);
			this.button_resetTab2.TabIndex = 80;
			this.button_resetTab2.Text = "Reset Tab";
			this.toolTip_general.SetToolTip(this.button_resetTab2, "Resets all settings of the current Tab");
			this.button_resetTab2.UseVisualStyleBackColor = true;
			this.button_resetTab2.Click += new System.EventHandler(this.button_resetTab2_Click);
			// 
			// button_resetTab1
			// 
			this.button_resetTab1.Location = new System.Drawing.Point(649, 432);
			this.button_resetTab1.Name = "button_resetTab1";
			this.button_resetTab1.Size = new System.Drawing.Size(75, 23);
			this.button_resetTab1.TabIndex = 70;
			this.button_resetTab1.Text = "Reset Tab";
			this.toolTip_general.SetToolTip(this.button_resetTab1, "Resets all settings of the current Tab");
			this.button_resetTab1.UseVisualStyleBackColor = true;
			this.button_resetTab1.Click += new System.EventHandler(this.button_resetTab1_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage_general);
			this.tabControl1.Controls.Add(this.tabPage_general2);
			this.tabControl1.Controls.Add(this.tabPage_path_corner);
			this.tabControl1.Controls.Add(this.tabPage_detail_objects);
			this.tabControl1.Controls.Add(this.tabPage_preset);
			this.tabControl1.Controls.Add(this.tabPage_WAD);
			this.tabControl1.Controls.Add(this.tabPage_settings);
			this.tabControl1.Controls.Add(this.tabPage_howto);
			this.tabControl1.Controls.Add(this.tabPage_temp);
			this.tabControl1.Controls.Add(this.tabPage_log);
			this.tabControl1.ImageList = this.tabIcons;
			this.tabControl1.Location = new System.Drawing.Point(12, 114);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.Padding = new System.Drawing.Point(6, 6);
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.ShowToolTips = true;
			this.tabControl1.Size = new System.Drawing.Size(738, 526);
			this.tabControl1.TabIndex = 10;
			this.toolTip_general.SetToolTip(this.tabControl1, "Resets all settings of the current Tab");
			// 
			// tabPage_general
			// 
			this.tabPage_general.Controls.Add(this.groupBox8);
			this.tabPage_general.Controls.Add(this.label23);
			this.tabPage_general.Controls.Add(this.button_resetTab1);
			this.tabPage_general.Controls.Add(this.groupBox_output_file_settings);
			this.tabPage_general.Controls.Add(this.groupBox_curve_settings);
			this.tabPage_general.Controls.Add(this.groupBox_height_ramp);
			this.tabPage_general.Controls.Add(this.groupBox_texture_settings);
			this.tabPage_general.ImageIndex = 0;
			this.tabPage_general.Location = new System.Drawing.Point(4, 61);
			this.tabPage_general.Name = "tabPage_general";
			this.tabPage_general.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_general.Size = new System.Drawing.Size(730, 461);
			this.tabPage_general.TabIndex = 0;
			this.tabPage_general.ToolTipText = "General Settings";
			// 
			// groupBox8
			// 
			this.groupBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.groupBox8.Controls.Add(this.pictureBox_help_mapcarve);
			this.groupBox8.Controls.Add(this.comboBox_mapcarve);
			this.groupBox8.Controls.Add(this.label_mapcarve);
			this.groupBox8.Location = new System.Drawing.Point(362, 26);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(350, 58);
			this.groupBox8.TabIndex = 40;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "Input File Settings";
			// 
			// pictureBox_help_mapcarve
			// 
			this.pictureBox_help_mapcarve.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_mapcarve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_mapcarve.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_mapcarve.Location = new System.Drawing.Point(326, 20);
			this.pictureBox_help_mapcarve.Name = "pictureBox_help_mapcarve";
			this.pictureBox_help_mapcarve.Size = new System.Drawing.Size(18, 19);
			this.pictureBox_help_mapcarve.TabIndex = 38;
			this.pictureBox_help_mapcarve.TabStop = false;
			this.pictureBox_help_mapcarve.Click += new System.EventHandler(this.help_Focus);
			// 
			// comboBox_mapcarve
			// 
			this.comboBox_mapcarve.AllowDrop = true;
			this.comboBox_mapcarve.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_mapcarve.FormattingEnabled = true;
			this.comboBox_mapcarve.Items.AddRange(new object[] {
            "No Carving",
            "X-axis before Transf.",
            "X-axis after Transf."});
			this.comboBox_mapcarve.Location = new System.Drawing.Point(6, 19);
			this.comboBox_mapcarve.Name = "comboBox_mapcarve";
			this.comboBox_mapcarve.Size = new System.Drawing.Size(100, 21);
			this.comboBox_mapcarve.TabIndex = 1;
			this.comboBox_mapcarve.Tag = "mapcarve";
			this.comboBox_mapcarve.SelectedIndexChanged += new System.EventHandler(this.comboBox_mapcarve_SelectedIndexChanged);
			this.comboBox_mapcarve.Enter += new System.EventHandler(this.help_Populate);
			// 
			// label_mapcarve
			// 
			this.label_mapcarve.AutoSize = true;
			this.label_mapcarve.ForeColor = System.Drawing.Color.Fuchsia;
			this.label_mapcarve.Location = new System.Drawing.Point(112, 23);
			this.label_mapcarve.Name = "label_mapcarve";
			this.label_mapcarve.Size = new System.Drawing.Size(159, 13);
			this.label_mapcarve.TabIndex = 37;
			this.label_mapcarve.Text = "Input Map Carving (NEW v0.87)";
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(3, 3);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(124, 13);
			this.label23.TabIndex = 39;
			this.label23.Text = "Curve / General Settings";
			// 
			// groupBox_output_file_settings
			// 
			this.groupBox_output_file_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.groupBox_output_file_settings.Controls.Add(this.pictureBox_help_target_2);
			this.groupBox_output_file_settings.Controls.Add(this.pictureBox_help_append);
			this.groupBox_output_file_settings.Controls.Add(this.checkBox_export_map);
			this.groupBox_output_file_settings.Controls.Add(this.checkBox_export_obj);
			this.groupBox_output_file_settings.Controls.Add(this.checkBox_append);
			this.groupBox_output_file_settings.Controls.Add(this.checkBox_export_rmf);
			this.groupBox_output_file_settings.Location = new System.Drawing.Point(6, 26);
			this.groupBox_output_file_settings.Name = "groupBox_output_file_settings";
			this.groupBox_output_file_settings.Size = new System.Drawing.Size(350, 112);
			this.groupBox_output_file_settings.TabIndex = 20;
			this.groupBox_output_file_settings.TabStop = false;
			this.groupBox_output_file_settings.Text = "Output File Settings";
			// 
			// pictureBox_help_target_2
			// 
			this.pictureBox_help_target_2.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_target_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_target_2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_target_2.Location = new System.Drawing.Point(326, 40);
			this.pictureBox_help_target_2.Name = "pictureBox_help_target_2";
			this.pictureBox_help_target_2.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_target_2.TabIndex = 11;
			this.pictureBox_help_target_2.TabStop = false;
			this.pictureBox_help_target_2.Click += new System.EventHandler(this.help_Focus);
			// 
			// pictureBox_help_append
			// 
			this.pictureBox_help_append.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_append.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_append.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_append.Location = new System.Drawing.Point(326, 86);
			this.pictureBox_help_append.Name = "pictureBox_help_append";
			this.pictureBox_help_append.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_append.TabIndex = 9;
			this.pictureBox_help_append.TabStop = false;
			this.pictureBox_help_append.Click += new System.EventHandler(this.help_Focus);
			// 
			// checkBox_export_map
			// 
			this.checkBox_export_map.AutoSize = true;
			this.checkBox_export_map.Location = new System.Drawing.Point(6, 18);
			this.checkBox_export_map.Name = "checkBox_export_map";
			this.checkBox_export_map.Size = new System.Drawing.Size(148, 17);
			this.checkBox_export_map.TabIndex = 1;
			this.checkBox_export_map.Tag = "map";
			this.checkBox_export_map.Text = "Export to MAP file format?";
			this.checkBox_export_map.UseVisualStyleBackColor = true;
			this.checkBox_export_map.CheckedChanged += new System.EventHandler(this.checkBox_export_map_CheckedChanged);
			this.checkBox_export_map.Enter += new System.EventHandler(this.help_Populate);
			// 
			// checkBox_export_obj
			// 
			this.checkBox_export_obj.AutoSize = true;
			this.checkBox_export_obj.Location = new System.Drawing.Point(6, 64);
			this.checkBox_export_obj.Name = "checkBox_export_obj";
			this.checkBox_export_obj.Size = new System.Drawing.Size(208, 17);
			this.checkBox_export_obj.TabIndex = 3;
			this.checkBox_export_obj.Tag = "obj";
			this.checkBox_export_obj.Text = "Export to OBJ file format? (rudimentary)";
			this.checkBox_export_obj.UseVisualStyleBackColor = true;
			this.checkBox_export_obj.CheckedChanged += new System.EventHandler(this.checkBox_export_obj_CheckedChanged);
			this.checkBox_export_obj.Enter += new System.EventHandler(this.help_Populate);
			// 
			// checkBox_append
			// 
			this.checkBox_append.AutoSize = true;
			this.checkBox_append.Location = new System.Drawing.Point(6, 87);
			this.checkBox_append.Name = "checkBox_append";
			this.checkBox_append.Size = new System.Drawing.Size(285, 17);
			this.checkBox_append.TabIndex = 4;
			this.checkBox_append.Tag = "append";
			this.checkBox_append.Text = "Append result to existing output file? (only for MAP atm)";
			this.checkBox_append.UseVisualStyleBackColor = false;
			this.checkBox_append.CheckedChanged += new System.EventHandler(this.checkBox_append_CheckedChanged);
			this.checkBox_append.Enter += new System.EventHandler(this.help_Populate);
			// 
			// checkBox_export_rmf
			// 
			this.checkBox_export_rmf.AutoSize = true;
			this.checkBox_export_rmf.Location = new System.Drawing.Point(6, 41);
			this.checkBox_export_rmf.Name = "checkBox_export_rmf";
			this.checkBox_export_rmf.Size = new System.Drawing.Size(224, 17);
			this.checkBox_export_rmf.TabIndex = 2;
			this.checkBox_export_rmf.Tag = "rmf";
			this.checkBox_export_rmf.Text = "Export to RMF file format? (recommended)";
			this.checkBox_export_rmf.UseVisualStyleBackColor = true;
			this.checkBox_export_rmf.CheckedChanged += new System.EventHandler(this.checkBox_export_rmf_CheckedChanged);
			this.checkBox_export_rmf.Enter += new System.EventHandler(this.help_Populate);
			// 
			// groupBox_curve_settings
			// 
			this.groupBox_curve_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.groupBox_curve_settings.Controls.Add(this.pictureBox_help_bounds);
			this.groupBox_curve_settings.Controls.Add(this.pictureBox_help_range);
			this.groupBox_curve_settings.Controls.Add(this.pictureBox_help_flatcircle);
			this.groupBox_curve_settings.Controls.Add(this.pictureBox_help_type);
			this.groupBox_curve_settings.Controls.Add(this.pictureBox_help_res);
			this.groupBox_curve_settings.Controls.Add(this.pictureBox_help_offset);
			this.groupBox_curve_settings.Controls.Add(this.pictureBox_help_rad);
			this.groupBox_curve_settings.Controls.Add(this.pictureBox_help_c_enable);
			this.groupBox_curve_settings.Controls.Add(this.comboBox_bounds);
			this.groupBox_curve_settings.Controls.Add(this.label_bounds);
			this.groupBox_curve_settings.Controls.Add(this.checkBox_c_enable);
			this.groupBox_curve_settings.Controls.Add(this.textBox_range_end);
			this.groupBox_curve_settings.Controls.Add(this.checkBox_flatcircle);
			this.groupBox_curve_settings.Controls.Add(this.label_range_end);
			this.groupBox_curve_settings.Controls.Add(this.label_type);
			this.groupBox_curve_settings.Controls.Add(this.label_range_start);
			this.groupBox_curve_settings.Controls.Add(this.comboBox_type);
			this.groupBox_curve_settings.Controls.Add(this.textBox_range_start);
			this.groupBox_curve_settings.Controls.Add(this.label_res);
			this.groupBox_curve_settings.Controls.Add(this.textBox_res);
			this.groupBox_curve_settings.Controls.Add(this.textBox_rad);
			this.groupBox_curve_settings.Controls.Add(this.label_offset);
			this.groupBox_curve_settings.Controls.Add(this.textBox_offset);
			this.groupBox_curve_settings.Controls.Add(this.label_radius);
			this.groupBox_curve_settings.Location = new System.Drawing.Point(6, 154);
			this.groupBox_curve_settings.Name = "groupBox_curve_settings";
			this.groupBox_curve_settings.Size = new System.Drawing.Size(350, 261);
			this.groupBox_curve_settings.TabIndex = 30;
			this.groupBox_curve_settings.TabStop = false;
			this.groupBox_curve_settings.Text = "Curve Framework Settings";
			// 
			// pictureBox_help_bounds
			// 
			this.pictureBox_help_bounds.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_bounds.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_bounds.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_bounds.Location = new System.Drawing.Point(326, 223);
			this.pictureBox_help_bounds.Name = "pictureBox_help_bounds";
			this.pictureBox_help_bounds.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_bounds.TabIndex = 35;
			this.pictureBox_help_bounds.TabStop = false;
			this.pictureBox_help_bounds.Click += new System.EventHandler(this.help_Focus);
			// 
			// pictureBox_help_range
			// 
			this.pictureBox_help_range.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_range.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_range.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_range.Location = new System.Drawing.Point(326, 183);
			this.pictureBox_help_range.Name = "pictureBox_help_range";
			this.pictureBox_help_range.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_range.TabIndex = 34;
			this.pictureBox_help_range.TabStop = false;
			this.pictureBox_help_range.Click += new System.EventHandler(this.help_Focus);
			// 
			// pictureBox_help_flatcircle
			// 
			this.pictureBox_help_flatcircle.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_flatcircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_flatcircle.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_flatcircle.Location = new System.Drawing.Point(326, 146);
			this.pictureBox_help_flatcircle.Name = "pictureBox_help_flatcircle";
			this.pictureBox_help_flatcircle.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_flatcircle.TabIndex = 33;
			this.pictureBox_help_flatcircle.TabStop = false;
			this.pictureBox_help_flatcircle.Click += new System.EventHandler(this.help_Focus);
			// 
			// pictureBox_help_type
			// 
			this.pictureBox_help_type.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_type.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_type.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_type.Location = new System.Drawing.Point(326, 121);
			this.pictureBox_help_type.Name = "pictureBox_help_type";
			this.pictureBox_help_type.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_type.TabIndex = 32;
			this.pictureBox_help_type.TabStop = false;
			this.pictureBox_help_type.Click += new System.EventHandler(this.help_Focus);
			// 
			// pictureBox_help_res
			// 
			this.pictureBox_help_res.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_res.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_res.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_res.Location = new System.Drawing.Point(326, 95);
			this.pictureBox_help_res.Name = "pictureBox_help_res";
			this.pictureBox_help_res.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_res.TabIndex = 31;
			this.pictureBox_help_res.TabStop = false;
			this.pictureBox_help_res.Click += new System.EventHandler(this.help_Focus);
			// 
			// pictureBox_help_offset
			// 
			this.pictureBox_help_offset.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_offset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_offset.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_offset.Location = new System.Drawing.Point(326, 69);
			this.pictureBox_help_offset.Name = "pictureBox_help_offset";
			this.pictureBox_help_offset.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_offset.TabIndex = 30;
			this.pictureBox_help_offset.TabStop = false;
			this.pictureBox_help_offset.Click += new System.EventHandler(this.help_Focus);
			// 
			// pictureBox_help_rad
			// 
			this.pictureBox_help_rad.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_rad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_rad.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_rad.Location = new System.Drawing.Point(326, 43);
			this.pictureBox_help_rad.Name = "pictureBox_help_rad";
			this.pictureBox_help_rad.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_rad.TabIndex = 29;
			this.pictureBox_help_rad.TabStop = false;
			this.pictureBox_help_rad.Click += new System.EventHandler(this.help_Focus);
			// 
			// pictureBox_help_c_enable
			// 
			this.pictureBox_help_c_enable.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_c_enable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_c_enable.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_c_enable.Location = new System.Drawing.Point(326, 18);
			this.pictureBox_help_c_enable.Name = "pictureBox_help_c_enable";
			this.pictureBox_help_c_enable.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_c_enable.TabIndex = 12;
			this.pictureBox_help_c_enable.TabStop = false;
			this.pictureBox_help_c_enable.Click += new System.EventHandler(this.help_Focus);
			// 
			// comboBox_bounds
			// 
			this.comboBox_bounds.AllowDrop = true;
			this.comboBox_bounds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_bounds.FormattingEnabled = true;
			this.comboBox_bounds.Items.AddRange(new object[] {
            "None",
            "Simple Brush",
            "Hollow Skybox"});
			this.comboBox_bounds.Location = new System.Drawing.Point(6, 222);
			this.comboBox_bounds.Name = "comboBox_bounds";
			this.comboBox_bounds.Size = new System.Drawing.Size(100, 21);
			this.comboBox_bounds.TabIndex = 9;
			this.comboBox_bounds.Tag = "bounds";
			this.comboBox_bounds.SelectedIndexChanged += new System.EventHandler(this.comboBox_bounds_SelectedIndexChanged);
			this.comboBox_bounds.Enter += new System.EventHandler(this.help_Populate);
			// 
			// label_bounds
			// 
			this.label_bounds.AutoSize = true;
			this.label_bounds.Location = new System.Drawing.Point(112, 225);
			this.label_bounds.Name = "label_bounds";
			this.label_bounds.Size = new System.Drawing.Size(100, 13);
			this.label_bounds.TabIndex = 26;
			this.label_bounds.Text = "Bounding Box Type";
			// 
			// checkBox_c_enable
			// 
			this.checkBox_c_enable.AutoSize = true;
			this.checkBox_c_enable.Location = new System.Drawing.Point(6, 19);
			this.checkBox_c_enable.Name = "checkBox_c_enable";
			this.checkBox_c_enable.Size = new System.Drawing.Size(128, 17);
			this.checkBox_c_enable.TabIndex = 1;
			this.checkBox_c_enable.Tag = "c_enable";
			this.checkBox_c_enable.Text = "Export Curve Brushes";
			this.checkBox_c_enable.UseVisualStyleBackColor = true;
			this.checkBox_c_enable.CheckedChanged += new System.EventHandler(this.checkBox_c_enable_CheckedChanged);
			this.checkBox_c_enable.Enter += new System.EventHandler(this.help_Populate);
			// 
			// textBox_range_end
			// 
			this.textBox_range_end.Location = new System.Drawing.Point(6, 196);
			this.textBox_range_end.MaxLength = 10;
			this.textBox_range_end.Name = "textBox_range_end";
			this.textBox_range_end.Size = new System.Drawing.Size(100, 20);
			this.textBox_range_end.TabIndex = 8;
			this.textBox_range_end.Tag = "range_end";
			this.textBox_range_end.Enter += new System.EventHandler(this.help_Populate);
			this.textBox_range_end.Leave += new System.EventHandler(this.textBox_range_end_Leave);
			// 
			// checkBox_flatcircle
			// 
			this.checkBox_flatcircle.AutoSize = true;
			this.checkBox_flatcircle.Location = new System.Drawing.Point(6, 147);
			this.checkBox_flatcircle.Name = "checkBox_flatcircle";
			this.checkBox_flatcircle.Size = new System.Drawing.Size(154, 17);
			this.checkBox_flatcircle.TabIndex = 6;
			this.checkBox_flatcircle.Tag = "flatcircle";
			this.checkBox_flatcircle.Text = "Flatten Pi Circle Framework";
			this.checkBox_flatcircle.UseVisualStyleBackColor = true;
			this.checkBox_flatcircle.CheckedChanged += new System.EventHandler(this.checkBox_flatten_CheckedChanged);
			this.checkBox_flatcircle.Enter += new System.EventHandler(this.help_Populate);
			// 
			// label_range_end
			// 
			this.label_range_end.AutoSize = true;
			this.label_range_end.Location = new System.Drawing.Point(112, 199);
			this.label_range_end.Name = "label_range_end";
			this.label_range_end.Size = new System.Drawing.Size(147, 13);
			this.label_range_end.TabIndex = 28;
			this.label_range_end.Text = "Export Range End % (e.g. 75)";
			// 
			// label_type
			// 
			this.label_type.AutoSize = true;
			this.label_type.Location = new System.Drawing.Point(112, 124);
			this.label_type.Name = "label_type";
			this.label_type.Size = new System.Drawing.Size(117, 13);
			this.label_type.TabIndex = 17;
			this.label_type.Text = "Curve Framework Type";
			// 
			// label_range_start
			// 
			this.label_range_start.AutoSize = true;
			this.label_range_start.Location = new System.Drawing.Point(112, 173);
			this.label_range_start.Name = "label_range_start";
			this.label_range_start.Size = new System.Drawing.Size(159, 13);
			this.label_range_start.TabIndex = 24;
			this.label_range_start.Text = "Export Range Start % (e.g. 12.5)";
			// 
			// comboBox_type
			// 
			this.comboBox_type.AllowDrop = true;
			this.comboBox_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_type.FormattingEnabled = true;
			this.comboBox_type.Items.AddRange(new object[] {
            "Circle Pi",
            "Circle Grid",
            "Path_Corner Simple",
            "Path_Corner Precise"});
			this.comboBox_type.Location = new System.Drawing.Point(6, 120);
			this.comboBox_type.Name = "comboBox_type";
			this.comboBox_type.Size = new System.Drawing.Size(100, 21);
			this.comboBox_type.TabIndex = 5;
			this.comboBox_type.Tag = "type";
			this.comboBox_type.SelectedIndexChanged += new System.EventHandler(this.comboBox_type_SelectedIndexChanged);
			this.comboBox_type.Enter += new System.EventHandler(this.help_Populate);
			// 
			// textBox_range_start
			// 
			this.textBox_range_start.Location = new System.Drawing.Point(6, 170);
			this.textBox_range_start.MaxLength = 10;
			this.textBox_range_start.Name = "textBox_range_start";
			this.textBox_range_start.Size = new System.Drawing.Size(100, 20);
			this.textBox_range_start.TabIndex = 7;
			this.textBox_range_start.Tag = "range_start";
			this.textBox_range_start.Enter += new System.EventHandler(this.help_Populate);
			this.textBox_range_start.Leave += new System.EventHandler(this.textBox_range_start_Leave);
			// 
			// label_res
			// 
			this.label_res.AutoSize = true;
			this.label_res.Location = new System.Drawing.Point(112, 98);
			this.label_res.Name = "label_res";
			this.label_res.Size = new System.Drawing.Size(57, 13);
			this.label_res.TabIndex = 15;
			this.label_res.Text = "Resolution";
			// 
			// textBox_res
			// 
			this.textBox_res.Location = new System.Drawing.Point(6, 94);
			this.textBox_res.MaxLength = 10;
			this.textBox_res.Name = "textBox_res";
			this.textBox_res.Size = new System.Drawing.Size(100, 20);
			this.textBox_res.TabIndex = 4;
			this.textBox_res.Tag = "res";
			this.textBox_res.Enter += new System.EventHandler(this.help_Populate);
			this.textBox_res.Leave += new System.EventHandler(this.textBox_res_Leave);
			// 
			// textBox_rad
			// 
			this.textBox_rad.Location = new System.Drawing.Point(6, 42);
			this.textBox_rad.MaxLength = 10;
			this.textBox_rad.Name = "textBox_rad";
			this.textBox_rad.Size = new System.Drawing.Size(100, 20);
			this.textBox_rad.TabIndex = 2;
			this.textBox_rad.Tag = "rad";
			this.textBox_rad.Enter += new System.EventHandler(this.help_Populate);
			this.textBox_rad.Leave += new System.EventHandler(this.textBox_radius_Leave);
			// 
			// label_offset
			// 
			this.label_offset.AutoSize = true;
			this.label_offset.Location = new System.Drawing.Point(112, 72);
			this.label_offset.Name = "label_offset";
			this.label_offset.Size = new System.Drawing.Size(71, 13);
			this.label_offset.TabIndex = 13;
			this.label_offset.Text = "Radius Offset";
			// 
			// textBox_offset
			// 
			this.textBox_offset.Location = new System.Drawing.Point(6, 68);
			this.textBox_offset.MaxLength = 10;
			this.textBox_offset.Name = "textBox_offset";
			this.textBox_offset.Size = new System.Drawing.Size(100, 20);
			this.textBox_offset.TabIndex = 3;
			this.textBox_offset.Tag = "offset";
			this.textBox_offset.Enter += new System.EventHandler(this.help_Populate);
			this.textBox_offset.Leave += new System.EventHandler(this.textBox_offset_Leave);
			// 
			// label_radius
			// 
			this.label_radius.AutoSize = true;
			this.label_radius.Location = new System.Drawing.Point(112, 46);
			this.label_radius.Name = "label_radius";
			this.label_radius.Size = new System.Drawing.Size(40, 13);
			this.label_radius.TabIndex = 11;
			this.label_radius.Text = "Radius";
			// 
			// groupBox_height_ramp
			// 
			this.groupBox_height_ramp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.groupBox_height_ramp.Controls.Add(this.pictureBox_help_ramp);
			this.groupBox_height_ramp.Controls.Add(this.pictureBox_help_heightmode);
			this.groupBox_height_ramp.Controls.Add(this.pictureBox_help_height);
			this.groupBox_height_ramp.Controls.Add(this.checkBox_ramp);
			this.groupBox_height_ramp.Controls.Add(this.label_heightmode);
			this.groupBox_height_ramp.Controls.Add(this.comboBox_heightmode);
			this.groupBox_height_ramp.Controls.Add(this.textBox_height);
			this.groupBox_height_ramp.Controls.Add(this.label_height);
			this.groupBox_height_ramp.Location = new System.Drawing.Point(362, 100);
			this.groupBox_height_ramp.Name = "groupBox_height_ramp";
			this.groupBox_height_ramp.Size = new System.Drawing.Size(350, 104);
			this.groupBox_height_ramp.TabIndex = 50;
			this.groupBox_height_ramp.TabStop = false;
			this.groupBox_height_ramp.Text = "Height and Ramp Settings";
			// 
			// pictureBox_help_ramp
			// 
			this.pictureBox_help_ramp.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_ramp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_ramp.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_ramp.Location = new System.Drawing.Point(326, 71);
			this.pictureBox_help_ramp.Name = "pictureBox_help_ramp";
			this.pictureBox_help_ramp.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_ramp.TabIndex = 20;
			this.pictureBox_help_ramp.TabStop = false;
			this.pictureBox_help_ramp.Click += new System.EventHandler(this.help_Focus);
			// 
			// pictureBox_help_heightmode
			// 
			this.pictureBox_help_heightmode.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_heightmode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_heightmode.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_heightmode.Location = new System.Drawing.Point(326, 46);
			this.pictureBox_help_heightmode.Name = "pictureBox_help_heightmode";
			this.pictureBox_help_heightmode.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_heightmode.TabIndex = 19;
			this.pictureBox_help_heightmode.TabStop = false;
			this.pictureBox_help_heightmode.Click += new System.EventHandler(this.help_Focus);
			// 
			// pictureBox_help_height
			// 
			this.pictureBox_help_height.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_height.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_height.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_height.Location = new System.Drawing.Point(326, 20);
			this.pictureBox_help_height.Name = "pictureBox_help_height";
			this.pictureBox_help_height.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_height.TabIndex = 18;
			this.pictureBox_help_height.TabStop = false;
			this.pictureBox_help_height.Click += new System.EventHandler(this.help_Focus);
			// 
			// checkBox_ramp
			// 
			this.checkBox_ramp.AutoSize = true;
			this.checkBox_ramp.Location = new System.Drawing.Point(6, 72);
			this.checkBox_ramp.Name = "checkBox_ramp";
			this.checkBox_ramp.Size = new System.Drawing.Size(90, 17);
			this.checkBox_ramp.TabIndex = 3;
			this.checkBox_ramp.Tag = "ramp";
			this.checkBox_ramp.Text = "Sloped Ramp";
			this.checkBox_ramp.UseVisualStyleBackColor = true;
			this.checkBox_ramp.CheckedChanged += new System.EventHandler(this.checkBox_ramp_CheckedChanged);
			this.checkBox_ramp.Enter += new System.EventHandler(this.help_Populate);
			// 
			// label_heightmode
			// 
			this.label_heightmode.AutoSize = true;
			this.label_heightmode.Location = new System.Drawing.Point(112, 48);
			this.label_heightmode.Name = "label_heightmode";
			this.label_heightmode.Size = new System.Drawing.Size(69, 13);
			this.label_heightmode.TabIndex = 17;
			this.label_heightmode.Text = "Height Curve";
			// 
			// comboBox_heightmode
			// 
			this.comboBox_heightmode.AllowDrop = true;
			this.comboBox_heightmode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_heightmode.FormattingEnabled = true;
			this.comboBox_heightmode.Items.AddRange(new object[] {
            "Linear",
            "Path_Corner",
            "Random Jagged",
            "Ease In Out Sine",
            "Ease In Out Quad",
            "Ease In Out Cubic",
            "Ease In Out Quart",
            "Ease In Sine",
            "Ease In Quad",
            "Ease In Cubic",
            "Ease In Quart",
            "Ease Out Sine",
            "Ease Out Quad",
            "Ease Out Cubic",
            "Ease Out Quart"});
			this.comboBox_heightmode.Location = new System.Drawing.Point(6, 45);
			this.comboBox_heightmode.Name = "comboBox_heightmode";
			this.comboBox_heightmode.Size = new System.Drawing.Size(100, 21);
			this.comboBox_heightmode.TabIndex = 2;
			this.comboBox_heightmode.Tag = "heightmode";
			this.comboBox_heightmode.SelectedIndexChanged += new System.EventHandler(this.comboBox_heightmode_SelectedIndexChanged);
			this.comboBox_heightmode.Enter += new System.EventHandler(this.help_Populate);
			// 
			// textBox_height
			// 
			this.textBox_height.Location = new System.Drawing.Point(6, 19);
			this.textBox_height.MaxLength = 10;
			this.textBox_height.Name = "textBox_height";
			this.textBox_height.Size = new System.Drawing.Size(100, 20);
			this.textBox_height.TabIndex = 1;
			this.textBox_height.Tag = "height";
			this.textBox_height.Enter += new System.EventHandler(this.help_Populate);
			this.textBox_height.Leave += new System.EventHandler(this.textBox_height_Leave);
			// 
			// label_height
			// 
			this.label_height.AutoSize = true;
			this.label_height.Location = new System.Drawing.Point(112, 22);
			this.label_height.Name = "label_height";
			this.label_height.Size = new System.Drawing.Size(38, 13);
			this.label_height.TabIndex = 11;
			this.label_height.Text = "Height";
			// 
			// groupBox_texture_settings
			// 
			this.groupBox_texture_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.groupBox_texture_settings.Controls.Add(this.pictureBox_help_hstretchamt);
			this.groupBox_texture_settings.Controls.Add(this.pictureBox_help_hstretch);
			this.groupBox_texture_settings.Controls.Add(this.pictureBox_help_hshiftoffset);
			this.groupBox_texture_settings.Controls.Add(this.pictureBox_help_hshiftsrc);
			this.groupBox_texture_settings.Controls.Add(this.pictureBox_help_shift);
			this.groupBox_texture_settings.Controls.Add(this.pictureBox_help_texmode);
			this.groupBox_texture_settings.Controls.Add(this.label_shift);
			this.groupBox_texture_settings.Controls.Add(this.comboBox_shift);
			this.groupBox_texture_settings.Controls.Add(this.textBox_hstretchamt);
			this.groupBox_texture_settings.Controls.Add(this.label_hstretchamt);
			this.groupBox_texture_settings.Controls.Add(this.checkBox_hstretch);
			this.groupBox_texture_settings.Controls.Add(this.label_hshiftsrc);
			this.groupBox_texture_settings.Controls.Add(this.comboBox_hshiftsrc);
			this.groupBox_texture_settings.Controls.Add(this.label_texmode);
			this.groupBox_texture_settings.Controls.Add(this.comboBox_texmode);
			this.groupBox_texture_settings.Controls.Add(this.label_hshiftoffset);
			this.groupBox_texture_settings.Controls.Add(this.textBox_hshiftoffset);
			this.groupBox_texture_settings.Location = new System.Drawing.Point(362, 220);
			this.groupBox_texture_settings.Name = "groupBox_texture_settings";
			this.groupBox_texture_settings.Size = new System.Drawing.Size(350, 185);
			this.groupBox_texture_settings.TabIndex = 60;
			this.groupBox_texture_settings.TabStop = false;
			this.groupBox_texture_settings.Text = "Texture Settings";
			// 
			// pictureBox_help_hstretchamt
			// 
			this.pictureBox_help_hstretchamt.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_hstretchamt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_hstretchamt.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_hstretchamt.Location = new System.Drawing.Point(326, 150);
			this.pictureBox_help_hstretchamt.Name = "pictureBox_help_hstretchamt";
			this.pictureBox_help_hstretchamt.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_hstretchamt.TabIndex = 29;
			this.pictureBox_help_hstretchamt.TabStop = false;
			this.pictureBox_help_hstretchamt.Click += new System.EventHandler(this.help_Focus);
			// 
			// pictureBox_help_hstretch
			// 
			this.pictureBox_help_hstretch.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_hstretch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_hstretch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_hstretch.Location = new System.Drawing.Point(326, 125);
			this.pictureBox_help_hstretch.Name = "pictureBox_help_hstretch";
			this.pictureBox_help_hstretch.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_hstretch.TabIndex = 28;
			this.pictureBox_help_hstretch.TabStop = false;
			this.pictureBox_help_hstretch.Click += new System.EventHandler(this.help_Focus);
			// 
			// pictureBox_help_hshiftoffset
			// 
			this.pictureBox_help_hshiftoffset.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_hshiftoffset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_hshiftoffset.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_hshiftoffset.Location = new System.Drawing.Point(326, 101);
			this.pictureBox_help_hshiftoffset.Name = "pictureBox_help_hshiftoffset";
			this.pictureBox_help_hshiftoffset.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_hshiftoffset.TabIndex = 27;
			this.pictureBox_help_hshiftoffset.TabStop = false;
			this.pictureBox_help_hshiftoffset.Click += new System.EventHandler(this.help_Focus);
			// 
			// pictureBox_help_hshiftsrc
			// 
			this.pictureBox_help_hshiftsrc.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_hshiftsrc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_hshiftsrc.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_hshiftsrc.Location = new System.Drawing.Point(326, 74);
			this.pictureBox_help_hshiftsrc.Name = "pictureBox_help_hshiftsrc";
			this.pictureBox_help_hshiftsrc.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_hshiftsrc.TabIndex = 26;
			this.pictureBox_help_hshiftsrc.TabStop = false;
			this.pictureBox_help_hshiftsrc.Click += new System.EventHandler(this.help_Focus);
			// 
			// pictureBox_help_shift
			// 
			this.pictureBox_help_shift.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_shift.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_shift.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_shift.Location = new System.Drawing.Point(326, 47);
			this.pictureBox_help_shift.Name = "pictureBox_help_shift";
			this.pictureBox_help_shift.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_shift.TabIndex = 25;
			this.pictureBox_help_shift.TabStop = false;
			this.pictureBox_help_shift.Click += new System.EventHandler(this.help_Focus);
			// 
			// pictureBox_help_texmode
			// 
			this.pictureBox_help_texmode.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_texmode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_texmode.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_texmode.Location = new System.Drawing.Point(326, 20);
			this.pictureBox_help_texmode.Name = "pictureBox_help_texmode";
			this.pictureBox_help_texmode.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_texmode.TabIndex = 21;
			this.pictureBox_help_texmode.TabStop = false;
			this.pictureBox_help_texmode.Click += new System.EventHandler(this.help_Focus);
			// 
			// label_shift
			// 
			this.label_shift.AutoSize = true;
			this.label_shift.Location = new System.Drawing.Point(112, 50);
			this.label_shift.Name = "label_shift";
			this.label_shift.Size = new System.Drawing.Size(140, 13);
			this.label_shift.TabIndex = 24;
			this.label_shift.Text = "Horizontal Shift Group Mode";
			// 
			// comboBox_shift
			// 
			this.comboBox_shift.AllowDrop = true;
			this.comboBox_shift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_shift.FormattingEnabled = true;
			this.comboBox_shift.Items.AddRange(new object[] {
            "Null-Shift",
            "Per Section",
            "Per Brush",
            "Per Brush Texture",
            "Aligned Left",
            "Per Group Texture"});
			this.comboBox_shift.Location = new System.Drawing.Point(6, 46);
			this.comboBox_shift.Name = "comboBox_shift";
			this.comboBox_shift.Size = new System.Drawing.Size(100, 21);
			this.comboBox_shift.TabIndex = 2;
			this.comboBox_shift.Tag = "shift";
			this.comboBox_shift.SelectedIndexChanged += new System.EventHandler(this.comboBox_shift_SelectedIndexChanged);
			this.comboBox_shift.Enter += new System.EventHandler(this.help_Populate);
			// 
			// textBox_hstretchamt
			// 
			this.textBox_hstretchamt.Location = new System.Drawing.Point(6, 149);
			this.textBox_hstretchamt.MaxLength = 10;
			this.textBox_hstretchamt.Name = "textBox_hstretchamt";
			this.textBox_hstretchamt.Size = new System.Drawing.Size(100, 20);
			this.textBox_hstretchamt.TabIndex = 6;
			this.textBox_hstretchamt.Tag = "hstretchamt";
			this.textBox_hstretchamt.Enter += new System.EventHandler(this.help_Populate);
			this.textBox_hstretchamt.Leave += new System.EventHandler(this.textBox_hstretchamt_Leave);
			// 
			// label_hstretchamt
			// 
			this.label_hstretchamt.AutoSize = true;
			this.label_hstretchamt.Location = new System.Drawing.Point(112, 153);
			this.label_hstretchamt.Name = "label_hstretchamt";
			this.label_hstretchamt.Size = new System.Drawing.Size(181, 13);
			this.label_hstretchamt.TabIndex = 22;
			this.label_hstretchamt.Text = "Horizontal Stretch Amount (if 0: Auto)";
			// 
			// checkBox_hstretch
			// 
			this.checkBox_hstretch.AutoSize = true;
			this.checkBox_hstretch.Location = new System.Drawing.Point(6, 126);
			this.checkBox_hstretch.Name = "checkBox_hstretch";
			this.checkBox_hstretch.Size = new System.Drawing.Size(149, 17);
			this.checkBox_hstretch.TabIndex = 5;
			this.checkBox_hstretch.Tag = "hstretch";
			this.checkBox_hstretch.Text = "Horizontal Texture Stretch";
			this.checkBox_hstretch.UseVisualStyleBackColor = true;
			this.checkBox_hstretch.CheckedChanged += new System.EventHandler(this.checkBox_hstretch_CheckedChanged);
			this.checkBox_hstretch.Enter += new System.EventHandler(this.help_Populate);
			// 
			// label_hshiftsrc
			// 
			this.label_hshiftsrc.AutoSize = true;
			this.label_hshiftsrc.Location = new System.Drawing.Point(112, 77);
			this.label_hshiftsrc.Name = "label_hshiftsrc";
			this.label_hshiftsrc.Size = new System.Drawing.Size(143, 13);
			this.label_hshiftsrc.TabIndex = 19;
			this.label_hshiftsrc.Text = "Horizontal Shift Source Edge";
			// 
			// comboBox_hshiftsrc
			// 
			this.comboBox_hshiftsrc.AllowDrop = true;
			this.comboBox_hshiftsrc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_hshiftsrc.FormattingEnabled = true;
			this.comboBox_hshiftsrc.Items.AddRange(new object[] {
            "Short Edge",
            "Long Edge"});
			this.comboBox_hshiftsrc.Location = new System.Drawing.Point(6, 73);
			this.comboBox_hshiftsrc.Name = "comboBox_hshiftsrc";
			this.comboBox_hshiftsrc.Size = new System.Drawing.Size(100, 21);
			this.comboBox_hshiftsrc.TabIndex = 3;
			this.comboBox_hshiftsrc.Tag = "hshiftsrc";
			this.comboBox_hshiftsrc.SelectedIndexChanged += new System.EventHandler(this.comboBox_hshiftsrc_SelectedIndexChanged);
			this.comboBox_hshiftsrc.Enter += new System.EventHandler(this.help_Populate);
			// 
			// label_texmode
			// 
			this.label_texmode.AutoSize = true;
			this.label_texmode.Location = new System.Drawing.Point(112, 23);
			this.label_texmode.Name = "label_texmode";
			this.label_texmode.Size = new System.Drawing.Size(87, 13);
			this.label_texmode.TabIndex = 17;
			this.label_texmode.Text = "Texture Mapping";
			// 
			// comboBox_texmode
			// 
			this.comboBox_texmode.AllowDrop = true;
			this.comboBox_texmode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_texmode.FormattingEnabled = true;
			this.comboBox_texmode.Items.AddRange(new object[] {
            "Rectangular",
            "Sheared"});
			this.comboBox_texmode.Location = new System.Drawing.Point(6, 19);
			this.comboBox_texmode.Name = "comboBox_texmode";
			this.comboBox_texmode.Size = new System.Drawing.Size(100, 21);
			this.comboBox_texmode.TabIndex = 1;
			this.comboBox_texmode.Tag = "texmode";
			this.comboBox_texmode.SelectedIndexChanged += new System.EventHandler(this.comboBox_texmode_SelectedIndexChanged);
			this.comboBox_texmode.Enter += new System.EventHandler(this.help_Populate);
			// 
			// label_hshiftoffset
			// 
			this.label_hshiftoffset.AutoSize = true;
			this.label_hshiftoffset.Location = new System.Drawing.Point(112, 104);
			this.label_hshiftoffset.Name = "label_hshiftoffset";
			this.label_hshiftoffset.Size = new System.Drawing.Size(109, 13);
			this.label_hshiftoffset.TabIndex = 13;
			this.label_hshiftoffset.Text = "Horizontal Shift Offset";
			// 
			// textBox_hshiftoffset
			// 
			this.textBox_hshiftoffset.Location = new System.Drawing.Point(6, 100);
			this.textBox_hshiftoffset.MaxLength = 10;
			this.textBox_hshiftoffset.Name = "textBox_hshiftoffset";
			this.textBox_hshiftoffset.Size = new System.Drawing.Size(100, 20);
			this.textBox_hshiftoffset.TabIndex = 4;
			this.textBox_hshiftoffset.Tag = "hshiftoffset";
			this.textBox_hshiftoffset.Enter += new System.EventHandler(this.help_Populate);
			this.textBox_hshiftoffset.Leave += new System.EventHandler(this.textBox_hshiftoffset_Leave);
			// 
			// tabPage_general2
			// 
			this.tabPage_general2.Controls.Add(this.groupBox_middle_sections);
			this.tabPage_general2.Controls.Add(this.groupBox_grid);
			this.tabPage_general2.Controls.Add(this.label28);
			this.tabPage_general2.Controls.Add(this.button_resetTab2);
			this.tabPage_general2.Controls.Add(this.groupBox_transforms_src);
			this.tabPage_general2.Controls.Add(this.groupBox_triangulation);
			this.tabPage_general2.Controls.Add(this.groupBox_transforms);
			this.tabPage_general2.Controls.Add(this.groupBox_null_brushes);
			this.tabPage_general2.ImageIndex = 1;
			this.tabPage_general2.Location = new System.Drawing.Point(4, 61);
			this.tabPage_general2.Name = "tabPage_general2";
			this.tabPage_general2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_general2.Size = new System.Drawing.Size(730, 461);
			this.tabPage_general2.TabIndex = 4;
			this.tabPage_general2.ToolTipText = "General Settings II";
			// 
			// groupBox_middle_sections
			// 
			this.groupBox_middle_sections.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.groupBox_middle_sections.Controls.Add(this.pictureBox_help_gaplen);
			this.groupBox_middle_sections.Controls.Add(this.pictureBox_help_gaps);
			this.groupBox_middle_sections.Controls.Add(this.label_gaplen);
			this.groupBox_middle_sections.Controls.Add(this.checkBox_gaps);
			this.groupBox_middle_sections.Controls.Add(this.textBox_gaplen);
			this.groupBox_middle_sections.Location = new System.Drawing.Point(362, 287);
			this.groupBox_middle_sections.Name = "groupBox_middle_sections";
			this.groupBox_middle_sections.Size = new System.Drawing.Size(350, 75);
			this.groupBox_middle_sections.TabIndex = 70;
			this.groupBox_middle_sections.TabStop = false;
			this.groupBox_middle_sections.Text = "Middle Sections";
			// 
			// pictureBox_help_gaplen
			// 
			this.pictureBox_help_gaplen.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_gaplen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_gaplen.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_gaplen.Location = new System.Drawing.Point(326, 43);
			this.pictureBox_help_gaplen.Name = "pictureBox_help_gaplen";
			this.pictureBox_help_gaplen.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_gaplen.TabIndex = 32;
			this.pictureBox_help_gaplen.TabStop = false;
			this.pictureBox_help_gaplen.Click += new System.EventHandler(this.help_Focus);
			// 
			// pictureBox_help_gaps
			// 
			this.pictureBox_help_gaps.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_gaps.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_gaps.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_gaps.Location = new System.Drawing.Point(326, 18);
			this.pictureBox_help_gaps.Name = "pictureBox_help_gaps";
			this.pictureBox_help_gaps.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_gaps.TabIndex = 30;
			this.pictureBox_help_gaps.TabStop = false;
			this.pictureBox_help_gaps.Click += new System.EventHandler(this.help_Focus);
			// 
			// label_gaplen
			// 
			this.label_gaplen.AutoSize = true;
			this.label_gaplen.Location = new System.Drawing.Point(112, 46);
			this.label_gaplen.Name = "label_gaplen";
			this.label_gaplen.Size = new System.Drawing.Size(75, 13);
			this.label_gaplen.TabIndex = 18;
			this.label_gaplen.Text = "Section length";
			// 
			// checkBox_gaps
			// 
			this.checkBox_gaps.AutoSize = true;
			this.checkBox_gaps.Location = new System.Drawing.Point(6, 19);
			this.checkBox_gaps.Name = "checkBox_gaps";
			this.checkBox_gaps.Size = new System.Drawing.Size(145, 17);
			this.checkBox_gaps.TabIndex = 1;
			this.checkBox_gaps.Text = "Generate middle sections";
			this.checkBox_gaps.UseVisualStyleBackColor = true;
			this.checkBox_gaps.CheckedChanged += new System.EventHandler(this.checkBox_gaps_CheckedChanged);
			this.checkBox_gaps.Enter += new System.EventHandler(this.help_Populate);
			// 
			// textBox_gaplen
			// 
			this.textBox_gaplen.Location = new System.Drawing.Point(6, 42);
			this.textBox_gaplen.Name = "textBox_gaplen";
			this.textBox_gaplen.Size = new System.Drawing.Size(100, 20);
			this.textBox_gaplen.TabIndex = 2;
			this.textBox_gaplen.Enter += new System.EventHandler(this.help_Populate);
			this.textBox_gaplen.Leave += new System.EventHandler(this.textBox_gaplen_Leave);
			// 
			// groupBox_grid
			// 
			this.groupBox_grid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.groupBox_grid.Controls.Add(this.label_gridsize_sep_v1);
			this.groupBox_grid.Controls.Add(this.label_gridsize_sep_v2);
			this.groupBox_grid.Controls.Add(this.label34);
			this.groupBox_grid.Controls.Add(this.pictureBox_help_gridsize);
			this.groupBox_grid.Controls.Add(this.label35);
			this.groupBox_grid.Controls.Add(this.textBox_gridsize_z);
			this.groupBox_grid.Controls.Add(this.label37);
			this.groupBox_grid.Controls.Add(this.label_gridsize);
			this.groupBox_grid.Controls.Add(this.textBox_gridsize_x);
			this.groupBox_grid.Controls.Add(this.textBox_gridsize_y);
			this.groupBox_grid.Controls.Add(this.pictureBox_help_transit_round);
			this.groupBox_grid.Controls.Add(this.checkBox_round);
			this.groupBox_grid.Controls.Add(this.pictureBox_help_round);
			this.groupBox_grid.Controls.Add(this.checkBox_transit_round);
			this.groupBox_grid.Controls.Add(this.label_gridsize_sep_h);
			this.groupBox_grid.Location = new System.Drawing.Point(6, 103);
			this.groupBox_grid.Name = "groupBox_grid";
			this.groupBox_grid.Size = new System.Drawing.Size(350, 116);
			this.groupBox_grid.TabIndex = 30;
			this.groupBox_grid.TabStop = false;
			this.groupBox_grid.Text = "Snap to Grid";
			// 
			// label_gridsize_sep_v1
			// 
			this.label_gridsize_sep_v1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label_gridsize_sep_v1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label_gridsize_sep_v1.Location = new System.Drawing.Point(68, 82);
			this.label_gridsize_sep_v1.Name = "label_gridsize_sep_v1";
			this.label_gridsize_sep_v1.Size = new System.Drawing.Size(2, 25);
			this.label_gridsize_sep_v1.TabIndex = 56;
			// 
			// label_gridsize_sep_v2
			// 
			this.label_gridsize_sep_v2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label_gridsize_sep_v2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label_gridsize_sep_v2.Location = new System.Drawing.Point(134, 82);
			this.label_gridsize_sep_v2.Name = "label_gridsize_sep_v2";
			this.label_gridsize_sep_v2.Size = new System.Drawing.Size(2, 25);
			this.label_gridsize_sep_v2.TabIndex = 57;
			// 
			// label34
			// 
			this.label34.AutoSize = true;
			this.label34.Location = new System.Drawing.Point(161, 66);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(14, 13);
			this.label34.TabIndex = 49;
			this.label34.Text = "Z";
			// 
			// pictureBox_help_gridsize
			// 
			this.pictureBox_help_gridsize.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_gridsize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_gridsize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_gridsize.Location = new System.Drawing.Point(326, 86);
			this.pictureBox_help_gridsize.Name = "pictureBox_help_gridsize";
			this.pictureBox_help_gridsize.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_gridsize.TabIndex = 45;
			this.pictureBox_help_gridsize.TabStop = false;
			this.pictureBox_help_gridsize.Click += new System.EventHandler(this.help_Focus);
			// 
			// label35
			// 
			this.label35.AutoSize = true;
			this.label35.Location = new System.Drawing.Point(95, 66);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(14, 13);
			this.label35.TabIndex = 48;
			this.label35.Text = "Y";
			// 
			// textBox_gridsize_z
			// 
			this.textBox_gridsize_z.Location = new System.Drawing.Point(138, 85);
			this.textBox_gridsize_z.Name = "textBox_gridsize_z";
			this.textBox_gridsize_z.Size = new System.Drawing.Size(60, 20);
			this.textBox_gridsize_z.TabIndex = 5;
			this.textBox_gridsize_z.Tag = "gridsize_z";
			this.textBox_gridsize_z.Enter += new System.EventHandler(this.help_Populate);
			this.textBox_gridsize_z.Leave += new System.EventHandler(this.textBox_gridsize_Leave);
			// 
			// label37
			// 
			this.label37.AutoSize = true;
			this.label37.Location = new System.Drawing.Point(29, 66);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(14, 13);
			this.label37.TabIndex = 47;
			this.label37.Text = "X";
			// 
			// label_gridsize
			// 
			this.label_gridsize.AutoSize = true;
			this.label_gridsize.Location = new System.Drawing.Point(204, 89);
			this.label_gridsize.Name = "label_gridsize";
			this.label_gridsize.Size = new System.Drawing.Size(44, 13);
			this.label_gridsize.TabIndex = 39;
			this.label_gridsize.Text = "Gridsize";
			// 
			// textBox_gridsize_x
			// 
			this.textBox_gridsize_x.Location = new System.Drawing.Point(6, 85);
			this.textBox_gridsize_x.Name = "textBox_gridsize_x";
			this.textBox_gridsize_x.Size = new System.Drawing.Size(60, 20);
			this.textBox_gridsize_x.TabIndex = 3;
			this.textBox_gridsize_x.Tag = "gridsize_x";
			this.textBox_gridsize_x.Enter += new System.EventHandler(this.help_Populate);
			this.textBox_gridsize_x.Leave += new System.EventHandler(this.textBox_gridsize_Leave);
			// 
			// textBox_gridsize_y
			// 
			this.textBox_gridsize_y.Location = new System.Drawing.Point(72, 85);
			this.textBox_gridsize_y.Name = "textBox_gridsize_y";
			this.textBox_gridsize_y.Size = new System.Drawing.Size(60, 20);
			this.textBox_gridsize_y.TabIndex = 4;
			this.textBox_gridsize_y.Tag = "gridsize_y";
			this.textBox_gridsize_y.Enter += new System.EventHandler(this.help_Populate);
			this.textBox_gridsize_y.Leave += new System.EventHandler(this.textBox_gridsize_Leave);
			// 
			// pictureBox_help_transit_round
			// 
			this.pictureBox_help_transit_round.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_transit_round.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_transit_round.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_transit_round.Location = new System.Drawing.Point(326, 41);
			this.pictureBox_help_transit_round.Name = "pictureBox_help_transit_round";
			this.pictureBox_help_transit_round.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_transit_round.TabIndex = 29;
			this.pictureBox_help_transit_round.TabStop = false;
			this.pictureBox_help_transit_round.Click += new System.EventHandler(this.help_Focus);
			// 
			// checkBox_round
			// 
			this.checkBox_round.AutoSize = true;
			this.checkBox_round.Location = new System.Drawing.Point(6, 19);
			this.checkBox_round.Name = "checkBox_round";
			this.checkBox_round.Size = new System.Drawing.Size(136, 17);
			this.checkBox_round.TabIndex = 1;
			this.checkBox_round.Tag = "round";
			this.checkBox_round.Text = "Snap all vertices to grid";
			this.checkBox_round.UseVisualStyleBackColor = true;
			this.checkBox_round.CheckedChanged += new System.EventHandler(this.checkBox_round_CheckedChanged);
			this.checkBox_round.Enter += new System.EventHandler(this.help_Populate);
			// 
			// pictureBox_help_round
			// 
			this.pictureBox_help_round.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_round.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_round.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_round.Location = new System.Drawing.Point(326, 18);
			this.pictureBox_help_round.Name = "pictureBox_help_round";
			this.pictureBox_help_round.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_round.TabIndex = 28;
			this.pictureBox_help_round.TabStop = false;
			this.pictureBox_help_round.Click += new System.EventHandler(this.help_Focus);
			// 
			// checkBox_transit_round
			// 
			this.checkBox_transit_round.AutoSize = true;
			this.checkBox_transit_round.Location = new System.Drawing.Point(6, 42);
			this.checkBox_transit_round.Name = "checkBox_transit_round";
			this.checkBox_transit_round.Size = new System.Drawing.Size(235, 17);
			this.checkBox_transit_round.TabIndex = 2;
			this.checkBox_transit_round.Tag = "transit_round";
			this.checkBox_transit_round.Text = "Snap outer vertices of border brushes to grid";
			this.checkBox_transit_round.UseVisualStyleBackColor = true;
			this.checkBox_transit_round.CheckedChanged += new System.EventHandler(this.checkBox_transit_round_CheckedChanged);
			this.checkBox_transit_round.Enter += new System.EventHandler(this.help_Populate);
			// 
			// label_gridsize_sep_h
			// 
			this.label_gridsize_sep_h.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label_gridsize_sep_h.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label_gridsize_sep_h.Location = new System.Drawing.Point(6, 79);
			this.label_gridsize_sep_h.Name = "label_gridsize_sep_h";
			this.label_gridsize_sep_h.Size = new System.Drawing.Size(192, 2);
			this.label_gridsize_sep_h.TabIndex = 50;
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Location = new System.Drawing.Point(3, 3);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(133, 13);
			this.label28.TabIndex = 40;
			this.label28.Text = "Curve / General Settings II";
			// 
			// groupBox_transforms_src
			// 
			this.groupBox_transforms_src.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.groupBox_transforms_src.Controls.Add(this.checkBox_mirror_src_z);
			this.groupBox_transforms_src.Controls.Add(this.checkBox_mirror_src_y);
			this.groupBox_transforms_src.Controls.Add(this.checkBox_mirror_src_x);
			this.groupBox_transforms_src.Controls.Add(this.label_mirror_src);
			this.groupBox_transforms_src.Controls.Add(this.pictureBox_help_mirror_src);
			this.groupBox_transforms_src.Controls.Add(this.label43);
			this.groupBox_transforms_src.Controls.Add(this.label_rot_src_y);
			this.groupBox_transforms_src.Controls.Add(this.label_transsrc_sep_v1);
			this.groupBox_transforms_src.Controls.Add(this.label_transsrc_sep_v2);
			this.groupBox_transforms_src.Controls.Add(this.label_transsrc_sep_h);
			this.groupBox_transforms_src.Controls.Add(this.label38);
			this.groupBox_transforms_src.Controls.Add(this.pictureBox_help_rot_src);
			this.groupBox_transforms_src.Controls.Add(this.label39);
			this.groupBox_transforms_src.Controls.Add(this.pictureBox_help_scale_src);
			this.groupBox_transforms_src.Controls.Add(this.label40);
			this.groupBox_transforms_src.Controls.Add(this.textBox_scale_src);
			this.groupBox_transforms_src.Controls.Add(this.textBox_rot_src_z);
			this.groupBox_transforms_src.Controls.Add(this.label_rot_src);
			this.groupBox_transforms_src.Controls.Add(this.textBox_rot_src_x);
			this.groupBox_transforms_src.Controls.Add(this.textBox_rot_src_y);
			this.groupBox_transforms_src.Controls.Add(this.label_scale_src);
			this.groupBox_transforms_src.Location = new System.Drawing.Point(6, 239);
			this.groupBox_transforms_src.Name = "groupBox_transforms_src";
			this.groupBox_transforms_src.Size = new System.Drawing.Size(350, 135);
			this.groupBox_transforms_src.TabIndex = 40;
			this.groupBox_transforms_src.TabStop = false;
			this.groupBox_transforms_src.Text = "Transformations Source";
			// 
			// checkBox_mirror_src_z
			// 
			this.checkBox_mirror_src_z.AutoSize = true;
			this.checkBox_mirror_src_z.Location = new System.Drawing.Point(163, 107);
			this.checkBox_mirror_src_z.Name = "checkBox_mirror_src_z";
			this.checkBox_mirror_src_z.Size = new System.Drawing.Size(15, 14);
			this.checkBox_mirror_src_z.TabIndex = 7;
			this.checkBox_mirror_src_z.Tag = "mirror_src_z";
			this.checkBox_mirror_src_z.UseVisualStyleBackColor = true;
			this.checkBox_mirror_src_z.CheckedChanged += new System.EventHandler(this.checkBox_mirror_src_CheckedChanged);
			this.checkBox_mirror_src_z.Enter += new System.EventHandler(this.help_Populate);
			// 
			// checkBox_mirror_src_y
			// 
			this.checkBox_mirror_src_y.AutoSize = true;
			this.checkBox_mirror_src_y.Location = new System.Drawing.Point(97, 107);
			this.checkBox_mirror_src_y.Name = "checkBox_mirror_src_y";
			this.checkBox_mirror_src_y.Size = new System.Drawing.Size(15, 14);
			this.checkBox_mirror_src_y.TabIndex = 6;
			this.checkBox_mirror_src_y.Tag = "mirror_src_y";
			this.checkBox_mirror_src_y.UseVisualStyleBackColor = true;
			this.checkBox_mirror_src_y.CheckedChanged += new System.EventHandler(this.checkBox_mirror_src_CheckedChanged);
			this.checkBox_mirror_src_y.Enter += new System.EventHandler(this.help_Populate);
			// 
			// checkBox_mirror_src_x
			// 
			this.checkBox_mirror_src_x.AutoSize = true;
			this.checkBox_mirror_src_x.Location = new System.Drawing.Point(31, 107);
			this.checkBox_mirror_src_x.Name = "checkBox_mirror_src_x";
			this.checkBox_mirror_src_x.Size = new System.Drawing.Size(15, 14);
			this.checkBox_mirror_src_x.TabIndex = 5;
			this.checkBox_mirror_src_x.Tag = "mirror_src_x";
			this.checkBox_mirror_src_x.UseVisualStyleBackColor = true;
			this.checkBox_mirror_src_x.CheckedChanged += new System.EventHandler(this.checkBox_mirror_src_CheckedChanged);
			this.checkBox_mirror_src_x.Enter += new System.EventHandler(this.help_Populate);
			// 
			// label_mirror_src
			// 
			this.label_mirror_src.AutoSize = true;
			this.label_mirror_src.ForeColor = System.Drawing.Color.Fuchsia;
			this.label_mirror_src.Location = new System.Drawing.Point(206, 108);
			this.label_mirror_src.Name = "label_mirror_src";
			this.label_mirror_src.Size = new System.Drawing.Size(112, 13);
			this.label_mirror_src.TabIndex = 58;
			this.label_mirror_src.Text = "Mirroring (NEW v0.87)";
			// 
			// pictureBox_help_mirror_src
			// 
			this.pictureBox_help_mirror_src.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_mirror_src.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_mirror_src.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_mirror_src.Location = new System.Drawing.Point(326, 105);
			this.pictureBox_help_mirror_src.Name = "pictureBox_help_mirror_src";
			this.pictureBox_help_mirror_src.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_mirror_src.TabIndex = 57;
			this.pictureBox_help_mirror_src.TabStop = false;
			this.pictureBox_help_mirror_src.Click += new System.EventHandler(this.help_Focus);
			// 
			// label43
			// 
			this.label43.AutoSize = true;
			this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
			this.label43.Location = new System.Drawing.Point(137, 88);
			this.label43.Name = "label43";
			this.label43.Size = new System.Drawing.Size(61, 9);
			this.label43.TabIndex = 56;
			this.label43.Text = "+/- 90,180,270,...";
			// 
			// label_rot_src_y
			// 
			this.label_rot_src_y.AutoSize = true;
			this.label_rot_src_y.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
			this.label_rot_src_y.Location = new System.Drawing.Point(70, 88);
			this.label_rot_src_y.Name = "label_rot_src_y";
			this.label_rot_src_y.Size = new System.Drawing.Size(61, 9);
			this.label_rot_src_y.TabIndex = 34;
			this.label_rot_src_y.Text = "+/- 90,180,270,...";
			// 
			// label_transsrc_sep_v1
			// 
			this.label_transsrc_sep_v1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label_transsrc_sep_v1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label_transsrc_sep_v1.Location = new System.Drawing.Point(68, 39);
			this.label_transsrc_sep_v1.Name = "label_transsrc_sep_v1";
			this.label_transsrc_sep_v1.Size = new System.Drawing.Size(2, 90);
			this.label_transsrc_sep_v1.TabIndex = 54;
			// 
			// label_transsrc_sep_v2
			// 
			this.label_transsrc_sep_v2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label_transsrc_sep_v2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label_transsrc_sep_v2.Location = new System.Drawing.Point(134, 39);
			this.label_transsrc_sep_v2.Name = "label_transsrc_sep_v2";
			this.label_transsrc_sep_v2.Size = new System.Drawing.Size(2, 90);
			this.label_transsrc_sep_v2.TabIndex = 55;
			// 
			// label_transsrc_sep_h
			// 
			this.label_transsrc_sep_h.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label_transsrc_sep_h.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label_transsrc_sep_h.Location = new System.Drawing.Point(6, 37);
			this.label_transsrc_sep_h.Name = "label_transsrc_sep_h";
			this.label_transsrc_sep_h.Size = new System.Drawing.Size(192, 2);
			this.label_transsrc_sep_h.TabIndex = 53;
			// 
			// label38
			// 
			this.label38.AutoSize = true;
			this.label38.Location = new System.Drawing.Point(161, 24);
			this.label38.Name = "label38";
			this.label38.Size = new System.Drawing.Size(14, 13);
			this.label38.TabIndex = 52;
			this.label38.Text = "Z";
			// 
			// pictureBox_help_rot_src
			// 
			this.pictureBox_help_rot_src.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_rot_src.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_rot_src.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_rot_src.Location = new System.Drawing.Point(326, 69);
			this.pictureBox_help_rot_src.Name = "pictureBox_help_rot_src";
			this.pictureBox_help_rot_src.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_rot_src.TabIndex = 38;
			this.pictureBox_help_rot_src.TabStop = false;
			this.pictureBox_help_rot_src.Click += new System.EventHandler(this.help_Focus);
			// 
			// label39
			// 
			this.label39.AutoSize = true;
			this.label39.Location = new System.Drawing.Point(95, 24);
			this.label39.Name = "label39";
			this.label39.Size = new System.Drawing.Size(14, 13);
			this.label39.TabIndex = 51;
			this.label39.Text = "Y";
			// 
			// pictureBox_help_scale_src
			// 
			this.pictureBox_help_scale_src.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_scale_src.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_scale_src.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_scale_src.Location = new System.Drawing.Point(326, 43);
			this.pictureBox_help_scale_src.Name = "pictureBox_help_scale_src";
			this.pictureBox_help_scale_src.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_scale_src.TabIndex = 33;
			this.pictureBox_help_scale_src.TabStop = false;
			this.pictureBox_help_scale_src.Click += new System.EventHandler(this.help_Focus);
			// 
			// label40
			// 
			this.label40.AutoSize = true;
			this.label40.Location = new System.Drawing.Point(29, 24);
			this.label40.Name = "label40";
			this.label40.Size = new System.Drawing.Size(14, 13);
			this.label40.TabIndex = 50;
			this.label40.Text = "X";
			// 
			// textBox_scale_src
			// 
			this.textBox_scale_src.Location = new System.Drawing.Point(72, 42);
			this.textBox_scale_src.Name = "textBox_scale_src";
			this.textBox_scale_src.Size = new System.Drawing.Size(60, 20);
			this.textBox_scale_src.TabIndex = 1;
			this.textBox_scale_src.Tag = "scale_src";
			this.textBox_scale_src.Enter += new System.EventHandler(this.help_Populate);
			this.textBox_scale_src.Leave += new System.EventHandler(this.textBox_scale_src_Leave);
			// 
			// textBox_rot_src_z
			// 
			this.textBox_rot_src_z.Location = new System.Drawing.Point(138, 68);
			this.textBox_rot_src_z.Name = "textBox_rot_src_z";
			this.textBox_rot_src_z.Size = new System.Drawing.Size(60, 20);
			this.textBox_rot_src_z.TabIndex = 4;
			this.textBox_rot_src_z.Tag = "rot_src_z";
			this.textBox_rot_src_z.Enter += new System.EventHandler(this.help_Populate);
			this.textBox_rot_src_z.Leave += new System.EventHandler(this.textBox_rot_src_z_Leave);
			// 
			// label_rot_src
			// 
			this.label_rot_src.AutoSize = true;
			this.label_rot_src.Location = new System.Drawing.Point(204, 72);
			this.label_rot_src.Name = "label_rot_src";
			this.label_rot_src.Size = new System.Drawing.Size(47, 13);
			this.label_rot_src.TabIndex = 30;
			this.label_rot_src.Text = "Rotation";
			// 
			// textBox_rot_src_x
			// 
			this.textBox_rot_src_x.Location = new System.Drawing.Point(6, 68);
			this.textBox_rot_src_x.Name = "textBox_rot_src_x";
			this.textBox_rot_src_x.Size = new System.Drawing.Size(60, 20);
			this.textBox_rot_src_x.TabIndex = 2;
			this.textBox_rot_src_x.Tag = "rot_src_x";
			this.textBox_rot_src_x.Enter += new System.EventHandler(this.help_Populate);
			this.textBox_rot_src_x.Leave += new System.EventHandler(this.textBox_rot_src_x_Leave);
			// 
			// textBox_rot_src_y
			// 
			this.textBox_rot_src_y.Location = new System.Drawing.Point(72, 68);
			this.textBox_rot_src_y.Name = "textBox_rot_src_y";
			this.textBox_rot_src_y.Size = new System.Drawing.Size(60, 20);
			this.textBox_rot_src_y.TabIndex = 3;
			this.textBox_rot_src_y.Tag = "rot_src_y";
			this.textBox_rot_src_y.Enter += new System.EventHandler(this.help_Populate);
			this.textBox_rot_src_y.Leave += new System.EventHandler(this.textBox_rot_src_y_Leave);
			// 
			// label_scale_src
			// 
			this.label_scale_src.AutoSize = true;
			this.label_scale_src.Location = new System.Drawing.Point(204, 46);
			this.label_scale_src.Name = "label_scale_src";
			this.label_scale_src.Size = new System.Drawing.Size(84, 13);
			this.label_scale_src.TabIndex = 32;
			this.label_scale_src.Text = "Scale (uniformly)";
			// 
			// groupBox_triangulation
			// 
			this.groupBox_triangulation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.groupBox_triangulation.Controls.Add(this.pictureBox_help_transit_tri);
			this.groupBox_triangulation.Controls.Add(this.pictureBox_help_tri);
			this.groupBox_triangulation.Controls.Add(this.checkBox_transit_tri);
			this.groupBox_triangulation.Controls.Add(this.checkBox_tri);
			this.groupBox_triangulation.Location = new System.Drawing.Point(6, 26);
			this.groupBox_triangulation.Name = "groupBox_triangulation";
			this.groupBox_triangulation.Size = new System.Drawing.Size(350, 71);
			this.groupBox_triangulation.TabIndex = 20;
			this.groupBox_triangulation.TabStop = false;
			this.groupBox_triangulation.Text = "Triangulation";
			// 
			// pictureBox_help_transit_tri
			// 
			this.pictureBox_help_transit_tri.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_transit_tri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_transit_tri.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_transit_tri.Location = new System.Drawing.Point(326, 41);
			this.pictureBox_help_transit_tri.Name = "pictureBox_help_transit_tri";
			this.pictureBox_help_transit_tri.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_transit_tri.TabIndex = 27;
			this.pictureBox_help_transit_tri.TabStop = false;
			this.pictureBox_help_transit_tri.Click += new System.EventHandler(this.help_Focus);
			// 
			// pictureBox_help_tri
			// 
			this.pictureBox_help_tri.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_tri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_tri.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_tri.Location = new System.Drawing.Point(326, 18);
			this.pictureBox_help_tri.Name = "pictureBox_help_tri";
			this.pictureBox_help_tri.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_tri.TabIndex = 26;
			this.pictureBox_help_tri.TabStop = false;
			this.pictureBox_help_tri.Click += new System.EventHandler(this.help_Focus);
			// 
			// checkBox_transit_tri
			// 
			this.checkBox_transit_tri.AutoSize = true;
			this.checkBox_transit_tri.Location = new System.Drawing.Point(6, 42);
			this.checkBox_transit_tri.Name = "checkBox_transit_tri";
			this.checkBox_transit_tri.Size = new System.Drawing.Size(174, 17);
			this.checkBox_transit_tri.TabIndex = 2;
			this.checkBox_transit_tri.Tag = "transit_tri";
			this.checkBox_transit_tri.Text = "Triangulate border brushes only";
			this.checkBox_transit_tri.UseVisualStyleBackColor = true;
			this.checkBox_transit_tri.CheckedChanged += new System.EventHandler(this.checkBox_transit_tri_CheckedChanged);
			this.checkBox_transit_tri.Enter += new System.EventHandler(this.help_Populate);
			// 
			// checkBox_tri
			// 
			this.checkBox_tri.AutoSize = true;
			this.checkBox_tri.Location = new System.Drawing.Point(6, 19);
			this.checkBox_tri.Name = "checkBox_tri";
			this.checkBox_tri.Size = new System.Drawing.Size(212, 17);
			this.checkBox_tri.TabIndex = 1;
			this.checkBox_tri.Tag = "tri";
			this.checkBox_tri.Text = "Triangulate all brushes (Auto by default)";
			this.checkBox_tri.UseVisualStyleBackColor = true;
			this.checkBox_tri.CheckedChanged += new System.EventHandler(this.checkBox_tri_CheckedChanged);
			this.checkBox_tri.Enter += new System.EventHandler(this.help_Populate);
			// 
			// groupBox_transforms
			// 
			this.groupBox_transforms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.groupBox_transforms.Controls.Add(this.label_transfin_sep_v1);
			this.groupBox_transforms.Controls.Add(this.label_transfin_sep_v2);
			this.groupBox_transforms.Controls.Add(this.checkBox_mirror_z);
			this.groupBox_transforms.Controls.Add(this.checkBox_mirror_y);
			this.groupBox_transforms.Controls.Add(this.checkBox_mirror_x);
			this.groupBox_transforms.Controls.Add(this.label_mirror);
			this.groupBox_transforms.Controls.Add(this.pictureBox_help_mirror);
			this.groupBox_transforms.Controls.Add(this.label_rot);
			this.groupBox_transforms.Controls.Add(this.pictureBox_help_move);
			this.groupBox_transforms.Controls.Add(this.pictureBox_help_rot);
			this.groupBox_transforms.Controls.Add(this.pictureBox_help_scale);
			this.groupBox_transforms.Controls.Add(this.textBox_rot_z);
			this.groupBox_transforms.Controls.Add(this.label_transfin_z);
			this.groupBox_transforms.Controls.Add(this.textBox_rot_y);
			this.groupBox_transforms.Controls.Add(this.label_transfin_y);
			this.groupBox_transforms.Controls.Add(this.textBox_move_z);
			this.groupBox_transforms.Controls.Add(this.textBox_move_y);
			this.groupBox_transforms.Controls.Add(this.textBox_move_x);
			this.groupBox_transforms.Controls.Add(this.label_move);
			this.groupBox_transforms.Controls.Add(this.textBox_rot_x);
			this.groupBox_transforms.Controls.Add(this.label_scale);
			this.groupBox_transforms.Controls.Add(this.textBox_scale);
			this.groupBox_transforms.Controls.Add(this.label_transfin_x);
			this.groupBox_transforms.Controls.Add(this.label_transfin_sep_h);
			this.groupBox_transforms.Location = new System.Drawing.Point(362, 26);
			this.groupBox_transforms.Name = "groupBox_transforms";
			this.groupBox_transforms.Size = new System.Drawing.Size(350, 145);
			this.groupBox_transforms.TabIndex = 50;
			this.groupBox_transforms.TabStop = false;
			this.groupBox_transforms.Text = "Transformations Final";
			// 
			// label_transfin_sep_v1
			// 
			this.label_transfin_sep_v1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label_transfin_sep_v1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label_transfin_sep_v1.Location = new System.Drawing.Point(70, 35);
			this.label_transfin_sep_v1.Name = "label_transfin_sep_v1";
			this.label_transfin_sep_v1.Size = new System.Drawing.Size(2, 105);
			this.label_transfin_sep_v1.TabIndex = 48;
			// 
			// label_transfin_sep_v2
			// 
			this.label_transfin_sep_v2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label_transfin_sep_v2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label_transfin_sep_v2.Location = new System.Drawing.Point(136, 35);
			this.label_transfin_sep_v2.Name = "label_transfin_sep_v2";
			this.label_transfin_sep_v2.Size = new System.Drawing.Size(2, 105);
			this.label_transfin_sep_v2.TabIndex = 49;
			// 
			// checkBox_mirror_z
			// 
			this.checkBox_mirror_z.AutoSize = true;
			this.checkBox_mirror_z.Location = new System.Drawing.Point(163, 119);
			this.checkBox_mirror_z.Name = "checkBox_mirror_z";
			this.checkBox_mirror_z.Size = new System.Drawing.Size(15, 14);
			this.checkBox_mirror_z.TabIndex = 10;
			this.checkBox_mirror_z.UseVisualStyleBackColor = true;
			this.checkBox_mirror_z.CheckedChanged += new System.EventHandler(this.checkBox_mirror_CheckedChanged);
			this.checkBox_mirror_z.Enter += new System.EventHandler(this.help_Populate);
			// 
			// checkBox_mirror_y
			// 
			this.checkBox_mirror_y.AutoSize = true;
			this.checkBox_mirror_y.Location = new System.Drawing.Point(97, 119);
			this.checkBox_mirror_y.Name = "checkBox_mirror_y";
			this.checkBox_mirror_y.Size = new System.Drawing.Size(15, 14);
			this.checkBox_mirror_y.TabIndex = 9;
			this.checkBox_mirror_y.UseVisualStyleBackColor = true;
			this.checkBox_mirror_y.CheckedChanged += new System.EventHandler(this.checkBox_mirror_CheckedChanged);
			this.checkBox_mirror_y.Enter += new System.EventHandler(this.help_Populate);
			// 
			// checkBox_mirror_x
			// 
			this.checkBox_mirror_x.AutoSize = true;
			this.checkBox_mirror_x.Location = new System.Drawing.Point(31, 119);
			this.checkBox_mirror_x.Name = "checkBox_mirror_x";
			this.checkBox_mirror_x.Size = new System.Drawing.Size(15, 14);
			this.checkBox_mirror_x.TabIndex = 8;
			this.checkBox_mirror_x.UseVisualStyleBackColor = true;
			this.checkBox_mirror_x.CheckedChanged += new System.EventHandler(this.checkBox_mirror_CheckedChanged);
			this.checkBox_mirror_x.Enter += new System.EventHandler(this.help_Populate);
			// 
			// label_mirror
			// 
			this.label_mirror.AutoSize = true;
			this.label_mirror.ForeColor = System.Drawing.Color.Fuchsia;
			this.label_mirror.Location = new System.Drawing.Point(206, 120);
			this.label_mirror.Name = "label_mirror";
			this.label_mirror.Size = new System.Drawing.Size(112, 13);
			this.label_mirror.TabIndex = 43;
			this.label_mirror.Text = "Mirroring (NEW v0.87)";
			// 
			// pictureBox_help_mirror
			// 
			this.pictureBox_help_mirror.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_mirror.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_mirror.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_mirror.Location = new System.Drawing.Point(326, 117);
			this.pictureBox_help_mirror.Name = "pictureBox_help_mirror";
			this.pictureBox_help_mirror.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_mirror.TabIndex = 42;
			this.pictureBox_help_mirror.TabStop = false;
			this.pictureBox_help_mirror.Click += new System.EventHandler(this.help_Focus);
			// 
			// label_rot
			// 
			this.label_rot.AutoSize = true;
			this.label_rot.Location = new System.Drawing.Point(206, 95);
			this.label_rot.Name = "label_rot";
			this.label_rot.Size = new System.Drawing.Size(47, 13);
			this.label_rot.TabIndex = 41;
			this.label_rot.Text = "Rotation";
			// 
			// pictureBox_help_move
			// 
			this.pictureBox_help_move.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_move.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_move.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_move.Location = new System.Drawing.Point(326, 66);
			this.pictureBox_help_move.Name = "pictureBox_help_move";
			this.pictureBox_help_move.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_move.TabIndex = 40;
			this.pictureBox_help_move.TabStop = false;
			this.pictureBox_help_move.Click += new System.EventHandler(this.help_Focus);
			// 
			// pictureBox_help_rot
			// 
			this.pictureBox_help_rot.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_rot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_rot.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_rot.Location = new System.Drawing.Point(326, 92);
			this.pictureBox_help_rot.Name = "pictureBox_help_rot";
			this.pictureBox_help_rot.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_rot.TabIndex = 39;
			this.pictureBox_help_rot.TabStop = false;
			this.pictureBox_help_rot.Click += new System.EventHandler(this.help_Focus);
			// 
			// pictureBox_help_scale
			// 
			this.pictureBox_help_scale.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_scale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_scale.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_scale.Location = new System.Drawing.Point(326, 40);
			this.pictureBox_help_scale.Name = "pictureBox_help_scale";
			this.pictureBox_help_scale.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_scale.TabIndex = 38;
			this.pictureBox_help_scale.TabStop = false;
			this.pictureBox_help_scale.Click += new System.EventHandler(this.help_Focus);
			// 
			// textBox_rot_z
			// 
			this.textBox_rot_z.Location = new System.Drawing.Point(140, 91);
			this.textBox_rot_z.Name = "textBox_rot_z";
			this.textBox_rot_z.Size = new System.Drawing.Size(60, 20);
			this.textBox_rot_z.TabIndex = 7;
			this.textBox_rot_z.Enter += new System.EventHandler(this.help_Populate);
			this.textBox_rot_z.Leave += new System.EventHandler(this.textBox_rot_z_Leave);
			// 
			// label_transfin_z
			// 
			this.label_transfin_z.AutoSize = true;
			this.label_transfin_z.Location = new System.Drawing.Point(163, 20);
			this.label_transfin_z.Name = "label_transfin_z";
			this.label_transfin_z.Size = new System.Drawing.Size(14, 13);
			this.label_transfin_z.TabIndex = 36;
			this.label_transfin_z.Text = "Z";
			// 
			// textBox_rot_y
			// 
			this.textBox_rot_y.Location = new System.Drawing.Point(74, 91);
			this.textBox_rot_y.Name = "textBox_rot_y";
			this.textBox_rot_y.Size = new System.Drawing.Size(60, 20);
			this.textBox_rot_y.TabIndex = 6;
			this.textBox_rot_y.Enter += new System.EventHandler(this.help_Populate);
			this.textBox_rot_y.Leave += new System.EventHandler(this.textBox_rot_y_Leave);
			// 
			// label_transfin_y
			// 
			this.label_transfin_y.AutoSize = true;
			this.label_transfin_y.Location = new System.Drawing.Point(97, 20);
			this.label_transfin_y.Name = "label_transfin_y";
			this.label_transfin_y.Size = new System.Drawing.Size(14, 13);
			this.label_transfin_y.TabIndex = 34;
			this.label_transfin_y.Text = "Y";
			// 
			// textBox_move_z
			// 
			this.textBox_move_z.Location = new System.Drawing.Point(140, 65);
			this.textBox_move_z.Name = "textBox_move_z";
			this.textBox_move_z.Size = new System.Drawing.Size(60, 20);
			this.textBox_move_z.TabIndex = 4;
			this.textBox_move_z.Enter += new System.EventHandler(this.help_Populate);
			this.textBox_move_z.Leave += new System.EventHandler(this.textBox_move_z_Leave);
			// 
			// textBox_move_y
			// 
			this.textBox_move_y.Location = new System.Drawing.Point(74, 65);
			this.textBox_move_y.Name = "textBox_move_y";
			this.textBox_move_y.Size = new System.Drawing.Size(60, 20);
			this.textBox_move_y.TabIndex = 3;
			this.textBox_move_y.Enter += new System.EventHandler(this.help_Populate);
			this.textBox_move_y.Leave += new System.EventHandler(this.textBox_move_y_Leave);
			// 
			// textBox_move_x
			// 
			this.textBox_move_x.Location = new System.Drawing.Point(8, 65);
			this.textBox_move_x.Name = "textBox_move_x";
			this.textBox_move_x.Size = new System.Drawing.Size(60, 20);
			this.textBox_move_x.TabIndex = 2;
			this.textBox_move_x.Enter += new System.EventHandler(this.help_Populate);
			this.textBox_move_x.Leave += new System.EventHandler(this.textBox_move_x_Leave);
			// 
			// label_move
			// 
			this.label_move.AutoSize = true;
			this.label_move.Location = new System.Drawing.Point(206, 69);
			this.label_move.Name = "label_move";
			this.label_move.Size = new System.Drawing.Size(59, 13);
			this.label_move.TabIndex = 20;
			this.label_move.Text = "Translation";
			// 
			// textBox_rot_x
			// 
			this.textBox_rot_x.Location = new System.Drawing.Point(8, 91);
			this.textBox_rot_x.Name = "textBox_rot_x";
			this.textBox_rot_x.Size = new System.Drawing.Size(60, 20);
			this.textBox_rot_x.TabIndex = 5;
			this.textBox_rot_x.Enter += new System.EventHandler(this.help_Populate);
			this.textBox_rot_x.Leave += new System.EventHandler(this.textBox_rot_x_Leave);
			// 
			// label_scale
			// 
			this.label_scale.AutoSize = true;
			this.label_scale.Location = new System.Drawing.Point(206, 42);
			this.label_scale.Name = "label_scale";
			this.label_scale.Size = new System.Drawing.Size(84, 13);
			this.label_scale.TabIndex = 18;
			this.label_scale.Text = "Scale (uniformly)";
			// 
			// textBox_scale
			// 
			this.textBox_scale.Location = new System.Drawing.Point(74, 39);
			this.textBox_scale.Name = "textBox_scale";
			this.textBox_scale.Size = new System.Drawing.Size(60, 20);
			this.textBox_scale.TabIndex = 1;
			this.textBox_scale.Enter += new System.EventHandler(this.help_Populate);
			this.textBox_scale.Leave += new System.EventHandler(this.textBox_scale_Leave);
			// 
			// label_transfin_x
			// 
			this.label_transfin_x.AutoSize = true;
			this.label_transfin_x.Location = new System.Drawing.Point(31, 20);
			this.label_transfin_x.Name = "label_transfin_x";
			this.label_transfin_x.Size = new System.Drawing.Size(14, 13);
			this.label_transfin_x.TabIndex = 11;
			this.label_transfin_x.Text = "X";
			// 
			// label_transfin_sep_h
			// 
			this.label_transfin_sep_h.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label_transfin_sep_h.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label_transfin_sep_h.Location = new System.Drawing.Point(8, 33);
			this.label_transfin_sep_h.Name = "label_transfin_sep_h";
			this.label_transfin_sep_h.Size = new System.Drawing.Size(192, 2);
			this.label_transfin_sep_h.TabIndex = 47;
			// 
			// groupBox_null_brushes
			// 
			this.groupBox_null_brushes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.groupBox_null_brushes.Controls.Add(this.pictureBox_help_skipnull);
			this.groupBox_null_brushes.Controls.Add(this.pictureBox_help_spike_height);
			this.groupBox_null_brushes.Controls.Add(this.pictureBox_help_nulltex);
			this.groupBox_null_brushes.Controls.Add(this.textBox_spike_height);
			this.groupBox_null_brushes.Controls.Add(this.label_nulltex);
			this.groupBox_null_brushes.Controls.Add(this.checkBox_skipnull);
			this.groupBox_null_brushes.Controls.Add(this.textBox_nulltex);
			this.groupBox_null_brushes.Controls.Add(this.label_spike_height);
			this.groupBox_null_brushes.Location = new System.Drawing.Point(362, 177);
			this.groupBox_null_brushes.Name = "groupBox_null_brushes";
			this.groupBox_null_brushes.Size = new System.Drawing.Size(350, 104);
			this.groupBox_null_brushes.TabIndex = 60;
			this.groupBox_null_brushes.TabStop = false;
			this.groupBox_null_brushes.Text = "NULL Brushes";
			// 
			// pictureBox_help_skipnull
			// 
			this.pictureBox_help_skipnull.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_skipnull.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_skipnull.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_skipnull.Location = new System.Drawing.Point(326, 71);
			this.pictureBox_help_skipnull.Name = "pictureBox_help_skipnull";
			this.pictureBox_help_skipnull.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_skipnull.TabIndex = 32;
			this.pictureBox_help_skipnull.TabStop = false;
			this.pictureBox_help_skipnull.Click += new System.EventHandler(this.help_Focus);
			// 
			// pictureBox_help_spike_height
			// 
			this.pictureBox_help_spike_height.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_spike_height.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_spike_height.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_spike_height.Location = new System.Drawing.Point(326, 46);
			this.pictureBox_help_spike_height.Name = "pictureBox_help_spike_height";
			this.pictureBox_help_spike_height.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_spike_height.TabIndex = 31;
			this.pictureBox_help_spike_height.TabStop = false;
			this.pictureBox_help_spike_height.Click += new System.EventHandler(this.help_Focus);
			// 
			// pictureBox_help_nulltex
			// 
			this.pictureBox_help_nulltex.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_nulltex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_nulltex.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_nulltex.Location = new System.Drawing.Point(326, 19);
			this.pictureBox_help_nulltex.Name = "pictureBox_help_nulltex";
			this.pictureBox_help_nulltex.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_nulltex.TabIndex = 30;
			this.pictureBox_help_nulltex.TabStop = false;
			this.pictureBox_help_nulltex.Click += new System.EventHandler(this.help_Focus);
			// 
			// textBox_spike_height
			// 
			this.textBox_spike_height.Location = new System.Drawing.Point(6, 45);
			this.textBox_spike_height.Name = "textBox_spike_height";
			this.textBox_spike_height.Size = new System.Drawing.Size(100, 20);
			this.textBox_spike_height.TabIndex = 2;
			this.textBox_spike_height.Enter += new System.EventHandler(this.help_Populate);
			this.textBox_spike_height.Leave += new System.EventHandler(this.textBox_spike_height_Leave);
			// 
			// label_nulltex
			// 
			this.label_nulltex.AutoSize = true;
			this.label_nulltex.Location = new System.Drawing.Point(112, 22);
			this.label_nulltex.Name = "label_nulltex";
			this.label_nulltex.Size = new System.Drawing.Size(74, 13);
			this.label_nulltex.TabIndex = 18;
			this.label_nulltex.Text = "NULL Texture";
			// 
			// checkBox_skipnull
			// 
			this.checkBox_skipnull.AutoSize = true;
			this.checkBox_skipnull.Location = new System.Drawing.Point(6, 72);
			this.checkBox_skipnull.Name = "checkBox_skipnull";
			this.checkBox_skipnull.Size = new System.Drawing.Size(155, 17);
			this.checkBox_skipnull.TabIndex = 3;
			this.checkBox_skipnull.Text = "Don\'t export NULL-Brushes";
			this.checkBox_skipnull.UseVisualStyleBackColor = true;
			this.checkBox_skipnull.CheckedChanged += new System.EventHandler(this.checkBox_skipnull_CheckedChanged);
			this.checkBox_skipnull.Enter += new System.EventHandler(this.help_Populate);
			// 
			// textBox_nulltex
			// 
			this.textBox_nulltex.Location = new System.Drawing.Point(6, 19);
			this.textBox_nulltex.Name = "textBox_nulltex";
			this.textBox_nulltex.Size = new System.Drawing.Size(100, 20);
			this.textBox_nulltex.TabIndex = 1;
			this.textBox_nulltex.Enter += new System.EventHandler(this.help_Populate);
			this.textBox_nulltex.Leave += new System.EventHandler(this.textBox_nulltex_Leave);
			// 
			// label_spike_height
			// 
			this.label_spike_height.AutoSize = true;
			this.label_spike_height.Location = new System.Drawing.Point(112, 48);
			this.label_spike_height.Name = "label_spike_height";
			this.label_spike_height.Size = new System.Drawing.Size(68, 13);
			this.label_spike_height.TabIndex = 11;
			this.label_spike_height.Text = "Spike Height";
			// 
			// tabPage_path_corner
			// 
			this.tabPage_path_corner.Controls.Add(this.groupBox6);
			this.tabPage_path_corner.Controls.Add(this.label29);
			this.tabPage_path_corner.Controls.Add(this.button_resetTab3);
			this.tabPage_path_corner.ImageIndex = 2;
			this.tabPage_path_corner.Location = new System.Drawing.Point(4, 61);
			this.tabPage_path_corner.Name = "tabPage_path_corner";
			this.tabPage_path_corner.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_path_corner.Size = new System.Drawing.Size(730, 461);
			this.tabPage_path_corner.TabIndex = 1;
			this.tabPage_path_corner.ToolTipText = "Path Corner Settings";
			// 
			// groupBox6
			// 
			this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.groupBox6.Controls.Add(this.button_splinefile);
			this.groupBox6.Controls.Add(this.label_splinefile);
			this.groupBox6.Controls.Add(this.pictureBox_help_splinefile);
			this.groupBox6.Controls.Add(this.checkBox_p_cornerfix);
			this.groupBox6.Controls.Add(this.button5);
			this.groupBox6.Controls.Add(this.checkBox_p_reverse);
			this.groupBox6.Controls.Add(this.checkBox_p_split);
			this.groupBox6.Controls.Add(this.pictureBox_help_p_scale);
			this.groupBox6.Controls.Add(this.label_p_expand);
			this.groupBox6.Controls.Add(this.pictureBox_help_p_expand);
			this.groupBox6.Controls.Add(this.checkBox_p_evenout);
			this.groupBox6.Controls.Add(this.pictureBox_help_p_cornerfix);
			this.groupBox6.Controls.Add(this.label_p_scale_y);
			this.groupBox6.Controls.Add(this.pictureBox_help_p_evenout);
			this.groupBox6.Controls.Add(this.label_p_scale_x);
			this.groupBox6.Controls.Add(this.pictureBox_help_p_reverse);
			this.groupBox6.Controls.Add(this.label_p_scale_z);
			this.groupBox6.Controls.Add(this.pictureBox_help_p_split);
			this.groupBox6.Controls.Add(this.textBox_splinefile);
			this.groupBox6.Controls.Add(this.textBox_p_expand);
			this.groupBox6.Controls.Add(this.textBox_p_scale_y);
			this.groupBox6.Controls.Add(this.textBox_p_scale_z);
			this.groupBox6.Controls.Add(this.textBox_p_scale_x);
			this.groupBox6.Location = new System.Drawing.Point(6, 26);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(718, 294);
			this.groupBox6.TabIndex = 20;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Path_Corner Settings";
			// 
			// button_splinefile
			// 
			this.button_splinefile.Location = new System.Drawing.Point(6, 24);
			this.button_splinefile.Name = "button_splinefile";
			this.button_splinefile.Size = new System.Drawing.Size(111, 23);
			this.button_splinefile.TabIndex = 1;
			this.button_splinefile.Text = "Path_Corner File";
			this.button_splinefile.UseVisualStyleBackColor = true;
			this.button_splinefile.Click += new System.EventHandler(this.button_splinefile_Click);
			// 
			// label_splinefile
			// 
			this.label_splinefile.AutoSize = true;
			this.label_splinefile.ForeColor = System.Drawing.Color.Red;
			this.label_splinefile.Location = new System.Drawing.Point(120, 49);
			this.label_splinefile.Name = "label_splinefile";
			this.label_splinefile.Size = new System.Drawing.Size(231, 13);
			this.label_splinefile.TabIndex = 5;
			this.label_splinefile.Text = "File must contain at least 2 path_corner entities!";
			this.label_splinefile.Visible = false;
			// 
			// pictureBox_help_splinefile
			// 
			this.pictureBox_help_splinefile.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_splinefile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_splinefile.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_splinefile.Location = new System.Drawing.Point(613, 26);
			this.pictureBox_help_splinefile.Name = "pictureBox_help_splinefile";
			this.pictureBox_help_splinefile.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_splinefile.TabIndex = 50;
			this.pictureBox_help_splinefile.TabStop = false;
			this.pictureBox_help_splinefile.Click += new System.EventHandler(this.help_Populate);
			// 
			// checkBox_p_cornerfix
			// 
			this.checkBox_p_cornerfix.AutoSize = true;
			this.checkBox_p_cornerfix.Location = new System.Drawing.Point(6, 144);
			this.checkBox_p_cornerfix.Name = "checkBox_p_cornerfix";
			this.checkBox_p_cornerfix.Size = new System.Drawing.Size(167, 17);
			this.checkBox_p_cornerfix.TabIndex = 7;
			this.checkBox_p_cornerfix.Text = "Corner Fix (not recommended)";
			this.checkBox_p_cornerfix.UseVisualStyleBackColor = true;
			this.checkBox_p_cornerfix.CheckedChanged += new System.EventHandler(this.checkBox_p_cornerfix_CheckedChanged);
			this.checkBox_p_cornerfix.Enter += new System.EventHandler(this.help_Populate);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(637, 24);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 3;
			this.button5.Text = "Remove";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button_RemoveCornerFile);
			// 
			// checkBox_p_reverse
			// 
			this.checkBox_p_reverse.AutoSize = true;
			this.checkBox_p_reverse.Location = new System.Drawing.Point(6, 98);
			this.checkBox_p_reverse.Name = "checkBox_p_reverse";
			this.checkBox_p_reverse.Size = new System.Drawing.Size(133, 17);
			this.checkBox_p_reverse.TabIndex = 5;
			this.checkBox_p_reverse.Text = "Reverse path direction";
			this.checkBox_p_reverse.UseVisualStyleBackColor = true;
			this.checkBox_p_reverse.CheckedChanged += new System.EventHandler(this.checkBox_p_reverse_CheckedChanged);
			this.checkBox_p_reverse.Enter += new System.EventHandler(this.help_Populate);
			// 
			// checkBox_p_split
			// 
			this.checkBox_p_split.AutoSize = true;
			this.checkBox_p_split.Location = new System.Drawing.Point(6, 75);
			this.checkBox_p_split.Name = "checkBox_p_split";
			this.checkBox_p_split.Size = new System.Drawing.Size(211, 17);
			this.checkBox_p_split.TabIndex = 4;
			this.checkBox_p_split.Text = "Split up curve depending on orientation";
			this.checkBox_p_split.UseVisualStyleBackColor = true;
			this.checkBox_p_split.CheckedChanged += new System.EventHandler(this.checkBox_p_split_CheckedChanged);
			this.checkBox_p_split.Enter += new System.EventHandler(this.help_Populate);
			// 
			// pictureBox_help_p_scale
			// 
			this.pictureBox_help_p_scale.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_p_scale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_p_scale.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_p_scale.Location = new System.Drawing.Point(224, 225);
			this.pictureBox_help_p_scale.Name = "pictureBox_help_p_scale";
			this.pictureBox_help_p_scale.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_p_scale.TabIndex = 47;
			this.pictureBox_help_p_scale.TabStop = false;
			this.pictureBox_help_p_scale.Click += new System.EventHandler(this.help_Populate);
			// 
			// label_p_expand
			// 
			this.label_p_expand.AutoSize = true;
			this.label_p_expand.Location = new System.Drawing.Point(112, 170);
			this.label_p_expand.Name = "label_p_expand";
			this.label_p_expand.Size = new System.Drawing.Size(68, 13);
			this.label_p_expand.TabIndex = 32;
			this.label_p_expand.Text = "Path Expand";
			// 
			// pictureBox_help_p_expand
			// 
			this.pictureBox_help_p_expand.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_p_expand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_p_expand.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_p_expand.Location = new System.Drawing.Point(224, 167);
			this.pictureBox_help_p_expand.Name = "pictureBox_help_p_expand";
			this.pictureBox_help_p_expand.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_p_expand.TabIndex = 46;
			this.pictureBox_help_p_expand.TabStop = false;
			this.pictureBox_help_p_expand.Click += new System.EventHandler(this.help_Populate);
			// 
			// checkBox_p_evenout
			// 
			this.checkBox_p_evenout.AutoSize = true;
			this.checkBox_p_evenout.Location = new System.Drawing.Point(6, 121);
			this.checkBox_p_evenout.Name = "checkBox_p_evenout";
			this.checkBox_p_evenout.Size = new System.Drawing.Size(138, 17);
			this.checkBox_p_evenout.TabIndex = 6;
			this.checkBox_p_evenout.Text = "Even out corner density";
			this.checkBox_p_evenout.UseVisualStyleBackColor = true;
			this.checkBox_p_evenout.CheckedChanged += new System.EventHandler(this.checkBox_p_evenout_CheckedChanged);
			this.checkBox_p_evenout.Enter += new System.EventHandler(this.help_Populate);
			// 
			// pictureBox_help_p_cornerfix
			// 
			this.pictureBox_help_p_cornerfix.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_p_cornerfix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_p_cornerfix.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_p_cornerfix.Location = new System.Drawing.Point(224, 143);
			this.pictureBox_help_p_cornerfix.Name = "pictureBox_help_p_cornerfix";
			this.pictureBox_help_p_cornerfix.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_p_cornerfix.TabIndex = 45;
			this.pictureBox_help_p_cornerfix.TabStop = false;
			this.pictureBox_help_p_cornerfix.Click += new System.EventHandler(this.help_Populate);
			// 
			// label_p_scale_y
			// 
			this.label_p_scale_y.AutoSize = true;
			this.label_p_scale_y.Location = new System.Drawing.Point(112, 227);
			this.label_p_scale_y.Name = "label_p_scale_y";
			this.label_p_scale_y.Size = new System.Drawing.Size(69, 13);
			this.label_p_scale_y.TabIndex = 37;
			this.label_p_scale_y.Text = "Path Scale Y";
			// 
			// pictureBox_help_p_evenout
			// 
			this.pictureBox_help_p_evenout.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_p_evenout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_p_evenout.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_p_evenout.Location = new System.Drawing.Point(224, 120);
			this.pictureBox_help_p_evenout.Name = "pictureBox_help_p_evenout";
			this.pictureBox_help_p_evenout.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_p_evenout.TabIndex = 44;
			this.pictureBox_help_p_evenout.TabStop = false;
			this.pictureBox_help_p_evenout.Click += new System.EventHandler(this.help_Populate);
			// 
			// label_p_scale_x
			// 
			this.label_p_scale_x.AutoSize = true;
			this.label_p_scale_x.Location = new System.Drawing.Point(112, 201);
			this.label_p_scale_x.Name = "label_p_scale_x";
			this.label_p_scale_x.Size = new System.Drawing.Size(69, 13);
			this.label_p_scale_x.TabIndex = 35;
			this.label_p_scale_x.Text = "Path Scale X";
			// 
			// pictureBox_help_p_reverse
			// 
			this.pictureBox_help_p_reverse.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_p_reverse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_p_reverse.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_p_reverse.Location = new System.Drawing.Point(224, 97);
			this.pictureBox_help_p_reverse.Name = "pictureBox_help_p_reverse";
			this.pictureBox_help_p_reverse.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_p_reverse.TabIndex = 43;
			this.pictureBox_help_p_reverse.TabStop = false;
			this.pictureBox_help_p_reverse.Click += new System.EventHandler(this.help_Populate);
			// 
			// label_p_scale_z
			// 
			this.label_p_scale_z.AutoSize = true;
			this.label_p_scale_z.Location = new System.Drawing.Point(112, 253);
			this.label_p_scale_z.Name = "label_p_scale_z";
			this.label_p_scale_z.Size = new System.Drawing.Size(69, 13);
			this.label_p_scale_z.TabIndex = 39;
			this.label_p_scale_z.Text = "Path Scale Z";
			// 
			// pictureBox_help_p_split
			// 
			this.pictureBox_help_p_split.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_p_split.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_p_split.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_p_split.Location = new System.Drawing.Point(224, 74);
			this.pictureBox_help_p_split.Name = "pictureBox_help_p_split";
			this.pictureBox_help_p_split.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_p_split.TabIndex = 42;
			this.pictureBox_help_p_split.TabStop = false;
			this.pictureBox_help_p_split.Click += new System.EventHandler(this.help_Populate);
			// 
			// textBox_splinefile
			// 
			this.textBox_splinefile.Location = new System.Drawing.Point(123, 25);
			this.textBox_splinefile.Name = "textBox_splinefile";
			this.textBox_splinefile.ReadOnly = true;
			this.textBox_splinefile.Size = new System.Drawing.Size(484, 20);
			this.textBox_splinefile.TabIndex = 2;
			this.textBox_splinefile.Enter += new System.EventHandler(this.help_Populate);
			// 
			// textBox_p_expand
			// 
			this.textBox_p_expand.Location = new System.Drawing.Point(6, 167);
			this.textBox_p_expand.Name = "textBox_p_expand";
			this.textBox_p_expand.Size = new System.Drawing.Size(100, 20);
			this.textBox_p_expand.TabIndex = 8;
			this.textBox_p_expand.Enter += new System.EventHandler(this.help_Populate);
			this.textBox_p_expand.Leave += new System.EventHandler(this.textBox_p_expand_Leave);
			// 
			// textBox_p_scale_y
			// 
			this.textBox_p_scale_y.Location = new System.Drawing.Point(6, 224);
			this.textBox_p_scale_y.Name = "textBox_p_scale_y";
			this.textBox_p_scale_y.Size = new System.Drawing.Size(100, 20);
			this.textBox_p_scale_y.TabIndex = 10;
			this.textBox_p_scale_y.Enter += new System.EventHandler(this.help_Populate);
			this.textBox_p_scale_y.Leave += new System.EventHandler(this.textBox_p_scale_y_Leave);
			// 
			// textBox_p_scale_z
			// 
			this.textBox_p_scale_z.Location = new System.Drawing.Point(6, 250);
			this.textBox_p_scale_z.Name = "textBox_p_scale_z";
			this.textBox_p_scale_z.Size = new System.Drawing.Size(100, 20);
			this.textBox_p_scale_z.TabIndex = 11;
			this.textBox_p_scale_z.Enter += new System.EventHandler(this.help_Populate);
			this.textBox_p_scale_z.Leave += new System.EventHandler(this.textBox_p_scale_z_Leave);
			// 
			// textBox_p_scale_x
			// 
			this.textBox_p_scale_x.Location = new System.Drawing.Point(6, 198);
			this.textBox_p_scale_x.Name = "textBox_p_scale_x";
			this.textBox_p_scale_x.Size = new System.Drawing.Size(100, 20);
			this.textBox_p_scale_x.TabIndex = 9;
			this.textBox_p_scale_x.Enter += new System.EventHandler(this.help_Populate);
			this.textBox_p_scale_x.Leave += new System.EventHandler(this.textBox_p_scale_x_Leave);
			// 
			// label29
			// 
			this.label29.AutoSize = true;
			this.label29.Location = new System.Drawing.Point(3, 3);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(146, 13);
			this.label29.TabIndex = 51;
			this.label29.Text = "Curve / Path_Corner Settings";
			// 
			// button_resetTab3
			// 
			this.button_resetTab3.Location = new System.Drawing.Point(649, 432);
			this.button_resetTab3.Name = "button_resetTab3";
			this.button_resetTab3.Size = new System.Drawing.Size(75, 23);
			this.button_resetTab3.TabIndex = 30;
			this.button_resetTab3.Text = "Reset Tab";
			this.button_resetTab3.UseVisualStyleBackColor = true;
			this.button_resetTab3.Click += new System.EventHandler(this.button_resetTab3_Click);
			// 
			// tabPage_detail_objects
			// 
			this.tabPage_detail_objects.Controls.Add(this.label30);
			this.tabPage_detail_objects.Controls.Add(this.button_resetTab4);
			this.tabPage_detail_objects.Controls.Add(this.groupBox4);
			this.tabPage_detail_objects.Controls.Add(this.groupBox3);
			this.tabPage_detail_objects.Controls.Add(this.groupBox2);
			this.tabPage_detail_objects.Controls.Add(this.groupBox1);
			this.tabPage_detail_objects.ImageIndex = 3;
			this.tabPage_detail_objects.Location = new System.Drawing.Point(4, 61);
			this.tabPage_detail_objects.Name = "tabPage_detail_objects";
			this.tabPage_detail_objects.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_detail_objects.Size = new System.Drawing.Size(730, 461);
			this.tabPage_detail_objects.TabIndex = 2;
			this.tabPage_detail_objects.ToolTipText = "Detail Object Settings";
			// 
			// label30
			// 
			this.label30.AutoSize = true;
			this.label30.Location = new System.Drawing.Point(3, 3);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(148, 13);
			this.label30.TabIndex = 52;
			this.label30.Text = "Curve / Detail Object Settings";
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.groupBox4.Controls.Add(this.pictureBox_help_d_skip);
			this.groupBox4.Controls.Add(this.pictureBox_help_d_draw);
			this.groupBox4.Controls.Add(this.pictureBox_help_d_draw_rand);
			this.groupBox4.Controls.Add(this.pictureBox_help_d_enable);
			this.groupBox4.Controls.Add(this.checkBox_d_enable);
			this.groupBox4.Controls.Add(this.checkBox_d_draw_rand);
			this.groupBox4.Controls.Add(this.label10);
			this.groupBox4.Controls.Add(this.textBox_d_skip);
			this.groupBox4.Controls.Add(this.label9);
			this.groupBox4.Controls.Add(this.textBox_d_draw);
			this.groupBox4.Location = new System.Drawing.Point(6, 305);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(350, 127);
			this.groupBox4.TabIndex = 40;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Export Control";
			// 
			// pictureBox_help_d_skip
			// 
			this.pictureBox_help_d_skip.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_d_skip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_d_skip.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_d_skip.Location = new System.Drawing.Point(326, 92);
			this.pictureBox_help_d_skip.Name = "pictureBox_help_d_skip";
			this.pictureBox_help_d_skip.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_d_skip.TabIndex = 38;
			this.pictureBox_help_d_skip.TabStop = false;
			this.pictureBox_help_d_skip.Click += new System.EventHandler(this.help_Populate);
			// 
			// pictureBox_help_d_draw
			// 
			this.pictureBox_help_d_draw.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_d_draw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_d_draw.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_d_draw.Location = new System.Drawing.Point(326, 66);
			this.pictureBox_help_d_draw.Name = "pictureBox_help_d_draw";
			this.pictureBox_help_d_draw.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_d_draw.TabIndex = 37;
			this.pictureBox_help_d_draw.TabStop = false;
			this.pictureBox_help_d_draw.Click += new System.EventHandler(this.help_Populate);
			// 
			// pictureBox_help_d_draw_rand
			// 
			this.pictureBox_help_d_draw_rand.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_d_draw_rand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_d_draw_rand.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_d_draw_rand.Location = new System.Drawing.Point(326, 41);
			this.pictureBox_help_d_draw_rand.Name = "pictureBox_help_d_draw_rand";
			this.pictureBox_help_d_draw_rand.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_d_draw_rand.TabIndex = 36;
			this.pictureBox_help_d_draw_rand.TabStop = false;
			this.pictureBox_help_d_draw_rand.Click += new System.EventHandler(this.help_Populate);
			// 
			// pictureBox_help_d_enable
			// 
			this.pictureBox_help_d_enable.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_d_enable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_d_enable.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_d_enable.Location = new System.Drawing.Point(326, 18);
			this.pictureBox_help_d_enable.Name = "pictureBox_help_d_enable";
			this.pictureBox_help_d_enable.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_d_enable.TabIndex = 35;
			this.pictureBox_help_d_enable.TabStop = false;
			this.pictureBox_help_d_enable.Click += new System.EventHandler(this.help_Populate);
			// 
			// checkBox_d_enable
			// 
			this.checkBox_d_enable.AutoSize = true;
			this.checkBox_d_enable.Location = new System.Drawing.Point(6, 19);
			this.checkBox_d_enable.Name = "checkBox_d_enable";
			this.checkBox_d_enable.Size = new System.Drawing.Size(125, 17);
			this.checkBox_d_enable.TabIndex = 1;
			this.checkBox_d_enable.Text = "Export Detail Objects";
			this.checkBox_d_enable.UseVisualStyleBackColor = true;
			this.checkBox_d_enable.CheckedChanged += new System.EventHandler(this.checkBox_d_enable_CheckedChanged);
			this.checkBox_d_enable.Enter += new System.EventHandler(this.help_Populate);
			// 
			// checkBox_d_draw_rand
			// 
			this.checkBox_d_draw_rand.AutoSize = true;
			this.checkBox_d_draw_rand.Location = new System.Drawing.Point(6, 42);
			this.checkBox_d_draw_rand.Name = "checkBox_d_draw_rand";
			this.checkBox_d_draw_rand.Size = new System.Drawing.Size(170, 17);
			this.checkBox_d_draw_rand.TabIndex = 2;
			this.checkBox_d_draw_rand.Text = "Export Detail Objects randomly";
			this.checkBox_d_draw_rand.UseVisualStyleBackColor = true;
			this.checkBox_d_draw_rand.CheckedChanged += new System.EventHandler(this.checkBox_d_draw_rand_CheckedChanged);
			this.checkBox_d_draw_rand.Enter += new System.EventHandler(this.help_Populate);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(112, 94);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(192, 13);
			this.label10.TabIndex = 32;
			this.label10.Text = "Do NOT export every x-th Detail Object";
			// 
			// textBox_d_skip
			// 
			this.textBox_d_skip.Location = new System.Drawing.Point(6, 91);
			this.textBox_d_skip.Name = "textBox_d_skip";
			this.textBox_d_skip.Size = new System.Drawing.Size(100, 20);
			this.textBox_d_skip.TabIndex = 4;
			this.textBox_d_skip.Enter += new System.EventHandler(this.help_Populate);
			this.textBox_d_skip.Leave += new System.EventHandler(this.textBox_d_skip_Leave);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(112, 68);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(150, 13);
			this.label9.TabIndex = 30;
			this.label9.Text = "Export every x-th Detail Object";
			// 
			// textBox_d_draw
			// 
			this.textBox_d_draw.Location = new System.Drawing.Point(6, 65);
			this.textBox_d_draw.Name = "textBox_d_draw";
			this.textBox_d_draw.Size = new System.Drawing.Size(100, 20);
			this.textBox_d_draw.TabIndex = 3;
			this.textBox_d_draw.Enter += new System.EventHandler(this.help_Populate);
			this.textBox_d_draw.Leave += new System.EventHandler(this.textBox_d_draw_Leave);
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.groupBox3.Controls.Add(this.pictureBox_help_d_pos);
			this.groupBox3.Controls.Add(this.pictureBox_help_d_autoname);
			this.groupBox3.Controls.Add(this.pictureBox_help_d_autoyaw);
			this.groupBox3.Controls.Add(this.pictureBox_help_d_autopitch);
			this.groupBox3.Controls.Add(this.label_d_pos);
			this.groupBox3.Controls.Add(this.textBox_d_pos);
			this.groupBox3.Controls.Add(this.checkBox_d_autoyaw);
			this.groupBox3.Controls.Add(this.checkBox_d_autoname);
			this.groupBox3.Controls.Add(this.checkBox_d_autopitch);
			this.groupBox3.Location = new System.Drawing.Point(6, 163);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(350, 125);
			this.groupBox3.TabIndex = 30;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Transformation";
			// 
			// pictureBox_help_d_pos
			// 
			this.pictureBox_help_d_pos.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_d_pos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_d_pos.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_d_pos.Location = new System.Drawing.Point(326, 89);
			this.pictureBox_help_d_pos.Name = "pictureBox_help_d_pos";
			this.pictureBox_help_d_pos.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_d_pos.TabIndex = 34;
			this.pictureBox_help_d_pos.TabStop = false;
			this.pictureBox_help_d_pos.Click += new System.EventHandler(this.help_Populate);
			// 
			// pictureBox_help_d_autoname
			// 
			this.pictureBox_help_d_autoname.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_d_autoname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_d_autoname.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_d_autoname.Location = new System.Drawing.Point(326, 64);
			this.pictureBox_help_d_autoname.Name = "pictureBox_help_d_autoname";
			this.pictureBox_help_d_autoname.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_d_autoname.TabIndex = 33;
			this.pictureBox_help_d_autoname.TabStop = false;
			this.pictureBox_help_d_autoname.Click += new System.EventHandler(this.help_Populate);
			// 
			// pictureBox_help_d_autoyaw
			// 
			this.pictureBox_help_d_autoyaw.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_d_autoyaw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_d_autoyaw.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_d_autoyaw.Location = new System.Drawing.Point(326, 41);
			this.pictureBox_help_d_autoyaw.Name = "pictureBox_help_d_autoyaw";
			this.pictureBox_help_d_autoyaw.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_d_autoyaw.TabIndex = 32;
			this.pictureBox_help_d_autoyaw.TabStop = false;
			this.pictureBox_help_d_autoyaw.Click += new System.EventHandler(this.help_Populate);
			// 
			// pictureBox_help_d_autopitch
			// 
			this.pictureBox_help_d_autopitch.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_d_autopitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_d_autopitch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_d_autopitch.Location = new System.Drawing.Point(326, 18);
			this.pictureBox_help_d_autopitch.Name = "pictureBox_help_d_autopitch";
			this.pictureBox_help_d_autopitch.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_d_autopitch.TabIndex = 27;
			this.pictureBox_help_d_autopitch.TabStop = false;
			this.pictureBox_help_d_autopitch.Click += new System.EventHandler(this.help_Populate);
			// 
			// label_d_pos
			// 
			this.label_d_pos.AutoSize = true;
			this.label_d_pos.Location = new System.Drawing.Point(112, 91);
			this.label_d_pos.Name = "label_d_pos";
			this.label_d_pos.Size = new System.Drawing.Size(136, 13);
			this.label_d_pos.TabIndex = 31;
			this.label_d_pos.Text = "Position (relative to section)";
			// 
			// textBox_d_pos
			// 
			this.textBox_d_pos.Location = new System.Drawing.Point(6, 88);
			this.textBox_d_pos.Name = "textBox_d_pos";
			this.textBox_d_pos.Size = new System.Drawing.Size(100, 20);
			this.textBox_d_pos.TabIndex = 4;
			this.textBox_d_pos.Enter += new System.EventHandler(this.help_Populate);
			this.textBox_d_pos.Leave += new System.EventHandler(this.textBox_d_pos_Leave);
			// 
			// checkBox_d_autoyaw
			// 
			this.checkBox_d_autoyaw.AutoSize = true;
			this.checkBox_d_autoyaw.Location = new System.Drawing.Point(6, 42);
			this.checkBox_d_autoyaw.Name = "checkBox_d_autoyaw";
			this.checkBox_d_autoyaw.Size = new System.Drawing.Size(192, 17);
			this.checkBox_d_autoyaw.TabIndex = 2;
			this.checkBox_d_autoyaw.Text = "Auto-Yaw depending on curve yaw";
			this.checkBox_d_autoyaw.UseVisualStyleBackColor = true;
			this.checkBox_d_autoyaw.CheckedChanged += new System.EventHandler(this.checkBox_d_autoyaw_CheckedChanged);
			this.checkBox_d_autoyaw.Enter += new System.EventHandler(this.help_Populate);
			// 
			// checkBox_d_autoname
			// 
			this.checkBox_d_autoname.AutoSize = true;
			this.checkBox_d_autoname.Location = new System.Drawing.Point(6, 65);
			this.checkBox_d_autoname.Name = "checkBox_d_autoname";
			this.checkBox_d_autoname.Size = new System.Drawing.Size(255, 17);
			this.checkBox_d_autoname.TabIndex = 3;
			this.checkBox_d_autoname.Text = "Auto-name entities like path_corner (rudimentary)";
			this.checkBox_d_autoname.UseVisualStyleBackColor = true;
			this.checkBox_d_autoname.CheckedChanged += new System.EventHandler(this.checkBox_d_autoname_CheckedChanged);
			this.checkBox_d_autoname.Enter += new System.EventHandler(this.help_Populate);
			// 
			// checkBox_d_autopitch
			// 
			this.checkBox_d_autopitch.AutoSize = true;
			this.checkBox_d_autopitch.Location = new System.Drawing.Point(6, 19);
			this.checkBox_d_autopitch.Name = "checkBox_d_autopitch";
			this.checkBox_d_autopitch.Size = new System.Drawing.Size(199, 17);
			this.checkBox_d_autopitch.TabIndex = 1;
			this.checkBox_d_autopitch.Text = "Auto-Pitch depending on curve pitch";
			this.checkBox_d_autopitch.UseVisualStyleBackColor = true;
			this.checkBox_d_autopitch.CheckedChanged += new System.EventHandler(this.checkBox_d_autopitch_CheckedChanged);
			this.checkBox_d_autopitch.Enter += new System.EventHandler(this.help_Populate);
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.groupBox2.Controls.Add(this.pictureBox_help_d_pos_rand);
			this.groupBox2.Controls.Add(this.pictureBox_help_d_movey_rand);
			this.groupBox2.Controls.Add(this.pictureBox_help_d_rotz_rand);
			this.groupBox2.Controls.Add(this.pictureBox_help_d_scale_rand);
			this.groupBox2.Controls.Add(this.textBox_d_pos_max);
			this.groupBox2.Controls.Add(this.label_d_pos_max);
			this.groupBox2.Controls.Add(this.label_d_pos_min);
			this.groupBox2.Controls.Add(this.textBox_d_pos_min);
			this.groupBox2.Controls.Add(this.checkBox_d_pos_rand);
			this.groupBox2.Controls.Add(this.checkBox_d_scale_rand);
			this.groupBox2.Controls.Add(this.textBox_d_movey_rand_max);
			this.groupBox2.Controls.Add(this.textBox_d_scale_rand_min);
			this.groupBox2.Controls.Add(this.label_d_movey_rand_max);
			this.groupBox2.Controls.Add(this.checkBox_d_rotz_rand);
			this.groupBox2.Controls.Add(this.label_d_movey_rand_min);
			this.groupBox2.Controls.Add(this.label_d_scale_rand_min);
			this.groupBox2.Controls.Add(this.textBox_d_movey_rand_min);
			this.groupBox2.Controls.Add(this.checkBox_d_movey_rand);
			this.groupBox2.Controls.Add(this.textBox_d_rotz_rand_max);
			this.groupBox2.Controls.Add(this.label_d_scale_rand_max);
			this.groupBox2.Controls.Add(this.label_d_rotz_rand_max);
			this.groupBox2.Controls.Add(this.textBox_d_scale_rand_max);
			this.groupBox2.Controls.Add(this.label_d_rotz_rand_min);
			this.groupBox2.Controls.Add(this.textBox_d_rotz_rand_min);
			this.groupBox2.Location = new System.Drawing.Point(362, 26);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(350, 364);
			this.groupBox2.TabIndex = 50;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Random Transformation";
			// 
			// pictureBox_help_d_pos_rand
			// 
			this.pictureBox_help_d_pos_rand.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_d_pos_rand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_d_pos_rand.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_d_pos_rand.Location = new System.Drawing.Point(326, 302);
			this.pictureBox_help_d_pos_rand.Name = "pictureBox_help_d_pos_rand";
			this.pictureBox_help_d_pos_rand.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_d_pos_rand.TabIndex = 42;
			this.pictureBox_help_d_pos_rand.TabStop = false;
			this.pictureBox_help_d_pos_rand.Click += new System.EventHandler(this.help_Populate);
			// 
			// pictureBox_help_d_movey_rand
			// 
			this.pictureBox_help_d_movey_rand.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_d_movey_rand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_d_movey_rand.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_d_movey_rand.Location = new System.Drawing.Point(326, 217);
			this.pictureBox_help_d_movey_rand.Name = "pictureBox_help_d_movey_rand";
			this.pictureBox_help_d_movey_rand.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_d_movey_rand.TabIndex = 41;
			this.pictureBox_help_d_movey_rand.TabStop = false;
			this.pictureBox_help_d_movey_rand.Click += new System.EventHandler(this.help_Populate);
			// 
			// pictureBox_help_d_rotz_rand
			// 
			this.pictureBox_help_d_rotz_rand.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_d_rotz_rand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_d_rotz_rand.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_d_rotz_rand.Location = new System.Drawing.Point(326, 128);
			this.pictureBox_help_d_rotz_rand.Name = "pictureBox_help_d_rotz_rand";
			this.pictureBox_help_d_rotz_rand.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_d_rotz_rand.TabIndex = 40;
			this.pictureBox_help_d_rotz_rand.TabStop = false;
			this.pictureBox_help_d_rotz_rand.Click += new System.EventHandler(this.help_Populate);
			// 
			// pictureBox_help_d_scale_rand
			// 
			this.pictureBox_help_d_scale_rand.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_d_scale_rand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_d_scale_rand.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_d_scale_rand.Location = new System.Drawing.Point(326, 43);
			this.pictureBox_help_d_scale_rand.Name = "pictureBox_help_d_scale_rand";
			this.pictureBox_help_d_scale_rand.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_d_scale_rand.TabIndex = 39;
			this.pictureBox_help_d_scale_rand.TabStop = false;
			this.pictureBox_help_d_scale_rand.Click += new System.EventHandler(this.help_Populate);
			// 
			// textBox_d_pos_max
			// 
			this.textBox_d_pos_max.Location = new System.Drawing.Point(6, 327);
			this.textBox_d_pos_max.Name = "textBox_d_pos_max";
			this.textBox_d_pos_max.Size = new System.Drawing.Size(100, 20);
			this.textBox_d_pos_max.TabIndex = 12;
			this.textBox_d_pos_max.Enter += new System.EventHandler(this.help_Populate);
			this.textBox_d_pos_max.Leave += new System.EventHandler(this.textBox_d_pos_max_Leave);
			// 
			// label_d_pos_max
			// 
			this.label_d_pos_max.AutoSize = true;
			this.label_d_pos_max.Location = new System.Drawing.Point(112, 331);
			this.label_d_pos_max.Name = "label_d_pos_max";
			this.label_d_pos_max.Size = new System.Drawing.Size(102, 13);
			this.label_d_pos_max.TabIndex = 39;
			this.label_d_pos_max.Text = "Maximum (e.g. 0.65)";
			// 
			// label_d_pos_min
			// 
			this.label_d_pos_min.AutoSize = true;
			this.label_d_pos_min.Location = new System.Drawing.Point(112, 305);
			this.label_d_pos_min.Name = "label_d_pos_min";
			this.label_d_pos_min.Size = new System.Drawing.Size(99, 13);
			this.label_d_pos_min.TabIndex = 37;
			this.label_d_pos_min.Text = "Minimum (e.g. 0.25)";
			// 
			// textBox_d_pos_min
			// 
			this.textBox_d_pos_min.Location = new System.Drawing.Point(6, 301);
			this.textBox_d_pos_min.Name = "textBox_d_pos_min";
			this.textBox_d_pos_min.Size = new System.Drawing.Size(100, 20);
			this.textBox_d_pos_min.TabIndex = 11;
			this.textBox_d_pos_min.Enter += new System.EventHandler(this.help_Populate);
			this.textBox_d_pos_min.Leave += new System.EventHandler(this.textBox_d_pos_min_Leave);
			// 
			// checkBox_d_pos_rand
			// 
			this.checkBox_d_pos_rand.AutoSize = true;
			this.checkBox_d_pos_rand.Location = new System.Drawing.Point(6, 278);
			this.checkBox_d_pos_rand.Name = "checkBox_d_pos_rand";
			this.checkBox_d_pos_rand.Size = new System.Drawing.Size(234, 17);
			this.checkBox_d_pos_rand.TabIndex = 10;
			this.checkBox_d_pos_rand.Text = "Move randomly along section (X-axis, 0 to 1)";
			this.checkBox_d_pos_rand.UseVisualStyleBackColor = true;
			this.checkBox_d_pos_rand.CheckedChanged += new System.EventHandler(this.checkBox_d_pos_CheckedChanged);
			this.checkBox_d_pos_rand.Enter += new System.EventHandler(this.help_Populate);
			// 
			// checkBox_d_scale_rand
			// 
			this.checkBox_d_scale_rand.AutoSize = true;
			this.checkBox_d_scale_rand.Location = new System.Drawing.Point(6, 19);
			this.checkBox_d_scale_rand.Name = "checkBox_d_scale_rand";
			this.checkBox_d_scale_rand.Size = new System.Drawing.Size(98, 17);
			this.checkBox_d_scale_rand.TabIndex = 1;
			this.checkBox_d_scale_rand.Text = "Scale randomly";
			this.checkBox_d_scale_rand.UseVisualStyleBackColor = true;
			this.checkBox_d_scale_rand.CheckedChanged += new System.EventHandler(this.checkBox_d_scale_rand_CheckedChanged);
			this.checkBox_d_scale_rand.Enter += new System.EventHandler(this.help_Populate);
			// 
			// textBox_d_movey_rand_max
			// 
			this.textBox_d_movey_rand_max.Location = new System.Drawing.Point(6, 242);
			this.textBox_d_movey_rand_max.Name = "textBox_d_movey_rand_max";
			this.textBox_d_movey_rand_max.Size = new System.Drawing.Size(100, 20);
			this.textBox_d_movey_rand_max.TabIndex = 9;
			this.textBox_d_movey_rand_max.Enter += new System.EventHandler(this.help_Populate);
			this.textBox_d_movey_rand_max.Leave += new System.EventHandler(this.textBox_d_movey_rand_max_Leave);
			// 
			// textBox_d_scale_rand_min
			// 
			this.textBox_d_scale_rand_min.Location = new System.Drawing.Point(6, 42);
			this.textBox_d_scale_rand_min.Name = "textBox_d_scale_rand_min";
			this.textBox_d_scale_rand_min.Size = new System.Drawing.Size(100, 20);
			this.textBox_d_scale_rand_min.TabIndex = 2;
			this.textBox_d_scale_rand_min.Enter += new System.EventHandler(this.help_Populate);
			this.textBox_d_scale_rand_min.Leave += new System.EventHandler(this.textBox_d_scale_rand_min_Leave);
			// 
			// label_d_movey_rand_max
			// 
			this.label_d_movey_rand_max.AutoSize = true;
			this.label_d_movey_rand_max.Location = new System.Drawing.Point(112, 246);
			this.label_d_movey_rand_max.Name = "label_d_movey_rand_max";
			this.label_d_movey_rand_max.Size = new System.Drawing.Size(93, 13);
			this.label_d_movey_rand_max.TabIndex = 34;
			this.label_d_movey_rand_max.Text = "Maximum (e.g. 32)";
			// 
			// checkBox_d_rotz_rand
			// 
			this.checkBox_d_rotz_rand.AutoSize = true;
			this.checkBox_d_rotz_rand.Location = new System.Drawing.Point(6, 104);
			this.checkBox_d_rotz_rand.Name = "checkBox_d_rotz_rand";
			this.checkBox_d_rotz_rand.Size = new System.Drawing.Size(170, 17);
			this.checkBox_d_rotz_rand.TabIndex = 4;
			this.checkBox_d_rotz_rand.Text = "Rotate randomly around Z-axis";
			this.checkBox_d_rotz_rand.UseVisualStyleBackColor = true;
			this.checkBox_d_rotz_rand.CheckedChanged += new System.EventHandler(this.checkBox_d_rotz_rand_CheckedChanged);
			this.checkBox_d_rotz_rand.Enter += new System.EventHandler(this.help_Populate);
			// 
			// label_d_movey_rand_min
			// 
			this.label_d_movey_rand_min.AutoSize = true;
			this.label_d_movey_rand_min.Location = new System.Drawing.Point(112, 220);
			this.label_d_movey_rand_min.Name = "label_d_movey_rand_min";
			this.label_d_movey_rand_min.Size = new System.Drawing.Size(93, 13);
			this.label_d_movey_rand_min.TabIndex = 32;
			this.label_d_movey_rand_min.Text = "Minimum (e.g. -64)";
			// 
			// label_d_scale_rand_min
			// 
			this.label_d_scale_rand_min.AutoSize = true;
			this.label_d_scale_rand_min.Location = new System.Drawing.Point(112, 46);
			this.label_d_scale_rand_min.Name = "label_d_scale_rand_min";
			this.label_d_scale_rand_min.Size = new System.Drawing.Size(93, 13);
			this.label_d_scale_rand_min.TabIndex = 11;
			this.label_d_scale_rand_min.Text = "Minimum (e.g. 0.5)";
			// 
			// textBox_d_movey_rand_min
			// 
			this.textBox_d_movey_rand_min.Location = new System.Drawing.Point(6, 216);
			this.textBox_d_movey_rand_min.Name = "textBox_d_movey_rand_min";
			this.textBox_d_movey_rand_min.Size = new System.Drawing.Size(100, 20);
			this.textBox_d_movey_rand_min.TabIndex = 8;
			this.textBox_d_movey_rand_min.Enter += new System.EventHandler(this.help_Populate);
			this.textBox_d_movey_rand_min.Leave += new System.EventHandler(this.textBox_d_movey_rand_min_Leave);
			// 
			// checkBox_d_movey_rand
			// 
			this.checkBox_d_movey_rand.AutoSize = true;
			this.checkBox_d_movey_rand.Location = new System.Drawing.Point(6, 193);
			this.checkBox_d_movey_rand.Name = "checkBox_d_movey_rand";
			this.checkBox_d_movey_rand.Size = new System.Drawing.Size(158, 17);
			this.checkBox_d_movey_rand.TabIndex = 7;
			this.checkBox_d_movey_rand.Text = "Move randomly along Y-axis";
			this.checkBox_d_movey_rand.UseVisualStyleBackColor = true;
			this.checkBox_d_movey_rand.CheckedChanged += new System.EventHandler(this.checkBox_d_movey_rand_CheckedChanged);
			this.checkBox_d_movey_rand.Enter += new System.EventHandler(this.help_Populate);
			// 
			// textBox_d_rotz_rand_max
			// 
			this.textBox_d_rotz_rand_max.Location = new System.Drawing.Point(6, 153);
			this.textBox_d_rotz_rand_max.Name = "textBox_d_rotz_rand_max";
			this.textBox_d_rotz_rand_max.Size = new System.Drawing.Size(100, 20);
			this.textBox_d_rotz_rand_max.TabIndex = 6;
			this.textBox_d_rotz_rand_max.Enter += new System.EventHandler(this.help_Populate);
			this.textBox_d_rotz_rand_max.Leave += new System.EventHandler(this.textBox_d_rotz_rand_max_Leave);
			// 
			// label_d_scale_rand_max
			// 
			this.label_d_scale_rand_max.AutoSize = true;
			this.label_d_scale_rand_max.Location = new System.Drawing.Point(112, 72);
			this.label_d_scale_rand_max.Name = "label_d_scale_rand_max";
			this.label_d_scale_rand_max.Size = new System.Drawing.Size(102, 13);
			this.label_d_scale_rand_max.TabIndex = 26;
			this.label_d_scale_rand_max.Text = "Maximum (e.g. 4.35)";
			// 
			// label_d_rotz_rand_max
			// 
			this.label_d_rotz_rand_max.AutoSize = true;
			this.label_d_rotz_rand_max.Location = new System.Drawing.Point(112, 157);
			this.label_d_rotz_rand_max.Name = "label_d_rotz_rand_max";
			this.label_d_rotz_rand_max.Size = new System.Drawing.Size(99, 13);
			this.label_d_rotz_rand_max.TabIndex = 30;
			this.label_d_rotz_rand_max.Text = "Maximum (e.g. 135)";
			// 
			// textBox_d_scale_rand_max
			// 
			this.textBox_d_scale_rand_max.Location = new System.Drawing.Point(6, 68);
			this.textBox_d_scale_rand_max.Name = "textBox_d_scale_rand_max";
			this.textBox_d_scale_rand_max.Size = new System.Drawing.Size(100, 20);
			this.textBox_d_scale_rand_max.TabIndex = 3;
			this.textBox_d_scale_rand_max.Enter += new System.EventHandler(this.help_Populate);
			this.textBox_d_scale_rand_max.Leave += new System.EventHandler(this.textBox_d_scale_rand_max_Leave);
			// 
			// label_d_rotz_rand_min
			// 
			this.label_d_rotz_rand_min.AutoSize = true;
			this.label_d_rotz_rand_min.Location = new System.Drawing.Point(112, 131);
			this.label_d_rotz_rand_min.Name = "label_d_rotz_rand_min";
			this.label_d_rotz_rand_min.Size = new System.Drawing.Size(93, 13);
			this.label_d_rotz_rand_min.TabIndex = 28;
			this.label_d_rotz_rand_min.Text = "Minimum (e.g. -45)";
			// 
			// textBox_d_rotz_rand_min
			// 
			this.textBox_d_rotz_rand_min.Location = new System.Drawing.Point(6, 127);
			this.textBox_d_rotz_rand_min.Name = "textBox_d_rotz_rand_min";
			this.textBox_d_rotz_rand_min.Size = new System.Drawing.Size(100, 20);
			this.textBox_d_rotz_rand_min.TabIndex = 5;
			this.textBox_d_rotz_rand_min.Enter += new System.EventHandler(this.help_Populate);
			this.textBox_d_rotz_rand_min.Leave += new System.EventHandler(this.textBox_d_rotz_rand_min_Leave);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.groupBox1.Controls.Add(this.pictureBox_help_d_circlemode);
			this.groupBox1.Controls.Add(this.pictureBox_help_d_carve);
			this.groupBox1.Controls.Add(this.pictureBox_help_d_autoassign);
			this.groupBox1.Controls.Add(this.pictureBox_help_d_separate);
			this.groupBox1.Controls.Add(this.checkBox_d_circlemode);
			this.groupBox1.Controls.Add(this.checkBox_d_carve);
			this.groupBox1.Controls.Add(this.checkBox_d_autoassign);
			this.groupBox1.Controls.Add(this.checkBox_d_separate);
			this.groupBox1.Location = new System.Drawing.Point(6, 26);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(350, 121);
			this.groupBox1.TabIndex = 20;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "General Settings";
			// 
			// pictureBox_help_d_circlemode
			// 
			this.pictureBox_help_d_circlemode.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_d_circlemode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_d_circlemode.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_d_circlemode.Location = new System.Drawing.Point(326, 87);
			this.pictureBox_help_d_circlemode.Name = "pictureBox_help_d_circlemode";
			this.pictureBox_help_d_circlemode.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_d_circlemode.TabIndex = 26;
			this.pictureBox_help_d_circlemode.TabStop = false;
			this.pictureBox_help_d_circlemode.Click += new System.EventHandler(this.help_Populate);
			// 
			// pictureBox_help_d_carve
			// 
			this.pictureBox_help_d_carve.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_d_carve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_d_carve.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_d_carve.Location = new System.Drawing.Point(326, 64);
			this.pictureBox_help_d_carve.Name = "pictureBox_help_d_carve";
			this.pictureBox_help_d_carve.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_d_carve.TabIndex = 25;
			this.pictureBox_help_d_carve.TabStop = false;
			this.pictureBox_help_d_carve.Click += new System.EventHandler(this.help_Populate);
			// 
			// pictureBox_help_d_autoassign
			// 
			this.pictureBox_help_d_autoassign.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_d_autoassign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_d_autoassign.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_d_autoassign.Location = new System.Drawing.Point(326, 41);
			this.pictureBox_help_d_autoassign.Name = "pictureBox_help_d_autoassign";
			this.pictureBox_help_d_autoassign.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_d_autoassign.TabIndex = 24;
			this.pictureBox_help_d_autoassign.TabStop = false;
			this.pictureBox_help_d_autoassign.Click += new System.EventHandler(this.help_Populate);
			// 
			// pictureBox_help_d_separate
			// 
			this.pictureBox_help_d_separate.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_d_separate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_d_separate.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_d_separate.Location = new System.Drawing.Point(326, 18);
			this.pictureBox_help_d_separate.Name = "pictureBox_help_d_separate";
			this.pictureBox_help_d_separate.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_d_separate.TabIndex = 23;
			this.pictureBox_help_d_separate.TabStop = false;
			this.pictureBox_help_d_separate.Click += new System.EventHandler(this.help_Populate);
			// 
			// checkBox_d_circlemode
			// 
			this.checkBox_d_circlemode.AutoSize = true;
			this.checkBox_d_circlemode.Location = new System.Drawing.Point(6, 88);
			this.checkBox_d_circlemode.Name = "checkBox_d_circlemode";
			this.checkBox_d_circlemode.Size = new System.Drawing.Size(187, 17);
			this.checkBox_d_circlemode.TabIndex = 4;
			this.checkBox_d_circlemode.Text = "Override radius (for low-res circles)";
			this.checkBox_d_circlemode.UseVisualStyleBackColor = true;
			this.checkBox_d_circlemode.CheckedChanged += new System.EventHandler(this.checkBox_d_circlemode_CheckedChanged);
			this.checkBox_d_circlemode.Enter += new System.EventHandler(this.help_Populate);
			// 
			// checkBox_d_carve
			// 
			this.checkBox_d_carve.AutoSize = true;
			this.checkBox_d_carve.Location = new System.Drawing.Point(6, 65);
			this.checkBox_d_carve.Name = "checkBox_d_carve";
			this.checkBox_d_carve.Size = new System.Drawing.Size(222, 17);
			this.checkBox_d_carve.TabIndex = 3;
			this.checkBox_d_carve.Text = "Carve Detail Objects (atm for circles only!)";
			this.checkBox_d_carve.UseVisualStyleBackColor = true;
			this.checkBox_d_carve.CheckedChanged += new System.EventHandler(this.checkBox_d_carve_CheckedChanged);
			this.checkBox_d_carve.Enter += new System.EventHandler(this.help_Populate);
			// 
			// checkBox_d_autoassign
			// 
			this.checkBox_d_autoassign.AutoSize = true;
			this.checkBox_d_autoassign.Location = new System.Drawing.Point(6, 42);
			this.checkBox_d_autoassign.Name = "checkBox_d_autoassign";
			this.checkBox_d_autoassign.Size = new System.Drawing.Size(274, 17);
			this.checkBox_d_autoassign.TabIndex = 2;
			this.checkBox_d_autoassign.Text = "Put all ungrouped solid entities into one Detail Object";
			this.checkBox_d_autoassign.UseVisualStyleBackColor = true;
			this.checkBox_d_autoassign.CheckedChanged += new System.EventHandler(this.checkBox_d_autoassign_CheckedChanged);
			this.checkBox_d_autoassign.Enter += new System.EventHandler(this.help_Populate);
			// 
			// checkBox_d_separate
			// 
			this.checkBox_d_separate.AutoSize = true;
			this.checkBox_d_separate.Location = new System.Drawing.Point(6, 19);
			this.checkBox_d_separate.Name = "checkBox_d_separate";
			this.checkBox_d_separate.Size = new System.Drawing.Size(176, 17);
			this.checkBox_d_separate.TabIndex = 1;
			this.checkBox_d_separate.Text = "Export Detail Objects separately";
			this.checkBox_d_separate.UseVisualStyleBackColor = true;
			this.checkBox_d_separate.CheckedChanged += new System.EventHandler(this.checkBox_d_separate_CheckedChanged);
			this.checkBox_d_separate.Enter += new System.EventHandler(this.help_Populate);
			// 
			// tabPage_preset
			// 
			this.tabPage_preset.Controls.Add(this.label31);
			this.tabPage_preset.Controls.Add(this.preset_shower);
			this.tabPage_preset.ImageIndex = 4;
			this.tabPage_preset.Location = new System.Drawing.Point(4, 61);
			this.tabPage_preset.Name = "tabPage_preset";
			this.tabPage_preset.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_preset.Size = new System.Drawing.Size(730, 461);
			this.tabPage_preset.TabIndex = 3;
			this.tabPage_preset.ToolTipText = "Preset File Preview";
			// 
			// label31
			// 
			this.label31.AutoSize = true;
			this.label31.Location = new System.Drawing.Point(3, 3);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(136, 13);
			this.label31.TabIndex = 52;
			this.label31.Text = "Curve / Preset-File Preview";
			// 
			// preset_shower
			// 
			this.preset_shower.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.preset_shower.Location = new System.Drawing.Point(20, 30);
			this.preset_shower.Multiline = true;
			this.preset_shower.Name = "preset_shower";
			this.preset_shower.ReadOnly = true;
			this.preset_shower.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.preset_shower.Size = new System.Drawing.Size(692, 412);
			this.preset_shower.TabIndex = 20;
			this.preset_shower.VisibleChanged += new System.EventHandler(this.preset_shower_VisibleChanged);
			// 
			// tabPage_WAD
			// 
			this.tabPage_WAD.BackColor = System.Drawing.Color.Transparent;
			this.tabPage_WAD.Controls.Add(this.label32);
			this.tabPage_WAD.Controls.Add(this.label_WADList);
			this.tabPage_WAD.Controls.Add(this.button_WAD_remove);
			this.tabPage_WAD.Controls.Add(this.button_WAD_add);
			this.tabPage_WAD.Controls.Add(this.listBox_WAD_list);
			this.tabPage_WAD.ImageIndex = 5;
			this.tabPage_WAD.Location = new System.Drawing.Point(4, 61);
			this.tabPage_WAD.Name = "tabPage_WAD";
			this.tabPage_WAD.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_WAD.Size = new System.Drawing.Size(730, 461);
			this.tabPage_WAD.TabIndex = 6;
			this.tabPage_WAD.ToolTipText = "WAD Settings";
			// 
			// label32
			// 
			this.label32.AutoSize = true;
			this.label32.Location = new System.Drawing.Point(3, 3);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(101, 13);
			this.label32.TabIndex = 52;
			this.label32.Text = "Settings / WAD-List";
			// 
			// label_WADList
			// 
			this.label_WADList.AutoSize = true;
			this.label_WADList.Location = new System.Drawing.Point(65, 44);
			this.label_WADList.Name = "label_WADList";
			this.label_WADList.Size = new System.Drawing.Size(593, 65);
			this.label_WADList.TabIndex = 38;
			this.label_WADList.Text = resources.GetString("label_WADList.Text");
			// 
			// button_WAD_remove
			// 
			this.button_WAD_remove.Location = new System.Drawing.Point(602, 372);
			this.button_WAD_remove.Name = "button_WAD_remove";
			this.button_WAD_remove.Size = new System.Drawing.Size(69, 23);
			this.button_WAD_remove.TabIndex = 22;
			this.button_WAD_remove.Text = "Remove";
			this.button_WAD_remove.UseVisualStyleBackColor = true;
			this.button_WAD_remove.Click += new System.EventHandler(this.button_WAD_remove_Click);
			// 
			// button_WAD_add
			// 
			this.button_WAD_add.Location = new System.Drawing.Point(548, 372);
			this.button_WAD_add.Name = "button_WAD_add";
			this.button_WAD_add.Size = new System.Drawing.Size(49, 23);
			this.button_WAD_add.TabIndex = 21;
			this.button_WAD_add.Text = "Add";
			this.button_WAD_add.UseVisualStyleBackColor = true;
			this.button_WAD_add.Click += new System.EventHandler(this.button_WAD_add_Click);
			// 
			// listBox_WAD_list
			// 
			this.listBox_WAD_list.FormattingEnabled = true;
			this.listBox_WAD_list.Location = new System.Drawing.Point(68, 125);
			this.listBox_WAD_list.Name = "listBox_WAD_list";
			this.listBox_WAD_list.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.listBox_WAD_list.Size = new System.Drawing.Size(603, 238);
			this.listBox_WAD_list.TabIndex = 20;
			// 
			// tabPage_settings
			// 
			this.tabPage_settings.Controls.Add(this.label33);
			this.tabPage_settings.Controls.Add(this.groupBox_Preset_Settings);
			this.tabPage_settings.Controls.Add(this.label_btn_settings_saved);
			this.tabPage_settings.Controls.Add(this.button_saveSettings);
			this.tabPage_settings.Controls.Add(this.groupBox_Editor_Settings);
			this.tabPage_settings.Controls.Add(this.textBox_M2C_exe_path);
			this.tabPage_settings.Controls.Add(this.textBox_Editor_exe_path);
			this.tabPage_settings.Controls.Add(this.button_M2C_exe_select);
			this.tabPage_settings.Controls.Add(this.button_Editor_exe_select);
			this.tabPage_settings.Controls.Add(this.groupBox_M2C_Settings);
			this.tabPage_settings.ImageIndex = 6;
			this.tabPage_settings.Location = new System.Drawing.Point(4, 61);
			this.tabPage_settings.Name = "tabPage_settings";
			this.tabPage_settings.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_settings.Size = new System.Drawing.Size(730, 461);
			this.tabPage_settings.TabIndex = 5;
			this.tabPage_settings.ToolTipText = "GUI Settings";
			this.tabPage_settings.Leave += new System.EventHandler(this.tabPage_settings_Leave);
			// 
			// label33
			// 
			this.label33.AutoSize = true;
			this.label33.Location = new System.Drawing.Point(3, 3);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(95, 13);
			this.label33.TabIndex = 53;
			this.label33.Text = "Settings / Program";
			// 
			// groupBox_Preset_Settings
			// 
			this.groupBox_Preset_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.groupBox_Preset_Settings.Controls.Add(this.checkBox_Preset_Inherit);
			this.groupBox_Preset_Settings.Controls.Add(this.checkBox_ForceAllToPreset);
			this.groupBox_Preset_Settings.Location = new System.Drawing.Point(6, 191);
			this.groupBox_Preset_Settings.Name = "groupBox_Preset_Settings";
			this.groupBox_Preset_Settings.Size = new System.Drawing.Size(350, 67);
			this.groupBox_Preset_Settings.TabIndex = 40;
			this.groupBox_Preset_Settings.TabStop = false;
			this.groupBox_Preset_Settings.Text = "Preset File Settings";
			// 
			// checkBox_Preset_Inherit
			// 
			this.checkBox_Preset_Inherit.AutoSize = true;
			this.checkBox_Preset_Inherit.Location = new System.Drawing.Point(6, 42);
			this.checkBox_Preset_Inherit.Name = "checkBox_Preset_Inherit";
			this.checkBox_Preset_Inherit.Size = new System.Drawing.Size(279, 17);
			this.checkBox_Preset_Inherit.TabIndex = 2;
			this.checkBox_Preset_Inherit.Text = "Inherit settings from previous curve object (smaller file)";
			this.checkBox_Preset_Inherit.UseVisualStyleBackColor = true;
			// 
			// checkBox_ForceAllToPreset
			// 
			this.checkBox_ForceAllToPreset.AutoSize = true;
			this.checkBox_ForceAllToPreset.Checked = true;
			this.checkBox_ForceAllToPreset.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_ForceAllToPreset.Location = new System.Drawing.Point(6, 19);
			this.checkBox_ForceAllToPreset.Name = "checkBox_ForceAllToPreset";
			this.checkBox_ForceAllToPreset.Size = new System.Drawing.Size(252, 17);
			this.checkBox_ForceAllToPreset.TabIndex = 1;
			this.checkBox_ForceAllToPreset.Text = "Export all curve-settings to preset-file (bigger file)";
			this.checkBox_ForceAllToPreset.UseVisualStyleBackColor = true;
			// 
			// label_btn_settings_saved
			// 
			this.label_btn_settings_saved.AutoSize = true;
			this.label_btn_settings_saved.ForeColor = System.Drawing.Color.Green;
			this.label_btn_settings_saved.Location = new System.Drawing.Point(329, 434);
			this.label_btn_settings_saved.Name = "label_btn_settings_saved";
			this.label_btn_settings_saved.Size = new System.Drawing.Size(80, 13);
			this.label_btn_settings_saved.TabIndex = 30;
			this.label_btn_settings_saved.Text = "Settings saved!";
			this.label_btn_settings_saved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label_btn_settings_saved.Visible = false;
			// 
			// button_saveSettings
			// 
			this.button_saveSettings.Location = new System.Drawing.Point(271, 391);
			this.button_saveSettings.Name = "button_saveSettings";
			this.button_saveSettings.Size = new System.Drawing.Size(197, 35);
			this.button_saveSettings.TabIndex = 60;
			this.button_saveSettings.Text = "Save Settings";
			this.button_saveSettings.UseVisualStyleBackColor = true;
			this.button_saveSettings.Click += new System.EventHandler(this.button_saveSettings_Click);
			// 
			// groupBox_Editor_Settings
			// 
			this.groupBox_Editor_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.groupBox_Editor_Settings.Controls.Add(this.checkBox_OpenFileInEditor);
			this.groupBox_Editor_Settings.Location = new System.Drawing.Point(6, 264);
			this.groupBox_Editor_Settings.Name = "groupBox_Editor_Settings";
			this.groupBox_Editor_Settings.Size = new System.Drawing.Size(350, 45);
			this.groupBox_Editor_Settings.TabIndex = 50;
			this.groupBox_Editor_Settings.TabStop = false;
			this.groupBox_Editor_Settings.Text = "Level-Editor Settings";
			// 
			// checkBox_OpenFileInEditor
			// 
			this.checkBox_OpenFileInEditor.AutoSize = true;
			this.checkBox_OpenFileInEditor.Location = new System.Drawing.Point(6, 19);
			this.checkBox_OpenFileInEditor.Name = "checkBox_OpenFileInEditor";
			this.checkBox_OpenFileInEditor.Size = new System.Drawing.Size(288, 17);
			this.checkBox_OpenFileInEditor.TabIndex = 1;
			this.checkBox_OpenFileInEditor.Text = "Open generated file after processing (specify editor.exe)";
			// 
			// textBox_M2C_exe_path
			// 
			this.textBox_M2C_exe_path.Location = new System.Drawing.Point(123, 28);
			this.textBox_M2C_exe_path.Name = "textBox_M2C_exe_path";
			this.textBox_M2C_exe_path.ReadOnly = true;
			this.textBox_M2C_exe_path.Size = new System.Drawing.Size(591, 20);
			this.textBox_M2C_exe_path.TabIndex = 21;
			// 
			// textBox_Editor_exe_path
			// 
			this.textBox_Editor_exe_path.Location = new System.Drawing.Point(123, 57);
			this.textBox_Editor_exe_path.Name = "textBox_Editor_exe_path";
			this.textBox_Editor_exe_path.ReadOnly = true;
			this.textBox_Editor_exe_path.Size = new System.Drawing.Size(591, 20);
			this.textBox_Editor_exe_path.TabIndex = 23;
			// 
			// button_M2C_exe_select
			// 
			this.button_M2C_exe_select.Location = new System.Drawing.Point(6, 26);
			this.button_M2C_exe_select.Name = "button_M2C_exe_select";
			this.button_M2C_exe_select.Size = new System.Drawing.Size(111, 23);
			this.button_M2C_exe_select.TabIndex = 20;
			this.button_M2C_exe_select.Text = "Map2Curve.exe";
			this.button_M2C_exe_select.UseVisualStyleBackColor = true;
			this.button_M2C_exe_select.Click += new System.EventHandler(this.button_M2C_exe_select_Click);
			// 
			// button_Editor_exe_select
			// 
			this.button_Editor_exe_select.Location = new System.Drawing.Point(6, 55);
			this.button_Editor_exe_select.Name = "button_Editor_exe_select";
			this.button_Editor_exe_select.Size = new System.Drawing.Size(111, 23);
			this.button_Editor_exe_select.TabIndex = 22;
			this.button_Editor_exe_select.Text = "Level-Editor.exe";
			this.button_Editor_exe_select.UseVisualStyleBackColor = true;
			this.button_Editor_exe_select.Click += new System.EventHandler(this.button_Editor_exe_select_Click);
			// 
			// groupBox_M2C_Settings
			// 
			this.groupBox_M2C_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.groupBox_M2C_Settings.Controls.Add(this.checkBox_M2C_log);
			this.groupBox_M2C_Settings.Controls.Add(this.checkBox_M2C_dev);
			this.groupBox_M2C_Settings.Controls.Add(this.checkBox_M2C_autoclose);
			this.groupBox_M2C_Settings.Location = new System.Drawing.Point(6, 94);
			this.groupBox_M2C_Settings.Name = "groupBox_M2C_Settings";
			this.groupBox_M2C_Settings.Size = new System.Drawing.Size(350, 91);
			this.groupBox_M2C_Settings.TabIndex = 30;
			this.groupBox_M2C_Settings.TabStop = false;
			this.groupBox_M2C_Settings.Text = "Map2Curve Settings";
			// 
			// checkBox_M2C_log
			// 
			this.checkBox_M2C_log.AutoSize = true;
			this.checkBox_M2C_log.Checked = true;
			this.checkBox_M2C_log.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_M2C_log.ForeColor = System.Drawing.Color.Fuchsia;
			this.checkBox_M2C_log.Location = new System.Drawing.Point(6, 42);
			this.checkBox_M2C_log.Name = "checkBox_M2C_log";
			this.checkBox_M2C_log.Size = new System.Drawing.Size(343, 17);
			this.checkBox_M2C_log.TabIndex = 2;
			this.checkBox_M2C_log.Text = "Log all messages from M2C.exe to Map2Curve.log in root dir (NEW)";
			this.checkBox_M2C_log.UseVisualStyleBackColor = true;
			// 
			// checkBox_M2C_dev
			// 
			this.checkBox_M2C_dev.AutoSize = true;
			this.checkBox_M2C_dev.ForeColor = System.Drawing.SystemColors.AppWorkspace;
			this.checkBox_M2C_dev.Location = new System.Drawing.Point(6, 65);
			this.checkBox_M2C_dev.Name = "checkBox_M2C_dev";
			this.checkBox_M2C_dev.Size = new System.Drawing.Size(105, 17);
			this.checkBox_M2C_dev.TabIndex = 3;
			this.checkBox_M2C_dev.TabStop = false;
			this.checkBox_M2C_dev.Text = "Dev (not for you)";
			this.checkBox_M2C_dev.UseVisualStyleBackColor = true;
			// 
			// checkBox_M2C_autoclose
			// 
			this.checkBox_M2C_autoclose.AutoSize = true;
			this.checkBox_M2C_autoclose.Checked = true;
			this.checkBox_M2C_autoclose.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_M2C_autoclose.Location = new System.Drawing.Point(6, 19);
			this.checkBox_M2C_autoclose.Name = "checkBox_M2C_autoclose";
			this.checkBox_M2C_autoclose.Size = new System.Drawing.Size(227, 17);
			this.checkBox_M2C_autoclose.TabIndex = 1;
			this.checkBox_M2C_autoclose.Text = "Close M2C.exe after processing Preset-File";
			this.checkBox_M2C_autoclose.UseVisualStyleBackColor = true;
			// 
			// tabPage_howto
			// 
			this.tabPage_howto.Controls.Add(this.tabControl_howto);
			this.tabPage_howto.ImageIndex = 7;
			this.tabPage_howto.Location = new System.Drawing.Point(4, 61);
			this.tabPage_howto.Name = "tabPage_howto";
			this.tabPage_howto.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_howto.Size = new System.Drawing.Size(730, 461);
			this.tabPage_howto.TabIndex = 7;
			this.tabPage_howto.ToolTipText = "Tutorials";
			// 
			// tabControl_howto
			// 
			this.tabControl_howto.Appearance = System.Windows.Forms.TabAppearance.Buttons;
			this.tabControl_howto.Controls.Add(this.tabPage_howto_1);
			this.tabControl_howto.Controls.Add(this.tabPage_howto_2);
			this.tabControl_howto.Controls.Add(this.tabPage_howto_3);
			this.tabControl_howto.Controls.Add(this.tabPage_howto_4);
			this.tabControl_howto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl_howto.Location = new System.Drawing.Point(6, 6);
			this.tabControl_howto.Name = "tabControl_howto";
			this.tabControl_howto.Padding = new System.Drawing.Point(15, 5);
			this.tabControl_howto.SelectedIndex = 0;
			this.tabControl_howto.Size = new System.Drawing.Size(718, 449);
			this.tabControl_howto.TabIndex = 20;
			// 
			// tabPage_howto_1
			// 
			this.tabPage_howto_1.BackColor = System.Drawing.Color.Transparent;
			this.tabPage_howto_1.Controls.Add(this.label1);
			this.tabPage_howto_1.Controls.Add(this.label7);
			this.tabPage_howto_1.Controls.Add(this.label6);
			this.tabPage_howto_1.Controls.Add(this.label5);
			this.tabPage_howto_1.Controls.Add(this.label4);
			this.tabPage_howto_1.Controls.Add(this.label3);
			this.tabPage_howto_1.Controls.Add(this.pictureBox2);
			this.tabPage_howto_1.Controls.Add(this.pictureBox1);
			this.tabPage_howto_1.Location = new System.Drawing.Point(4, 29);
			this.tabPage_howto_1.Name = "tabPage_howto_1";
			this.tabPage_howto_1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_howto_1.Size = new System.Drawing.Size(710, 416);
			this.tabPage_howto_1.TabIndex = 0;
			this.tabPage_howto_1.Text = "Input Scene Example";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(14, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(139, 32);
			this.label1.TabIndex = 22;
			this.label1.Text = "Brushes can have any\r\nlength on x-axis.";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(361, 14);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(268, 32);
			this.label7.TabIndex = 21;
			this.label7.Text = "For proper texture shift calculation, unused\r\nfaces should have the NULL texture " +
    "applied.";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(6, 124);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(138, 48);
			this.label6.TabIndex = 18;
			this.label6.Text = "Brushes can be world\r\nor solid entities.\r\n(Entity recommended)";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(79, 202);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(149, 64);
			this.label5.TabIndex = 17;
			this.label5.Text = "Body-faces:\r\n- any amount\r\n- 4 vertices per face\r\n- texture rot: 0,90,180,270";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(441, 76);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(170, 64);
			this.label4.TabIndex = 16;
			this.label4.Text = "Cut-faces:\r\n- 2 per brush\r\n- any amount of vertices\r\n- can be textured in any way" +
    "";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(419, 373);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(106, 32);
			this.label3.TabIndex = 15;
			this.label3.Text = "Align your scene\r\nalong the x-axis!";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(146, -11);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(301, 456);
			this.pictureBox2.TabIndex = 19;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(486, 163);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(196, 245);
			this.pictureBox1.TabIndex = 20;
			this.pictureBox1.TabStop = false;
			// 
			// tabPage_howto_2
			// 
			this.tabPage_howto_2.BackColor = System.Drawing.Color.Transparent;
			this.tabPage_howto_2.Controls.Add(this.label8);
			this.tabPage_howto_2.Controls.Add(this.tableLayoutPanel1);
			this.tabPage_howto_2.Location = new System.Drawing.Point(4, 29);
			this.tabPage_howto_2.Name = "tabPage_howto_2";
			this.tabPage_howto_2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_howto_2.Size = new System.Drawing.Size(710, 416);
			this.tabPage_howto_2.TabIndex = 1;
			this.tabPage_howto_2.Text = "Triangulation";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(9, 7);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(656, 48);
			this.label8.TabIndex = 7;
			this.label8.Text = resources.GetString("label8.Text");
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Controls.Add(this.textBox3, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.pictureBox5, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.pictureBox4, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 60);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(698, 350);
			this.tableLayoutPanel1.TabIndex = 6;
			// 
			// textBox3
			// 
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox3.Location = new System.Drawing.Point(467, 195);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(226, 152);
			this.textBox3.TabIndex = 10;
			this.textBox3.Text = "Object divided into even more brushes/wedges.\r\n\r\nAlso suited for triangulation. M" +
    "ore flexible than figure 2, but uses more brushes.\r\n\r\nAllows for hollow objects." +
    "";
			// 
			// textBox2
			// 
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(235, 195);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(226, 152);
			this.textBox2.TabIndex = 9;
			this.textBox2.Text = "Object divided into several brushes.\r\n\r\nIdeal for triangulation, more efficient t" +
    "han figure 3.";
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = global::Map2CurveGUI.Properties.Resources.HowTo_2_3;
			this.pictureBox5.Location = new System.Drawing.Point(467, 3);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(196, 186);
			this.pictureBox5.TabIndex = 7;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = global::Map2CurveGUI.Properties.Resources.HowTo_2_2;
			this.pictureBox4.Location = new System.Drawing.Point(235, 3);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(196, 186);
			this.pictureBox4.TabIndex = 6;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::Map2CurveGUI.Properties.Resources.HowTo_2_1;
			this.pictureBox3.Location = new System.Drawing.Point(3, 3);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(196, 186);
			this.pictureBox3.TabIndex = 5;
			this.pictureBox3.TabStop = false;
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(3, 195);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(226, 152);
			this.textBox1.TabIndex = 8;
			this.textBox1.Text = resources.GetString("textBox1.Text");
			// 
			// tabPage_howto_3
			// 
			this.tabPage_howto_3.Controls.Add(this.label11);
			this.tabPage_howto_3.Controls.Add(this.label2);
			this.tabPage_howto_3.Controls.Add(this.pictureBox7);
			this.tabPage_howto_3.Controls.Add(this.pictureBox6);
			this.tabPage_howto_3.Controls.Add(this.pictureBox8);
			this.tabPage_howto_3.Location = new System.Drawing.Point(4, 29);
			this.tabPage_howto_3.Name = "tabPage_howto_3";
			this.tabPage_howto_3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_howto_3.Size = new System.Drawing.Size(710, 416);
			this.tabPage_howto_3.TabIndex = 2;
			this.tabPage_howto_3.Text = "Path_Corner Extrusion";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(8, 274);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(371, 135);
			this.label11.TabIndex = 2;
			this.label11.Text = resources.GetString("label11.Text");
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 7);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(269, 30);
			this.label2.TabIndex = 2;
			this.label2.Text = "The easiest way to build a path for extrusion is to\r\ndrag-copy one path_corner en" +
    "tity:";
			// 
			// pictureBox7
			// 
			this.pictureBox7.Image = global::Map2CurveGUI.Properties.Resources.HowTo_Path_Corner_1_2;
			this.pictureBox7.Location = new System.Drawing.Point(395, 3);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(289, 316);
			this.pictureBox7.TabIndex = 1;
			this.pictureBox7.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = global::Map2CurveGUI.Properties.Resources.HowTo_Path_Corner_1_1;
			this.pictureBox6.Location = new System.Drawing.Point(8, 44);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(289, 233);
			this.pictureBox6.TabIndex = 0;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Image = global::Map2CurveGUI.Properties.Resources.HowTo_Path_Corner_1_3;
			this.pictureBox8.Location = new System.Drawing.Point(395, 310);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(292, 115);
			this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox8.TabIndex = 3;
			this.pictureBox8.TabStop = false;
			// 
			// tabPage_howto_4
			// 
			this.tabPage_howto_4.Controls.Add(this.panel1);
			this.tabPage_howto_4.Location = new System.Drawing.Point(4, 29);
			this.tabPage_howto_4.Name = "tabPage_howto_4";
			this.tabPage_howto_4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_howto_4.Size = new System.Drawing.Size(710, 416);
			this.tabPage_howto_4.TabIndex = 3;
			this.tabPage_howto_4.Text = "Detail Objects";
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.Controls.Add(this.label27);
			this.panel1.Controls.Add(this.label26);
			this.panel1.Controls.Add(this.pictureBox13);
			this.panel1.Controls.Add(this.label25);
			this.panel1.Controls.Add(this.label24);
			this.panel1.Controls.Add(this.pictureBox12);
			this.panel1.Controls.Add(this.label22);
			this.panel1.Controls.Add(this.label21);
			this.panel1.Controls.Add(this.label20);
			this.panel1.Controls.Add(this.label18);
			this.panel1.Controls.Add(this.label17);
			this.panel1.Controls.Add(this.pictureBox11);
			this.panel1.Controls.Add(this.pictureBox10);
			this.panel1.Controls.Add(this.label15);
			this.panel1.Controls.Add(this.pictureBox9);
			this.panel1.Controls.Add(this.label16);
			this.panel1.Controls.Add(this.label13);
			this.panel1.Controls.Add(this.label14);
			this.panel1.Controls.Add(this.label19);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Location = new System.Drawing.Point(6, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(698, 410);
			this.panel1.TabIndex = 0;
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label27.Location = new System.Drawing.Point(342, 967);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(308, 80);
			this.label27.TabIndex = 29;
			this.label27.Text = "If Map2Curve crashes or errors occur, try to replace\r\nbrushes in question with ne" +
    "w ones.\r\n\r\nSometimes simply recreating brushes\r\nsolves the issue.";
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label26.Location = new System.Drawing.Point(454, 937);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(111, 16);
			this.label26.TabIndex = 28;
			this.label26.Text = "Errors/Crashes";
			// 
			// pictureBox13
			// 
			this.pictureBox13.Image = global::Map2CurveGUI.Properties.Resources.HowTo_Detail_2_1;
			this.pictureBox13.Location = new System.Drawing.Point(374, 485);
			this.pictureBox13.Name = "pictureBox13";
			this.pictureBox13.Size = new System.Drawing.Size(270, 198);
			this.pictureBox13.TabIndex = 27;
			this.pictureBox13.TabStop = false;
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label25.Location = new System.Drawing.Point(342, 686);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(297, 224);
			this.label25.TabIndex = 26;
			this.label25.Text = resources.GetString("label25.Text");
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label24.Location = new System.Drawing.Point(342, 456);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(322, 16);
			this.label24.TabIndex = 26;
			this.label24.Text = "1) Set up your scene, extrude it long enough on x-axis:";
			// 
			// pictureBox12
			// 
			this.pictureBox12.Image = global::Map2CurveGUI.Properties.Resources.HowTo_Detail_1_3;
			this.pictureBox12.Location = new System.Drawing.Point(27, 941);
			this.pictureBox12.Name = "pictureBox12";
			this.pictureBox12.Size = new System.Drawing.Size(263, 375);
			this.pictureBox12.TabIndex = 24;
			this.pictureBox12.TabStop = false;
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label22.Location = new System.Drawing.Point(7, 794);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(309, 128);
			this.label22.TabIndex = 23;
			this.label22.Text = resources.GetString("label22.Text");
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label21.Location = new System.Drawing.Point(7, 450);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(299, 32);
			this.label21.TabIndex = 22;
			this.label21.Text = "2) Select all parts of this object, open properties,\r\nenter Smart-Edit mode and a" +
    "dd a new Key-Value:";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(202, 235);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(100, 26);
			this.label20.TabIndex = 21;
			this.label20.Text = "Add an Origin brush\r\nif neccessary.";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(7, 204);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(272, 32);
			this.label18.TabIndex = 20;
			this.label18.Text = "1) Set up your object as one or multiple solid-\r\nand/or point-entities.";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(90, 180);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(153, 16);
			this.label17.TabIndex = 19;
			this.label17.Text = "Set up Detail Objects";
			// 
			// pictureBox11
			// 
			this.pictureBox11.Image = global::Map2CurveGUI.Properties.Resources.HowTo_Detail_1_2;
			this.pictureBox11.Location = new System.Drawing.Point(27, 492);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new System.Drawing.Size(263, 288);
			this.pictureBox11.TabIndex = 18;
			this.pictureBox11.TabStop = false;
			// 
			// pictureBox10
			// 
			this.pictureBox10.Image = global::Map2CurveGUI.Properties.Resources.HowTo_Detail_1_1;
			this.pictureBox10.Location = new System.Drawing.Point(54, 246);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(224, 193);
			this.pictureBox10.TabIndex = 17;
			this.pictureBox10.TabStop = false;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(139, 9);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(54, 16);
			this.label15.TabIndex = 13;
			this.label15.Text = "What?!";
			// 
			// pictureBox9
			// 
			this.pictureBox9.Image = global::Map2CurveGUI.Properties.Resources.Tutorial_Detail_1;
			this.pictureBox9.Location = new System.Drawing.Point(361, 194);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(296, 230);
			this.pictureBox9.TabIndex = 16;
			this.pictureBox9.TabStop = false;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(479, 113);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(60, 16);
			this.label16.TabIndex = 15;
			this.label16.Text = "Carving";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(342, 30);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(312, 64);
			this.label13.TabIndex = 14;
			this.label13.Text = "Currently detail objects can be controlled all at once\r\nvia the curve settings ta" +
    "b \"Detail Objects\" or indi-\r\nvidually in your leveleditor via FGD entity\r\ninfo_d" +
    "etailgroup.";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(438, 9);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(151, 16);
			this.label14.TabIndex = 12;
			this.label14.Text = "2 Ways of controlling";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(342, 132);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(331, 48);
			this.label19.TabIndex = 10;
			this.label19.Text = "By using Carving on detail objects, you can also create\r\nhighly detailed arcs.\r\nC" +
    "urrently this only works with the circle framework.\r\n";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(7, 28);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(319, 144);
			this.label12.TabIndex = 11;
			this.label12.Text = resources.GetString("label12.Text");
			// 
			// tabPage_temp
			// 
			this.tabPage_temp.Controls.Add(this.flowLayoutPanel2);
			this.tabPage_temp.Controls.Add(this.pictureBox_tempR);
			this.tabPage_temp.Controls.Add(this.listView_templates);
			this.tabPage_temp.Controls.Add(this.pictureBox_tempL);
			this.tabPage_temp.Controls.Add(this.button_temp_Load);
			this.tabPage_temp.Controls.Add(this.label36);
			this.tabPage_temp.ImageIndex = 8;
			this.tabPage_temp.Location = new System.Drawing.Point(4, 61);
			this.tabPage_temp.Name = "tabPage_temp";
			this.tabPage_temp.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_temp.Size = new System.Drawing.Size(730, 461);
			this.tabPage_temp.TabIndex = 9;
			this.tabPage_temp.ToolTipText = "Templates";
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Controls.Add(this.tableLayoutPanel2);
			this.flowLayoutPanel2.Controls.Add(this.label_temp);
			this.flowLayoutPanel2.Location = new System.Drawing.Point(6, 211);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(214, 247);
			this.flowLayoutPanel2.TabIndex = 61;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.54502F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.45498F));
			this.tableLayoutPanel2.Controls.Add(this.label_temp_path_h, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.label_temp_name, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.label_temp_name_h, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.label_temp_type_h, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.label_temp_path, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.label_temp_type, 1, 1);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 3;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(211, 86);
			this.tableLayoutPanel2.TabIndex = 62;
			// 
			// label_temp_path_h
			// 
			this.label_temp_path_h.AutoSize = true;
			this.label_temp_path_h.Location = new System.Drawing.Point(3, 56);
			this.label_temp_path_h.Name = "label_temp_path_h";
			this.label_temp_path_h.Size = new System.Drawing.Size(51, 13);
			this.label_temp_path_h.TabIndex = 5;
			this.label_temp_path_h.Text = "File Path:";
			// 
			// label_temp_name
			// 
			this.label_temp_name.AutoSize = true;
			this.label_temp_name.Location = new System.Drawing.Point(77, 0);
			this.label_temp_name.Name = "label_temp_name";
			this.label_temp_name.Size = new System.Drawing.Size(16, 13);
			this.label_temp_name.TabIndex = 3;
			this.label_temp_name.Text = "...";
			// 
			// label_temp_name_h
			// 
			this.label_temp_name_h.AutoSize = true;
			this.label_temp_name_h.Location = new System.Drawing.Point(3, 0);
			this.label_temp_name_h.Name = "label_temp_name_h";
			this.label_temp_name_h.Size = new System.Drawing.Size(38, 13);
			this.label_temp_name_h.TabIndex = 0;
			this.label_temp_name_h.Text = "Name:";
			// 
			// label_temp_type_h
			// 
			this.label_temp_type_h.AutoSize = true;
			this.label_temp_type_h.Location = new System.Drawing.Point(3, 28);
			this.label_temp_type_h.Name = "label_temp_type_h";
			this.label_temp_type_h.Size = new System.Drawing.Size(62, 13);
			this.label_temp_type_h.TabIndex = 1;
			this.label_temp_type_h.Text = "Framework:";
			// 
			// label_temp_path
			// 
			this.label_temp_path.AutoSize = true;
			this.label_temp_path.Location = new System.Drawing.Point(77, 56);
			this.label_temp_path.Name = "label_temp_path";
			this.label_temp_path.Size = new System.Drawing.Size(16, 13);
			this.label_temp_path.TabIndex = 2;
			this.label_temp_path.Text = "...";
			// 
			// label_temp_type
			// 
			this.label_temp_type.AutoSize = true;
			this.label_temp_type.Location = new System.Drawing.Point(77, 28);
			this.label_temp_type.Name = "label_temp_type";
			this.label_temp_type.Size = new System.Drawing.Size(16, 13);
			this.label_temp_type.TabIndex = 4;
			this.label_temp_type.Text = "...";
			// 
			// label_temp
			// 
			this.label_temp.AutoSize = true;
			this.label_temp.Location = new System.Drawing.Point(3, 92);
			this.label_temp.Name = "label_temp";
			this.label_temp.Size = new System.Drawing.Size(16, 13);
			this.label_temp.TabIndex = 61;
			this.label_temp.Text = "...";
			// 
			// pictureBox_tempR
			// 
			this.pictureBox_tempR.Location = new System.Drawing.Point(226, 211);
			this.pictureBox_tempR.Name = "pictureBox_tempR";
			this.pictureBox_tempR.Size = new System.Drawing.Size(247, 247);
			this.pictureBox_tempR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox_tempR.TabIndex = 56;
			this.pictureBox_tempR.TabStop = false;
			// 
			// listView_templates
			// 
			this.listView_templates.Alignment = System.Windows.Forms.ListViewAlignment.Left;
			this.listView_templates.BackColor = System.Drawing.SystemColors.Menu;
			this.listView_templates.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listView_templates.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.temp_name,
            this.temp_framework,
            this.temp_filepath});
			this.listView_templates.FullRowSelect = true;
			this.listView_templates.GridLines = true;
			this.listView_templates.HideSelection = false;
			this.listView_templates.LargeImageList = this.templateIcons;
			this.listView_templates.Location = new System.Drawing.Point(6, 19);
			this.listView_templates.MultiSelect = false;
			this.listView_templates.Name = "listView_templates";
			this.listView_templates.Size = new System.Drawing.Size(718, 154);
			this.listView_templates.TabIndex = 20;
			this.listView_templates.UseCompatibleStateImageBehavior = false;
			this.listView_templates.SelectedIndexChanged += new System.EventHandler(this.template_list_select);
			this.listView_templates.DoubleClick += new System.EventHandler(this.button_temp_Load_Click);
			// 
			// temp_name
			// 
			this.temp_name.Text = "Name";
			this.temp_name.Width = 200;
			// 
			// temp_framework
			// 
			this.temp_framework.Text = "Framework";
			this.temp_framework.Width = 66;
			// 
			// temp_filepath
			// 
			this.temp_filepath.Text = "Preset File Path";
			this.temp_filepath.Width = 308;
			// 
			// templateIcons
			// 
			this.templateIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("templateIcons.ImageStream")));
			this.templateIcons.TransparentColor = System.Drawing.Color.Transparent;
			this.templateIcons.Images.SetKeyName(0, "Temp_ConcreteWalk_Preview.png");
			this.templateIcons.Images.SetKeyName(1, "Temp_RailTunnel_Preview.png");
			this.templateIcons.Images.SetKeyName(2, "Temp_BlackMesaPanel_Preview.png");
			this.templateIcons.Images.SetKeyName(3, "Temp_80sServer_Preview.png");
			this.templateIcons.Images.SetKeyName(4, "Temp_RockTerrain_Preview.png");
			this.templateIcons.Images.SetKeyName(5, "Temp_XenBioWall_Preview.png");
			this.templateIcons.Images.SetKeyName(6, "Temp_ReinforcedArc_Preview.png");
			this.templateIcons.Images.SetKeyName(7, "Temp_Composition_Preview.png");
			this.templateIcons.Images.SetKeyName(8, "Temp_DecoBridge_Preview.png");
			this.templateIcons.Images.SetKeyName(9, "Temp_DecoBridgeRamp_Preview.png");
			this.templateIcons.Images.SetKeyName(10, "Temp_LabHallway_Preview.png");
			this.templateIcons.Images.SetKeyName(11, "Temp_LabHallway2_Preview.png");
			this.templateIcons.Images.SetKeyName(12, "Temp_PipeShaft_Preview.png");
			this.templateIcons.Images.SetKeyName(13, "Temp_RailTunnel2_Preview.png");
			this.templateIcons.Images.SetKeyName(14, "Temp_TechBridge_Preview.png");
			this.templateIcons.Images.SetKeyName(15, "Temp_TechChamber_Preview.png");
			this.templateIcons.Images.SetKeyName(16, "Temp_TechPipeHollow_Preview.png");
			this.templateIcons.Images.SetKeyName(17, "Temp_WaterPipe_Preview.png");
			this.templateIcons.Images.SetKeyName(18, "Temp_XenAlley_Preview.png");
			this.templateIcons.Images.SetKeyName(19, "Temp_SqueakyRail_Preview.png");
			// 
			// pictureBox_tempL
			// 
			this.pictureBox_tempL.Location = new System.Drawing.Point(477, 211);
			this.pictureBox_tempL.Name = "pictureBox_tempL";
			this.pictureBox_tempL.Size = new System.Drawing.Size(247, 247);
			this.pictureBox_tempL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox_tempL.TabIndex = 55;
			this.pictureBox_tempL.TabStop = false;
			this.pictureBox_tempL.MouseEnter += new System.EventHandler(this.pictureBox_tempL_MouseOver);
			this.pictureBox_tempL.MouseLeave += new System.EventHandler(this.pictureBox_tempL_MouseLeave);
			// 
			// button_temp_Load
			// 
			this.button_temp_Load.Location = new System.Drawing.Point(6, 179);
			this.button_temp_Load.Name = "button_temp_Load";
			this.button_temp_Load.Size = new System.Drawing.Size(106, 23);
			this.button_temp_Load.TabIndex = 21;
			this.button_temp_Load.Text = "Load Template";
			this.button_temp_Load.UseVisualStyleBackColor = true;
			this.button_temp_Load.Click += new System.EventHandler(this.button_temp_Load_Click);
			// 
			// label36
			// 
			this.label36.AutoSize = true;
			this.label36.Location = new System.Drawing.Point(3, 3);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(89, 13);
			this.label36.TabIndex = 54;
			this.label36.Text = "Help / Templates";
			// 
			// tabPage_log
			// 
			this.tabPage_log.Controls.Add(this.textBox_log);
			this.tabPage_log.Controls.Add(this.label41);
			this.tabPage_log.ImageIndex = 9;
			this.tabPage_log.Location = new System.Drawing.Point(4, 61);
			this.tabPage_log.Name = "tabPage_log";
			this.tabPage_log.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_log.Size = new System.Drawing.Size(730, 461);
			this.tabPage_log.TabIndex = 10;
			this.tabPage_log.ToolTipText = "Log";
			// 
			// textBox_log
			// 
			this.textBox_log.BackColor = System.Drawing.Color.Black;
			this.textBox_log.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_log.ForeColor = System.Drawing.Color.White;
			this.textBox_log.Location = new System.Drawing.Point(20, 30);
			this.textBox_log.Multiline = true;
			this.textBox_log.Name = "textBox_log";
			this.textBox_log.ReadOnly = true;
			this.textBox_log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox_log.Size = new System.Drawing.Size(692, 412);
			this.textBox_log.TabIndex = 20;
			this.textBox_log.VisibleChanged += new System.EventHandler(this.textBox_Log_VisibleChanged);
			// 
			// label41
			// 
			this.label41.AutoSize = true;
			this.label41.Location = new System.Drawing.Point(3, 3);
			this.label41.Name = "label41";
			this.label41.Size = new System.Drawing.Size(64, 13);
			this.label41.TabIndex = 53;
			this.label41.Text = "Curve / Log";
			// 
			// tabIcons
			// 
			this.tabIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tabIcons.ImageStream")));
			this.tabIcons.TransparentColor = System.Drawing.Color.Transparent;
			this.tabIcons.Images.SetKeyName(0, "TabIco_General.png");
			this.tabIcons.Images.SetKeyName(1, "TabIco_General2.png");
			this.tabIcons.Images.SetKeyName(2, "TabIco_PathCorner2.png");
			this.tabIcons.Images.SetKeyName(3, "TabIco_DetailObject.png");
			this.tabIcons.Images.SetKeyName(4, "TabIco_Preset.png");
			this.tabIcons.Images.SetKeyName(5, "TabIco_WAD.png");
			this.tabIcons.Images.SetKeyName(6, "TabIco_Settings2.png");
			this.tabIcons.Images.SetKeyName(7, "TabIco_HowTo.png");
			this.tabIcons.Images.SetKeyName(8, "TabIco_Templates.png");
			this.tabIcons.Images.SetKeyName(9, "TabIco_Log.png");
			// 
			// comboBox_CurveObj
			// 
			this.comboBox_CurveObj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_CurveObj.FormattingEnabled = true;
			this.comboBox_CurveObj.Location = new System.Drawing.Point(92, 647);
			this.comboBox_CurveObj.Name = "comboBox_CurveObj";
			this.comboBox_CurveObj.Size = new System.Drawing.Size(129, 21);
			this.comboBox_CurveObj.TabIndex = 11;
			this.toolTip_general.SetToolTip(this.comboBox_CurveObj, "Shows all existing curve objects.\r\nAll curve objects share the same input- and ou" +
        "tput-files, but can have their own settings otherwise.");
			this.comboBox_CurveObj.SelectionChangeCommitted += new System.EventHandler(this.comboBox_CurveObj_SelectionChangeCommitted);
			// 
			// button_CurveObj_Add
			// 
			this.button_CurveObj_Add.Location = new System.Drawing.Point(291, 646);
			this.button_CurveObj_Add.Name = "button_CurveObj_Add";
			this.button_CurveObj_Add.Size = new System.Drawing.Size(46, 23);
			this.button_CurveObj_Add.TabIndex = 14;
			this.button_CurveObj_Add.Text = "Add";
			this.toolTip_general.SetToolTip(this.button_CurveObj_Add, "Adds a new curve object with default settings at the end of the list");
			this.button_CurveObj_Add.UseVisualStyleBackColor = true;
			this.button_CurveObj_Add.Click += new System.EventHandler(this.button_CurveObj_Add_Click);
			// 
			// button_CurveObj_Remove
			// 
			this.button_CurveObj_Remove.Location = new System.Drawing.Point(395, 646);
			this.button_CurveObj_Remove.Name = "button_CurveObj_Remove";
			this.button_CurveObj_Remove.Size = new System.Drawing.Size(62, 23);
			this.button_CurveObj_Remove.TabIndex = 16;
			this.button_CurveObj_Remove.Text = "Remove";
			this.toolTip_general.SetToolTip(this.button_CurveObj_Remove, "Removes the current curve object.\r\nFirst curve object can\'t be removed.");
			this.button_CurveObj_Remove.UseVisualStyleBackColor = true;
			this.button_CurveObj_Remove.Click += new System.EventHandler(this.button_CurveObj_Remove_Click);
			// 
			// button_CurveObj_Rename
			// 
			this.button_CurveObj_Rename.Location = new System.Drawing.Point(463, 646);
			this.button_CurveObj_Rename.Name = "button_CurveObj_Rename";
			this.button_CurveObj_Rename.Size = new System.Drawing.Size(62, 23);
			this.button_CurveObj_Rename.TabIndex = 17;
			this.button_CurveObj_Rename.Text = "Rename";
			this.toolTip_general.SetToolTip(this.button_CurveObj_Rename, "Renames the current curve object.\r\nNaming curves can help with preset-file clarit" +
        "y.");
			this.button_CurveObj_Rename.UseVisualStyleBackColor = true;
			this.button_CurveObj_Rename.Click += new System.EventHandler(this.button_CurveObj_Rename_Click);
			// 
			// button_CurveObj_prev
			// 
			this.button_CurveObj_prev.Location = new System.Drawing.Point(227, 646);
			this.button_CurveObj_prev.Name = "button_CurveObj_prev";
			this.button_CurveObj_prev.Size = new System.Drawing.Size(26, 23);
			this.button_CurveObj_prev.TabIndex = 12;
			this.button_CurveObj_prev.Text = "<";
			this.toolTip_general.SetToolTip(this.button_CurveObj_prev, "Loads the previous curve object");
			this.button_CurveObj_prev.UseVisualStyleBackColor = true;
			this.button_CurveObj_prev.Click += new System.EventHandler(this.button_CurveObj_prev_Click);
			// 
			// button_CurveObj_next
			// 
			this.button_CurveObj_next.Location = new System.Drawing.Point(259, 646);
			this.button_CurveObj_next.Name = "button_CurveObj_next";
			this.button_CurveObj_next.Size = new System.Drawing.Size(26, 23);
			this.button_CurveObj_next.TabIndex = 13;
			this.button_CurveObj_next.Text = ">";
			this.toolTip_general.SetToolTip(this.button_CurveObj_next, "Loads the next curve object");
			this.button_CurveObj_next.UseVisualStyleBackColor = true;
			this.button_CurveObj_next.Click += new System.EventHandler(this.button_CurveObj_next_Click);
			// 
			// button_CurveObj_Clone
			// 
			this.button_CurveObj_Clone.Location = new System.Drawing.Point(343, 646);
			this.button_CurveObj_Clone.Name = "button_CurveObj_Clone";
			this.button_CurveObj_Clone.Size = new System.Drawing.Size(46, 23);
			this.button_CurveObj_Clone.TabIndex = 15;
			this.button_CurveObj_Clone.Text = "Clone";
			this.toolTip_general.SetToolTip(this.button_CurveObj_Clone, "Copies current curve object along with its settings");
			this.button_CurveObj_Clone.UseVisualStyleBackColor = true;
			this.button_CurveObj_Clone.Click += new System.EventHandler(this.button_CurveObj_Clone_Click);
			// 
			// checkBox_CurveObj_ChangeAll
			// 
			this.checkBox_CurveObj_ChangeAll.AutoSize = true;
			this.checkBox_CurveObj_ChangeAll.Location = new System.Drawing.Point(531, 649);
			this.checkBox_CurveObj_ChangeAll.Name = "checkBox_CurveObj_ChangeAll";
			this.checkBox_CurveObj_ChangeAll.Size = new System.Drawing.Size(77, 17);
			this.checkBox_CurveObj_ChangeAll.TabIndex = 18;
			this.checkBox_CurveObj_ChangeAll.Text = "Change All";
			this.toolTip_general.SetToolTip(this.checkBox_CurveObj_ChangeAll, "When active, changes in curve settings will affect all existing curve objects.\r\nT" +
        "ab-reset and curve object functions (Add, Clone, ...) ignore this setting.");
			this.checkBox_CurveObj_ChangeAll.UseVisualStyleBackColor = true;
			this.checkBox_CurveObj_ChangeAll.CheckedChanged += new System.EventHandler(this.checkBox_CurveObj_ChangeAll_CheckedChanged);
			// 
			// button_Input_File_Open
			// 
			this.button_Input_File_Open.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button_Input_File_Open.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button_Input_File_Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.button_Input_File_Open.Image = global::Map2CurveGUI.Properties.Resources.ico20_editor;
			this.button_Input_File_Open.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_Input_File_Open.Location = new System.Drawing.Point(626, 24);
			this.button_Input_File_Open.Margin = new System.Windows.Forms.Padding(0);
			this.button_Input_File_Open.Name = "button_Input_File_Open";
			this.button_Input_File_Open.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.button_Input_File_Open.Size = new System.Drawing.Size(120, 28);
			this.button_Input_File_Open.TabIndex = 3;
			this.button_Input_File_Open.Text = "Open in Editor";
			this.button_Input_File_Open.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button_Input_File_Open.UseVisualStyleBackColor = false;
			this.button_Input_File_Open.Click += new System.EventHandler(this.button_OpenInputFileInEditor_Click);
			// 
			// button_Output_Folder_Open
			// 
			this.button_Output_Folder_Open.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button_Output_Folder_Open.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button_Output_Folder_Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.button_Output_Folder_Open.Image = global::Map2CurveGUI.Properties.Resources.ico20_folder;
			this.button_Output_Folder_Open.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_Output_Folder_Open.Location = new System.Drawing.Point(626, 53);
			this.button_Output_Folder_Open.Margin = new System.Windows.Forms.Padding(0);
			this.button_Output_Folder_Open.Name = "button_Output_Folder_Open";
			this.button_Output_Folder_Open.Size = new System.Drawing.Size(120, 28);
			this.button_Output_Folder_Open.TabIndex = 6;
			this.button_Output_Folder_Open.Text = "Open in Explorer";
			this.button_Output_Folder_Open.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button_Output_Folder_Open.UseVisualStyleBackColor = false;
			this.button_Output_Folder_Open.Click += new System.EventHandler(this.button_OpenOutputFolderInExplorer_Click);
			// 
			// pictureBox_preview
			// 
			this.pictureBox_preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.pictureBox_preview.Location = new System.Drawing.Point(756, 380);
			this.pictureBox_preview.Name = "pictureBox_preview";
			this.pictureBox_preview.Size = new System.Drawing.Size(256, 256);
			this.pictureBox_preview.TabIndex = 43;
			this.pictureBox_preview.TabStop = false;
			// 
			// richTextBox_help
			// 
			this.richTextBox_help.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox_help.Location = new System.Drawing.Point(756, 136);
			this.richTextBox_help.Name = "richTextBox_help";
			this.richTextBox_help.ReadOnly = true;
			this.richTextBox_help.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
			this.richTextBox_help.Size = new System.Drawing.Size(256, 238);
			this.richTextBox_help.TabIndex = 20;
			this.richTextBox_help.Text = "";
			this.richTextBox_help.TextChanged += new System.EventHandler(this.richTextBox_help_TextChanged);
			// 
			// pictureBox_help_source
			// 
			this.pictureBox_help_source.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_source.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_source.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_source.Location = new System.Drawing.Point(605, 29);
			this.pictureBox_help_source.Name = "pictureBox_help_source";
			this.pictureBox_help_source.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_source.TabIndex = 45;
			this.pictureBox_help_source.TabStop = false;
			this.pictureBox_help_source.Click += new System.EventHandler(this.pictureBox_help_source_Click);
			// 
			// pictureBox_help_target
			// 
			this.pictureBox_help_target.BackgroundImage = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.pictureBox_help_target.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_help_target.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_help_target.Location = new System.Drawing.Point(605, 58);
			this.pictureBox_help_target.Name = "pictureBox_help_target";
			this.pictureBox_help_target.Size = new System.Drawing.Size(18, 18);
			this.pictureBox_help_target.TabIndex = 46;
			this.pictureBox_help_target.TabStop = false;
			this.pictureBox_help_target.Click += new System.EventHandler(this.help_Populate);
			// 
			// label_CurveObj
			// 
			this.label_CurveObj.AutoSize = true;
			this.label_CurveObj.Location = new System.Drawing.Point(13, 651);
			this.label_CurveObj.Name = "label_CurveObj";
			this.label_CurveObj.Size = new System.Drawing.Size(72, 13);
			this.label_CurveObj.TabIndex = 48;
			this.label_CurveObj.Text = "Curve Object:";
			// 
			// menuStrip2
			// 
			this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem9});
			this.menuStrip2.Location = new System.Drawing.Point(0, 0);
			this.menuStrip2.Name = "menuStrip2";
			this.menuStrip2.Size = new System.Drawing.Size(1024, 24);
			this.menuStrip2.TabIndex = 55;
			this.menuStrip2.Text = "menuStrip2";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.ToolStripMenu_reloadPreset,
            this.toolStripMenu_MRU2,
            this.toolStripSeparator6,
            this.generateToolStripMenuItem1,
            this.toolStripSeparator4,
            this.toolStripMenuItem8});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
			this.toolStripMenuItem1.Text = "File";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.toolStripMenuItem2.Size = new System.Drawing.Size(272, 22);
			this.toolStripMenuItem2.Text = "New Preset";
			this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenu_NewPreset_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Image = global::Map2CurveGUI.Properties.Resources.ico20_folder;
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.toolStripMenuItem3.Size = new System.Drawing.Size(272, 22);
			this.toolStripMenuItem3.Text = "Open Preset";
			this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenu_load_Click);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Image = global::Map2CurveGUI.Properties.Resources.ico20_save;
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.toolStripMenuItem4.Size = new System.Drawing.Size(272, 22);
			this.toolStripMenuItem4.Text = "Save Preset";
			this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenu_save_Click);
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Image = global::Map2CurveGUI.Properties.Resources.ico20_save;
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.ShortcutKeyDisplayString = "";
			this.toolStripMenuItem5.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
			this.toolStripMenuItem5.Size = new System.Drawing.Size(272, 22);
			this.toolStripMenuItem5.Text = "Save Preset as";
			this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenu_save_as_Click);
			// 
			// ToolStripMenu_reloadPreset
			// 
			this.ToolStripMenu_reloadPreset.ForeColor = System.Drawing.Color.Silver;
			this.ToolStripMenu_reloadPreset.Name = "ToolStripMenu_reloadPreset";
			this.ToolStripMenu_reloadPreset.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
			this.ToolStripMenu_reloadPreset.Size = new System.Drawing.Size(272, 22);
			this.ToolStripMenu_reloadPreset.Text = "Reload Preset";
			this.ToolStripMenu_reloadPreset.Click += new System.EventHandler(this.ToolStripMenu_reloadPreset_Click);
			// 
			// toolStripMenu_MRU2
			// 
			this.toolStripMenu_MRU2.Name = "toolStripMenu_MRU2";
			this.toolStripMenu_MRU2.Size = new System.Drawing.Size(272, 22);
			this.toolStripMenu_MRU2.Text = "Recent Files";
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(269, 6);
			// 
			// generateToolStripMenuItem1
			// 
			this.generateToolStripMenuItem1.Image = global::Map2CurveGUI.Properties.Resources.Ico32;
			this.generateToolStripMenuItem1.Name = "generateToolStripMenuItem1";
			this.generateToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F9;
			this.generateToolStripMenuItem1.Size = new System.Drawing.Size(272, 22);
			this.generateToolStripMenuItem1.Text = "Generate";
			this.generateToolStripMenuItem1.Click += new System.EventHandler(this.button_generate_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(269, 6);
			// 
			// toolStripMenuItem8
			// 
			this.toolStripMenuItem8.Name = "toolStripMenuItem8";
			this.toolStripMenuItem8.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
			this.toolStripMenuItem8.Size = new System.Drawing.Size(272, 22);
			this.toolStripMenuItem8.Text = "Exit";
			this.toolStripMenuItem8.Click += new System.EventHandler(this.ToolStripMenu_Exit_Click);
			// 
			// toolStripMenuItem9
			// 
			this.toolStripMenuItem9.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.templatesToolStripMenuItem,
            this.tutorialsToolStripMenuItem,
            this.toolStripSeparator5,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11});
			this.toolStripMenuItem9.Name = "toolStripMenuItem9";
			this.toolStripMenuItem9.Size = new System.Drawing.Size(44, 20);
			this.toolStripMenuItem9.Text = "Help";
			// 
			// templatesToolStripMenuItem
			// 
			this.templatesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenu_Temp_0,
            this.ToolStripMenu_Temp_1,
            this.ToolStripMenu_Temp_2,
            this.ToolStripMenu_Temp_3,
            this.ToolStripMenu_Temp_4});
			this.templatesToolStripMenuItem.Name = "templatesToolStripMenuItem";
			this.templatesToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			this.templatesToolStripMenuItem.Text = "Templates";
			this.templatesToolStripMenuItem.Click += new System.EventHandler(this.button_template_Click);
			// 
			// ToolStripMenu_Temp_0
			// 
			this.ToolStripMenu_Temp_0.Name = "ToolStripMenu_Temp_0";
			this.ToolStripMenu_Temp_0.Size = new System.Drawing.Size(165, 22);
			this.ToolStripMenu_Temp_0.Text = "Rail Tunnel";
			this.ToolStripMenu_Temp_0.Click += new System.EventHandler(this.button_template_Click);
			// 
			// ToolStripMenu_Temp_1
			// 
			this.ToolStripMenu_Temp_1.Name = "ToolStripMenu_Temp_1";
			this.ToolStripMenu_Temp_1.Size = new System.Drawing.Size(165, 22);
			this.ToolStripMenu_Temp_1.Text = "Black Mesa Panel";
			this.ToolStripMenu_Temp_1.Click += new System.EventHandler(this.button_template_Click);
			// 
			// ToolStripMenu_Temp_2
			// 
			this.ToolStripMenu_Temp_2.Name = "ToolStripMenu_Temp_2";
			this.ToolStripMenu_Temp_2.Size = new System.Drawing.Size(165, 22);
			this.ToolStripMenu_Temp_2.Text = "80s Server";
			this.ToolStripMenu_Temp_2.Click += new System.EventHandler(this.button_template_Click);
			// 
			// ToolStripMenu_Temp_3
			// 
			this.ToolStripMenu_Temp_3.Name = "ToolStripMenu_Temp_3";
			this.ToolStripMenu_Temp_3.Size = new System.Drawing.Size(165, 22);
			this.ToolStripMenu_Temp_3.Text = "Rock Terrain";
			this.ToolStripMenu_Temp_3.Click += new System.EventHandler(this.button_template_Click);
			// 
			// ToolStripMenu_Temp_4
			// 
			this.ToolStripMenu_Temp_4.Name = "ToolStripMenu_Temp_4";
			this.ToolStripMenu_Temp_4.Size = new System.Drawing.Size(165, 22);
			this.ToolStripMenu_Temp_4.Text = "Xen Bio Wall";
			this.ToolStripMenu_Temp_4.Click += new System.EventHandler(this.button_template_Click);
			// 
			// tutorialsToolStripMenuItem
			// 
			this.tutorialsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenu_Tuto_0,
            this.ToolStripMenu_Tuto_1,
            this.ToolStripMenu_Tuto_2,
            this.ToolStripMenu_Tuto_3});
			this.tutorialsToolStripMenuItem.Name = "tutorialsToolStripMenuItem";
			this.tutorialsToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			this.tutorialsToolStripMenuItem.Text = "Tutorials";
			this.tutorialsToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenu_Tutorials_Click);
			// 
			// ToolStripMenu_Tuto_0
			// 
			this.ToolStripMenu_Tuto_0.Name = "ToolStripMenu_Tuto_0";
			this.ToolStripMenu_Tuto_0.Size = new System.Drawing.Size(190, 22);
			this.ToolStripMenu_Tuto_0.Text = "Input Scene Example";
			this.ToolStripMenu_Tuto_0.Click += new System.EventHandler(this.ToolStripMenu_Tutorials_Click);
			// 
			// ToolStripMenu_Tuto_1
			// 
			this.ToolStripMenu_Tuto_1.Name = "ToolStripMenu_Tuto_1";
			this.ToolStripMenu_Tuto_1.Size = new System.Drawing.Size(190, 22);
			this.ToolStripMenu_Tuto_1.Text = "Triangulation";
			this.ToolStripMenu_Tuto_1.Click += new System.EventHandler(this.ToolStripMenu_Tutorials_Click);
			// 
			// ToolStripMenu_Tuto_2
			// 
			this.ToolStripMenu_Tuto_2.Name = "ToolStripMenu_Tuto_2";
			this.ToolStripMenu_Tuto_2.Size = new System.Drawing.Size(190, 22);
			this.ToolStripMenu_Tuto_2.Text = "Path_Corner Extrusion";
			this.ToolStripMenu_Tuto_2.Click += new System.EventHandler(this.ToolStripMenu_Tutorials_Click);
			// 
			// ToolStripMenu_Tuto_3
			// 
			this.ToolStripMenu_Tuto_3.Name = "ToolStripMenu_Tuto_3";
			this.ToolStripMenu_Tuto_3.Size = new System.Drawing.Size(190, 22);
			this.ToolStripMenu_Tuto_3.Text = "Detail Objects";
			this.ToolStripMenu_Tuto_3.Click += new System.EventHandler(this.ToolStripMenu_Tutorials_Click);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(137, 6);
			// 
			// toolStripMenuItem10
			// 
			this.toolStripMenuItem10.Name = "toolStripMenuItem10";
			this.toolStripMenuItem10.Size = new System.Drawing.Size(140, 22);
			this.toolStripMenuItem10.Text = "Online-Docs";
			this.toolStripMenuItem10.Click += new System.EventHandler(this.ToolStripMenu_onlineDoc_Click);
			// 
			// toolStripMenuItem11
			// 
			this.toolStripMenuItem11.Image = global::Map2CurveGUI.Properties.Resources.help_icon18;
			this.toolStripMenuItem11.Name = "toolStripMenuItem11";
			this.toolStripMenuItem11.Size = new System.Drawing.Size(140, 22);
			this.toolStripMenuItem11.Text = "About";
			this.toolStripMenuItem11.Click += new System.EventHandler(this.ToolStripMenu_about_Click);
			// 
			// MainGUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1024, 681);
			this.Controls.Add(this.checkBox_CurveObj_ChangeAll);
			this.Controls.Add(this.menuStrip2);
			this.Controls.Add(this.button_CurveObj_Clone);
			this.Controls.Add(this.button_CurveObj_next);
			this.Controls.Add(this.button_CurveObj_prev);
			this.Controls.Add(this.button_CurveObj_Rename);
			this.Controls.Add(this.button_CurveObj_Remove);
			this.Controls.Add(this.button_CurveObj_Add);
			this.Controls.Add(this.label_CurveObj);
			this.Controls.Add(this.comboBox_CurveObj);
			this.Controls.Add(this.pictureBox_help_target);
			this.Controls.Add(this.pictureBox_help_source);
			this.Controls.Add(this.richTextBox_help);
			this.Controls.Add(this.pictureBox_preview);
			this.Controls.Add(this.button_Output_Folder_Open);
			this.Controls.Add(this.button_Input_File_Open);
			this.Controls.Add(this.label_hint_saveChanges);
			this.Controls.Add(this.button_Output_File_Open);
			this.Controls.Add(this.button_resetAll);
			this.Controls.Add(this.button_input_file_select);
			this.Controls.Add(this.label_output_file_name);
			this.Controls.Add(this.textBox_output_file_name);
			this.Controls.Add(this.textBox_output_folder);
			this.Controls.Add(this.textBox_input_file);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.button_output_folder_select);
			this.Controls.Add(this.button_generate);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainGUI";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Map2Curve GUI";
			this.tabControl1.ResumeLayout(false);
			this.tabPage_general.ResumeLayout(false);
			this.tabPage_general.PerformLayout();
			this.groupBox8.ResumeLayout(false);
			this.groupBox8.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_mapcarve)).EndInit();
			this.groupBox_output_file_settings.ResumeLayout(false);
			this.groupBox_output_file_settings.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_target_2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_append)).EndInit();
			this.groupBox_curve_settings.ResumeLayout(false);
			this.groupBox_curve_settings.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_bounds)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_range)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_flatcircle)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_type)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_res)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_offset)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_rad)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_c_enable)).EndInit();
			this.groupBox_height_ramp.ResumeLayout(false);
			this.groupBox_height_ramp.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_ramp)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_heightmode)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_height)).EndInit();
			this.groupBox_texture_settings.ResumeLayout(false);
			this.groupBox_texture_settings.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_hstretchamt)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_hstretch)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_hshiftoffset)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_hshiftsrc)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_shift)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_texmode)).EndInit();
			this.tabPage_general2.ResumeLayout(false);
			this.tabPage_general2.PerformLayout();
			this.groupBox_middle_sections.ResumeLayout(false);
			this.groupBox_middle_sections.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_gaplen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_gaps)).EndInit();
			this.groupBox_grid.ResumeLayout(false);
			this.groupBox_grid.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_gridsize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_transit_round)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_round)).EndInit();
			this.groupBox_transforms_src.ResumeLayout(false);
			this.groupBox_transforms_src.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_mirror_src)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_rot_src)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_scale_src)).EndInit();
			this.groupBox_triangulation.ResumeLayout(false);
			this.groupBox_triangulation.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_transit_tri)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_tri)).EndInit();
			this.groupBox_transforms.ResumeLayout(false);
			this.groupBox_transforms.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_mirror)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_move)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_rot)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_scale)).EndInit();
			this.groupBox_null_brushes.ResumeLayout(false);
			this.groupBox_null_brushes.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_skipnull)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_spike_height)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_nulltex)).EndInit();
			this.tabPage_path_corner.ResumeLayout(false);
			this.tabPage_path_corner.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_splinefile)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_p_scale)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_p_expand)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_p_cornerfix)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_p_evenout)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_p_reverse)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_p_split)).EndInit();
			this.tabPage_detail_objects.ResumeLayout(false);
			this.tabPage_detail_objects.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_d_skip)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_d_draw)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_d_draw_rand)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_d_enable)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_d_pos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_d_autoname)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_d_autoyaw)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_d_autopitch)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_d_pos_rand)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_d_movey_rand)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_d_rotz_rand)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_d_scale_rand)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_d_circlemode)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_d_carve)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_d_autoassign)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_d_separate)).EndInit();
			this.tabPage_preset.ResumeLayout(false);
			this.tabPage_preset.PerformLayout();
			this.tabPage_WAD.ResumeLayout(false);
			this.tabPage_WAD.PerformLayout();
			this.tabPage_settings.ResumeLayout(false);
			this.tabPage_settings.PerformLayout();
			this.groupBox_Preset_Settings.ResumeLayout(false);
			this.groupBox_Preset_Settings.PerformLayout();
			this.groupBox_Editor_Settings.ResumeLayout(false);
			this.groupBox_Editor_Settings.PerformLayout();
			this.groupBox_M2C_Settings.ResumeLayout(false);
			this.groupBox_M2C_Settings.PerformLayout();
			this.tabPage_howto.ResumeLayout(false);
			this.tabControl_howto.ResumeLayout(false);
			this.tabPage_howto_1.ResumeLayout(false);
			this.tabPage_howto_1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tabPage_howto_2.ResumeLayout(false);
			this.tabPage_howto_2.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.tabPage_howto_3.ResumeLayout(false);
			this.tabPage_howto_3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
			this.tabPage_howto_4.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
			this.tabPage_temp.ResumeLayout(false);
			this.tabPage_temp.PerformLayout();
			this.flowLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel2.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_tempR)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_tempL)).EndInit();
			this.tabPage_log.ResumeLayout(false);
			this.tabPage_log.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_preview)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_source)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_help_target)).EndInit();
			this.menuStrip2.ResumeLayout(false);
			this.menuStrip2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button_generate;
		private System.Windows.Forms.Button button_input_file_select;
		private System.Windows.Forms.Label label_output_file_name;
		private System.Windows.Forms.TextBox textBox_output_file_name;
		private System.Windows.Forms.TextBox textBox_output_folder;
		private System.Windows.Forms.TextBox textBox_input_file;
		private System.Windows.Forms.Button button_output_folder_select;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenu_file;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenu_load;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenu_save;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenu_save_as;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_help;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_onlineDoc;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_about;
		private System.Windows.Forms.Button button_resetAll;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenu_Close;
		private System.Windows.Forms.Button button_Output_File_Open;
		private System.Windows.Forms.Label label_hint_saveChanges;
		private System.Windows.Forms.ToolTip toolTip_general;
		private System.Windows.Forms.Button button_Input_File_Open;
		private System.Windows.Forms.Button button_Output_Folder_Open;
		private System.Windows.Forms.PictureBox pictureBox_preview;
		private System.Windows.Forms.RichTextBox richTextBox_help;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenu_MRU;
		private System.Windows.Forms.PictureBox pictureBox_help_source;
		private System.Windows.Forms.PictureBox pictureBox_help_target;
		private System.Windows.Forms.TabPage tabPage_settings;
		private System.Windows.Forms.Label label_btn_settings_saved;
		private System.Windows.Forms.Button button_saveSettings;
		private System.Windows.Forms.GroupBox groupBox_Editor_Settings;
		private System.Windows.Forms.CheckBox checkBox_OpenFileInEditor;
		private System.Windows.Forms.TextBox textBox_M2C_exe_path;
		private System.Windows.Forms.TextBox textBox_Editor_exe_path;
		private System.Windows.Forms.Button button_M2C_exe_select;
		private System.Windows.Forms.Button button_Editor_exe_select;
		private System.Windows.Forms.GroupBox groupBox_M2C_Settings;
		private System.Windows.Forms.CheckBox checkBox_ForceAllToPreset;
		private System.Windows.Forms.CheckBox checkBox_M2C_dev;
		private System.Windows.Forms.CheckBox checkBox_M2C_autoclose;
		private System.Windows.Forms.TabPage tabPage_preset;
		private System.Windows.Forms.TextBox preset_shower;
		private System.Windows.Forms.TabPage tabPage_detail_objects;
		private System.Windows.Forms.Button button_resetTab4;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.PictureBox pictureBox_help_d_skip;
		private System.Windows.Forms.PictureBox pictureBox_help_d_draw;
		private System.Windows.Forms.PictureBox pictureBox_help_d_draw_rand;
		private System.Windows.Forms.PictureBox pictureBox_help_d_enable;
		private System.Windows.Forms.CheckBox checkBox_d_enable;
		private System.Windows.Forms.CheckBox checkBox_d_draw_rand;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBox_d_skip;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBox_d_draw;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.PictureBox pictureBox_help_d_pos;
		private System.Windows.Forms.PictureBox pictureBox_help_d_autoname;
		private System.Windows.Forms.PictureBox pictureBox_help_d_autoyaw;
		private System.Windows.Forms.PictureBox pictureBox_help_d_autopitch;
		private System.Windows.Forms.Label label_d_pos;
		private System.Windows.Forms.TextBox textBox_d_pos;
		private System.Windows.Forms.CheckBox checkBox_d_autoyaw;
		private System.Windows.Forms.CheckBox checkBox_d_autoname;
		private System.Windows.Forms.CheckBox checkBox_d_autopitch;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.PictureBox pictureBox_help_d_pos_rand;
		private System.Windows.Forms.PictureBox pictureBox_help_d_movey_rand;
		private System.Windows.Forms.PictureBox pictureBox_help_d_rotz_rand;
		private System.Windows.Forms.PictureBox pictureBox_help_d_scale_rand;
		private System.Windows.Forms.TextBox textBox_d_pos_max;
		private System.Windows.Forms.Label label_d_pos_max;
		private System.Windows.Forms.Label label_d_pos_min;
		private System.Windows.Forms.TextBox textBox_d_pos_min;
		private System.Windows.Forms.CheckBox checkBox_d_pos_rand;
		private System.Windows.Forms.CheckBox checkBox_d_scale_rand;
		private System.Windows.Forms.TextBox textBox_d_movey_rand_max;
		private System.Windows.Forms.TextBox textBox_d_scale_rand_min;
		private System.Windows.Forms.Label label_d_movey_rand_max;
		private System.Windows.Forms.CheckBox checkBox_d_rotz_rand;
		private System.Windows.Forms.Label label_d_movey_rand_min;
		private System.Windows.Forms.Label label_d_scale_rand_min;
		private System.Windows.Forms.TextBox textBox_d_movey_rand_min;
		private System.Windows.Forms.CheckBox checkBox_d_movey_rand;
		private System.Windows.Forms.TextBox textBox_d_rotz_rand_max;
		private System.Windows.Forms.Label label_d_scale_rand_max;
		private System.Windows.Forms.Label label_d_rotz_rand_max;
		private System.Windows.Forms.TextBox textBox_d_scale_rand_max;
		private System.Windows.Forms.Label label_d_rotz_rand_min;
		private System.Windows.Forms.TextBox textBox_d_rotz_rand_min;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox pictureBox_help_d_circlemode;
		private System.Windows.Forms.PictureBox pictureBox_help_d_carve;
		private System.Windows.Forms.PictureBox pictureBox_help_d_autoassign;
		private System.Windows.Forms.PictureBox pictureBox_help_d_separate;
		private System.Windows.Forms.CheckBox checkBox_d_circlemode;
		private System.Windows.Forms.CheckBox checkBox_d_carve;
		private System.Windows.Forms.CheckBox checkBox_d_autoassign;
		private System.Windows.Forms.CheckBox checkBox_d_separate;
		private System.Windows.Forms.PictureBox pictureBox_help_splinefile;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button_resetTab3;
		private System.Windows.Forms.PictureBox pictureBox_help_p_scale;
		private System.Windows.Forms.PictureBox pictureBox_help_p_expand;
		private System.Windows.Forms.PictureBox pictureBox_help_p_cornerfix;
		private System.Windows.Forms.PictureBox pictureBox_help_p_evenout;
		private System.Windows.Forms.PictureBox pictureBox_help_p_reverse;
		private System.Windows.Forms.PictureBox pictureBox_help_p_split;
		private System.Windows.Forms.TextBox textBox_p_expand;
		private System.Windows.Forms.TextBox textBox_p_scale_z;
		private System.Windows.Forms.TextBox textBox_p_scale_x;
		private System.Windows.Forms.TextBox textBox_p_scale_y;
		private System.Windows.Forms.TextBox textBox_splinefile;
		private System.Windows.Forms.Label label_p_scale_z;
		private System.Windows.Forms.Label label_p_scale_x;
		private System.Windows.Forms.Label label_p_scale_y;
		private System.Windows.Forms.CheckBox checkBox_p_evenout;
		private System.Windows.Forms.Label label_p_expand;
		private System.Windows.Forms.CheckBox checkBox_p_split;
		private System.Windows.Forms.CheckBox checkBox_p_reverse;
		private System.Windows.Forms.CheckBox checkBox_p_cornerfix;
		private System.Windows.Forms.Label label_splinefile;
		private System.Windows.Forms.Button button_splinefile;
		private System.Windows.Forms.TabPage tabPage_general2;
		private System.Windows.Forms.Button button_resetTab2;
		private System.Windows.Forms.GroupBox groupBox_transforms_src;
		private System.Windows.Forms.PictureBox pictureBox_help_rot_src;
		private System.Windows.Forms.PictureBox pictureBox_help_scale_src;
		private System.Windows.Forms.TextBox textBox_scale_src;
		private System.Windows.Forms.TextBox textBox_rot_src_z;
		private System.Windows.Forms.Label label_rot_src;
		private System.Windows.Forms.TextBox textBox_rot_src_x;
		private System.Windows.Forms.TextBox textBox_rot_src_y;
		private System.Windows.Forms.Label label_scale_src;
		private System.Windows.Forms.Label label_rot_src_y;
		private System.Windows.Forms.GroupBox groupBox_triangulation;
		private System.Windows.Forms.PictureBox pictureBox_help_transit_round;
		private System.Windows.Forms.PictureBox pictureBox_help_round;
		private System.Windows.Forms.PictureBox pictureBox_help_transit_tri;
		private System.Windows.Forms.PictureBox pictureBox_help_tri;
		private System.Windows.Forms.CheckBox checkBox_transit_round;
		private System.Windows.Forms.CheckBox checkBox_transit_tri;
		private System.Windows.Forms.CheckBox checkBox_round;
		private System.Windows.Forms.CheckBox checkBox_tri;
		private System.Windows.Forms.GroupBox groupBox_transforms;
		private System.Windows.Forms.PictureBox pictureBox_help_move;
		private System.Windows.Forms.PictureBox pictureBox_help_rot;
		private System.Windows.Forms.PictureBox pictureBox_help_scale;
		private System.Windows.Forms.TextBox textBox_rot_z;
		private System.Windows.Forms.Label label_transfin_z;
		private System.Windows.Forms.TextBox textBox_rot_y;
		private System.Windows.Forms.Label label_transfin_y;
		private System.Windows.Forms.TextBox textBox_move_z;
		private System.Windows.Forms.TextBox textBox_move_y;
		private System.Windows.Forms.TextBox textBox_move_x;
		private System.Windows.Forms.Label label_move;
		private System.Windows.Forms.Label label_scale;
		private System.Windows.Forms.Label label_transfin_x;
		private System.Windows.Forms.GroupBox groupBox_null_brushes;
		private System.Windows.Forms.PictureBox pictureBox_help_skipnull;
		private System.Windows.Forms.PictureBox pictureBox_help_spike_height;
		private System.Windows.Forms.PictureBox pictureBox_help_nulltex;
		private System.Windows.Forms.TextBox textBox_spike_height;
		private System.Windows.Forms.Label label_nulltex;
		private System.Windows.Forms.CheckBox checkBox_skipnull;
		private System.Windows.Forms.TextBox textBox_nulltex;
		private System.Windows.Forms.Label label_spike_height;
		private System.Windows.Forms.TabPage tabPage_general;
		private System.Windows.Forms.Button button_resetTab1;
		private System.Windows.Forms.GroupBox groupBox_output_file_settings;
		private System.Windows.Forms.PictureBox pictureBox_help_target_2;
		private System.Windows.Forms.PictureBox pictureBox_help_append;
		private System.Windows.Forms.CheckBox checkBox_append;
		private System.Windows.Forms.CheckBox checkBox_export_map;
		private System.Windows.Forms.CheckBox checkBox_export_obj;
		private System.Windows.Forms.CheckBox checkBox_export_rmf;
		private System.Windows.Forms.GroupBox groupBox_curve_settings;
		private System.Windows.Forms.PictureBox pictureBox_help_bounds;
		private System.Windows.Forms.PictureBox pictureBox_help_range;
		private System.Windows.Forms.PictureBox pictureBox_help_flatcircle;
		private System.Windows.Forms.PictureBox pictureBox_help_type;
		private System.Windows.Forms.PictureBox pictureBox_help_res;
		private System.Windows.Forms.PictureBox pictureBox_help_offset;
		private System.Windows.Forms.PictureBox pictureBox_help_rad;
		private System.Windows.Forms.PictureBox pictureBox_help_c_enable;
		private System.Windows.Forms.ComboBox comboBox_bounds;
		private System.Windows.Forms.Label label_bounds;
		private System.Windows.Forms.CheckBox checkBox_c_enable;
		private System.Windows.Forms.TextBox textBox_range_end;
		private System.Windows.Forms.CheckBox checkBox_flatcircle;
		private System.Windows.Forms.Label label_range_end;
		private System.Windows.Forms.Label label_type;
		private System.Windows.Forms.Label label_range_start;
		private System.Windows.Forms.ComboBox comboBox_type;
		private System.Windows.Forms.TextBox textBox_range_start;
		private System.Windows.Forms.Label label_res;
		private System.Windows.Forms.TextBox textBox_res;
		private System.Windows.Forms.TextBox textBox_rad;
		private System.Windows.Forms.Label label_offset;
		private System.Windows.Forms.TextBox textBox_offset;
		private System.Windows.Forms.Label label_radius;
		private System.Windows.Forms.GroupBox groupBox_height_ramp;
		private System.Windows.Forms.PictureBox pictureBox_help_ramp;
		private System.Windows.Forms.PictureBox pictureBox_help_heightmode;
		private System.Windows.Forms.PictureBox pictureBox_help_height;
		private System.Windows.Forms.CheckBox checkBox_ramp;
		private System.Windows.Forms.Label label_heightmode;
		private System.Windows.Forms.ComboBox comboBox_heightmode;
		private System.Windows.Forms.TextBox textBox_height;
		private System.Windows.Forms.Label label_height;
		private System.Windows.Forms.GroupBox groupBox_texture_settings;
		private System.Windows.Forms.PictureBox pictureBox_help_hstretchamt;
		private System.Windows.Forms.PictureBox pictureBox_help_hstretch;
		private System.Windows.Forms.PictureBox pictureBox_help_hshiftoffset;
		private System.Windows.Forms.PictureBox pictureBox_help_hshiftsrc;
		private System.Windows.Forms.PictureBox pictureBox_help_shift;
		private System.Windows.Forms.PictureBox pictureBox_help_texmode;
		private System.Windows.Forms.Label label_shift;
		private System.Windows.Forms.ComboBox comboBox_shift;
		private System.Windows.Forms.TextBox textBox_hstretchamt;
		private System.Windows.Forms.Label label_hstretchamt;
		private System.Windows.Forms.CheckBox checkBox_hstretch;
		private System.Windows.Forms.Label label_hshiftsrc;
		private System.Windows.Forms.ComboBox comboBox_hshiftsrc;
		private System.Windows.Forms.Label label_texmode;
		private System.Windows.Forms.ComboBox comboBox_texmode;
		private System.Windows.Forms.Label label_hshiftoffset;
		private System.Windows.Forms.TextBox textBox_hshiftoffset;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage_WAD;
		private System.Windows.Forms.ListBox listBox_WAD_list;
		private System.Windows.Forms.Button button_WAD_add;
		private System.Windows.Forms.Button button_WAD_remove;
		private System.Windows.Forms.ComboBox comboBox_CurveObj;
		private System.Windows.Forms.Label label_CurveObj;
		private System.Windows.Forms.Button button_CurveObj_Add;
		private System.Windows.Forms.Button button_CurveObj_Remove;
		private System.Windows.Forms.Button button_CurveObj_Rename;
		private System.Windows.Forms.TabPage tabPage_path_corner;
		private System.Windows.Forms.Button button_CurveObj_prev;
		private System.Windows.Forms.Button button_CurveObj_next;
		private System.Windows.Forms.GroupBox groupBox_Preset_Settings;
		private System.Windows.Forms.CheckBox checkBox_Preset_Inherit;
		private System.Windows.Forms.Label label_WADList;
		private System.Windows.Forms.Button button_CurveObj_Clone;
		private System.Windows.Forms.TabPage tabPage_howto;
		private System.Windows.Forms.TabControl tabControl_howto;
		private System.Windows.Forms.TabPage tabPage_howto_1;
		private System.Windows.Forms.TabPage tabPage_howto_2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TabPage tabPage_howto_3;
		private System.Windows.Forms.TabPage tabPage_howto_4;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.PictureBox pictureBox11;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.PictureBox pictureBox12;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.PictureBox pictureBox13;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.ImageList tabIcons;
		private System.Windows.Forms.TabPage tabPage_temp;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.PictureBox pictureBox_tempL;
		private System.Windows.Forms.PictureBox pictureBox_tempR;
		private System.Windows.Forms.Button button_temp_Load;
		private System.Windows.Forms.ListView listView_templates;
		private System.Windows.Forms.ColumnHeader temp_name;
		private System.Windows.Forms.ColumnHeader temp_framework;
		private System.Windows.Forms.ColumnHeader temp_filepath;
		private System.Windows.Forms.ImageList templateIcons;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label label_temp;
		private System.Windows.Forms.Label label_temp_name_h;
		private System.Windows.Forms.Label label_temp_type_h;
		private System.Windows.Forms.Label label_temp_path;
		private System.Windows.Forms.Label label_temp_path_h;
		private System.Windows.Forms.Label label_temp_name;
		private System.Windows.Forms.Label label_temp_type;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_tutorials;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_tuts_0;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_tuts_1;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_tuts_2;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_tuts_3;
		private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_reloadPreset;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenu_MRU2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
		private System.Windows.Forms.ToolStripMenuItem templatesToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Temp_0;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Temp_1;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Temp_2;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Temp_3;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Temp_4;
		private System.Windows.Forms.ToolStripMenuItem tutorialsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Tuto_0;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Tuto_1;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Tuto_2;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Tuto_3;
		private System.Windows.Forms.GroupBox groupBox_grid;
		private System.Windows.Forms.PictureBox pictureBox_help_gridsize;
		private System.Windows.Forms.TextBox textBox_gridsize_z;
		private System.Windows.Forms.Label label_gridsize;
		private System.Windows.Forms.TextBox textBox_gridsize_x;
		private System.Windows.Forms.TextBox textBox_gridsize_y;
		private System.Windows.Forms.PictureBox pictureBox_help_mapcarve;
		private System.Windows.Forms.Label label_mapcarve;
		private System.Windows.Forms.ComboBox comboBox_mapcarve;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.GroupBox groupBox_middle_sections;
		private System.Windows.Forms.PictureBox pictureBox_help_gaplen;
		private System.Windows.Forms.PictureBox pictureBox_help_gaps;
		private System.Windows.Forms.Label label_gaplen;
		private System.Windows.Forms.CheckBox checkBox_gaps;
		private System.Windows.Forms.TextBox textBox_gaplen;
        private System.Windows.Forms.CheckBox checkBox_M2C_log;
        private System.Windows.Forms.TextBox textBox_rot_x;
        private System.Windows.Forms.Label label_rot;
        private System.Windows.Forms.TextBox textBox_scale;
        private System.Windows.Forms.Label label_mirror;
        private System.Windows.Forms.PictureBox pictureBox_help_mirror;
        private System.Windows.Forms.CheckBox checkBox_mirror_z;
        private System.Windows.Forms.CheckBox checkBox_mirror_y;
        private System.Windows.Forms.CheckBox checkBox_mirror_x;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label_gridsize_sep_h;
        private System.Windows.Forms.Label label_transfin_sep_h;
        private System.Windows.Forms.Label label_transsrc_sep_h;
        private System.Windows.Forms.Label label_transfin_sep_v1;
        private System.Windows.Forms.Label label_transsrc_sep_v1;
        private System.Windows.Forms.Label label_transsrc_sep_v2;
        private System.Windows.Forms.Label label_transfin_sep_v2;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.CheckBox checkBox_mirror_src_z;
        private System.Windows.Forms.CheckBox checkBox_mirror_src_y;
        private System.Windows.Forms.CheckBox checkBox_mirror_src_x;
        private System.Windows.Forms.Label label_mirror_src;
        private System.Windows.Forms.PictureBox pictureBox_help_mirror_src;
        private System.Windows.Forms.Label label_gridsize_sep_v1;
        private System.Windows.Forms.Label label_gridsize_sep_v2;
        private System.Windows.Forms.TabPage tabPage_log;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.CheckBox checkBox_CurveObj_ChangeAll;
    }
}