using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using MainForm.Structs;

namespace MainForm.Classes
{
    static class GetWindowRectWrapper
    {
        //
        // DLL imports
        //
        #region DLL imports

        // GetCursorPos API import 
        [DllImport("User32.Dll")]
        public static extern IntPtr GetDesktopWindow();

        // GetCursorPos API import
        [DllImport("User32.Dll")]
        private static extern int GetWindowRect(IntPtr cHWnd, ref WinRect rRect);

        #endregion

        //
        // Static methods
        //
        #region Static methods

        // Get window rectangle
        public static bool GetWindowRectangle(IntPtr cHWnd,
            ref WinRect rRect)
        {
            return (GetWindowRect(cHWnd, ref rRect) != WinBool.FALSE);
        }

        #endregion
    }
}
