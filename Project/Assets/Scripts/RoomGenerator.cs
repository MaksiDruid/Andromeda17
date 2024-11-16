using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomGenerator : MonoBehaviour
{
    [SerializeField] List<Rigidbody> roomsRbs = new List<Rigidbody>();
    [SerializeField] List<Transform> roomsPos = new List<Transform>();
    [SerializeField] Rigidbody firstRoom;
    [SerializeField] float speed;
    private int roomsCount;

    // Start is called before the first frame update
    void Awake()
    {
        firstRoom.gameObject.SetActive(true);
        roomsCount = roomsRbs.Count;

        foreach (var room in roomsPos) 
        {
            GenerateRoom(room);
        }
    }

    private void GenerateRoom(Transform room)
    {
        int randomNum = Random.Range(0, roomsCount);
        while (roomsRbs[randomNum].gameObject.activeSelf == true)
        {
            randomNum = Random.Range(0, roomsCount);
        }
        roomsRbs[randomNum].transform.position = room.position;
        roomsRbs[randomNum].gameObject.SetActive(true);
    }
}
