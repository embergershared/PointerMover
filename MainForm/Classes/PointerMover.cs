using MainForm.Interfaces;
using Microsoft.Extensions.Localization;
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
        // Localization
        private readonly IStringLocalizer<PointerMover> _localizer;

        // Debug infos display
        private Label? _labelAction;
        private Label? _labelX;
        private Label? _labelY;

        #endregion

        #region Constructor

        public PointerMover(
            IStringLocalizer<PointerMover> localizer
            )
        {
            //Initialize(5);
            _moveAway = true;
            _localizer = localizer;
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
                    var direction = _moveAway ? _localizer["away"] : _localizer["back"];
                    // ReSharper disable once LocalizableElement
                    if (_labelAction != null) _labelAction.Text = $"{_localizer["Moving pointer"]} {direction}.";

                    var moveValue = _moveAway ? (1 * _pixelMoveValue) : (-1 * _pixelMoveValue);
                    PerformMove(moveValue);
                    _moveAway = !_moveAway;
                }
                else
                {
                    if (_labelAction != null) _labelAction.Text = @"Pointer has already been moved.";
                    _moveAway = true;
                }
            }

            // Update Last pointer position
            _pointerLastPos = PointerHelper.GetCurrentPosition();
            if (_pointerLastPos == null) return;
            if (_labelX != null) _labelX.Text = @$"X: {_pointerLastPos.X}";
            if (_labelY != null) _labelY.Text = @$"Y: {_pointerLastPos.Y}";
        }

        public void ShareDebugInfos(Label labelAction, Label labelX, Label labelY)
        {
            _labelAction = labelAction;
            _labelX = labelX;
            _labelY = labelY;
        }

        private static void PerformMove(int moveValue)
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
