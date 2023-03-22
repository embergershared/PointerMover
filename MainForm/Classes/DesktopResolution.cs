using System;
using System.Runtime.InteropServices;
using MainForm.Structs;

namespace MainForm.Classes;

public class DesktopResolution
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

    //
    // Static methods
    //
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