using PointerMover.Structs;

namespace PointerMover.Classes;

public class PointerPosition
{
    #region Constants

    // Invalid value
    private const int ResetValue = -1;

    #endregion

    #region Members

    private int _pointerX;
    private int _pointerY;
    //private WinPoint pointerPoint;

    #endregion

    #region Properties

    // X property
    public int X
    {
        get { return _pointerX; }
    }

    // Y property
    public int Y
    {
        get { return _pointerY; }
    }

    #endregion

    #region Constructors

    public PointerPosition()
    {
        _pointerX = ResetValue;
        _pointerY = ResetValue;
    }

    public PointerPosition(WinPoint pointerPoint) => MoveAbsolute(pointerPoint.mX, pointerPoint.mY);

    #endregion

    #region Public methods

    // Move to absolute position
    public void MoveAbsolute(int cX, int cY)
    {
        _pointerX = cX;
        _pointerY = cY;
    }

    // Move to relative position
    public void MoveRelative(int cDeltaX, int cDeltaY)
    {
        _pointerX += cDeltaX;
        _pointerY += cDeltaY;
    }


    // Equal operator
    public bool IsSamePosition (PointerPosition pointerPosition)
    {
        return ((_pointerX == pointerPosition.X) && (_pointerY == pointerPosition.Y));
    }

    #endregion
}