using System;
using System.Collections.Generic;
using System.Windows.Forms;

// CURVE OBJECTS
// There can be multiple Curve Objects in one M2C preset file.
// This file contains the GUI elements and functions to control those Curve Objects.

// In spite of there being multiple curve objects, there can only be one input/output file per preset file!
// Input/output file paths and names are always stored in CurveList[0], which can not be removed.
// Each curve object can have its own path_corner map file attached though.

namespace Map2CurveGUI
{
	public partial class MainGUI : Form
	{
		List<CurveObject> CurveList = new List<CurveObject>();
		CurveObject SelCurveObj; // reference of currently selected curve object for editing
		int SelCurveID = 0;
		bool ChangeAll = false;

        // ADD/REMOVE CURVE OBJECT BUTTONS
        private void button_CurveObj_Add_Click(object sender, EventArgs e)
		{
			AddCurveObj();
			UpdatePresetTab();
		}

		private void button_CurveObj_Remove_Click(object sender, EventArgs e)
		{
			RemoveCurveObj();
			UpdatePresetTab();
		}

		private void button_CurveObj_Rename_Click(object sender, EventArgs e)
		{
			RenameCurveObj();
			UpdatePresetTab();
		}

		private void comboBox_CurveObj_SelectionChangeCommitted(object sender, EventArgs e)
		{
			LoadCurveObj(comboBox_CurveObj.SelectedIndex);
		}
		private void button_CurveObj_Clone_Click(object sender, EventArgs e)
		{
			AddCurveObj(true);
			UpdatePresetTab();
		}
		
        private void checkBox_CurveObj_ChangeAll_CheckedChanged(object sender, EventArgs e)
        {
			ChangeAll = checkBox_CurveObj_ChangeAll.Checked;
        }



		// NEXT/PREV CURVE OBJECT BUTTONS
		private void button_CurveObj_prev_Click(object sender, EventArgs e)
		{
			if (CurveList.Count > 1)
			{
				int sel = comboBox_CurveObj.SelectedIndex;
				sel -= 1;
				if (sel < 0) sel = 0;
				LoadCurveObj(sel);
				comboBox_CurveObj.SelectedIndex = sel;
			}
		}

		private void button_CurveObj_next_Click(object sender, EventArgs e)
		{
			if (CurveList.Count > 1)
			{
				int sel = comboBox_CurveObj.SelectedIndex;
				sel += 1;
				if (sel > CurveList.Count - 1) sel = CurveList.Count - 1;
				LoadCurveObj(sel);
				comboBox_CurveObj.SelectedIndex = sel;
			}
		}




		// CURVE OBJECT METHODS
		private void LoadCurveObj(int i)
		{
			if (CurveList.Count > 0)
			{
				SelCurveObj = CurveList[i];
                SelCurveID = i;
				bool TempChangeAll = ChangeAll;
				ChangeAll = false;

                // load box values
                bool UpdateFilePaths = true; if (i > 0) UpdateFilePaths = false;
				SetBoxValues(ref SelCurveObj, UpdateFilePaths);

				// check path_corner filepath
				if (tabControl1.SelectedTab.Name == "tabPage_path_corner")
				{
					CheckCornerFileValidity(SelCurveObj.cornerFilePath);
				}

				ChangeAll = TempChangeAll;
			}
		}

		private void AddCurveObj(bool cloneSelected = false)
		{
			int tCurves = CurveList.Count;
			if (tCurves <= 9)
			{
				string title = "";
				if (tCurves <= 0)
				{
					title = "Curve 1";
					CurveList.Add(new CurveObject(0, title));
				}
				else
				{
					int latestID = CurveList[tCurves - 1].curveObjID + 1;
					int newNumber = latestID + 1;
					title = "Curve " + newNumber.ToString();
					CurveList.Add(new CurveObject(latestID, title));
				}
				if(cloneSelected)
				{
					CurveList[CurveList.Count - 1].setAllTabs(ref SelCurveObj, true);
				}
				RefreshCurveList();

				int sel = CurveList.Count - 1;
				comboBox_CurveObj.SelectedIndex = sel;
				LoadCurveObj(sel);

				changesTrue();
			}
		}
		private void RemoveCurveObj()
		{
			int tCurves = CurveList.Count;
			if (tCurves > 1)
			{
				int sel = comboBox_CurveObj.SelectedIndex;
				if (sel > 0) // first Curve must not be deleted because it contains the input/output file paths
				{
					CurveList.RemoveAt(sel);
					RefreshCurveList();

					if (comboBox_CurveObj.Items.Count - 1 >= sel)
					{
						comboBox_CurveObj.SelectedIndex = sel;
						LoadCurveObj(sel);
					}
					else
					{
						comboBox_CurveObj.SelectedIndex = sel - 1;
						LoadCurveObj(sel - 1);
					}
					changesTrue();
				}
			}
		}
		private void RenameCurveObj()
		{
			int tCurves = CurveList.Count;
			if (tCurves > 0)
			{
				int sel = comboBox_CurveObj.SelectedIndex;
				string current = CurveList[sel].curveObjName;

				string newName = Prompt.ShowDialog("Please enter a new curve name:", "New Curve Name", current);
				if (newName.Length > 0 && newName != current)
				{
					CurveList[sel].curveObjName = newName;
					RefreshCurveList();
					comboBox_CurveObj.SelectedIndex = sel;
					changesTrue();
				}
			}
		}

		private void RefreshCurveList()
		{
			comboBox_CurveObj.DataSource = null;
			comboBox_CurveObj.DataSource = CurveList;
			comboBox_CurveObj.DisplayMember = "GetCurveName";
			//comboBox_CurveObj.SelectedIndex = i;
		}
	}



}