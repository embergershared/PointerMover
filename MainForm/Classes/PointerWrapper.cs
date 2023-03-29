using System.Runtime.InteropServices;
using PointerMover.Structs;

namespace PointerMover.Classes
{
    internal class PointerWrapper
    {
        //
        // DLL imports
        //
        #region DLL imports

        // GetCursorPos API import
        [DllImport("User32.Dll")]
        private static extern int GetCursorPos(ref WinPoint pPoint);

        // SetCursorPos API import
        [DllImport("User32.Dll")]
        private static extern int SetCursorPos(int pX, int pY);

        #endregion

        //
        // Static methods
        //
        #region Static methods

        // Get cursor position 
        public static bool GetCursorPosition(ref WinPoint rPoint)
        {
            return (GetCursorPos(ref rPoint) == WinBool.TRUE);
        }

        // Set cursor position
        public static bool SetCursorPosition(WinPoint cPoint)
        {
            return (SetCursorPos(cPoint.mX, cPoint.mY) == WinBool.TRUE);
        }

        #endregion
    }
}
