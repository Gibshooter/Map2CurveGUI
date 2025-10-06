using Map2CurveGUI;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;


namespace Map2CurveGUI
{

	// RENAME CURVE PROMPT DIALOG
	public static class Prompt
	{
		public static string ShowDialog(string text, string caption, string current)
		{
			Form prompt = new Form()
			{
				Width = 250,
				Height = 150,
				FormBorderStyle = FormBorderStyle.FixedDialog,
				Text = caption,
				StartPosition = FormStartPosition.CenterScreen,
				MinimizeBox = false,
				MaximizeBox = false
			};
			Label textLabel = new Label() { Left = 20, Top = 20, Text = text };
			TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 200 };
			Button confirmation = new Button() { Text = "Ok", Left = 65, Width = 50, Top = 75, DialogResult = DialogResult.OK };
			textBox.Text = current;
			textBox.MaxLength = 20;
			confirmation.Click += (sender, e) => { prompt.Close(); };
			prompt.Controls.Add(textBox);
			prompt.Controls.Add(confirmation);
			prompt.Controls.Add(textLabel);
			prompt.AcceptButton = confirmation;

			return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
		}
	}



    public enum cVar
    {
		// NULL
		NULL = 0,

		// string
        cornerFilePath,
        nulltex,

		// float
        rad,
        offset,
        height,
        p_expand,
        range_start,
        range_end,
        spike_height,
        hshiftoffset,
        scale,
        scale_src,
        d_pos,
        hstretchamt,
        rot_x,
        rot_y,
        rot_z,
        rot_src_x,
        rot_src_y,
        rot_src_z,
        move_x,
        move_y,
        move_z,
        p_scale_x,
        p_scale_y,
        p_scale_z,
        d_pos_rand_mm_min,
        d_pos_rand_mm_max,
        d_rotz_rand_mm_min,
        d_rotz_rand_mm_max,
        d_movey_rand_mm_min,
        d_movey_rand_mm_max,
        d_scale_rand_mm_min,
        d_scale_rand_mm_max,
        gridsize_x,
        gridsize_y,
        gridsize_z,
        gaplen,

		// int
        res,
        type,
        shift,
        ramptex,
        bounds,
        heightmode,
        texmode,
        hshiftsrc,
        d_draw,
        d_skip,
        mapcarve,

		// bool
        skipnull,
        obj,
        map,
        rmf,
        tri,
        round,
        ramp,
        append,
        transit_tri,
        transit_round,
        hstretch,
        flatcircle,
        c_enable,
        p_cornerfix,
        p_reverse,
        p_split,
        p_evenout,
        d_enable,
        d_autoyaw,
        d_autopitch,
        d_separate,
        d_autoname,
        d_draw_rand,
        d_carve,
        d_autoassign,
        d_circlemode,
        d_pos_rand,
        d_rotz_rand,
        d_movey_rand,
        d_scale_rand,
        gaps,
        mirror_x,
        mirror_y,
        mirror_z,
        mirror_src_x,
        mirror_src_y,
        mirror_src_z
    }


    public class CurveObject
	{
		public int curveObjID			= 0;
		public string curveObjName		= "";

		public string presetFileName	= "";
		public string presetFilePath	= "";

		public string outputFilename	= "";
		public string outputFolder		= "";

		public string inputFilePath		= "";
		public string inputFilename		= "";
		public string inputFolder		= "";

		public string cornerFilePath	= "";
		public string nulltex			= "NULL";
		public float rad				= 0;
		public float offset				= 0;
		public float height				= 0;
		public float p_expand			= 0;
		public float range_start		= 0;
		public float range_end			= 100;
		public float spike_height		= 4;
		public float hshiftoffset		= 0;
		public float scale				= 0;
		public float scale_src			= 0;
		public float d_pos				= 0.5f;
		public float hstretchamt		= 0;
		public float[] rot				= new float[] { 0, 0, 0 };
		public float[] rot_src			= new float[] { 0, 0, 0 };
		public float[] move				= new float[] { 0, 0, 0 };
		public float[] p_scale			= new float[] { 0, 0, 0 };
		public float[] d_pos_rand_mm	= new float[] { 0, 0 };
		public float[] d_rotz_rand_mm	= new float[] { 0, 0 };
		public float[] d_movey_rand_mm	= new float[] { 0, 0 };
		public float[] d_scale_rand_mm	= new float[] { 0, 0 };
		public float[] gridsize			= new float[] { 1, 1, 1 };
		public float gaplen				= 256;

		public int res					= 8;
		public int type					= 0;
		public int shift				= 5;
		public int ramptex				= 0;
		public int bounds				= 0;
		public int heightmode			= 0;
		public int texmode				= 0;
		public int hshiftsrc			= 1;
		public int d_draw				= 0;
		public int d_skip				= 0;
		public int mapcarve				= 0;

		public bool skipnull			= false;
		public bool obj					= false;
		public bool map					= false;
		public bool rmf					= true;
		public bool tri					= false;
		public bool round				= false;
		public bool ramp				= false;
		public bool append				= false;
		public bool transit_tri			= false;
		public bool transit_round		= false;
		public bool hstretch			= false;
		public bool flatcircle			= false;
		public bool c_enable			= true;
		public bool p_cornerfix			= false;
		public bool p_reverse			= false;
		public bool p_split				= false;
		public bool p_evenout			= false;
		public bool d_enable			= true;
		public bool d_autoyaw			= true;
		public bool d_autopitch			= true;
		public bool d_separate			= false;
		public bool d_autoname			= false;
		public bool d_draw_rand			= false;
		public bool d_carve				= false;
		public bool d_autoassign		= false;
		public bool d_circlemode		= false;
		public bool d_pos_rand			= false;
		public bool d_rotz_rand			= false;
		public bool d_movey_rand		= false;
		public bool d_scale_rand		= false;
		public bool gaps				= false;
		public bool[] mirror			= new bool[] { false, false, false };
		public bool[] mirror_src		= new bool[] { false, false, false };


		public void setCurveValues(cVar Val, ref object sender, string S)
		{
            // strings
            switch (Val)
            {
				case cVar.cornerFilePath:	cornerFilePath	= S; break;
                case cVar.nulltex:			nulltex			= S; break;
            }
        }

		public void setCurveValues(cVar Val, ref object sender, bool B )
		{
			// bool
            switch (Val)
            {
                case cVar.skipnull:			skipnull		= B; break;
                case cVar.obj:				obj				= B; break;
				case cVar.map:				map				= B; break;
                case cVar.rmf:				rmf				= B; break;
                case cVar.tri:				tri				= B; break;
                case cVar.round:			round			= B; break;
                case cVar.ramp:				ramp			= B; break;
                case cVar.append:			append			= B; break;
                case cVar.transit_tri:		transit_tri		= B; break;
                case cVar.transit_round:	transit_round	= B; break;
                case cVar.hstretch:			hstretch		= B; break;
                case cVar.flatcircle:		flatcircle		= B; break;
                case cVar.c_enable:			c_enable		= B; break;
                case cVar.p_cornerfix:		p_cornerfix		= B; break;
                case cVar.p_reverse:		p_reverse		= B; break;
                case cVar.p_split:			p_split			= B; break;
                case cVar.p_evenout:		p_evenout		= B; break;
                case cVar.d_enable:			d_enable		= B; break;
                case cVar.d_autoyaw:		d_autoyaw		= B; break;
                case cVar.d_autopitch:		d_autopitch		= B; break;
                case cVar.d_separate:		d_separate		= B; break;
                case cVar.d_autoname:		d_autoname		= B; break;
                case cVar.d_draw_rand:		d_draw_rand		= B; break;
                case cVar.d_carve:			d_carve			= B; break;
                case cVar.d_autoassign:		d_autoassign	= B; break;
                case cVar.d_circlemode:		d_circlemode	= B; break;
                case cVar.d_pos_rand:		d_pos_rand		= B; break;
                case cVar.d_rotz_rand:		d_rotz_rand		= B; break;
                case cVar.d_movey_rand:		d_movey_rand	= B; break;
                case cVar.d_scale_rand:		d_scale_rand	= B; break;
                case cVar.gaps:				gaps			= B; break;
                case cVar.mirror_x:			mirror[0]		= B; break;
                case cVar.mirror_y:			mirror[1]		= B; break;
                case cVar.mirror_z:			mirror[2]		= B; break;
                case cVar.mirror_src_x:		mirror_src[0]	= B; break;
                case cVar.mirror_src_y:		mirror_src[1]	= B; break;
                case cVar.mirror_src_z:		mirror_src[2]	= B; break;
            }
        }

		public void setCurveValues(cVar Val, ref object sender, int I)
        {
            // int
            switch (Val)
            {
                case cVar.res:					res					= I; break;
                case cVar.type:					type				= I; break;
                case cVar.shift:				shift				= I; break;
                case cVar.ramptex:				ramptex				= I; break;
                case cVar.bounds:				bounds				= I; break;
                case cVar.heightmode:			heightmode			= I; break;
                case cVar.texmode:				texmode				= I; break;
                case cVar.hshiftsrc:			hshiftsrc			= I; break;
                case cVar.d_draw:				d_draw				= I; break;
                case cVar.d_skip:				d_skip				= I; break;
                case cVar.mapcarve:				mapcarve			= I; break;
            }
        }

		public void setCurveValues(cVar Val, ref object sender, float F)
		{
            // float
            switch (Val)
            {
                case cVar.rad:					rad					= F; break;
				case cVar.offset:				offset				= F; break;
				case cVar.height:				height				= F; break;
				case cVar.p_expand:				p_expand			= F; break;
				case cVar.range_start:			range_start			= F; break;
				case cVar.range_end:			range_end			= F; break;
				case cVar.spike_height:			spike_height		= F; break;
				case cVar.hshiftoffset:			hshiftoffset		= F; break;
				case cVar.scale:				scale				= F; break;
				case cVar.scale_src:			scale_src			= F; break;
				case cVar.d_pos:				d_pos				= F; break;
				case cVar.hstretchamt:			hstretchamt			= F; break;
				case cVar.rot_x:				rot[0]				= F; break;
                case cVar.rot_y:				rot[1]				= F; break;
                case cVar.rot_z:				rot[2]				= F; break;
                case cVar.rot_src_x:			rot_src[0]			= F; break;
                case cVar.rot_src_y:			rot_src[1]			= F; break;
                case cVar.rot_src_z:			rot_src[2]			= F; break;
                case cVar.move_x:				move[0]				= F; break;
                case cVar.move_y:				move[1]				= F; break;
                case cVar.move_z:				move[2]				= F; break;
                case cVar.p_scale_x:			p_scale[0]			= F; break;
                case cVar.p_scale_y:			p_scale[1]			= F; break;
                case cVar.p_scale_z:			p_scale[2]			= F; break;
                case cVar.d_pos_rand_mm_min:	d_pos_rand_mm[0]	= F; break;
                case cVar.d_pos_rand_mm_max:	d_pos_rand_mm[1]	= F; break;
                case cVar.d_rotz_rand_mm_min:	d_rotz_rand_mm[0]	= F; break;
                case cVar.d_rotz_rand_mm_max:	d_rotz_rand_mm[1]	= F; break;
                case cVar.d_movey_rand_mm_min:	d_movey_rand_mm[0]	= F; break;
                case cVar.d_movey_rand_mm_max:	d_movey_rand_mm[1]	= F; break;
                case cVar.d_scale_rand_mm_min:	d_scale_rand_mm[0]	= F; break;
                case cVar.d_scale_rand_mm_max:	d_scale_rand_mm[1]	= F; break;
                case cVar.gridsize_x:			gridsize[0]			= F; break;
                case cVar.gridsize_y:			gridsize[1]			= F; break;
                case cVar.gridsize_z:			gridsize[2]			= F; break;
                case cVar.gaplen:				gaplen				= F; break;
			}
        }

		public int PrintMirror(bool src)
		{
            // 0 = Off, 1 = X, 2 = Y, 3 = Z, 4 = XY, 5 = XZ, 6 = YZ, 7 = XYZ

            if (!src)
			{
				if		(mirror[0] == true  && mirror[1] == false && mirror[2] == false) return 1;
				else if (mirror[0] == false && mirror[1] == true  && mirror[2] == false) return 2;
				else if (mirror[0] == false && mirror[1] == false && mirror[2] == true ) return 3;
                else if (mirror[0] == true  && mirror[1] == true  && mirror[2] == false) return 4;
                else if (mirror[0] == true  && mirror[1] == false && mirror[2] == true)  return 5;
                else if (mirror[0] == false && mirror[1] == true  && mirror[2] == true)  return 6;
                else if (mirror[0] == true  && mirror[1] == true  && mirror[2] == true)  return 7;
                else return 0;
			}
			else
			{
                if		(mirror_src[0] == true && mirror_src[1] == false && mirror_src[2] == false)	 return 1;
                else if (mirror_src[0] == false && mirror_src[1] == true  && mirror_src[2] == false) return 2;
                else if (mirror_src[0] == false && mirror_src[1] == false && mirror_src[2] == true)  return 3;
                else if (mirror_src[0] == true  && mirror_src[1] == true  && mirror_src[2] == false) return 4;
                else if (mirror_src[0] == true  && mirror_src[1] == false && mirror_src[2] == true)  return 5;
                else if (mirror_src[0] == false && mirror_src[1] == true  && mirror_src[2] == true)  return 6;
                else if (mirror_src[0] == true  && mirror_src[1] == true  && mirror_src[2] == true)  return 7;
                else return 0;
            }
        }

		public void setAllTabs(ref CurveObject Curve, bool setCorner)
		{
			setTab1(ref Curve);
			setTab2(ref Curve);
			setTab3(ref Curve, setCorner);
			setTab4(ref Curve);
		}

		public void setTab1(ref CurveObject Curve)
		{
			// checkboxes
			append = Curve.append;
			map = Curve.map;
			rmf = Curve.rmf;
			obj = Curve.obj;
			c_enable = Curve.c_enable;

			// combo boxes
			type = Curve.type;
			heightmode = Curve.heightmode;
			texmode = Curve.texmode;
			shift = Curve.shift;
			hshiftsrc = Curve.hshiftsrc;
			bounds = Curve.bounds;
			mapcarve = Curve.mapcarve;

			// check boxes
			flatcircle = Curve.flatcircle;
			ramp = Curve.ramp;
			hstretch = Curve.hstretch;

			// textboxes numbers
			rad = Curve.rad;
			offset = Curve.offset;
			res = Curve.res;
			range_start = Curve.range_start;
			range_end = Curve.range_end;
			height = Curve.height;
			hshiftoffset = Curve.hshiftoffset;
			hstretchamt = Curve.hstretchamt;
		}

		public void setTab2(ref CurveObject Curve)
		{
			// textboxes strings
			nulltex = Curve.nulltex;

			// check boxes
			tri = Curve.tri;
			transit_tri = Curve.transit_tri;
			round = Curve.round;
			transit_round = Curve.transit_round;
			skipnull = Curve.skipnull;
			gaps = Curve.gaps;
			mirror[0] = Curve.mirror[0];
            mirror[1] = Curve.mirror[1];
            mirror[2] = Curve.mirror[2];
            mirror_src[0] = Curve.mirror_src[0];
            mirror_src[1] = Curve.mirror_src[1];
            mirror_src[2] = Curve.mirror_src[2];

            // textboxes numbers
            spike_height = Curve.spike_height;
			scale_src = Curve.scale_src;
			rot_src[0] = Curve.rot_src[0];
			rot_src[1] = Curve.rot_src[1];
			rot_src[2] = Curve.rot_src[2];
			scale = Curve.scale;
			rot[0] = Curve.rot[0];
			rot[1] = Curve.rot[1];
			rot[2] = Curve.rot[2];
			move[0] = Curve.move[0];
			move[1] = Curve.move[1];
			move[2] = Curve.move[2];
			gridsize[0] = Curve.gridsize[0];
			gridsize[1] = Curve.gridsize[1];
			gridsize[2] = Curve.gridsize[2];
			gaplen = Curve.gaplen;
		}

		public void setTab3(ref CurveObject Curve, bool setCorner)
		{
			// strings
			if (setCorner)
				cornerFilePath = Curve.cornerFilePath;

			// check boxes
			p_split = Curve.p_split;
			p_reverse = Curve.p_reverse;
			p_cornerfix = Curve.p_cornerfix;
			p_evenout = Curve.p_evenout;

			// textboxes numbers
			p_expand = Curve.p_expand;
			p_scale[0] = Curve.p_scale[0];
			p_scale[1] = Curve.p_scale[1];
			p_scale[2] = Curve.p_scale[2];
		}

		public void setTab4(ref CurveObject Curve)
		{
			// textboxes numbers
			d_draw = Curve.d_draw;
			d_skip = Curve.d_skip;
			d_pos = Curve.d_pos;

			// check boxes
			d_separate = Curve.d_separate;
			d_autoassign = Curve.d_autoassign;
			d_carve = Curve.d_carve;
			d_circlemode = Curve.d_circlemode;
			d_autopitch = Curve.d_autopitch;
			d_autoyaw = Curve.d_autoyaw;
			d_autoname = Curve.d_autoname;
			d_enable = Curve.d_enable;
			d_draw_rand = Curve.d_draw_rand;
			d_scale_rand = Curve.d_scale_rand;
			d_movey_rand = Curve.d_movey_rand;
			d_pos_rand = Curve.d_pos_rand;
			d_rotz_rand = Curve.d_rotz_rand;

			// textboxes numbers
			d_scale_rand_mm[0] = Curve.d_scale_rand_mm[0];
			d_scale_rand_mm[1] = Curve.d_scale_rand_mm[1];
			d_rotz_rand_mm[0] = Curve.d_rotz_rand_mm[0];
			d_rotz_rand_mm[1] = Curve.d_rotz_rand_mm[1];
			d_movey_rand_mm[0] = Curve.d_movey_rand_mm[0];
			d_movey_rand_mm[1] = Curve.d_movey_rand_mm[1];
			d_pos_rand_mm[0] = Curve.d_pos_rand_mm[0];
			d_pos_rand_mm[1] = Curve.d_pos_rand_mm[1];
		}

		private bool IsVectorSameAs(ref float[] array1, ref float[] array2)
		{
			for (int i = 0; i < 3; i++)
			{
				if (array1[i] != array2[i]) return false;
			}
			return true;
		}
		private bool IsVectorSameAs(ref bool[] array1, ref bool[] array2)
		{
			for (int i = 0; i < 3; i++)
			{
				if (array1[i] != array2[i]) return false;
			}
			return true;
		}

		private bool IsVector2SameAs(ref bool bool1, ref bool bool2, ref float[] array1, ref float[] array2)
		{
			if (bool1 != bool2) return false;
			for (int i = 0; i < 2; i++) if (array1[i] != array2[i]) return false;
			return true;
		}

		public string CurveObjectToString(int c, ref bool[,] Differs, bool ExportAll = false, bool IsFirst = false)
		{
			string CurveBuffer = "";
			if (IsFirst)
			{
				//CurveBuffer += "//inputFileName\t" + inputFilename + "\r\n";
				//CurveBuffer += "//inputFolder\t" + inputFolder + "\r\n";
				if (inputFilePath.Length > 0)
					CurveBuffer += "source\t\t\"" + inputFilePath + "\"\r\n";
				else
					CurveBuffer += "source\t\t" + "\"UNSET\"" + "\r\n";

				if (outputFolder.Length > 0 && outputFilename.Length > 0)
					CurveBuffer += "target\t\t\"" + outputFolder + "\\" + outputFilename + ".map" + "\"\r\n";
				else
					CurveBuffer += "target\t\t" + "\"UNSET\"" + "\r\n";

				CurveBuffer += "\r\n";
			}

			CurveBuffer += "// ++++++++++ Curve Object #" + (curveObjID + 1) + " ++++++++++\r\n\r\n";
			CurveBuffer += "name\t\t" + curveObjName + "\r\n"; // always export curve name!
			CurveBuffer += "rad\t\t" + rad + "\r\n"; // always export rad!

			if (ExportAll || (!ExportAll && Differs[16, c]))
			{
				if (cornerFilePath.Length > 0)
					CurveBuffer += "splinefile\t\"" + cornerFilePath + "\"\r\n";
				else
					CurveBuffer += "splinefile\t" + "\"UNSET\"" + "\r\n";
			}
			if (ExportAll || (!ExportAll && Differs[34, c])) CurveBuffer += "nulltex\t\t" + nulltex + "\r\n";
			if (ExportAll || (!ExportAll && Differs[7, c])) CurveBuffer += "append\t\t" + Convert.ToInt32(append) + "\r\n";
			if (ExportAll || (!ExportAll && Differs[1, c])) CurveBuffer += "offset\t\t" + offset + "\r\n";
			if (ExportAll || (!ExportAll && Differs[10, c])) CurveBuffer += "height\t\t" + height + "\r\n";
			if (ExportAll || (!ExportAll && Differs[46, c])) CurveBuffer += "p_expand\t" + p_expand + "\r\n";
			if (ExportAll || (!ExportAll && Differs[23, c])) CurveBuffer += "range_start\t" + range_start + "\r\n";
			if (ExportAll || (!ExportAll && Differs[24, c])) CurveBuffer += "range_end\t" + range_end + "\r\n";
			if (ExportAll || (!ExportAll && Differs[35, c])) CurveBuffer += "spike_height\t" + spike_height + "\r\n";
			if (ExportAll || (!ExportAll && Differs[59, c])) CurveBuffer += "hshiftoffset\t" + hshiftoffset + "\r\n";
			if (ExportAll || (!ExportAll && Differs[17, c])) CurveBuffer += "scale\t\t" + scale + "\r\n";
			if (ExportAll || (!ExportAll && Differs[20, c])) CurveBuffer += "scale_src\t" + scale_src + "\r\n";
			if (ExportAll || (!ExportAll && Differs[33, c])) CurveBuffer += "d_pos\t\t" + d_pos + "\r\n";
			if (ExportAll || (!ExportAll && Differs[2, c])) CurveBuffer += "res\t\t" + res + "\r\n";
			if (ExportAll || (!ExportAll && Differs[4, c])) CurveBuffer += "obj\t\t" + Convert.ToInt32(obj) + "\r\n";
			if (ExportAll || (!ExportAll && Differs[48, c])) CurveBuffer += "map\t\t" + Convert.ToInt32(map) + "\r\n";
			if (ExportAll || (!ExportAll && Differs[56, c])) CurveBuffer += "rmf\t\t" + Convert.ToInt32(rmf) + "\r\n";
			if (ExportAll || (!ExportAll && Differs[3, c])) CurveBuffer += "type\t\t" + type + "\r\n";
			if (ExportAll || (!ExportAll && Differs[5, c])) CurveBuffer += "shift\t\t" + shift + "\r\n";
			if (ExportAll || (!ExportAll && Differs[8, c])) CurveBuffer += "tri\t\t" + Convert.ToInt32(tri) + "\r\n";
			if (ExportAll || (!ExportAll && Differs[9, c])) CurveBuffer += "round\t\t" + Convert.ToInt32(round) + "\r\n";
			if (ExportAll || (!ExportAll && Differs[11, c])) CurveBuffer += "ramp\t\t" + Convert.ToInt32(ramp) + "\r\n";
			if (ExportAll || (!ExportAll && Differs[12, c])) CurveBuffer += "p_cornerfix\t" + Convert.ToInt32(p_cornerfix) + "\r\n";
			if (ExportAll || (!ExportAll && Differs[13, c])) CurveBuffer += "p_reverse\t" + Convert.ToInt32(p_reverse) + "\r\n";
			if (ExportAll || (!ExportAll && Differs[15, c])) CurveBuffer += "p_split\t\t" + Convert.ToInt32(p_split) + "\r\n";
			if (ExportAll || (!ExportAll && Differs[47, c])) CurveBuffer += "p_evenout\t" + Convert.ToInt32(p_evenout) + "\r\n";
			if (ExportAll || (!ExportAll && Differs[22, c])) CurveBuffer += "bounds\t\t" + bounds + "\r\n";
			if (ExportAll || (!ExportAll && Differs[25, c])) CurveBuffer += "transit_tri\t" + Convert.ToInt32(transit_tri) + "\r\n";
			if (ExportAll || (!ExportAll && Differs[26, c])) CurveBuffer += "transit_round\t" + Convert.ToInt32(transit_round) + "\r\n";
			if (ExportAll || (!ExportAll && Differs[29, c])) CurveBuffer += "skipnull\t" + Convert.ToInt32(skipnull) + "\r\n";
			if (ExportAll || (!ExportAll && Differs[49, c])) CurveBuffer += "c_enable\t" + Convert.ToInt32(c_enable) + "\r\n";
			if (ExportAll || (!ExportAll && Differs[30, c])) CurveBuffer += "d_enable\t" + Convert.ToInt32(d_enable) + "\r\n";
			if (ExportAll || (!ExportAll && Differs[31, c])) CurveBuffer += "d_autoyaw\t" + Convert.ToInt32(d_autoyaw) + "\r\n";
			if (ExportAll || (!ExportAll && Differs[32, c])) CurveBuffer += "d_autopitch\t" + Convert.ToInt32(d_autopitch) + "\r\n";
			if (ExportAll || (!ExportAll && Differs[36, c])) CurveBuffer += "d_separate\t" + Convert.ToInt32(d_separate) + "\r\n";
			if (ExportAll || (!ExportAll && Differs[37, c])) CurveBuffer += "d_autoname\t" + Convert.ToInt32(d_autoname) + "\r\n";
			if (ExportAll || (!ExportAll && Differs[41, c])) CurveBuffer += "d_draw\t\t" + d_draw + "\r\n";
			if (ExportAll || (!ExportAll && Differs[42, c])) CurveBuffer += "d_draw_rand\t" + Convert.ToInt32(d_draw_rand) + "\r\n";
			if (ExportAll || (!ExportAll && Differs[43, c])) CurveBuffer += "d_skip\t\t" + d_skip + "\r\n";
			if (ExportAll || (!ExportAll && Differs[51, c])) CurveBuffer += "d_carve\t\t" + Convert.ToInt32(d_carve) + "\r\n";
			if (ExportAll || (!ExportAll && Differs[52, c])) CurveBuffer += "d_autoassign\t" + Convert.ToInt32(d_autoassign) + "\r\n";
			if (ExportAll || (!ExportAll && Differs[53, c])) CurveBuffer += "d_circlemode\t" + Convert.ToInt32(d_circlemode) + "\r\n";
			if (ExportAll || (!ExportAll && Differs[44, c])) CurveBuffer += "heightmode\t" + heightmode + "\r\n";
			if (ExportAll || (!ExportAll && Differs[50, c])) CurveBuffer += "texmode\t\t" + texmode + "\r\n";
			if (ExportAll || (!ExportAll && Differs[54, c])) CurveBuffer += "flatcircle\t" + Convert.ToInt32(flatcircle) + "\r\n";
			if (ExportAll || (!ExportAll && Differs[57, c])) CurveBuffer += "hstretch\t" + Convert.ToInt32(hstretch) + "\r\n";
			if (ExportAll || (!ExportAll && Differs[58, c])) CurveBuffer += "hstretchamt\t" + hstretchamt + "\r\n";
			if (ExportAll || (!ExportAll && Differs[60, c])) CurveBuffer += "hshiftsrc\t" + hshiftsrc + "\r\n";
			if (ExportAll || (!ExportAll && Differs[18, c])) CurveBuffer += "rot\t\t" + "\"" + rot[0] + " " + rot[1] + " " + rot[2] + "\"" + "\r\n";
			if (ExportAll || (!ExportAll && Differs[21, c])) CurveBuffer += "rot_src\t\t" + "\"" + rot_src[0] + " " + rot_src[1] + " " + rot_src[2] + "\"" + "\r\n";
			if (ExportAll || (!ExportAll && Differs[19, c])) CurveBuffer += "move\t\t" + "\"" + move[0] + " " + move[1] + " " + move[2] + "\"" + "\r\n";
            if (ExportAll || (!ExportAll && Differs[65, c])) CurveBuffer += "mirror\t\t" + PrintMirror(false) + "\r\n";
            if (ExportAll || (!ExportAll && Differs[66, c])) CurveBuffer += "mirror_src\t" + PrintMirror(true) + "\r\n";
            if (ExportAll || (!ExportAll && Differs[38, c])) CurveBuffer += "d_pos_rand\t" + "\"" + Convert.ToInt32(d_pos_rand) + " " + d_pos_rand_mm[0] + " " + d_pos_rand_mm[1] + "\"" + "\r\n";
			if (ExportAll || (!ExportAll && Differs[39, c])) CurveBuffer += "d_rotz_rand\t" + "\"" + Convert.ToInt32(d_rotz_rand) + " " + d_rotz_rand_mm[0] + " " + d_rotz_rand_mm[1] + "\"" + "\r\n";
			if (ExportAll || (!ExportAll && Differs[40, c])) CurveBuffer += "d_movey_rand\t" + "\"" + Convert.ToInt32(d_movey_rand) + " " + d_movey_rand_mm[0] + " " + d_movey_rand_mm[1] + "\"" + "\r\n";
			if (ExportAll || (!ExportAll && Differs[55, c])) CurveBuffer += "d_scale_rand\t" + "\"" + Convert.ToInt32(d_scale_rand) + " " + d_scale_rand_mm[0] + " " + d_scale_rand_mm[1] + "\"" + "\r\n";
			if (ExportAll || (!ExportAll && Differs[45, c])) CurveBuffer += "p_scale\t\t" + "\"" + p_scale[0] + " " + p_scale[1] + " " + p_scale[2] + "\"" + "\r\n";
			if (ExportAll || (!ExportAll && Differs[63, c])) CurveBuffer += "gridsize\t" + "\"" + gridsize[0] + " " + gridsize[1] + " " + gridsize[2] + "\"" + "\r\n";
			if (ExportAll || (!ExportAll && Differs[64, c])) CurveBuffer += "mapcarve\t" + mapcarve + "\r\n";
			if (ExportAll || (!ExportAll && Differs[27, c])) CurveBuffer += "gaps\t\t" + Convert.ToInt32(gaps) + "\r\n";
			if (ExportAll || (!ExportAll && Differs[28, c])) CurveBuffer += "gaplen\t\t" + gaplen + "\r\n";

			// deprecated
			/*CurveBuffer += "ramptex\t\t"    + 0 + "\r\n";*/
			return CurveBuffer;
		}

		public void TableToCurve(SettingsTable sTable)
		{
			// bool
			if (sTable.values_set[29]) skipnull = sTable.values_b[29];
			if (sTable.values_set[4]) obj = sTable.values_b[4];
			if (sTable.values_set[48]) map = sTable.values_b[48];
			if (sTable.values_set[56]) rmf = sTable.values_b[56];
			if (sTable.values_set[8]) tri = sTable.values_b[8];
			if (sTable.values_set[9]) round = sTable.values_b[9];
			if (sTable.values_set[11]) ramp = sTable.values_b[11];
			if (sTable.values_set[7]) append = sTable.values_b[7];
			if (sTable.values_set[25]) transit_tri = sTable.values_b[25];
			if (sTable.values_set[26]) transit_round = sTable.values_b[26];
			if (sTable.values_set[57]) hstretch = sTable.values_b[57];
			if (sTable.values_set[54]) flatcircle = sTable.values_b[54];
			if (sTable.values_set[49]) c_enable = sTable.values_b[49];
			if (sTable.values_set[12]) p_cornerfix = sTable.values_b[12];
			if (sTable.values_set[13]) p_reverse = sTable.values_b[13];
			if (sTable.values_set[15]) p_split = sTable.values_b[15];
			if (sTable.values_set[47]) p_evenout = sTable.values_b[47];
			if (sTable.values_set[30]) d_enable = sTable.values_b[30];
			if (sTable.values_set[31]) d_autoyaw = sTable.values_b[31];
			if (sTable.values_set[32]) d_autopitch = sTable.values_b[32];
			if (sTable.values_set[36]) d_separate = sTable.values_b[36];
			if (sTable.values_set[37]) d_autoname = sTable.values_b[37];
			if (sTable.values_set[51]) d_carve = sTable.values_b[51];
			if (sTable.values_set[52]) d_autoassign = sTable.values_b[52];
			if (sTable.values_set[53]) d_circlemode = sTable.values_b[53];
			if (sTable.values_set[27]) gaps = sTable.values_b[27];

			// int
			if (sTable.values_set[2]) res = sTable.values_i[2];
			if (sTable.values_set[3]) type = sTable.values_i[3];
			if (sTable.values_set[5]) shift = sTable.values_i[5];
			if (sTable.values_set[14]) ramptex = sTable.values_i[14];
			if (sTable.values_set[22]) bounds = sTable.values_i[22];
			if (sTable.values_set[44]) heightmode = sTable.values_i[44];
			if (sTable.values_set[50]) texmode = sTable.values_i[50];
			if (sTable.values_set[60]) hshiftsrc = sTable.values_i[60];
			if (sTable.values_set[41]) d_draw = sTable.values_i[41];
			if (sTable.values_set[43]) d_skip = sTable.values_i[43];
			if (sTable.values_set[64]) mapcarve = sTable.values_i[64];

            // bool mirror - is being converted from an int value:
            // 0=Off, 1=X, 2=Y, 3=Z, 4=XY, 5=XZ, 6=YZ, 7=XYZ
            if (sTable.values_set[65]) mirror[0] = sTable.ConvertMirrorValue(0, sTable.values_i[65]);
            if (sTable.values_set[65]) mirror[1] = sTable.ConvertMirrorValue(1, sTable.values_i[65]);
            if (sTable.values_set[65]) mirror[2] = sTable.ConvertMirrorValue(2, sTable.values_i[65]);
            if (sTable.values_set[66]) mirror_src[0] = sTable.ConvertMirrorValue(0, sTable.values_i[66]);
            if (sTable.values_set[66]) mirror_src[1] = sTable.ConvertMirrorValue(1, sTable.values_i[66]);
            if (sTable.values_set[66]) mirror_src[2] = sTable.ConvertMirrorValue(2, sTable.values_i[66]);

            //float
            if (sTable.values_set[0]) rad = sTable.values_f[0];
			if (sTable.values_set[1]) offset = sTable.values_f[1];
			if (sTable.values_set[10]) height = sTable.values_f[10];
			if (sTable.values_set[46]) p_expand = sTable.values_f[46];
			if (sTable.values_set[23]) range_start = sTable.values_f[23];
			if (sTable.values_set[24]) range_end = sTable.values_f[24];
			if (sTable.values_set[35]) spike_height = sTable.values_f[35];
			if (sTable.values_set[58]) hstretchamt = sTable.values_f[58];
			if (sTable.values_set[59]) hshiftoffset = sTable.values_f[59];
			if (sTable.values_set[33]) d_pos = sTable.values_f[33];
			if (sTable.values_set[17]) scale = sTable.values_f[17];
			if (sTable.values_set[20]) scale_src = sTable.values_f[20];
			if (sTable.values_set[28]) gaplen = sTable.values_f[28];

			// float transform
			if (sTable.values_set[19]) move[0] = sTable.values_v[19, 0];
			if (sTable.values_set[19]) move[1] = sTable.values_v[19, 1];
			if (sTable.values_set[19]) move[2] = sTable.values_v[19, 2];
			if (sTable.values_set[18]) rot[0] = sTable.values_v[18, 0];
			if (sTable.values_set[18]) rot[1] = sTable.values_v[18, 1];
			if (sTable.values_set[18]) rot[2] = sTable.values_v[18, 2];
			if (sTable.values_set[21]) rot_src[0] = sTable.values_v[21, 0];
			if (sTable.values_set[21]) rot_src[1] = sTable.values_v[21, 1];
			if (sTable.values_set[21]) rot_src[2] = sTable.values_v[21, 2];
			if (sTable.values_set[45]) p_scale[0] = sTable.values_v[45, 0];
			if (sTable.values_set[45]) p_scale[1] = sTable.values_v[45, 1];
			if (sTable.values_set[45]) p_scale[2] = sTable.values_v[45, 2];
			if (sTable.values_set[38]) d_pos_rand_mm[0] = sTable.values_v[38, 1];
			if (sTable.values_set[38]) d_pos_rand_mm[1] = sTable.values_v[38, 2];
			if (sTable.values_set[39]) d_rotz_rand_mm[0] = sTable.values_v[39, 1];
			if (sTable.values_set[39]) d_rotz_rand_mm[1] = sTable.values_v[39, 2];
			if (sTable.values_set[40]) d_movey_rand_mm[0] = sTable.values_v[40, 1];
			if (sTable.values_set[40]) d_movey_rand_mm[1] = sTable.values_v[40, 2];
			if (sTable.values_set[55]) d_scale_rand_mm[0] = sTable.values_v[55, 1];
			if (sTable.values_set[55]) d_scale_rand_mm[1] = sTable.values_v[55, 2];
			if (sTable.values_set[63]) gridsize[0] = sTable.values_v[63, 0];
			if (sTable.values_set[63]) gridsize[1] = sTable.values_v[63, 1];
			if (sTable.values_set[63]) gridsize[2] = sTable.values_v[63, 2];

			// bool transform
			if (sTable.values_set[42]) d_draw_rand = Convert.ToBoolean(sTable.values_v[42, 0]);
			if (sTable.values_set[38]) d_pos_rand = Convert.ToBoolean(sTable.values_v[38, 0]);
			if (sTable.values_set[39]) d_rotz_rand = Convert.ToBoolean(sTable.values_v[39, 0]);
			if (sTable.values_set[40]) d_movey_rand = Convert.ToBoolean(sTable.values_v[40, 0]);
			if (sTable.values_set[55]) d_scale_rand = Convert.ToBoolean(sTable.values_v[55, 0]);

			//strings
			int l, len, m;
			if (sTable.values_set[6])
			{
				l = sTable.values_s[6].LastIndexOf("\\");
				len = sTable.values_s[6].Length;
				if (sTable.values_s[6].IndexOf(".map") != -1) m = 4; else m = 0;
				//MessageBox.Show("sTable.values_s[6]:" + sTable.values_s[6] + "\r\nl " + l + "\r\nlen " + len);
				if (l != -1) outputFolder = sTable.values_s[6].Substring(0, l);
				if (l != -1 && len > 0) outputFilename = sTable.values_s[6].Substring(l + 1, len - l - 1 - m);
			}

			if (sTable.values_set[61])
			{
				l = sTable.values_s[61].LastIndexOf("\\");
				len = sTable.values_s[61].Length;
				if (sTable.values_s[61].IndexOf(".map") != -1) m = 4; else m = 0;
				//MessageBox.Show("sTable.values_s[61]:" + sTable.values_s[61] + "\r\nl " + l + "\r\nlen " + len);
				inputFilePath = sTable.values_s[61];
				if (l != -1) inputFolder = sTable.values_s[61].Substring(0, l);
				if (l != -1 && len > 0) inputFilename = sTable.values_s[61].Substring(l + 1, len - l - 1 - m);
			}

			if (sTable.values_set[16]) cornerFilePath = sTable.values_s[16];
			if (sTable.values_set[34]) nulltex = sTable.values_s[34];

			if (sTable.values_set[62]) curveObjName = sTable.values_s[62];
		}

		public void CreateDifferTable(ref bool[,] Differs, ref CurveObject Compare, int c)
		{
			if (cornerFilePath != Compare.cornerFilePath) Differs[16, c] = true;
			if (nulltex != Compare.nulltex) Differs[34, c] = true;
			if (append != Compare.append) Differs[7, c] = true;
			if (offset != Compare.offset) Differs[1, c] = true;
			if (height != Compare.height) Differs[10, c] = true;
			if (p_expand != Compare.p_expand) Differs[46, c] = true;
			if (range_start != Compare.range_start) Differs[23, c] = true;
			if (range_end != Compare.range_end) Differs[24, c] = true;
			if (spike_height != Compare.spike_height) Differs[35, c] = true;
			if (hshiftoffset != Compare.hshiftoffset) Differs[59, c] = true;
			if (scale != Compare.scale) Differs[17, c] = true;
			if (scale_src != Compare.scale_src) Differs[20, c] = true;
			if (!IsVectorSameAs(ref rot, ref Compare.rot)) Differs[18, c] = true;
			if (!IsVectorSameAs(ref rot_src, ref Compare.rot_src)) Differs[21, c] = true;
			if (!IsVectorSameAs(ref move, ref Compare.move)) Differs[19, c] = true;
			if (!IsVector2SameAs(ref d_pos_rand, ref Compare.d_pos_rand, ref d_pos_rand_mm, ref Compare.d_pos_rand_mm)) Differs[38, c] = true;
			if (!IsVector2SameAs(ref d_rotz_rand, ref Compare.d_rotz_rand, ref d_rotz_rand_mm, ref Compare.d_rotz_rand_mm)) Differs[39, c] = true;
			if (!IsVector2SameAs(ref d_movey_rand, ref Compare.d_movey_rand, ref d_movey_rand_mm, ref Compare.d_movey_rand_mm)) Differs[40, c] = true;
			if (!IsVector2SameAs(ref d_scale_rand, ref Compare.d_scale_rand, ref d_scale_rand_mm, ref Compare.d_scale_rand_mm)) Differs[55, c] = true;
			if (!IsVectorSameAs(ref p_scale, ref Compare.p_scale)) Differs[45, c] = true;
			if (d_pos != Compare.d_pos) Differs[33, c] = true;
			if (res != Compare.res) Differs[2, c] = true;
			if (obj != Compare.obj) Differs[4, c] = true;
			if (map != Compare.map) Differs[48, c] = true;
			if (rmf != Compare.rmf) Differs[56, c] = true;
			if (type != Compare.type) Differs[3, c] = true;
			if (shift != Compare.shift) Differs[5, c] = true;
			if (tri != Compare.tri) Differs[8, c] = true;
			if (round != Compare.round) Differs[9, c] = true;
			if (ramp != Compare.ramp) Differs[11, c] = true;
			if (p_cornerfix != Compare.p_cornerfix) Differs[12, c] = true;
			if (p_reverse != Compare.p_reverse) Differs[13, c] = true;
			if (p_split != Compare.p_split) Differs[15, c] = true;
			if (p_evenout != Compare.p_evenout) Differs[47, c] = true;
			if (bounds != Compare.bounds) Differs[22, c] = true;
			if (transit_tri != Compare.transit_tri) Differs[25, c] = true;
			if (transit_round != Compare.transit_round) Differs[26, c] = true;
			if (skipnull != Compare.skipnull) Differs[29, c] = true;
			if (c_enable != Compare.c_enable) Differs[49, c] = true;
			if (d_enable != Compare.d_enable) Differs[30, c] = true;
			if (d_autoyaw != Compare.d_autoyaw) Differs[31, c] = true;
			if (d_autopitch != Compare.d_autopitch) Differs[32, c] = true;
			if (d_separate != Compare.d_separate) Differs[36, c] = true;
			if (d_autoname != Compare.d_autoname) Differs[37, c] = true;
			if (d_draw != Compare.d_draw) Differs[41, c] = true;
			if (d_draw_rand != Compare.d_draw_rand) Differs[42, c] = true;
			if (d_skip != Compare.d_skip) Differs[43, c] = true;
			if (d_carve != Compare.d_carve) Differs[51, c] = true;
			if (d_autoassign != Compare.d_autoassign) Differs[52, c] = true;
			if (d_circlemode != Compare.d_circlemode) Differs[53, c] = true;
			if (heightmode != Compare.heightmode) Differs[44, c] = true;
			if (texmode != Compare.texmode) Differs[50, c] = true;
			if (flatcircle != Compare.flatcircle) Differs[54, c] = true;
			if (hstretch != Compare.hstretch) Differs[57, c] = true;
			if (hstretchamt != Compare.hstretchamt) Differs[58, c] = true;
			if (hshiftsrc != Compare.hshiftsrc) Differs[60, c] = true;
			if (!IsVectorSameAs(ref gridsize, ref Compare.gridsize)) Differs[63, c] = true;
			if (mapcarve != Compare.mapcarve) Differs[64, c] = true;
			if (gaps != Compare.gaps) Differs[27, c] = true;
			if (gaplen != Compare.gaplen) Differs[28, c] = true;
			if (!IsVectorSameAs(ref mirror, ref Compare.mirror)) Differs[65, c] = true;
			if (!IsVectorSameAs(ref mirror_src, ref Compare.mirror_src)) Differs[66, c] = true;
        }

		public bool AreCurvesSame(ref CurveObject Compare)
		{
			bool same = true;
			if (cornerFilePath != Compare.cornerFilePath) same = false;
			if (nulltex != Compare.nulltex) same = false;
			if (append != Compare.append) same = false;
			if (offset != Compare.offset) same = false;
			if (height != Compare.height) same = false;
			if (p_expand != Compare.p_expand) same = false;
			if (range_start != Compare.range_start) same = false;
			if (range_end != Compare.range_end) same = false;
			if (spike_height != Compare.spike_height) same = false;
			if (hshiftoffset != Compare.hshiftoffset) same = false;
			if (scale != Compare.scale) same = false;
			if (scale_src != Compare.scale_src) same = false;
			if (!IsVectorSameAs(ref rot, ref Compare.rot)) same = false;
			if (!IsVectorSameAs(ref rot_src, ref Compare.rot_src)) same = false;
			if (!IsVectorSameAs(ref move, ref Compare.move)) same = false;
			if (!IsVector2SameAs(ref d_pos_rand, ref Compare.d_pos_rand, ref d_pos_rand_mm, ref Compare.d_pos_rand_mm)) same = false;
			if (!IsVector2SameAs(ref d_rotz_rand, ref Compare.d_rotz_rand, ref d_rotz_rand_mm, ref Compare.d_rotz_rand_mm)) same = false;
			if (!IsVector2SameAs(ref d_movey_rand, ref Compare.d_movey_rand, ref d_movey_rand_mm, ref Compare.d_movey_rand_mm)) same = false;
			if (!IsVector2SameAs(ref d_scale_rand, ref Compare.d_scale_rand, ref d_scale_rand_mm, ref Compare.d_scale_rand_mm)) same = false;
			if (!IsVectorSameAs(ref p_scale, ref Compare.p_scale)) same = false;
			if (d_pos != Compare.d_pos) same = false;
			if (res != Compare.res) same = false;
			if (obj != Compare.obj) same = false;
			if (map != Compare.map) same = false;
			if (rmf != Compare.rmf) same = false;
			if (type != Compare.type) same = false;
			if (shift != Compare.shift) same = false;
			if (tri != Compare.tri) same = false;
			if (round != Compare.round) same = false;
			if (ramp != Compare.ramp) same = false;
			if (p_cornerfix != Compare.p_cornerfix) same = false;
			if (p_reverse != Compare.p_reverse) same = false;
			if (p_split != Compare.p_split) same = false;
			if (p_evenout != Compare.p_evenout) same = false;
			if (bounds != Compare.bounds) same = false;
			if (transit_tri != Compare.transit_tri) same = false;
			if (transit_round != Compare.transit_round) same = false;
			if (skipnull != Compare.skipnull) same = false;
			if (c_enable != Compare.c_enable) same = false;
			if (d_enable != Compare.d_enable) same = false;
			if (d_autoyaw != Compare.d_autoyaw) same = false;
			if (d_autopitch != Compare.d_autopitch) same = false;
			if (d_separate != Compare.d_separate) same = false;
			if (d_autoname != Compare.d_autoname) same = false;
			if (d_draw != Compare.d_draw) same = false;
			if (d_draw_rand != Compare.d_draw_rand) same = false;
			if (d_skip != Compare.d_skip) same = false;
			if (d_carve != Compare.d_carve) same = false;
			if (d_autoassign != Compare.d_autoassign) same = false;
			if (d_circlemode != Compare.d_circlemode) same = false;
			if (heightmode != Compare.heightmode) same = false;
			if (texmode != Compare.texmode) same = false;
			if (flatcircle != Compare.flatcircle) same = false;
			if (hstretch != Compare.hstretch) same = false;
			if (hstretchamt != Compare.hstretchamt) same = false;
			if (hshiftsrc != Compare.hshiftsrc) same = false;
			if (!IsVectorSameAs(ref gridsize, ref Compare.gridsize)) same = false;
			if (mapcarve != Compare.mapcarve) same = false;
			if (gaps != Compare.gaps) same = false;
			if (gaplen != Compare.gaplen) same = false;
            if (mirror != Compare.mirror) same = false;
            if (mirror_src != Compare.mirror_src) same = false;

            return same;
		}

		public CurveObject(int ID = 0, string Name = "Curve Object")
		{
			this.curveObjID = ID;
			this.curveObjName = Name;
		}

		public string GetCurveName { get { return curveObjName; } }
		public int GetCurveID { get { return curveObjID; } }
	}


    public class CurveHandler
	{
		public string AllCurveObjectsToString(ref List<CurveObject> Curves, bool ExportAll, bool ExportInherit)
		{
			CurveObject DefCurve = new CurveObject();
			int tKeywords = KeywordList.keyword.Length;
			bool[,] Differs = new bool[tKeywords, Curves.Count];

			// check which settings differ from default settings
			// if this is wished, only these settings will be exported
			for (int i = 0; i < Curves.Count; i++)
			{
				Curves[i].CreateDifferTable(ref Differs, ref DefCurve, i);
			}

			// Check inheritance
			// settings of following curves, that do not differ from default settings, won't be exported
			bool[] Down = new bool[tKeywords];
			for (int k = 0; k < Down.Length; k++) Down[k] = false;

			for (int k = 0; k < tKeywords; k++)
			{
				for (int c = Curves.Count - 1; c >= 0; c--)
				{
					if (Differs[k, c]) Down[k] = true;
					if (Down[k]) { Differs[k, c] = true; }
				}
			}
			// overwrite inheritance, if wished (all settings that differ from defaults will be exported)
			if (ExportInherit)
			{
				for (int k = 0; k < tKeywords; k++)
				{
					if (Down[k])
						for (int c = Curves.Count - 1; c >= 0; c--)
						{
							Differs[k, c] = true;
						}
				}
			}

			// transform Curve objects individually to string
			string CurveString = "";
			for (int i = 0; i < Curves.Count; i++)
			{
				CurveObject Curve = Curves[i];
				bool IsFirst = false;
				if (i == 0) IsFirst = true;

				CurveString += Curve.CurveObjectToString(i, ref Differs, ExportAll, IsFirst);
				CurveString += "\r\n";
			}
			return CurveString;
		}

		public void CurveObjListChangeValue(ref List<CurveObject> CurveList, ref object sender, bool ChangeAll, int SelCurveID, cVar varType, string Value)
        {
            for (int i = 0; i < CurveList.Count; i++)
            {
                CurveObject Curve = CurveList[i];

                if ((i == SelCurveID && !ChangeAll) || ChangeAll)
                {
                    Curve.setCurveValues(varType, ref sender, Value);
                    if (!ChangeAll) break;
                }
            }
        }
		public void CurveObjListChangeValue(ref List<CurveObject> CurveList, ref object sender, bool ChangeAll, int SelCurveID, cVar varType, bool Value)
        {
            for (int i = 0; i < CurveList.Count; i++)
            {
                CurveObject Curve = CurveList[i];

                if ((i == SelCurveID && !ChangeAll) || ChangeAll)
                {
                    Curve.setCurveValues(varType, ref sender, Value);
                    if (!ChangeAll) break;
                }
            }
        }
		public void CurveObjListChangeValue(ref List<CurveObject> CurveList, ref object sender, bool ChangeAll, int SelCurveID, cVar varType, int Value)
        {
            for (int i = 0; i < CurveList.Count; i++)
            {
                CurveObject Curve = CurveList[i];

                if ((i == SelCurveID && !ChangeAll) || ChangeAll)
                {
                    Curve.setCurveValues(varType, ref sender, Value);
                    if (!ChangeAll) break;
                }
            }
        }
		public void CurveObjListChangeValue(ref List<CurveObject> CurveList, ref object sender, bool ChangeAll, int SelCurveID, cVar varType, float Value)
        {
            for (int i = 0; i < CurveList.Count; i++)
            {
                CurveObject Curve = CurveList[i];

                if ((i == SelCurveID && !ChangeAll) || ChangeAll)
                {
                    Curve.setCurveValues(varType, ref sender, Value);
                    if (!ChangeAll) break;
                }
            }
        }

	}



	public class SettingsTable
	{
		public bool[] values_b;
		public int[] values_i;
		public float[] values_f;
		public float[,] values_v;
		public string[] values_s;
		public bool[] values_set;

		public bool ConvertMirrorValue(int axis, int m)
		{
			if (axis == 0 && (m == 1 || m == 4 || m == 5 || m == 7)) return true;
            else if (axis == 1 && (m == 2 || m == 4 || m == 6 || m == 7)) return true;
            else if (axis == 2 && (m == 3 || m == 5 || m == 6 || m == 7)) return true;
            else return false;
		}

		public void PresetFileToTable(ref List<string> ValuesList, ref List<int> KeywordIndexList, ref List<int> CurveIndexList, int CurrentCurveIndex)
		{
			int kLength = KeywordList.keyword.Length;

			for (int v = 0; v < ValuesList.Count(); v++) // values loop
			{
				for (int k = 0; k < kLength; k++) // keyword loop
				{
					int KeywordType = KeywordList.keyword_type[k];
					if (KeywordIndexList[v] == k && CurveIndexList[v] == CurrentCurveIndex)
					{
						int len = ValuesList[v].Length;
						if (len > 0 && ValuesList[v] != null) // value has content
						{
							try
							{
								// 0 = bool, 1 = int, 2 = float, 3 = string, 4 = tform
								if (KeywordType == 0)
								{
									if (ValuesList[v] == "1") values_b[k] = true;
									else values_b[k] = false;
									values_set[k] = true;
								}
								else if (KeywordType == 1)
								{ values_i[k] = int.Parse(ValuesList[v]); values_set[k] = true; }
								else if (KeywordType == 2)
								{ values_f[k] = float.Parse(ValuesList[v]); values_set[k] = true; }
								else if (KeywordType == 3)
								{
									if (ValuesList[v] != "\"UNSET\"")
									{
										values_s[k] = ValuesList[v];
										values_s[k] = values_s[k].Trim('\"');
										values_set[k] = true;
									}
								}
								else if (KeywordType == 4)
								{
									ValuesList[v] = ValuesList[v].Trim('\"');
									int c1 = ValuesList[v].IndexOf(' ');
									int c2 = ValuesList[v].LastIndexOf(' ');
									len = ValuesList[v].Length;
									//MessageBox.Show("now parsing keyword: " + KeywordList.keyword[k] + "\r\ntype: " + KeywordType + "\r\nvalue: " + ValuesList[k] + "\r\nlen: "+len+"|c1: " + c1 + "|c2: " + c2+"|l1: "+ c1 + "|l2: "+ (c2 - c1 - 1) + "|l3: " + (len - c2 - 1));
									if (c1 == -1 && c2 == -1)
									{
										values_v[k, 0] = Convert.ToSingle(ValuesList[v]); //"0"
										values_v[k, 1] = 0;
										values_v[k, 2] = 0;
										values_set[k] = true;
									}
									else if (c1 != -1 && c2 == c1)
									{
										string sub1 = ValuesList[v].Substring(0, c1); //"111 222"
										string sub2 = ValuesList[v].Substring(c1 + 1, len - c2 - 1);
										values_v[k, 0] = Convert.ToSingle(sub1);
										values_v[k, 1] = Convert.ToSingle(sub2);
										values_v[k, 2] = 0;
										values_set[k] = true;
									}
									else if (c1 != -1 && c2 != -1 && c1 < c2)
									{
										//MessageBox.Show("getting substrings...");
										string sub1 = ValuesList[v].Substring(0, c1); //"0 0 0"
										string sub2 = ValuesList[v].Substring(c1 + 1, (c2 - c1 - 1));
										string sub3 = ValuesList[v].Substring(c2 + 1, (len - c2 - 1));
										//MessageBox.Show("|"+ sub1 + "|"+ sub2 + "|"+ sub3 + "|");
										values_v[k, 0] = Convert.ToSingle(sub1);   // "[0]111[c1] 222 333"
										values_v[k, 1] = Convert.ToSingle(sub2);   // "111 [c1+1]222[c2] 333"
										values_v[k, 2] = Convert.ToSingle(sub3);   // "111 222 [c2+1]333[L]"
										values_set[k] = true;
									}
									//else { values_v[i, 0] = Convert.ToSingle(ValuesList[k]); }
								}
							}
							catch (Exception e)
							{
								MessageBox.Show("Parsing error while going through imported preset file!\r\n"
									+ "Keyword: " + KeywordList.keyword[k] + "\r\n"
									+ "Value: " + ValuesList[v] + "\r\n"
									+ e.Message);
							}
							/*
							MessageBox.Show("" +
								"Keyword[" + k + "]		\t= " + KeywordList.keyword[k] + "\r\n" +
								"Type					\t= " + KeywordType + "\r\n" +
								"Value[" + v + "]		\t= " + ValuesList[v] + "\r\n" +
								"CurveID[" + v + "]		\t= " + CurveIndexList[v] + "\r\n" +
								"KeywordID[" + v + "]	\t= " + KeywordIndexList[v] + "\r\n\r\n" +
								"values_set[" + k + "]	\t= " + values_set[k] + "\r\n\r\n" +
								"values_b[" + k + "]	\t= " + values_b[k] + "\r\n" +
								"values_i[" + k + "]	\t= " + values_i[k] + "\r\n" +
								"values_s[" + k + "]	\t= " + values_s[k] + "\r\n" +
								"values_v[" + k + "]	\t= " + values_v[k, 0] + "," + values_v[k, 1] + "," + values_v[k, 2] + "\r\n"
								);
							*/
						}
					}
				}
			}
		}

		public SettingsTable()
		{
			int k = KeywordList.keyword.Length;

			values_b = new bool[k];
			values_i = new int[k];
			values_f = new float[k];
			values_v = new float[k, 3];
			values_s = new string[k];
			values_set = new bool[k];

			for (int i = 0; i < k; i++)
			{
				values_b[i] = false;
				values_i[i] = -1;
				values_f[i] = -1f;
				values_s[i] = "";
				values_set[i] = false;
				for (int j = 0; j < 3; j++)
					values_v[i, j] = -1f;
			}
		}
	}




	static class KeywordList
	{
		public static string[] keyword = {
			"rad",
			"offset",
			"res",
			"type",
			"obj",
			"shift",
			"target",
			"append",
			"tri",
			"round",
			"height",
			"ramp",
			"p_cornerfix",
			"p_reverse",
			"ramptex",
			"p_split",
			"splinefile",
			"scale",
			"rot",
			"move",
			"scale_src",
			"rot_src",
			"bounds",
			"range_start",
			"range_end",
			"transit_tri",
			"transit_round",
			"gaps",
			"gaplen",
			"skipnull",
			"d_enable",
			"d_autoyaw",
			"d_autopitch",
			"d_pos",
			"nulltex",
			"spike_height",
			"d_separate",
			"d_autoname",
			"d_pos_rand",
			"d_rotz_rand",
			"d_movey_rand",
			"d_draw",
			"d_draw_rand",
			"d_skip",
			"heightmode",
			"p_scale",
			"p_expand",
			"p_evenout",
			"map",
			"c_enable",
			"texmode",
			"d_carve",
			"d_autoassign",
			"d_circlemode",
			"flatcircle",
			"d_scale_rand",
			"rmf",
			"hstretch",
			"hstretchamt",
			"hshiftoffset",
			"hshiftsrc",
			"source",
			"name",
			"gridsize",
			"mapcarve",
            "mirror",
            "mirror_src"
		};

		// 0 = bool, 1 = int, 2 = float, 3 = string, 4 = tform
		public static int[] keyword_type = { 2, 2, 1, 1, 0, 1, 3, 0, 0, 0, 2, 0, 0, 0, 0, 0, 3, 2, 4, 4, 2, 4, 1, 2, 2, 0, 0, 0, 2, 0, 0, 0, 0, 2, 3, 2, 0, 0, 4, 4, 4, 1, 0, 1, 1, 4, 2, 0, 0, 0, 1, 0, 0, 0, 0, 4, 0, 0, 2, 2, 1, 3, 3, 4, 1, 1, 1};

		//int[] keyword_min = { -131072, -131072, 0, 0, 0, 0, 0, 0, 0, 0, -131072, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -131072, 0, 0, 0, 0, 0, 0, 0, 0, 10, 0, 0, 0, -131072, 0, 0 };
		//int[] keyword_max = { 131072, 131072, 384, 3, 1, 5, 255, 1, 1, 1, 131072, 1, 1, 1, 1, 1, 255, 30, 30, 30, 30, 1, 2, 100, 100, 1, 1, 1, 131072, 1, 1, 1, 1, 1, 15, 131072, 1, 1, 30, 30, 30, 384, 1, 384, 14, 30, 131072, 1, 1, 1, 1, 1, 1, 1, 1, 10, 1, 1, 65536, 131072, 1, 255 };
	}


	public class PresetFileHandler
	{
		string presetFilePath;
		List<string> found_values = new List<string>();
		List<int> found_values_valueID = new List<int>();
		List<int> found_values_curveID = new List<int>();
		int tCurves = 0;
		List<SettingsTable> sTable = new List<SettingsTable>();

		void PresetFileToLines()
		{
			List<string> presetFileLines = new List<string>();
			string line = "";

			int tKeywords = KeywordList.keyword.Length;
			try
			{
				//Pass the file path and file name to the StreamReader constructor
				StreamReader sr = new StreamReader(presetFilePath);

				//Read the first line of text
				presetFileLines.Add(sr.ReadLine());

				//Continue to read until you reach end of file
				while (line != null)
				{
					//Read the next line
					line = sr.ReadLine();

					if (line != null) presetFileLines.Add(line);
				}

				//close the file
				sr.Close();

				int tLines = presetFileLines.Count;
				bool[] Processed = new bool[tLines];
				for (int j = 0; j < tLines; j++) { Processed[j] = false; }

				// get keyword values
				if (tLines > 0)
				{
					for (int i = 0; i < tKeywords; i++) // keyword loop "rad", "offest", etc.
					{
						int currentCurveID = 0;
						//int currentKeywordType = kwl.keyword_type[i];
						string keyword = KeywordList.keyword[i]; // e.g. "rad"

						int s, ee, cc;

						for (int j = 0; j < tLines; j++) // imported presetfile lines
						{
							if (!Processed[j])
							{
								ref List<string> Line = ref presetFileLines;
								s = Line[j].IndexOf(keyword); // e.g. "rad      512 //comment"

								if (s == 0) // if keyword was found at Beginning of Line (!=-1)
								{
									s += keyword.Length; // set start index to end of keyword // "rad[s]      512 //comment"
									if (Line[j][s] == ' ' || Line[j][s] == '\t') // keyword is no doppelganger
									{
										string temp = "";

										cc = Line[j].IndexOf("//"); // is there a comment? "rad[s]      512 [cc]//comment"
										ee = Line[j].Length;

										if (cc != -1 && cc > s) // there is either no comment or there is a comment but keyword is not commented out, proceed
										{
											temp = Line[j].Substring(s, cc - s); // end index is comment slash
										}
										else if (cc == -1)
										{
											temp = Line[j].Substring(s, ee - s); // end index is line end
										}

										char[] charsToTrim = { ' ', '\t', '\n', '\r' };
										temp = temp.Trim(charsToTrim);
										// no break anymore! instead find all keywords for multiple curve objects!
										//break; // keyword was found, end this loop and proceed to next keyword

										found_values.Add(temp);
										found_values_curveID.Add(currentCurveID);
										found_values_valueID.Add(i);
										Processed[j] = true;
										currentCurveID++;
									}
								}
							}
						}
					}
				}
				// count curve objects by counting "rad"
				for (int i = 0; i < found_values.Count(); i++)
				{
					if (found_values_valueID[i] == 0) tCurves++;
				}
			}
			catch (Exception e)
			{
				MessageBox.Show("There was a problem reading this preset file!\r\n" + e.Message);
			}
		}

		//string test = "";
		//test += "|vID|" + found_values_valueID[i] + "|cID|" + found_values_curveID[i] + "|Val|" + found_values[i] + "|\r\n";
		//MessageBox.Show(test);

		public void ProcessPresetFile(ref List<CurveObject> CurveList)
		{
			CurveList.Clear();

			// Get Keyword Values from given Preset File
			PresetFileToLines();

			// Create and fill Settings Tables and CurveList
			for (int i = 0; i < tCurves; i++)
			{
				sTable.Add(new SettingsTable());
				sTable[i].PresetFileToTable(ref found_values, ref found_values_valueID, ref found_values_curveID, i);

				CurveList.Add(new CurveObject());
				CurveList[i].curveObjName = "Curve " + (i + 1); // default curve name (will be overwritten in next step, if set)
				CurveList[i].TableToCurve(sTable[i]);
				CurveList[i].curveObjID = i;
			}

			if (tCurves == 0)
			{
				CurveList.Add(new CurveObject());
			}

			CurveList[0].presetFilePath = this.presetFilePath;
			int b = presetFilePath.LastIndexOf("\\") + 1;
			int l = presetFilePath.Length - b;
			CurveList[0].presetFileName = this.presetFilePath.Substring(b, l);
		}

		public PresetFileHandler(string Filepath)
		{
			this.presetFilePath = Filepath;
		}
	}



}
