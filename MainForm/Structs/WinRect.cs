using System.Runtime.InteropServices;

namespace PointerMover.Structs;

//
// Windows RECT equivalent structure 
//
[StructLayout(LayoutKind.Sequential)]
public struct WinRect
{
    public int mLeft;
    public int mTop;
    public int mRight;
    public int mBottom;
}
