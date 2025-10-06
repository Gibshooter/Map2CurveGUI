using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Map2CurveGUI
{
	public partial class MainGUI : Form
	{
		// MEMBER VARIABLES
		bool ChangesMade = false;

		public void changesTrue()
		{
			ChangesMade = true;
			SetGUITitleText();
			label_hint_saveChanges.Visible = true;
		}

		public void changesFalse()
		{
			ChangesMade = false;
			SetGUITitleText();
			label_hint_saveChanges.Visible = false;
		}

		/*
		public void changesMadeSet(bool b)
		{
			ChangesMade = b;
			SetGUITitleText();
			label_hint_saveChanges.Visible = b;
		}
		*/

		// GUI TITLE GENERATOR
		private void SetGUITitleText()
		{
			string ChangesMark = "";
			if (ChangesMade) ChangesMark = "*";

			string PresetFilePath = "No Preset File loaded...";
			if (CurveList[0].presetFilePath.Length > 0)
				PresetFilePath = CurveList[0].presetFilePath;

			this.Text = "Map2Curve GUI | " + ChangesMark + PresetFilePath;
		}






		// =========== PRESET FILE MENU METHODS ===========

		// NEW
		private void CreateNewPreset()
		{
			CurveList.Clear();
			AddCurveObj();

			// Update Settings Tab
			UpdatePresetTab();

			// reset colors
			ResetColors();

			// Reset Changes Made
			changesFalse();

			// Clear Help Text and Image
			help_Clear();

			// hide splinefile warning
			label_splinefile.Visible = false;

			SetPresetReloadButton();
		}

		// OPEN
		private void OpenPresetFile()
		{
			Ookii.Dialogs.WinForms.VistaOpenFileDialog OpenFile = new Ookii.Dialogs.WinForms.VistaOpenFileDialog();
			OpenFile.Filter = "M2C Preset-Files (*.txt)|*.txt";
			OpenFile.InitialDirectory = DIR_ROOT;
			OpenFile.RestoreDirectory = true;

			if (OpenFile.ShowDialog(this) == DialogResult.OK)
			{
				LoadPresetFromFilePath(OpenFile.FileName);
			}
		}

		// SAVE
		public void SavePresetFileDialog()
		{
			Ookii.Dialogs.WinForms.VistaSaveFileDialog SaveFile = new Ookii.Dialogs.WinForms.VistaSaveFileDialog();
			SaveFile.FileName = CurveList[0].outputFilename + ".txt";
			SaveFile.Filter = "M2C Preset-Files (*.txt)|*.txt";
			SaveFile.DefaultExt = "txt";

			string oldpresetFilePath = this.Text;

			if (SaveFile.ShowDialog(this) == DialogResult.OK)
			{
				if (!SaveFile.FileName.EndsWith(".txt")) SaveFile.FileName += ".txt";
				try
				{
					CurveList[0].presetFilePath = SaveFile.FileName;
					int b = SaveFile.FileName.LastIndexOf("\\") + 1;
					int l = SaveFile.FileName.Length - b;
					CurveList[0].presetFileName = SaveFile.FileName.Substring(b, l);

					File.WriteAllText(CurveList[0].presetFilePath, AllCurvesToString());

					// Changes Made
					RecentFile_Save(CurveList[0].presetFilePath);
					changesFalse();
				}
				catch (Exception ex) { MessageBox.Show(ex.Message); }
			}
			else
			{
				this.Text = oldpresetFilePath;
			}
		}

		// LOAD
		private void LoadPresetFromFilePath(string filepath)
		{
			if (File.Exists(textBox_M2C_exe_path.Text))
			{
				try
				{
					PresetFileHandler PHandler = new PresetFileHandler(filepath);
					PHandler.ProcessPresetFile(ref CurveList);

					if (CurveList.Count > 0)
					{
						ResetColors();
						comboBox_CurveObj.SelectedIndex = 0;
						RefreshCurveList();
						LoadCurveObj(0);
						changesFalse();

						CheckPathValidity(new int[] { 0, 1, 2 });
						CheckInOutFilenames();
						CheckCornerFileValidity(SelCurveObj.cornerFilePath);

						RecentFile_Save(filepath);

						help_Clear();
						UpdatePresetTab();
						SetPresetReloadButton();
					}
					else
					{
						MessageBox.Show("No curve object loaded!");
					}
				}
				catch (Exception ex)
				{
					//MessageBox.Show("There was a problem opening this preset file!\r\n" + ex.Message);
				}
			}
			else
			{
				MessageBox.Show(Properties.Resources.TXT_SPECIFY_M2C_EXE);
				tabControl1.SelectTab(tabPage_settings);
			}
		}

		private void LoadPresetChangesDialog(string filepath)
		{
			if (ChangesMade)
				switch (MessageBox.Show(this, "Recent Changes will be lost! Continue?", "Opening", MessageBoxButtons.YesNo))
				{
					case DialogResult.Yes:
						LoadPresetFromFilePath(filepath);
						break;

					default:
						break;
				}
			else LoadPresetFromFilePath(filepath);
		}


		// RESET BUTTON COLORS
		public void SetPresetReloadButton()
		{
			if (CurveList[0].presetFilePath.Length > 0) {
				ToolStripMenu_reloadPreset.Enabled = true;
				ToolStripMenu_reloadPreset.ForeColor = Color.Black;
			} else {
				ToolStripMenu_reloadPreset.Enabled = false;
 			}
		}









		// =========== MENU BUTTON EVENTS ===========

		// NEW
		private void toolStripMenu_NewPreset_Click(object sender, EventArgs e)
		{
			if (ChangesMade)
				switch (MessageBox.Show(this, "Recent Changes will be lost! Continue?", "Resetting", MessageBoxButtons.YesNo))
				{
					case DialogResult.Yes:
						CreateNewPreset();
						break;

					default:
						break;
				}
			else CreateNewPreset();
		}

		// LOAD
		private void toolStripMenu_load_Click(object sender, EventArgs e)
		{
			if (File.Exists(textBox_M2C_exe_path.Text))
			{
				if (ChangesMade)
					switch (MessageBox.Show(this, "Recent Changes will be lost! Continue?", "Resetting", MessageBoxButtons.YesNo))
					{
						case DialogResult.Yes:
							OpenPresetFile();
							break;

						default:
							break;
					}
				else OpenPresetFile();
			}
			else
			{
				MessageBox.Show(Properties.Resources.TXT_SPECIFY_M2C_EXE);
				tabControl1.SelectTab(tabPage_settings);
			}
		}

		// SAVE
		private void toolStripMenu_save_Click(object sender, EventArgs e)
		{
			ref string PresetFilePath = ref CurveList[0].presetFilePath;
			if (PresetFilePath.Length > 0)
			{
				try
				{
					string CurveString = AllCurvesToString();
					File.WriteAllText(PresetFilePath, CurveString);

					RecentFile_Save(PresetFilePath);
					changesFalse();
				}
				catch (Exception ex) { MessageBox.Show("There was a Problem saving the Preset File!\r\n" + ex.Message); }
			}
			else
			{
				SavePresetFileDialog();
			}
		}

		// SAVE AS
		private void toolStripMenu_save_as_Click(object sender, EventArgs e)
		{
			SavePresetFileDialog();
		}

		// RELOAD
		private void ToolStripMenu_reloadPreset_Click(object sender, EventArgs e)
		{
			string PresetFile = CurveList[0].presetFilePath;
			if (CurveList.Count > 0 && File.Exists(PresetFile))
			{
				if (ChangesMade)
					switch (MessageBox.Show(this, "Recent Changes will be lost! Continue?", "Reload", MessageBoxButtons.YesNo))
					{
						case DialogResult.Yes:
							LoadPresetFromFilePath(PresetFile);
							break;

						default:
							break;
					}
				else LoadPresetFromFilePath(PresetFile);
			}
		}











		// =========== RECENT FILES LIST ===========

		// (vvvv big thanks to code and tutorial by Hannes DuPreez vvvv)
		// https://www.codeguru.com/dotnet/creating-a-most-recently-used-menu-list-in-net/
		Queue<string> MRUlist = new Queue<string>();

		private void RecentFile_Save(string strPath)
		{
			toolStripMenu_MRU2.DropDownItems.Clear();

			RecentList_Load();

			if (!(MRUlist.Contains(strPath)))

				MRUlist.Enqueue(strPath);

			while (MRUlist.Count > 5)

				MRUlist.Dequeue();

			foreach (string strItem in MRUlist)
			{
				ToolStripMenuItem tsRecent = new ToolStripMenuItem(strItem, null, new EventHandler(RecentFile_Click));

				toolStripMenu_MRU2.DropDownItems.Add(tsRecent);
			}

			StreamWriter stringToWrite = new StreamWriter(System.Environment.CurrentDirectory + @"\GUIRecent.txt");

			foreach (string item in MRUlist)

				stringToWrite.WriteLine(item);

			stringToWrite.Flush();

			stringToWrite.Close();
		}

		private void RecentList_Load()
		{
			MRUlist.Clear();

			try
			{
				StreamReader srStream = new StreamReader(Environment.CurrentDirectory + @"\GUIRecent.txt");

				string strLine = "";

				while ((InlineAssignHelper(ref strLine, srStream.ReadLine())) != null)

					MRUlist.Enqueue(strLine);

				srStream.Close();
			}
			catch
			{
				//MessageBox.Show("There was a problem loading the Most Recent File List!");
			}
		}

		private static T InlineAssignHelper<T>(ref T target, T value)
		{
			target = value;
			return value;
		}

		private void RecentFile_Click(object sender, EventArgs e)
		{
			LoadPresetChangesDialog(sender.ToString());
		}

		private void RecentList_MenuSpread()
		{
			foreach (string item in MRUlist)
			{
				ToolStripMenuItem fileRecent = new ToolStripMenuItem(item, null, new EventHandler(RecentFile_Click));

				toolStripMenu_MRU2.DropDownItems.Add(fileRecent);
			}
		}
	}
}