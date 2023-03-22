using MainForm.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Classes
{
    public static class DesktopHelper
    {
        #region Static methods

        // Get desktop resolution
        public static ResolutionInfo GetResolution()
        {
            IntPtr desktop_hwnd = GetWindowRectWrapper.GetDesktopWindow();

            var desktop_rect = new WinRect();
            if (!GetWindowRectWrapper.GetWindowRectangle(desktop_hwnd, ref desktop_rect))
            {
                return new ResolutionInfo();
            }
            else
            {
                return new ResolutionInfo(desktop_rect);
            }
        }

        #endregion

    }
}
