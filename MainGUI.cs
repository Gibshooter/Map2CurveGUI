using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;


namespace Map2CurveGUI
{
	public partial class MainGUI : Form
	{
		readonly string DIR_ROOT;
		string DIR_M2C;
		readonly Color ColBGError = Color.LightPink;
		readonly Color ColEmpty = Color.Empty;


		// M2C GUI FORM
		public MainGUI()
		{
			InitializeComponent();
			SetAllControlTags();
			AddCurveObj();
			DIR_ROOT = Path.Combine(Directory.GetCurrentDirectory());

			// menu buttons
			SetPresetReloadButton();

			// Most Recent File List
			RecentList_Load();
			RecentList_MenuSpread();

			help_Clear();

			changesFalse();

			GUISettings_Initial();

			// WAD LIST
			LoadWADList();

			// Templates
			CreateTemplateList();
		}




		// GENERATE BUTTON
		private void button_generate_Click(object sender, EventArgs e)
		{
			string inFilePath = CurveList[0].inputFilePath;
			string m2cexe = textBox_M2C_exe_path.Text;
			bool AreFilePathsValid = CheckPathValidity(new int[] { 0, 1, 2 });
			bool DoFilenamesDiffer = CheckInOutFilenames();
			bool M2CExeExists = File.Exists(textBox_M2C_exe_path.Text);
			int PresetPathLen = CurveList[0].presetFilePath.Length;
			int inFilePathLen = inFilePath.Length;

			if (M2CExeExists && !ChangesMade && DoFilenamesDiffer && AreFilePathsValid && inFilePath.Length > 0 && PresetPathLen > 0)
				try
				{
					// Call M2C.Exe
					string M2Cparams = "";
					if (checkBox_M2C_autoclose.Checked) M2Cparams += " -autoclose";
					if (checkBox_M2C_log.Checked) M2Cparams += " -log";
					if (checkBox_M2C_dev.Checked) M2Cparams += " -dev";
					//Process.Start(m2cexe, "\""+CurveList[0].presetFilePath + "\"" + M2Cparams);

					Process process = new Process();
					process.StartInfo.FileName = m2cexe;
					process.StartInfo.Arguments = "\"" + CurveList[0].presetFilePath + "\"" + M2Cparams;
					process.Start();
					process.WaitForExit();
					int ExitCode = process.ExitCode;

					// in case M2C returned no error, proceed to open in Editor
					if (ExitCode == 0)
					{
						// Messages SUCCESS
						string ext = "";
						if (CurveList[0].map) ext = ".map";
						else if (CurveList[0].rmf) ext = ".rmf";
						else if (CurveList[0].obj) ext = ".obj";
						string message = "Preset:\t" + CurveList[0].presetFileName +
							"\r\nInput:\t" + CurveList[0].inputFilename + ".map" +
							"\r\nOutput:\t" + CurveList[0].outputFilename + ext +
							"\r\n\r\nCurve has been generated successfully!" +
							"\r\n";
						/*MessageBox.Show(message);*/
						Result resultDialog = new Result(message, 0);
						resultDialog.Show(this);


                        // Open output file if this was set
                        if (checkBox_OpenFileInEditor.Checked == true &&
							textBox_Editor_exe_path.Text.Length > 0 &&
							File.Exists(textBox_Editor_exe_path.Text) &&
							(CurveList[0].map || CurveList[0].rmf))
						{
							string OutputFolder = CurveList[0].outputFolder;
							if (!InputFilePath_Rooted[1]) OutputFolder = Path.Combine(DIR_M2C, CurveList[0].outputFolder);
							sendMapFileToEditor(OutputFolder + "\\" + CurveList[0].outputFilename, true);
						}

                        // Open log if this was set
                        if ( checkBox_M2C_log.Checked == true )
                        {
                            tabControl1.SelectedIndex = 9;
							UpdateLogTab();
                        }

                    }
                    else if (ExitCode == 2)
					{
						string message = "Curve has been generated with (a) warning(s)!\r\n" + Properties.Resources.TXT_MOREINFO;
						Result resultDialog = new Result(message, 2);
                        resultDialog.Show(this);
                        
                        //MessageBox.Show("Curve was processed with (a) warning(s)!\r\n" + Properties.Resources.TXT_MOREINFO);
                    }
                    else
					{
						string message = "There was a critical problem when generating the curve!\r\n" + Properties.Resources.TXT_MOREINFO;
						Result resultDialog = new Result(message, 1);
                        //resultDialog.ShowIcon = true;
                        //resultDialog.ShowInTaskbar = true;
                        //resultDialog.TopMost = true;
                        resultDialog.Show(this);

                        //MessageBox.Show("There was a critical problem generating the Curve!\r\n" + Properties.Resources.TXT_MOREINFO);
                    }
                }
				catch (Exception ex)
				{
					// Messages FAILURE
					MessageBox.Show(ex.Message);
				}
			else
			{
				string Message = "";
				if (!M2CExeExists) Message += Properties.Resources.TXT_SPECIFY_M2C_EXE + "\r\n";
				if (ChangesMade || CurveList[0].presetFilePath.Length == 0) Message += "Please save your changes!\r\n";
				if (!DoFilenamesDiffer && inFilePathLen > 0) Message += "Input and Output Filenames are the same!\r\n";
				if (!AreFilePathsValid && inFilePathLen > 0) Message += "There are invalid File Paths!\r\n";
				if (inFilePath.Length == 0) Message += "No Input Map File specified!\r\n";
				MessageBox.Show(Message);
			}
		}







		// =========== GUI EXIT OVERRIDE ===========
		private void ToolStripMenu_Exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		//https://stackoverflow.com/questions/1669318/override-standard-close-x-button-in-a-windows-form
		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			base.OnFormClosing(e);

			//if (ChangesMade)
			if (e.CloseReason == CloseReason.WindowsShutDown) return;

			// Confirm user wants to close
			if (ChangesMade)
				switch (MessageBox.Show(this, "Recent Changes will be lost! Continue?", "Closing", MessageBoxButtons.YesNo))
				{
					case DialogResult.No:
						e.Cancel = true;
						break;
					default:
						break;
				}
		}



		// MENU HELP -> Online 
		private void ToolStripMenu_onlineDoc_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("http://gibshooter.com/map2curve/docs/");
		}

		// MENU HELP -> ABOUT
		private void ToolStripMenu_about_Click(object sender, EventArgs e)
		{
			About aboutDialog = new About();
			aboutDialog.ShowDialog();
		}

		// MENU HELP -> TUTORIALS
		private void ToolStripMenu_Tutorials_Click(object sender, EventArgs e)
		{
			var btn = (System.Windows.Forms.ToolStripMenuItem)sender;
			if (btn.Name == "tutorialsToolStripMenuItem") {
				tabControl1.SelectedTab = tabControl1.TabPages[7];
			} else {
				int i = int.Parse(Char.ToString(btn.Name[19]));
				tabControl1.SelectedTab = tabControl1.TabPages[7];
				tabControl_howto.SelectedTab = tabControl_howto.TabPages[i];
			}
		}








		// TAB PRESET : UPDATE
		private void preset_shower_VisibleChanged(object sender, EventArgs e)
		{
			UpdatePresetTab();
		}

		private void UpdatePresetTab()
		{
			if (tabControl1.SelectedTab.Name == "tabPage_preset")
				preset_shower.Text = AllCurvesToString();
		}

		// All Curve Objects to String (for Preset Tab and Preset File Export)
		private string AllCurvesToString()
		{
			CurveHandler CHandler = new CurveHandler();
			string CurveString = "";
			CurveString += "// This Preset File was generated with Map2Curve GUI\r\n\r\n";
			CurveString += CHandler.AllCurveObjectsToString(ref CurveList, checkBox_ForceAllToPreset.Checked, !checkBox_Preset_Inherit.Checked);
			CurveString += "// End of Preset File";
			return CurveString;
		}







        // TAB LOG : UPDATE
        private void textBox_Log_VisibleChanged(object sender, EventArgs e)
        {
            UpdateLogTab();
        }

        private void UpdateLogTab()
        {
            //if (tabControl1.SelectedTab.Name == "tabPage_log")
            if (tabControl1.SelectedIndex == 9)
			{
				string filePath = Path.Combine(DIR_ROOT, "Map2Curve.log");

                if (File.Exists(filePath))
                {
                    try
                    {
                        string readText = File.ReadAllText(filePath);
                        textBox_log.Text = readText;
						textBox_log.SelectionLength = 0;
                    }
                    catch (Exception ex)
                    {
                        textBox_log.Text = "Error loading " + filePath;
                        /*MessageBox.Show(ex.Message);*/
                    }
                }
                else
                {
					textBox_log.Text = Properties.Resources.TXT_NO_LOG_FILE_FOUND;
                }
            }
        }

    }
}