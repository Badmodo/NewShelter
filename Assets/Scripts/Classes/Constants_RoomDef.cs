// Static class for all constants and pre-defs (partial).

namespace MySpace
{
    public static partial class Constants
    {
        // Room definitions
        public static readonly GridIndex EntranceRoomIndex = new GridIndex(0, GridSurfaceY, 0);
        public static readonly Enums.RoomSizes EntranceRoomSize = Enums.RoomSizes.Size2;
        public static readonly Enums.RoomTypes EntranceRoomType = Enums.RoomTypes.Common;

        // Room data - might be moved to a file or database or so later. Unique index is combo size+type
        public static readonly RoomDefData[] RoomDefinitions = new RoomDefData[]
        {
        new RoomDefData (
            "Common Room Size 2",
            "Room_Prefabs/Room_All_Standard_Sz2",
            Enums.RoomSizes.Size2,
            Enums.RoomTypes.Common,
            Enums.RoomCategories.Standard,
            2,
            new Enums.ManStates[] { Enums.ManStates.Idle, Enums.ManStates.Idle },
            "A standard room of small size. Can hold 2 men."
            ),

        new RoomDefData (
            "Common Room Size 4",
            "Room_Prefabs/Room_All_Standard_Sz4",
            Enums.RoomSizes.Size4,
            Enums.RoomTypes.Common,
            Enums.RoomCategories.Standard,
            4,
            new Enums.ManStates[] { Enums.ManStates.Idle, Enums.ManStates.Idle,
                                    Enums.ManStates.Idle, Enums.ManStates.Idle },
            "A standard room of medium size. Can hold 4 men."
            ),

        new RoomDefData (
            "Common Room Size 6",
            "Room_Prefabs/Room_All_Standard_Sz6",
            Enums.RoomSizes.Size6,
            Enums.RoomTypes.Common,
            Enums.RoomCategories.Standard,
            6,
            new Enums.ManStates[] { Enums.ManStates.Idle, Enums.ManStates.Idle,
                                    Enums.ManStates.Idle, Enums.ManStates.Idle,
                                    Enums.ManStates.Idle, Enums.ManStates.Idle },
            "A standard room of large size. Can hold 6 men."
            ),

        new RoomDefData (
            "Elevator",
            "Room_Prefabs/Room_Other_Elevator_Sz1",
            Enums.RoomSizes.Size1,
            Enums.RoomTypes.Elevator,
            Enums.RoomCategories.Other,
            0,
            new Enums.ManStates[] {  },
            "The elevator room is of size 1. It can not hold any men."
            )
        };
    }
}
