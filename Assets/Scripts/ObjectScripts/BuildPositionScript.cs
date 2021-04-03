// This script is attached to the room building position markers

using MySpace;
using UnityEngine;

public class BuildPositionScript : MonoBehaviour
{
    public Enums.RoomSizes RoomSize = Enums.RoomSizes.None;
    public Enums.RoomTypes RoomType = Enums.RoomTypes.None;
    public GridIndex LeftmostIndex;


    void Start()
    {
        Debug.Assert(RoomSize != Enums.RoomSizes.None);
        Debug.Assert(RoomType != Enums.RoomTypes.None);
        Debug.Assert(LeftmostIndex.IsValid() == true);
    }

    public void SetRoomInfoData(Enums.RoomSizes roomSize, Enums.RoomTypes roomType, GridIndex leftMostIndex)
    {
        RoomSize = roomSize;
        RoomType = roomType;
        LeftmostIndex = leftMostIndex;
    }
}
