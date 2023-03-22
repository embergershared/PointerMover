using MainForm.Interfaces;
using System.Windows.Forms;

namespace MainForm.Classes
{
    internal class PointerMover : IPointerMover
    {
        #region Members

        // Last cursor position
        private PointerPosition? _pointerLastPos;
        // Moving pixels amount
        private int _pixelMoveValue;
        // Back and Forth control
        private bool _moveAway;

        #endregion

        #region Constructor
        
        public PointerMover()
        {
            //Initialize(5);
            _moveAway = true;
        }

        #endregion

        #region Public Methods
        
        public void Initialize(int movePixelValue)
        {
            _pixelMoveValue = movePixelValue;
            _pointerLastPos = PointerHelper.GetCurrentPosition();
        }

        public void MovePointer()
        {
            var currentPointerPosition = PointerHelper.GetCurrentPosition();

            if (_pointerLastPos != null && currentPointerPosition != null)
            {
                // If the pointer didn't move since last interval, we move it
                if (_pointerLastPos.IsSamePosition(currentPointerPosition))
                {
                    var moveValue = _moveAway ? (1 * _pixelMoveValue) : (-1 * _pixelMoveValue);
                    PerformMove(moveValue);
                    _moveAway = !_moveAway;
                }
            }

            // Update Last pointer position
            _pointerLastPos = PointerHelper.GetCurrentPosition();
        }

        private void PerformMove(int moveValue)
        {
            // Calculating potential new pointer position:
            var currentPosition = PointerHelper.GetCurrentPosition();
            var deltaX = moveValue;
            var deltaY = moveValue;
            if (currentPosition != null)
            {
                var potNewX = currentPosition.X + deltaX;
                var potNewY = currentPosition.Y + deltaY;

                // Checking we stay on the screen, if not, we reverse the delta
                foreach (var screen in Screen.AllScreens)
                {
                    // Getting this screen boundaries
                    var bounds = screen.Bounds;
                    if (currentPosition.X < bounds.X || currentPosition.X > (bounds.X + bounds.Width)) continue;
                    // We are on the screen that has the pointer
                    if (potNewX < bounds.X || potNewX > bounds.Right)
                    {
                        deltaX = -deltaX;
                    }
                    if (potNewY < bounds.Y || potNewY > bounds.Bottom)
                    {
                        deltaY = -deltaY;
                    }

                    break;
                }
            }

            // Now we move the Pointer
            PointerHelper.SetPositionRelative(deltaX, deltaY);
        }

        #endregion
    }
}
