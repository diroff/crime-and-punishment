using UnityEngine;

public class RoomController : MonoBehaviour
{
    [SerializeField] private Room _startRoom;

    private Room _currentRoom;
    private Room _nextRoom;

    private void Start()
    {
        _currentRoom = _startRoom;
        OpenRoom(_currentRoom);
    }

    public void OpenRoom(Room room)
    {
        _currentRoom.SetRoomState(false);
        _nextRoom = room;
        _nextRoom.SetRoomState(true);
        _currentRoom = _nextRoom;
    }
}