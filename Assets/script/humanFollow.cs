using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class humanFollow : MonoBehaviour
{
    public Transform Player;
    public int speed = 4;
    public int maxDist = 10;
    public int minDist = 5;

    // Update is called once per frame
    void Update()
    {
        
        transform.LookAt(Player);

        if(Vector3.Distance(transform.position, Player.position) <= maxDist)
        {
            transform.position += transform.forward * speed * Time.deltaTime;

            if (Input.GetKey(KeyCode.B))
            {
                
                Debug.Log("Bark");
            }

            if (Vector3.Distance(transform.position, Player.position) <= minDist)
            {
                //disable
            }

        }



    }
}
