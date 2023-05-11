using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider : MonoBehaviour
{

    public GameObject player;
    public Transform respawnPoint;

    void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Player")
        {
            player.transform.position = respawnPoint.transform.position;
        }
    }
    
}
