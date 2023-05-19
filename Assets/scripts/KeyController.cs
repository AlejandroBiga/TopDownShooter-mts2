using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{
    public GameObject door; // Reference to the door game object

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
            Destroy(door); // Destroy the door object
        }
    }
}
