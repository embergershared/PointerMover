using PointerMover.Structs;

namespace PointerMover.Classes
{
    internal class PointerHelper
    {
        //
        // Static methods
        //
        #region Static methods

        // Get current cursor position
        public static PointerPosition? GetCurrentPosition()
        {
            var pointer_point = new WinPoint();
            if (!PointerWrapper.GetCursorPosition(ref pointer_point))
            {
                return new PointerPosition();
            }
            else
            {
                return new PointerPosition(pointer_point);
            }
        }

        // Set cursor position absolute
        public static bool SetPositionAbsolute(PointerPosition cPos)
        {
            // Get resolution
            var res_info = DesktopHelper.GetResolution();

            // Absolute coordinates are from 0 to 65536
            int real_x = (cPos.X * 65536) / res_info.Width;
            int real_y = (cPos.Y * 65536) / res_info.Height;

            // Create INPUT structure
            var input = new SendInputWrapper.Input();
            // Fill it
            input.mType = SendInputWrapper.eInputTypes.INPUT_MOUSE;
            input.mData.mMi.mMouseData = 0;
            input.mData.mMi.mTime = 0;
            input.mData.mMi.mX = real_x;
            input.mData.mMi.mY = real_y;
            input.mData.mMi.mFlags = SendInputWrapper.eMouseEventFlags.MOUSEEVENTF_ABSOLUTE | SendInputWrapper.eMouseEventFlags.MOUSEEVENTF_MOVE;
            // Send input
            return SendInputWrapper.SendInput(input);
        }

        // Set cursor position relative 
        public static bool SetPositionRelative(int cDeltaX, int cDeltaY)
        {
            // Create INPUT structure
            var input = new SendInputWrapper.Input();
            // Fill it
            input.mType = SendInputWrapper.eInputTypes.INPUT_MOUSE;
            input.mData.mMi.mMouseData = 0;
            input.mData.mMi.mTime = 0;
            input.mData.mMi.mX = cDeltaX;
            input.mData.mMi.mY = cDeltaY;
            input.mData.mMi.mFlags = SendInputWrapper.eMouseEventFlags.MOUSEEVENTF_MOVE;
            // Send input
            return SendInputWrapper.SendInput(input);
        }

        // Check absolute position
        public static bool CheckAbsolutePosition(PointerPosition cPos)
        {
            var resInfo = DesktopHelper.GetResolution();
            return (((cPos.X >= 0) && (cPos.X <= resInfo.Width)) &&
                    ((cPos.Y >= 0) && (cPos.Y <= resInfo.Height)));
        }

        // Check relative position
        public static bool CheckRelativePosition(int cDeltaX,
                                                 int cDeltaY)
        {
            // Compute the new position
            var newPos = GetCurrentPosition();
            if (newPos == null) return false;
            newPos.MoveRelative(cDeltaX, cDeltaY);

            return CheckAbsolutePosition(newPos);
        }

        #endregion
    }
}
