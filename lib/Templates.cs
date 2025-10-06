using Map2CurveGUI.Properties;
using Map2CurveGUI;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;


namespace Map2CurveGUI
{
	public class Template
	{
		public string Name;
		public string Description;
		public string FilePath;
		public int FrameType;
		public Bitmap ImgPreview;
		public Bitmap ImgPreview2;
		public Bitmap ImgSource;

		public Template() { }
		public Template(string name, string desc, string path, int type, Bitmap img_pre, Bitmap img_pre2, Bitmap img_src)
		{
			Name = name;
			Description = desc;
			FilePath = path;
			FrameType = type;
			ImgPreview = img_pre;
			ImgPreview2 = img_pre2;
			ImgSource = img_src;
		}
	}

	public partial class MainGUI : Form
	{
		List<Template> TempList = new List<Template>();

		private void CreateTemplateList()
		{
            TempList.Add(
                new Template(
                    "Concrete Walk",
                    Resources.TXT_TEMP_ConcreteWalk,
                    "Templates\\ConcreteWalk\\ConcreteWalk.txt",
                    0,
                    Resources.Temp_ConcreteWalk_Preview_1,
                    Resources.Temp_ConcreteWalk_Preview_2,
                    Resources.Temp_ConcreteWalk_Source
                    )
                );
            TempList.Add(
				new Template(
					"Rail Tunnel",
					Resources.TXT_TEMPLATE_1,
					"Templates\\RailTunnel\\RailTunnel.txt",
					0,
					Resources.Wizard_Circle_Texmode0_2,
					Resources.Wizard_Circle_Texmode0,
					Resources.Wizard_Circle_Texmode0_Input
					)
				);
			TempList.Add(
				new Template(
					"Black Mesa Panel",
					Resources.TXT_TEMPLATE_2,
					"Templates\\BlackMesaPanel\\BlackMesaPanel.txt",
					0,
					Resources.Wizard_Circle_Texmode1_2,
					Resources.Wizard_Circle_Texmode1,
					Resources.Wizard_Circle_Texmode1_Input
					)
				);
			TempList.Add(
				new Template(
					"80s Server",
					Resources.TXT_TEMPLATE_3,
					"Templates\\80sServer\\80sServer.txt",
					0,
					Resources.Wizard_Duplicate_2,
					Resources.Wizard_Duplicate,
					Resources.Wizard_Duplicate_input
					)
				);
			TempList.Add(
				new Template(
					"Rock Terrain",
					Resources.TXT_TEMPLATE_4,
					"Templates\\RockTerrain\\RockTerrain.txt",
					2,
					Resources.Wizard_PathCorner0_2,
					Resources.Wizard_PathCorner0,
					Resources.Wizard_PathCorner0_Input
					)
				);
			TempList.Add(
				new Template(
					"Xen Bio Wall",
					Resources.TXT_TEMPLATE_5,
					"Templates\\XenBioWall\\XenBioWall.txt",
					3,
					Resources.Wizard_PathCorner1_2,
					Resources.Wizard_PathCorner1,
					Resources.Wizard_PathCorner1_Input
					)
				);
			TempList.Add(
				new Template(
					"Reinforced Arc",
					"...",
					"Templates\\ReinforcedArc\\ReinforcedArc.txt",
					0,
					Resources.Tutorial_Detail_1,
					Resources.Tutorial_Detail_1,
					Resources.HowTo_Detail_2_1
					)
				);
			TempList.Add(
				new Template(
					"Composition",
					"...",
					"Templates\\Composition\\Composition1.txt",
					0,
					Resources.Temp_Composition_Preview,
					Resources.Temp_Composition_Preview,
					Resources.Temp_Composition_Source
					)
				);
			TempList.Add(
				new Template(
					"Deco Bridge",
					"...",
					"Templates\\DecoBridge\\DecoBridge.txt",
					0,
					Resources.Temp_DecoBridge_Preview,
					Resources.Temp_DecoBridge_Preview,
					Resources.Temp_DecoBridge_Source
					)
				);
			TempList.Add(
				new Template(
					"Deco Bridge Ramp",
					"...",
					"Templates\\DecoBridge\\DecoBridgeRamp.txt",
					0,
					Resources.Temp_DecoBridgeRamp_Preview,
					Resources.Temp_DecoBridgeRamp_Preview,
					Resources.Temp_DecoBridge_Source
					)
				);
			TempList.Add(
				new Template(
					"Lab Hallway",
					"...",
					"Templates\\LabHallway\\LabHallway.txt",
					0,
					Resources.Temp_LabHallway_Preview,
					Resources.Temp_LabHallway_Preview,
					Resources.Temp_LabHallway_Source
					)
				);
			TempList.Add(
				new Template(
					"Lab Hallway II",
					"...",
					"Templates\\LabHallway2\\LabHallway2.txt",
					0,
					Resources.Temp_LabHallway2_Preview,
					Resources.Temp_LabHallway2_Preview,
					Resources.Temp_LabHallway2_Source
					)
				);
			TempList.Add(
				new Template(
					"Pipe Shaft",
					"...",
					"Templates\\PipeShaft\\PipeShaft.txt",
					0,
					Resources.Temp_PipeShaft_Preview,
					Resources.Temp_PipeShaft_Preview,
					Resources.Temp_PipeShaft_Source
					)
				);
			TempList.Add(
				new Template(
					"Rail Tunnel II",
					"...",
					"Templates\\RailTunnel2\\RailTunnel2.txt",
					0,
					Resources.Temp_RailTunnel2_Preview,
					Resources.Temp_RailTunnel2_Preview,
					Resources.Temp_RailTunnel2_Source
					)
				);
			TempList.Add(
				new Template(
					"Tech Bridge",
					"...",
					"Templates\\TechBridge\\TechBridge.txt",
					0,
					Resources.Temp_TechBridge_Preview,
					Resources.Temp_TechBridge_Preview,
					Resources.Temp_TechBridge_Source
					)
				);
			TempList.Add(
				new Template(
					"Tech Chamber",
					"...",
					"Templates\\TechChamber\\TechChamber.txt",
					0,
					Resources.Temp_TechChamber_Preview,
					Resources.Temp_TechChamber_Preview,
					Resources.Temp_TechChamber_Source
					)
				);
			TempList.Add(
				new Template(
					"Tech Pipe Hollow",
					"...",
					"Templates\\TechPipeHollow\\TechPipeHollow.txt",
					0,
					Resources.Temp_TechPipeHollow_Preview,
					Resources.Temp_TechPipeHollow_Preview,
					Resources.Temp_TechPipeHollow_Source
					)
				);
			TempList.Add(
				new Template(
					"Water Pipe Ramped",
					"...",
					"Templates\\WaterPipe\\WaterPipeRamp.txt",
					0,
					Resources.Temp_WaterPipe_Preview,
					Resources.Temp_WaterPipe_Preview,
					Resources.Temp_WaterPipe_Source
					)
				);
			TempList.Add(
				new Template(
					"Xen Alley",
					"...",
					"Templates\\XenAlley\\XenAlley.txt",
					2,
					Resources.Temp_XenAlley_Preview,
					Resources.Temp_XenAlley_Preview,
					Resources.Temp_XenAlley_Source
					)
				);
            TempList.Add(
                new Template(
                    "Squeaky Rail",
                    "...",
                    "Templates\\SqueakyRail\\SqueakyRail.txt",
                    3,
                    Resources.Temp_SqueakyRail_Preview,
                    Resources.Temp_SqueakyRail_Preview,
                    Resources.Temp_SqueakyRail_Source
                    )
                );

            int i = 0;
			foreach (Template Temp in TempList)
			{
				var lvi = new ListViewItem();
				lvi.Text = Temp.Name;
				lvi.SubItems.Add(Temp.FrameType.ToString());
				lvi.SubItems.Add(Temp.FilePath);
				lvi.ImageIndex = i;
				listView_templates.Items.Add( lvi );
				i++;
			}
		}

		private void pictureBox_tempL_MouseOver(object sender, EventArgs e)
		{
			if (listView_templates.SelectedIndices.Count > 0) {
				int sel = listView_templates.SelectedIndices[0];
				if (sel != -1) { pictureBox_tempL.Image = TempList[sel].ImgPreview2; }
			}
		}

		private void pictureBox_tempL_MouseLeave(object sender, EventArgs e)
		{
			if (listView_templates.SelectedIndices.Count > 0)
			{
				int sel = listView_templates.SelectedIndices[0];
				if (sel != -1) { pictureBox_tempL.Image = TempList[sel].ImgPreview; }
			}
		}


		private void template_list_select(object sender, EventArgs e)
		{
			var listView = (System.Windows.Forms.ListView)sender;
			if(listView.SelectedIndices.Count>0) {
				int sel = listView.SelectedIndices[0];
				if (sel != -1) {
					pictureBox_tempL.Image = TempList[sel].ImgPreview;
					pictureBox_tempR.Image = TempList[sel].ImgSource;
					label_temp.Text = TempList[sel].Description;
					label_temp_name.Text = TempList[sel].Name;
					string[] frametype = { "Circle Pi", "Circle Grid", "Path Extrusion Simple", "Path Extrusion Precise" };
					label_temp_type.Text = frametype[TempList[sel].FrameType];
					label_temp_path.Text = TempList[sel].FilePath;
				}
			}
		}

		private void button_temp_Load_Click(object sender, EventArgs e)
		{
			var LV = (System.Windows.Forms.ListView)listView_templates;
			if (LV.SelectedIndices.Count > 0) {
				string path = Path.Combine(DIR_M2C, TempList[LV.SelectedIndices[0]].FilePath);
				LoadPresetChangesDialog(path);
			}
		}


		// menu strip template buttons

		private void button_template_Click(object sender, EventArgs e)
		{
			var btn = (System.Windows.Forms.ToolStripMenuItem)sender;
			if (btn.Name == "templatesToolStripMenuItem") {
				tabControl1.SelectedTab = tabControl1.TabPages[8];
			}
			else {
				int i = int.Parse(Char.ToString(btn.Name[19]));
				tabControl1.SelectedTab = tabControl1.TabPages[8];
				listView_templates.Items[i].Selected = true;
				listView_templates.Select();
			}
		}
	}
}