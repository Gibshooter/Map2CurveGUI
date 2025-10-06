using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Map2CurveGUI
{
	public partial class MainGUI : Form
	{
		// ====================== MEMBERS ======================
		List<string> WADList = new List<string>();
		string WADFilePath = "";




		// ====================== LOAD WAD LIST ON GUI START ======================
		private void LoadWADList()
		{
			WADFilePath = Path.Combine(DIR_M2C, "WAD", "WADList.txt");

			if (File.Exists(WADFilePath))
			{
				if (WADList.Count > 0) WADList.Clear();

				var lines = File.ReadAllLines(WADFilePath);
				for (int i = 0; i < lines.Length; i++)
				{
					string line = lines[i];
					line = line.Trim();

					// Add this Path to WAD List if WAD-File exists and is not a comment
					if (!line.StartsWith("//") && File.Exists(line))
					{
						WADList.Add(line);
					}
				}
				listBox_WAD_list.DataSource = WADList;
			}
		}






		// ====================== WAD TAB ======================


		// ------ [  BUTTON  ] ------ REMOVE --------------------------
		private void button_WAD_remove_Click(object sender, EventArgs e)
		{
			int selected = listBox_WAD_list.SelectedIndices.Count;
			if (selected > 0)
			{
				for (int i = selected - 1; i >= 0; i--)
				{
					int ci = listBox_WAD_list.SelectedIndices[i];
					WADList.RemoveAt(ci);
				}
				listBox_WAD_list.DataSource = null;
				listBox_WAD_list.DataSource = WADList;
				SaveWADFile();
			}
		}


		// ------ [  BUTTON  ] ------ ADD --------------------------
		private void button_WAD_add_Click(object sender, EventArgs e)
		{
			if (File.Exists(textBox_M2C_exe_path.Text))
				try
				{
					Ookii.Dialogs.WinForms.VistaOpenFileDialog OpenFile = new Ookii.Dialogs.WinForms.VistaOpenFileDialog();
					OpenFile.Filter = "WAD Files (*.wad)|*.wad";
					OpenFile.Multiselect = true;

					if (OpenFile.ShowDialog(this) == DialogResult.OK)
					{
						foreach (string NewWAD in OpenFile.FileNames)
						{
							// check if new WAD is already in List
							bool duplicate = false;
							foreach (string OldWAD in WADList)
							{
								if (NewWAD == OldWAD) { duplicate = true; break; }
							}
							if (!duplicate) WADList.Add(NewWAD);
						}
						listBox_WAD_list.DataSource = null;
						listBox_WAD_list.DataSource = WADList;
						SaveWADFile();
					}
				}
				catch (Exception ex) { MessageBox.Show("There was a problem saving the WAD List!\r\n" + ex.Message); }
		}


		// ------ [  BUTTON  ] ------ SAVE --------------------------
		private void SaveWADFile()
		{
			string M2CFile = textBox_M2C_exe_path.Text;
			if (Directory.Exists(DIR_M2C) && WADFilePath.Length > 0)
			{
				// Add basic info text again
				string WADString = @"// Here you can put any WAD files you are using in your maps." + "\r\n";
				WADString += @"// Use absolute paths only!" + "\r\n";
				WADString += @"// Example:" + "\r\n";
				WADString += @"// C:\SteamLibrary\steamapps\common\Half-Life\valve\halflife.wad" + "\r\n\r\n";
				WADString += @"// Alternatively you can place a copy of the actual WAD-file in the WAD dir." + "\r\n\r\n";

				foreach (string WADFile in WADList)
				{
					WADString += WADFile + "\r\n";
				}
				File.WriteAllText(WADFilePath, WADString);
			}
		}




	}
}