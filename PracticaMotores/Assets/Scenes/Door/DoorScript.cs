using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public GameObject key;
    public GameObject door;
    public float doorIncrement = 1.0f;
    public float maxDoorPositionY = 20.0f;
    private bool hasKey = false;
    private bool doorStopped = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Key"))
        {
            hasKey = true;
            Destroy(other.gameObject);
        }
    }

    void Update()
    {
        if (hasKey && door != null && !doorStopped)
        {
            door.transform.Translate(new Vector3(0, doorIncrement, 0));
            if (door.transform.position.y > maxDoorPositionY)
            {
                doorStopped = true;
            }
        }
    }
}
