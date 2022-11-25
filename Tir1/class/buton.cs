using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComponentFactory.Krypton.Toolkit;

namespace Tir1.@class
{

    public class buton
    {
        public static void GetBut(object button, int type, int r)
        {
            var but = (KryptonButton)button;
            if (type == -1)
            {
                but.OverrideDefault.Back.Color1 = System.Drawing.Color.SkyBlue;
                but.OverrideDefault.Back.Color2 = System.Drawing.Color.CornflowerBlue;
                but.OverrideDefault.Back.ColorAngle = 45F;
                but.OverrideDefault.Border.Color1 = System.Drawing.Color.SkyBlue;
                but.OverrideDefault.Border.Color2 = System.Drawing.Color.CornflowerBlue;
                but.OverrideDefault.Border.ColorAngle = 45F;
                but.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                but.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
                but.OverrideDefault.Border.Rounding = r;
                but.OverrideDefault.Border.Width = 1;
                but.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
                but.StateCommon.Back.Color1 = System.Drawing.Color.SkyBlue;
                but.StateCommon.Back.Color2 = System.Drawing.Color.CornflowerBlue;
                but.StateCommon.Back.ColorAngle = 45F;
                but.StateCommon.Border.Color1 = System.Drawing.Color.SkyBlue;
                but.StateCommon.Border.Color2 = System.Drawing.Color.CornflowerBlue;
                but.StateCommon.Border.ColorAngle = 45F;
                but.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                but.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
                but.StateCommon.Border.Rounding = r;
                but.StateCommon.Border.Width = 1;
                but.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
                but.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
                but.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
                but.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
                but.StatePressed.Back.ColorAngle = 135F;
                but.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
                but.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
                but.StatePressed.Border.ColorAngle = 135F;
                but.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                but.StatePressed.Border.Rounding = r;
                but.StatePressed.Border.Width = 1;
                but.StateTracking.Back.Color1 = System.Drawing.Color.SkyBlue;
                but.StateTracking.Back.Color2 = System.Drawing.Color.CornflowerBlue;
                but.StateTracking.Back.ColorAngle = 135F;
                but.StateTracking.Border.Color1 = System.Drawing.Color.SkyBlue;
                but.StateTracking.Border.Color2 = System.Drawing.Color.CornflowerBlue;
                but.StateTracking.Border.ColorAngle = 135F;
                but.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                but.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
                but.StateTracking.Border.Rounding = r;
                but.StateTracking.Border.Width = 1;
            }
            if (type == 0 || type == 11)
            {
                but.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
                but.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
                but.OverrideDefault.Border.Color1 = System.Drawing.Color.SkyBlue;
                but.OverrideDefault.Border.Color2 = System.Drawing.Color.CornflowerBlue;
                but.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                but.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
                but.OverrideDefault.Border.Rounding = r;
                but.OverrideDefault.Border.Width = type == 0 ? 1 : 3;
                but.OverrideDefault.Content.Padding = new System.Windows.Forms.Padding(-1, -1, -1, -1);
                but.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
                but.StateCommon.Back.Color1 = System.Drawing.Color.White;
                but.StateCommon.Back.Color2 = System.Drawing.Color.White;
                but.StateCommon.Border.Color1 = System.Drawing.Color.SkyBlue;
                but.StateCommon.Border.Color2 = System.Drawing.Color.CornflowerBlue;
                but.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                but.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
                but.StateCommon.Border.Rounding = r;
                but.StateCommon.Border.Width = type == 0? 1 : 3;
                but.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, -1, -1, -1);
                but.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
                but.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
                but.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                but.StateDisabled.Border.Rounding = r;
                but.StateDisabled.Border.Width = type == 0 ? 1 : 3;
                but.StateDisabled.Content.Padding = new System.Windows.Forms.Padding(-1, 1, -1, -1);
                but.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                but.StateNormal.Border.Rounding = r;
                but.StateNormal.Border.Width = type == 0 ? 1 : 3;
                but.StateNormal.Content.Padding = new System.Windows.Forms.Padding(-1, -1, -1, -1);
                but.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
                but.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
                but.StatePressed.Back.ColorAngle = 135F;
                but.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
                but.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
                but.StatePressed.Border.ColorAngle = 135F;
                but.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                but.StatePressed.Border.Rounding = r;
                but.StatePressed.Border.Width = type == 0 ? 1 : 3;
                but.StatePressed.Content.Padding = new System.Windows.Forms.Padding(-1, -1, -1, -1);
                but.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
                but.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
                but.StateTracking.Back.Color1 = System.Drawing.Color.SkyBlue;
                but.StateTracking.Back.Color2 = System.Drawing.Color.CornflowerBlue;
                but.StateTracking.Back.ColorAngle = 135F;
                but.StateTracking.Border.Color1 = System.Drawing.Color.SkyBlue;
                but.StateTracking.Border.Color2 = System.Drawing.Color.CornflowerBlue;
                but.StateTracking.Border.ColorAngle = 135F;
                but.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                but.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
                but.StateTracking.Border.Rounding = r;
                but.StateTracking.Border.Width = type == 0 ? 1 : 3;
                but.StateTracking.Content.Padding = new System.Windows.Forms.Padding(-1, -1, -1, -1);
                but.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
                but.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            }
            else
                if (type == 1 || type == 17)
            {
                but.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
                but.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
                but.OverrideDefault.Border.Color1 = System.Drawing.Color.Tomato;
                but.OverrideDefault.Border.Color2 = System.Drawing.Color.Tomato;
                but.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                but.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
                but.OverrideDefault.Border.Rounding = r;
                but.OverrideDefault.Border.Width = 3;
                but.OverrideDefault.Content.ShortText.Color1 = Color.Tomato;
                but.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
                but.StateCommon.Back.Color1 = System.Drawing.Color.White;
                but.StateCommon.Back.Color2 = System.Drawing.Color.White;
                but.StateCommon.Border.Color1 = System.Drawing.Color.Tomato;
                but.StateCommon.Border.Color2 = System.Drawing.Color.Tomato;
                but.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                but.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
                but.StateCommon.Border.Rounding = r;
                but.StateCommon.Border.Width = 3;
                but.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Tomato;
                but.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Tomato;
                but.StatePressed.Back.Color1 = System.Drawing.Color.IndianRed;
                but.StatePressed.Back.Color2 = System.Drawing.Color.Firebrick;
                but.StatePressed.Back.ColorAngle = 135F;
                but.StatePressed.Border.Color1 = System.Drawing.Color.IndianRed;
                but.StatePressed.Border.Color2 = System.Drawing.Color.Firebrick;
                but.StatePressed.Border.ColorAngle = 135F;
                but.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                but.StatePressed.Border.Rounding = r;
                but.StatePressed.Border.Width = 3;
                but.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
                but.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
                but.StateTracking.Back.Color1 = System.Drawing.Color.Tomato;
                but.StateTracking.Back.Color2 = System.Drawing.Color.Red;
                but.StateTracking.Back.ColorAngle = 45F;
                but.StateTracking.Border.Color1 = System.Drawing.Color.Tomato;
                but.StateTracking.Border.Color2 = System.Drawing.Color.Red;
                but.StateTracking.Border.ColorAngle = 45F;
                but.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                but.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
                but.StateTracking.Border.Rounding = r;
                but.StateTracking.Border.Width = 3;
                but.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            }
            else if (type == 10)
            {
                but.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
                but.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
                but.OverrideDefault.Border.Color1 = System.Drawing.Color.Gainsboro;
                but.OverrideDefault.Border.Color2 = System.Drawing.Color.DarkGray;
                but.OverrideDefault.Border.ColorAngle = 45F;
                but.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                but.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
                but.OverrideDefault.Border.Rounding = r;
                but.OverrideDefault.Border.Width = 3;
                but.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
                but.StateCommon.Back.Color1 = System.Drawing.Color.White;
                but.StateCommon.Back.Color2 = System.Drawing.Color.White;
                but.StateCommon.Border.Color1 = System.Drawing.Color.Gainsboro;
                but.StateCommon.Border.Color2 = System.Drawing.Color.DarkGray;
                but.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                but.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
                but.StateCommon.Border.Rounding = r;
                but.StateCommon.Border.Width = 3;
                but.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.DarkGray;
                but.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.DarkGray;
                but.StatePressed.Back.Color1 = System.Drawing.Color.DarkGray;
                but.StatePressed.Back.Color2 = System.Drawing.Color.DimGray;
                but.StatePressed.Back.ColorAngle = 45F;
                but.StatePressed.Border.Color1 = System.Drawing.Color.DarkGray;
                but.StatePressed.Border.Color2 = System.Drawing.Color.DimGray;
                but.StatePressed.Border.ColorAngle = 45F;
                but.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                but.StatePressed.Border.Rounding = r;
                but.StatePressed.Border.Width = 3;
                but.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
                but.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
                but.StateTracking.Back.Color1 = System.Drawing.Color.Gainsboro;
                but.StateTracking.Back.Color2 = System.Drawing.Color.DarkGray;
                but.StateTracking.Back.ColorAngle = 45F;
                but.StateTracking.Border.Color1 = System.Drawing.Color.Gainsboro;
                but.StateTracking.Border.Color2 = System.Drawing.Color.DarkGray;
                but.StateTracking.Border.ColorAngle = 45F;
                but.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                but.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
                but.StateTracking.Border.Rounding = r;
                but.StateTracking.Border.Width = 3;
                but.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
                but.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            }
            else 
                if (type == 12)
            {
                but.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
                but.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
                but.OverrideDefault.Border.Color1 = System.Drawing.Color.PaleGreen;
                but.OverrideDefault.Border.Color2 = System.Drawing.Color.LimeGreen;
                but.OverrideDefault.Border.ColorAngle = 45F;
                but.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                but.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
                but.OverrideDefault.Border.Rounding = r;
                but.OverrideDefault.Border.Width = 3;
                but.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.LimeGreen;
                but.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
                but.StateCommon.Back.Color1 = System.Drawing.Color.White;
                but.StateCommon.Back.Color2 = System.Drawing.Color.White;
                but.StateCommon.Border.Color1 = System.Drawing.Color.PaleGreen;
                but.StateCommon.Border.Color2 = System.Drawing.Color.LimeGreen;
                but.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                but.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
                but.StateCommon.Border.Rounding = r;
                but.StateCommon.Border.Width = 3;
                but.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.LimeGreen;
                but.StatePressed.Back.Color1 = System.Drawing.Color.LimeGreen;
                but.StatePressed.Back.Color2 = System.Drawing.Color.Green;
                but.StatePressed.Back.ColorAngle = 45F;
                but.StatePressed.Border.Color1 = System.Drawing.Color.LimeGreen;
                but.StatePressed.Border.Color2 = System.Drawing.Color.Green;
                but.StatePressed.Border.ColorAngle = 45F;
                but.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                but.StatePressed.Border.Rounding = r;
                but.StatePressed.Border.Width = 3;
                but.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
                but.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
                but.StateTracking.Back.Color1 = System.Drawing.Color.PaleGreen;
                but.StateTracking.Back.Color2 = System.Drawing.Color.Lime;
                but.StateTracking.Back.ColorAngle = 45F;
                but.StateTracking.Border.Color1 = System.Drawing.Color.PaleGreen;
                but.StateTracking.Border.Color2 = System.Drawing.Color.Lime;
                but.StateTracking.Border.ColorAngle = 45F;
                but.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                but.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
                but.StateTracking.Border.Rounding = r;
                but.StateTracking.Border.Width = 3;
                but.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
                but.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            }
            else 
            if (type == 13)
            {
                but.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
                but.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
                but.OverrideDefault.Border.Color1 = System.Drawing.Color.Gold;
                but.OverrideDefault.Border.Color2 = System.Drawing.Color.LimeGreen;
                but.OverrideDefault.Border.ColorAngle = 45F;
                but.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                but.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
                but.OverrideDefault.Border.Rounding = r;
                but.OverrideDefault.Border.Width = 3;
                but.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.Gold;
                but.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
                but.StateCommon.Back.Color1 = System.Drawing.Color.White;
                but.StateCommon.Back.Color2 = System.Drawing.Color.White;
                but.StateCommon.Border.Color1 = System.Drawing.Color.Gold;
                but.StateCommon.Border.Color2 = System.Drawing.Color.LimeGreen;
                but.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                but.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
                but.StateCommon.Border.Rounding = r;
                but.StateCommon.Border.Width = 3;
                but.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Gold;
                but.StatePressed.Back.Color1 = System.Drawing.Color.Gold;
                but.StatePressed.Back.Color2 = System.Drawing.Color.DarkGoldenrod;
                but.StatePressed.Back.ColorAngle = 45F;
                but.StatePressed.Border.Color1 = System.Drawing.Color.Gold;
                but.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                but.StatePressed.Border.Rounding = r;
                but.StatePressed.Border.Width = 3;
                but.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
                but.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
                but.StateTracking.Back.Color1 = System.Drawing.Color.Khaki;
                but.StateTracking.Back.Color2 = System.Drawing.Color.Gold;
                but.StateTracking.Back.ColorAngle = 45F;
                but.StateTracking.Border.Color1 = System.Drawing.Color.Gold;
                but.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                but.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
                but.StateTracking.Border.Rounding = r;
                but.StateTracking.Border.Width = 3;
                but.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
                but.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            }
            else
                if (type == 14)
            {
                but.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
                but.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
                but.OverrideDefault.Border.Color1 = System.Drawing.Color.Orange;
                but.OverrideDefault.Border.Color2 = System.Drawing.Color.LimeGreen;
                but.OverrideDefault.Border.ColorAngle = 45F;
                but.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                but.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
                but.OverrideDefault.Border.Rounding = r;
                but.OverrideDefault.Border.Width = 3;
                but.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.Orange;
                but.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
                but.StateCommon.Back.Color1 = System.Drawing.Color.White;
                but.StateCommon.Back.Color2 = System.Drawing.Color.White;
                but.StateCommon.Border.Color1 = System.Drawing.Color.Orange;
                but.StateCommon.Border.Color2 = System.Drawing.Color.LimeGreen;
                but.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                but.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
                but.StateCommon.Border.Rounding = r;
                but.StateCommon.Border.Width = 3;
                but.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Orange;
                but.StatePressed.Back.Color1 = System.Drawing.Color.Orange;
                but.StatePressed.Back.Color2 = System.Drawing.Color.OrangeRed;
                but.StatePressed.Back.ColorAngle = 45F;
                but.StatePressed.Border.Color1 = System.Drawing.Color.Gold;
                but.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                but.StatePressed.Border.Rounding = r;
                but.StatePressed.Border.Width = 3;
                but.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
                but.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
                but.StateTracking.Back.Color1 = System.Drawing.Color.PeachPuff;
                but.StateTracking.Back.Color2 = System.Drawing.Color.Orange;
                but.StateTracking.Back.ColorAngle = 45F;
                but.StateTracking.Border.Color1 = System.Drawing.Color.Orange;
                but.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                but.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
                but.StateTracking.Border.Rounding = r;
                but.StateTracking.Border.Width = 3;
                but.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
                but.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            }
            else
                if (type == 15)
            {
                but.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
                but.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
                but.OverrideDefault.Border.Color1 = System.Drawing.Color.MediumPurple;
                but.OverrideDefault.Border.Color2 = System.Drawing.Color.LimeGreen;
                but.OverrideDefault.Border.ColorAngle = 45F;
                but.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                but.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
                but.OverrideDefault.Border.Rounding = r;
                but.OverrideDefault.Border.Width = 3;
                but.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.MediumPurple;
                but.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
                but.StateCommon.Back.Color1 = System.Drawing.Color.White;
                but.StateCommon.Back.Color2 = System.Drawing.Color.White;
                but.StateCommon.Border.Color1 = System.Drawing.Color.MediumPurple;
                but.StateCommon.Border.Color2 = System.Drawing.Color.LimeGreen;
                but.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                but.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
                but.StateCommon.Border.Rounding = r;
                but.StateCommon.Border.Width = 3;
                but.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.MediumPurple;
                but.StatePressed.Back.Color1 = System.Drawing.Color.MediumPurple;
                but.StatePressed.Back.Color2 = System.Drawing.Color.DarkViolet;
                but.StatePressed.Back.ColorAngle = 45F;
                but.StatePressed.Border.Color1 = System.Drawing.Color.MediumPurple;
                but.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                but.StatePressed.Border.Rounding = r;
                but.StatePressed.Border.Width = 3;
                but.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
                but.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
                but.StateTracking.Back.Color1 = System.Drawing.Color.Plum;
                but.StateTracking.Back.Color2 = System.Drawing.Color.MediumPurple;
                but.StateTracking.Back.ColorAngle = 45F;
                but.StateTracking.Border.Color1 = System.Drawing.Color.MediumPurple;
                but.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                but.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
                but.StateTracking.Border.Rounding = r;
                but.StateTracking.Border.Width = 3;
                but.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
                but.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            }
            else
                if (type == 16)
            {
                but.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
                but.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
                but.OverrideDefault.Border.Color1 = System.Drawing.Color.Magenta;
                but.OverrideDefault.Border.Color2 = System.Drawing.Color.LimeGreen;
                but.OverrideDefault.Border.ColorAngle = 45F;
                but.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                but.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
                but.OverrideDefault.Border.Rounding = r;
                but.OverrideDefault.Border.Width = 3;
                but.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.Magenta;
                but.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
                but.StateCommon.Back.Color1 = System.Drawing.Color.White;
                but.StateCommon.Back.Color2 = System.Drawing.Color.White;
                but.StateCommon.Border.Color1 = System.Drawing.Color.Magenta;
                but.StateCommon.Border.Color2 = System.Drawing.Color.Magenta;
                but.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                but.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
                but.StateCommon.Border.Rounding = r;
                but.StateCommon.Border.Width = 3;
                but.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Magenta;
                but.StatePressed.Back.Color1 = System.Drawing.Color.Magenta;
                but.StatePressed.Back.Color2 = System.Drawing.Color.DarkMagenta;
                but.StatePressed.Back.ColorAngle = 45F;
                but.StatePressed.Border.Color1 = System.Drawing.Color.Magenta;
                but.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                but.StatePressed.Border.Rounding = r;
                but.StatePressed.Border.Width = 3;
                but.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
                but.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
                but.StateTracking.Back.Color1 = System.Drawing.Color.Plum;
                but.StateTracking.Back.Color2 = System.Drawing.Color.Magenta;
                but.StateTracking.Back.ColorAngle = 45F;
                but.StateTracking.Border.Color1 = System.Drawing.Color.Magenta;
                but.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                but.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
                but.StateTracking.Border.Rounding = r;
                but.StateTracking.Border.Width = 3;
                but.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
                but.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            }
            else
                if (type == 18)
            {
                but.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
                but.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
                but.OverrideDefault.Border.Color1 = System.Drawing.Color.Crimson;
                but.OverrideDefault.Border.Color2 = System.Drawing.Color.LimeGreen;
                but.OverrideDefault.Border.ColorAngle = 45F;
                but.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                but.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
                but.OverrideDefault.Border.Rounding = r;
                but.OverrideDefault.Border.Width = 3;
                but.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.Crimson;
                but.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
                but.StateCommon.Back.Color1 = System.Drawing.Color.White;
                but.StateCommon.Back.Color2 = System.Drawing.Color.White;
                but.StateCommon.Border.Color1 = System.Drawing.Color.Crimson;
                but.StateCommon.Border.Color2 = System.Drawing.Color.Magenta;
                but.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                but.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
                but.StateCommon.Border.Rounding = r;
                but.StateCommon.Border.Width = 3;
                but.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Crimson;
                but.StatePressed.Back.Color1 = System.Drawing.Color.Crimson;
                but.StatePressed.Back.Color2 = System.Drawing.Color.Maroon;
                but.StatePressed.Back.ColorAngle = 45F;
                but.StatePressed.Border.Color1 = System.Drawing.Color.Crimson;
                but.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                but.StatePressed.Border.Rounding = r;
                but.StatePressed.Border.Width = 3;
                but.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
                but.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
                but.StateTracking.Back.Color1 = System.Drawing.Color.Red;
                but.StateTracking.Back.Color2 = System.Drawing.Color.Crimson;
                but.StateTracking.Back.ColorAngle = 45F;
                but.StateTracking.Border.Color1 = System.Drawing.Color.Crimson;
                but.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                but.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
                but.StateTracking.Border.Rounding = r;
                but.StateTracking.Border.Width = 3;
                but.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
                but.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            }
            else
                if (type == 19)
            {
                but.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
                but.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
                but.OverrideDefault.Border.Color1 = System.Drawing.Color.MediumBlue;
                but.OverrideDefault.Border.Color2 = System.Drawing.Color.LimeGreen;
                but.OverrideDefault.Border.ColorAngle = 45F;
                but.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                but.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
                but.OverrideDefault.Border.Rounding = r;
                but.OverrideDefault.Border.Width = 3;
                but.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.MediumBlue;
                but.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
                but.StateCommon.Back.Color1 = System.Drawing.Color.White;
                but.StateCommon.Back.Color2 = System.Drawing.Color.White;
                but.StateCommon.Border.Color1 = System.Drawing.Color.MediumBlue;
                but.StateCommon.Border.Color2 = System.Drawing.Color.Magenta;
                but.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                but.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
                but.StateCommon.Border.Rounding = r;
                but.StateCommon.Border.Width = 3;
                but.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.MediumBlue;
                but.StatePressed.Back.Color1 = System.Drawing.Color.MediumBlue;
                but.StatePressed.Back.Color2 = System.Drawing.Color.DarkBlue;
                but.StatePressed.Back.ColorAngle = 45F;
                but.StatePressed.Border.Color1 = System.Drawing.Color.MediumBlue;
                but.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                but.StatePressed.Border.Rounding = r;
                but.StatePressed.Border.Width = 3;
                but.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
                but.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
                but.StateTracking.Back.Color1 = System.Drawing.Color.RoyalBlue;
                but.StateTracking.Back.Color2 = System.Drawing.Color.MediumBlue;
                but.StateTracking.Back.ColorAngle = 45F;
                but.StateTracking.Border.Color1 = System.Drawing.Color.MediumBlue;
                but.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                but.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
                but.StateTracking.Border.Rounding = r;
                but.StateTracking.Border.Width = 3;
                but.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
                but.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            }
        }
    }
}
