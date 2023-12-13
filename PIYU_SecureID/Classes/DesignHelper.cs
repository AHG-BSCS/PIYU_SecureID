using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIYU_SecureID.Classes;

internal static class DesignHelper
{
    static internal readonly Color COLOR_BLUE = Color.FromArgb(53, 69, 93);
    static internal readonly Color COLOR_TEAL = Color.FromArgb(60, 95, 106);

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
