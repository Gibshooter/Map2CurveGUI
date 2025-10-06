using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Map2CurveGUI
{
	public partial class MainGUI : Form
	{
		// MEMBERS
		bool[] InputFilePath_Exists = { true, true, true };
		bool[] InputFilePath_Rooted = { false, false, false };
		bool SameDir = false;



		// ================================ INPUT OUTPUT FILES ================================

		// -------[ BUTTON ]------- SELECT INPUT FILE -------------------------------
		public void button_input_file_select_Click(object sender, EventArgs e)
		{
			Ookii.Dialogs.WinForms.VistaOpenFileDialog OF = new Ookii.Dialogs.WinForms.VistaOpenFileDialog();
			OF.Filter = "map files (*.map)|*.map";
			OF.InitialDirectory = DIR_ROOT;
			OF.RestoreDirectory = true;

			if (OF.ShowDialog(this) == DialogResult.OK)
			{
				// Update Settings and TextBox
				ref string ST_inPath = ref CurveList[0].inputFilePath;
				ref string ST_inName = ref CurveList[0].inputFilename;
				ref string ST_inFolder = ref CurveList[0].inputFolder;

				ST_inPath = OF.FileName;
				textBox_input_file.Text = OF.FileName;

				ST_inName = OF.FileName;           // C:\Folder\Filename.map

				int m = ST_inName.LastIndexOf(".map");      // C:\Folder\Filename[m].map
				ST_inName = ST_inName.Remove(m);                // C:\Folder\Filename
				int bs = ST_inName.LastIndexOf("\\");        // C:\Folder[bs]\Filename
				ST_inFolder = ST_inName.Substring(0, bs);         // C:\Folder
				ST_inName = ST_inName.Substring(bs + 1);          // Filename

				if (textBox_output_file_name.Text.Length == 0)
				{
					textBox_output_file_name.Text = ST_inName + "_curved";
					CurveList[0].outputFilename = ST_inName + "_curved";
				}
				if (textBox_output_folder.Text.Length == 0)
				{
					textBox_output_folder.Text = ST_inFolder;
					CurveList[0].outputFolder = ST_inFolder;
				}

				// Update Settings Tab
				UpdatePresetTab();

				// reset bg color
				textBox_input_file.BackColor = ColEmpty;
				textBox_output_folder.BackColor = ColEmpty;

				CheckPathValidity(new int[] { 0 });
				CheckInOutFilenames();

				changesTrue();
			}
		}

		// -------[ BUTTON ]------- OUTPUT FOLDER -------------------------------
		private void button_output_folder_select_Click(object sender, EventArgs e)
		{
			Ookii.Dialogs.WinForms.VistaFolderBrowserDialog ChooseFolder = new Ookii.Dialogs.WinForms.VistaFolderBrowserDialog();

			if (ChooseFolder.ShowDialog(this) == DialogResult.OK)
			{
				string selectedFolder = ChooseFolder.SelectedPath;

				// Update Settings and TextBox
				CurveList[0].outputFolder = selectedFolder;
				textBox_output_folder.Text = selectedFolder;

				// Update Settings Tab
				UpdatePresetTab();

				// reset bg colors
				textBox_output_folder.BackColor = DefaultBackColor;

				CheckPathValidity(new int[] { 1 });
				CheckInOutFilenames();

				changesTrue();
			}
		}


		// -------[ TEXTBOX ]------- OUTPUT FILE NAME -------------------------------
		private void textBox_output_file_name_Leave(object sender, EventArgs e)
		{
			string temp = textBox_output_file_name.Text;

			// cut extension if found and name has at least 5 characters
			temp = temp.Trim();
			string temp_stripped = temp;

			string[] ext = { ".map", ".rmf", ".obj" };
			if (temp.Length > 4)
			{
				for (int i = 0; i < 3; i++)
				{
					if (temp.EndsWith(ext[i])) { temp_stripped = temp.Substring(0, temp.Length - 4); break; }
				}
			}

			// check if output name is same as inputname, abort if positive
			if (temp_stripped != CurveList[0].outputFilename && temp_stripped != CurveList[0].inputFilename && temp_stripped.Length > 0)
			{
				//MessageBox.Show("New Output File ("+ temp_stripped + ") Name\r\nis different than before ("+ CurveList[0].outputFilename + ")! Changes were made!");
				CurveList[0].outputFilename = temp_stripped;
				textBox_output_file_name.Text = temp_stripped;

				// Update Settings Tab
				UpdatePresetTab();

				CheckInOutFilenames();
				changesTrue();
			}
			else
			{
				textBox_output_file_name.Text = CurveList[0].outputFilename;
				CheckInOutFilenames();
			}
		}

		// -------[ METHOD ]------- SAME FILENAME CHECK -------------------------------
		private bool CheckInOutFilenames()
		{
			Color TempCol = textBox_output_file_name.BackColor;
			if (CurveList[0].inputFilename == textBox_output_file_name.Text)
			{
				textBox_output_file_name.BackColor = ColBGError;
				return false;
			}
			else
			{
				textBox_output_file_name.BackColor = TempCol;
				return true;
			}
		}




		// ================================ Check FILES ================================

		// METHOD: SAME ROOT DIR
		private void CheckSameDIR_ROOT()
		{
			if (DIR_M2C == DIR_ROOT) SameDir = true; else SameDir = false;
			//MessageBox.Show("SameDirCheck:\r\nDIR_M2C: " + DIR_M2C + "\r\nDIR_ROOT: " + DIR_ROOT + "\r\nSameDir: " + SameDir);
		}

		// METHOD: CHECK PATHS
		private bool CheckPathValidity(int[] Candies)
		{
			Color[] TempCols = { textBox_input_file.BackColor, textBox_output_folder.BackColor, textBox_output_file_name.BackColor };

			bool b1 = true, b2 = true, b3 = true;
			string[] FilePathRooted = { "", "", "" };
			string[] FilePaths = { CurveList[0].inputFilePath, CurveList[0].outputFolder, SelCurveObj.cornerFilePath };

			// Path is rooted
			for (int i = 0; i < 3; i++)
			{
				if (ProcessIndex(i, Candies))
				{
					if (Path.IsPathRooted(FilePaths[i])) InputFilePath_Rooted[i] = true;
					else InputFilePath_Rooted[i] = false;
				}
			}

			// complete non-rooted file path IF GUI.exe is not located in same dir as M2C.exe
			for (int i = 0; i < 3; i++)
			{
				if (ProcessIndex(i, Candies))
				{
					if (!InputFilePath_Rooted[i] && FilePaths[i].Length > 0)
					{
						FilePathRooted[i] = Path.Combine(DIR_M2C, FilePaths[i]);
					}
					else
					{
						FilePathRooted[i] = FilePaths[i];
					}
				}
			}

			bool R = true;
			// File/Folder exists
			for (int i = 0; i < 3; i++)
			{
				if (ProcessIndex(i, Candies))
				{
					if (i == 0 || i == 2)
					{
						InputFilePath_Exists[i] = File.Exists(FilePathRooted[i]);
						if (InputFilePath_Exists[i])
						{
							// always use rooted file paths if M2CGUI!=M2C folder
							if (!SameDir)
							{
								if (i == 0)
								{
									CurveList[0].inputFilePath = FilePathRooted[i];
									textBox_input_file.Text = FilePathRooted[i];
									if (!InputFilePath_Rooted[i]) { R = false; }
								}
								else if (i == 2)
								{
									SelCurveObj.cornerFilePath = FilePathRooted[i];
									textBox_splinefile.Text = FilePathRooted[i];
									if (!InputFilePath_Rooted[i]) { R = false; }
								}
							}
							// ... otherwise use original unrooted file paths
							else
							{
								if (i == 0)
								{
									CurveList[0].inputFilePath = FilePaths[i];
									textBox_input_file.Text = FilePaths[i];
								}
								else if (i == 2)
								{
									SelCurveObj.cornerFilePath = FilePaths[i];
									textBox_splinefile.Text = FilePaths[i];
								}
							}
						}
					}
					else if (i == 1)
					{
						InputFilePath_Exists[i] = Directory.Exists(FilePathRooted[i]);
						if (InputFilePath_Exists[i])
						{
							if (!SameDir)
							{
								CurveList[0].outputFolder = FilePathRooted[i];
								textBox_output_folder.Text = FilePathRooted[i];
								if (!InputFilePath_Rooted[i]) { R = false; }
							}
							else
							{
								CurveList[0].outputFolder = FilePaths[i];
								textBox_output_folder.Text = FilePaths[i];
							}
						}
					}
				}
			}
			if (!R)
			{
				changesTrue();
				MessageBox.Show("Relative File Paths were converted to absolute.\r\nPlease save these changes!");
			}

			// INPUT FILE
			if (!InputFilePath_Exists[0] && ProcessIndex(0, Candies))
			{
				b1 = false;
				textBox_input_file.BackColor = ColBGError;
			}
			else { textBox_input_file.BackColor = TempCols[0]; }

			// OUTPUT FOLDER
			if (!InputFilePath_Exists[1] && ProcessIndex(1, Candies))
			{
				b2 = false;
				textBox_output_folder.BackColor = ColBGError;
			}
			else { textBox_output_folder.BackColor = TempCols[1]; }

			// PATH_CORNER FILE
			if (!InputFilePath_Exists[2] && ProcessIndex(2, Candies) && FilePathRooted[2] != "UNSET" && FilePathRooted[2] != "")
			{
				b3 = false;
				textBox_splinefile.BackColor = ColBGError;
			}
			else { textBox_splinefile.BackColor = TempCols[2]; }

			if (!b1 || !b2 || !b3)
				return false;
			else
				return true;
		}

		private bool ProcessIndex(int i, int[] Candies)
		{
			foreach (int c in Candies)
			{
				if (i == c) return true;
			}
			return false;
		}


		// ================================ OPEN IN EXPLORER / EDITOR ================================


		// -------[ BUTTON ]------- INPUT FILE to EDITOR -------------------------------
		private void button_OpenInputFileInEditor_Click(object sender, EventArgs e)
		{
			string FilePath = CurveList[0].inputFilePath;
			if (!InputFilePath_Rooted[0]) FilePath = Path.Combine(DIR_M2C, CurveList[0].inputFilePath);

			sendMapFileToEditor(FilePath, false);
		}


		// -------[ BUTTON ]------- OUTPUT FILE to EDITOR -------------------------------
		private void button_OpenOutputFileInEditor_Click(object sender, EventArgs e)
		{
			string FilePath = Path.Combine(CurveList[0].outputFolder, CurveList[0].outputFilename);
			if (!InputFilePath_Rooted[0]) FilePath = Path.Combine(DIR_M2C, FilePath);

			sendMapFileToEditor(FilePath, true);
		}


		// -------[ BUTTON ]------- OUTPUT FOLDER to EXPLORER -------------------------------
		private void button_OpenOutputFolderInExplorer_Click(object sender, EventArgs e)
		{
			string FilePath = CurveList[0].outputFolder;
			if (!InputFilePath_Rooted[0]) FilePath = Path.Combine(DIR_M2C, CurveList[0].outputFolder);

			openFolderInExplorer(FilePath);
		}


		// -------[ METHOD ]------- OPEN MAP/RMF IN EDITOR -------------------------------
		public void sendMapFileToEditor(string output, bool AddExt)
		{
			try
			{
				if (AddExt)
					if (CurveList[0].map)
					{
						output += ".map";
					}
					else if (CurveList[0].rmf)
					{
						output += ".rmf";
					}

				// Call Editor.Exe
				//MessageBox.Show("output: " + output);
				if (File.Exists(output))
				{
					Process.Start(textBox_Editor_exe_path.Text, "\"" + output + "\"");
				}
				else
				{
					MessageBox.Show("The Map File you are trying to open does not exist!");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}


		// -------[ METHOD ]------- OPEN FOLDER IN EXPLORER -------------------------------
		public void openFolderInExplorer(string folderPath)
		{
			if (Directory.Exists(folderPath))
				Process.Start(folderPath);
			else MessageBox.Show("The directory you are trying to open does not exist!");
		}



	}
}