﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace MasterProxyWinform.Util
{
    public class TextBoxEx : TextBox
    {
        public String PlaceHolderStr { get; set; }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 0xF || m.Msg == 0x133)
            {
                WmPaint(ref m);
            }
        }
        private void WmPaint(ref Message m)
        {
            Graphics g = Graphics.FromHwnd(base.Handle);
            if (!String.IsNullOrEmpty(this.PlaceHolderStr) && string.IsNullOrEmpty(this.Text))
                g.DrawString(this.PlaceHolderStr, this.Font, new SolidBrush(Color.Gray), 0, 0);
        }
    }
}
