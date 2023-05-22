using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject nokey;
    public GameObject key;
    //public GameObject btnDoor;

    void Start()
    {
        key.SetActive(false);
        nokey.SetActive(false);
        //btnDoor.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("key)"))
        {
            OpenDoor.key += 1;
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag.Equals("door") && OpenDoor.key == 0)
        {
            nokey.SetActive(true);
        }

        if (collision.tag.Equals("door") && OpenDoor.key == 1)
        {
            key.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }
}
