using System.Runtime.InteropServices;

namespace PointerMover.Structs;

[StructLayout(LayoutKind.Sequential)]
public struct WinPoint
{
    public int mX;
    public int mY;
}