using System.Collections;
using System.Collections.Generic;
using UnityEditor.Overlays;
using UnityEngine;

public class KeyController : MonoBehaviour
{
    public GameObject door; // Reference to the door game object
    public GameObject doorOpen; // Prefab of door Opened

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject); // Destroy the key object
            UnlockDoor();
        }
    }

    private void UnlockDoor()
    {
        if (door != null)
        {
            Vector3 doorPosition = door.transform.position;
            Destroy(door); // Destroy the door object

            Instantiate(doorOpen, doorPosition, Quaternion.identity);
        }
    }
}
