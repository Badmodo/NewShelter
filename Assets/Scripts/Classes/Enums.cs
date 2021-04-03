using System;

namespace MySpace
{
    public static class Enums
    {
        // Game states
        public enum GameStates { None, Normal, GuiBlocking, BuildRoom, RoomSelected, ManPressed, ManSelected, ManDragging };

        // Cursor states
        public enum CursorStates { None, Normal, CamDrag, ManDrag, GuiBlocking };

        // Movement/Grid-Link directions, showing possible movement directions (bitfield). 
        [Flags] public enum MoveDirections : Int32 { Left = 1, Right = 2, Top = 4, Bottom = 8, Front = 16, Back = 32 };

        // Room related enums
        public enum RoomSizes
        { None = 0, Size1 = 1, Size2 = 2, Size4 = 4, Size6 = 6 };

        public enum RoomCategories
        { None, Standard, Other }

        public enum RoomTypes
        { None, Common, Elevator };

        // Avatar/man related enums
        public enum ManTypes
        { None, StandardMan }

        public enum ManStates
        { None, Idle, Running, RotatingToPlayer, Rotating, Waiting };
    }
}
