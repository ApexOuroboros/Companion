using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sheepToMain : MonoBehaviour
{
    public GameObject human;

    void OnTriggerEnter(Collider other)
    {
        GameObject.FindWithTag("Human");

        if (other.gameObject.CompareTag("Human"))
        {
            //Debug.Log("baa");
            SceneManager.LoadScene(0);
        }
    }

}
