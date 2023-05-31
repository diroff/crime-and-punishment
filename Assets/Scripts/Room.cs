using UnityEngine;

public class Room : MonoBehaviour
{
    [SerializeField] private GameObject _room;

    public void SetRoomState(bool open)
    {
        _room.SetActive(open);
    }
}