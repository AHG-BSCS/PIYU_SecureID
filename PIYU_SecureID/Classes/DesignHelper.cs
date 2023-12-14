using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIYU_SecureID.Classes;

internal static class DesignHelper
{
    static internal readonly Color COLOR_BLUE = Color.FromArgb(53, 69, 93);
    static internal readonly Color COLOR_TEAL = Color.FromArgb(60, 95, 106);
    static internal readonly Color COLOR_WHITE = Color.White;
    static internal readonly Color COLOR_YELLOW = Color.FromArgb(250, 201, 48);
    static internal readonly int borderRadius = 20;

    static internal void PaintRoundBorder(Form form)
    {
        using (GraphicsPath path = new GraphicsPath())
        {
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(form.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(form.Width - borderRadius, form.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, form.Height - borderRadius, borderRadius, borderRadius, 90, 90);

            form.Region = new Region(path);
        }
    }

    static internal float GetSystemDisplayScale()
    {
        return Graphics.FromHwnd(IntPtr.Zero).DpiX / 96f;
    }

    static internal float BaseWidthFactor()
    {
        return (Screen.PrimaryScreen.Bounds.Width / 1366f) * GetSystemDisplayScale();
        //return (1920f / 1366f);
    }

    static internal float BaseHeightFactor()
    {
        return (Screen.PrimaryScreen.Bounds.Height / 768f) * GetSystemDisplayScale();
        //return (1080f / 768f);
    }
}
