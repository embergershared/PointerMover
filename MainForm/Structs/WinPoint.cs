using System.Runtime.InteropServices;

namespace MainForm.Structs;

[StructLayout(LayoutKind.Sequential)]
public struct WinPoint
{
    public int mX;
    public int mY;
}