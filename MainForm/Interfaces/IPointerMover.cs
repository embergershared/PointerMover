using System.Windows.Forms;

namespace MainForm.Interfaces;

public interface IPointerMover
{
    void Initialize(int movePixelValue);
    void MovePointer();
    void ShareDebugInfos(Label labelAction, Label labelX, Label labelY);
}