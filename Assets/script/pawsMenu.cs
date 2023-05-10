using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pawsMenu : MonoBehaviour
{
    public static bool isPawsed = false;

    public GameObject pawsMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;

            if(isPawsed)
            {
                Resume();
            }
            else
            {
                Paws();
            }

        }
    }

    public void Resume()
    {
        pawsMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPawsed = false;
    }

    void Paws()
    {
        pawsMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPawsed=true;
    }

    public void ExitGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

}
