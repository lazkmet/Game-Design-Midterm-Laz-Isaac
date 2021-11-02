using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausedUI;
    bool isPaused = false;

    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            TogglePauseMenu();
        }
    }

    public void TogglePauseMenu()
    {
        if (isPaused == true)
        {
            Time.timeScale = 1;

            pausedUI.SetActive(false);
            isPaused = false;
        }
        else
        {
            Time.timeScale = 0;

            pausedUI.SetActive(true);
            isPaused = true;
        }

    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Restart() {
        SceneManager.LoadScene("CannonRoom");
    }
}
