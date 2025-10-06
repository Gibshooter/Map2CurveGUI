using System;
using System.IO;
using System.Windows.Forms;

namespace Map2CurveGUI
{
	public partial class MainGUI : Form
	{

		// ================ SETTINGS TAB EVENTS ================

		// -------[ BUTTON ]------- MAP2CURVE EXE
		private void button_M2C_exe_select_Click(object sender, EventArgs e)
		{
			string newFilePath = openExeFile();
			if (newFilePath.Length>0)
			{
				int IsRealEXE = newFilePath.IndexOf("Map2Curve.exe");
				if (IsRealEXE != -1 && File.Exists(newFilePath))
				{
					SetM2CExePath(newFilePath);
				}
				else
				{
					MessageBox.Show("The chosen executable doesn\'t seem to be valid.\r\nPlease select Map2Curve.exe!");
				}
			}
		}

		// -------[ BUTTON ]------- EDITOR EXE
		private void button_Editor_exe_select_Click(object sender, EventArgs e)
		{
			string newFilePath = openExeFile();
			if (newFilePath.Length > 0)
				textBox_Editor_exe_path.Text = newFilePath;
		}

		// -------[ BUTTON ]------- SAVE GUI SETTINGS
		private void button_saveSettings_Click(object sender, EventArgs e)
		{
			SaveGUISettingsToFile();
		}

		// -------[ LABEL ]------- Hide "Settings Saved" on Tab Leave
		private void tabPage_settings_Leave(object sender, EventArgs e)
		{
			label_btn_settings_saved.Visible = false;
		}







		// ================ SETTINGS TAB METHODS ================

		// MAP2CURVE EXE
		private void SetM2CExePath(string M2Cpath)
		{
			if (File.Exists(M2Cpath))
			{
				textBox_M2C_exe_path.Text = M2Cpath;
				DIR_M2C = M2Cpath.Substring(0, M2Cpath.LastIndexOf("\\"));
				CheckSameDIR_ROOT();

				LoadWADList();
			}
			else
			{
				MessageBox.Show("Specified file path for Map2Curve.exe in GUISettings.txt is invalid!");
				tabControl1.SelectTab(tabPage_settings);
			}
		}

		// SELECT APPS DIALOG
		public string openExeFile()
		{
			Ookii.Dialogs.WinForms.VistaOpenFileDialog OpenFile = new Ookii.Dialogs.WinForms.VistaOpenFileDialog();
			OpenFile.Filter = "Executable (*.exe)|*.exe";
			OpenFile.InitialDirectory = DIR_ROOT;
			OpenFile.RestoreDirectory = true;

			if (OpenFile.ShowDialog(this) == DialogResult.OK)
			{
				return OpenFile.FileName;
			}
			else { return ""; }
		}






		// ================ GUI SETTINGS FILE METHODS ================

		// STARTUP
		private void GUISettings_Initial()
		{
			string M2CEXEPath = Path.Combine(DIR_ROOT, "Map2Curve.exe");
			string GUISettingsFilePath = Path.Combine(DIR_ROOT, "GUISettings.txt");

			// GUI settings file exists or...
			if (File.Exists(GUISettingsFilePath)) { LoadGUISettingsFromFile(); }
			else
			{
				// ...does not exist
				tabControl1.SelectedTab = tabPage_settings;

				// M2C.exe was detected in same dir as GUI.exe or...
				if (File.Exists(M2CEXEPath)) { SetM2CExePath(M2CEXEPath); SaveGUISettingsToFile(); }
				else
				{
					// ... wasn't found at all
					MessageBox.Show("M2C.exe not found in root folder, please select!");
					M2CEXEPath = openExeFile();
					if (M2CEXEPath.Length > 0)
					{
						SetM2CExePath(M2CEXEPath);
						SaveGUISettingsToFile();
					}
				}
			}
		}

		// SAVE
		public void SaveGUISettingsToFile()
		{
			try
			{
				string FilePath = Path.Combine(DIR_ROOT, "GUISettings.txt");

				TextWriter tw = new StreamWriter(FilePath);

				// write lines of text to the file
				tw.WriteLine("S_M2C_EXE;" + textBox_M2C_exe_path.Text + ";");
				tw.WriteLine("S_EDITOR_EXE;" + textBox_Editor_exe_path.Text + ";");
				tw.WriteLine("S_EDITOR_OPEN;" + checkBox_OpenFileInEditor.Checked + ";");
				tw.WriteLine("S_M2C_AUTOCLOSE;" + checkBox_M2C_autoclose.Checked + ";");
				tw.WriteLine("S_M2C_DEV;" + checkBox_M2C_dev.Checked + ";");
				tw.WriteLine("S_M2C_FORCEALLTOPRE;" + checkBox_ForceAllToPreset.Checked + ";");
				tw.WriteLine("S_M2C_INHERITANCE;" + checkBox_Preset_Inherit.Checked + ";");
				tw.WriteLine("S_M2C_LOG;" + checkBox_M2C_log.Checked + ";");

				// close the stream     
				tw.Close();

				label_btn_settings_saved.Visible = true;
			}
			catch
			{
				MessageBox.Show("There was a Problem saving the GUI Settings!");
			}
		}

		// LOAD
		public void LoadGUISettingsFromFile()
		{
			string settingsFile = "";
			string line = "";
			string settingsFilePath = Path.Combine(DIR_ROOT, "GUISettings.txt");
			try
			{
				//Pass the file path and file name to the StreamReader constructor
				StreamReader sr = new StreamReader(settingsFilePath);
				//Read the first line of text
				settingsFile += sr.ReadLine();
				//Continue to read until you reach end of file
				while (line != null)
				{
					//Read the next line
					line = sr.ReadLine();

					if (line != null) settingsFile += line;
				}
				//close the file
				sr.Close();

				// get settings
				if (settingsFile.Length > 0)
				{
					string[] keyword = { "S_M2C_EXE;", "S_EDITOR_EXE;", "S_EDITOR_OPEN;", "S_M2C_AUTOCLOSE;", "S_M2C_DEV;", "S_M2C_FORCEALLTOPRE;", "S_M2C_INHERITANCE;" };
					int[] offset = { 10, 13, 14, 16, 10, 20, 18 };
					string[] content = new string[keyword.Length];

					for (int i = 0; i < keyword.Length; i++)
					{
						string k = keyword[i];
						ref string Content = ref content[i];
						int o = offset[i], s = 0, e = 0, ss = 0;

						s = settingsFile.IndexOf(k);
						ss = s + o;
						e = settingsFile.IndexOf(";", ss);
						if (s != -1 && e != -1)
							Content = settingsFile.Substring(ss, e - ss);
						else
							Content = "";
					}
					// fill GUI settings
					for (int i = 0; i < keyword.Length; i++)
					{
						if (content[i].Length > 0)
						{
							if (i == 0) SetM2CExePath(content[i]);
							else if (i == 1) textBox_Editor_exe_path.Text = content[i];
							else if (i == 2) checkBox_OpenFileInEditor.Checked = bool.Parse(content[i]);
							else if (i == 3) checkBox_M2C_autoclose.Checked = bool.Parse(content[i]);
							else if (i == 4) checkBox_M2C_dev.Checked = bool.Parse(content[i]);
							else if (i == 5) checkBox_ForceAllToPreset.Checked = bool.Parse(content[i]);
							else if (i == 6) checkBox_Preset_Inherit.Checked = bool.Parse(content[i]);
							else if (i == 7) checkBox_M2C_log.Checked = bool.Parse(content[i]);
						}
					}
				}
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
		}


	}
}