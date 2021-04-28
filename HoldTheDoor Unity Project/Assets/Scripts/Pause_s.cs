using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause_s : MonoBehaviour
{

    private bool gameOn = true;

    public void ClickPause()
    {
        if(gameOn)
        {
            PauseGame();
            gameOn = false;
        }
        else
        {
            ResumeGame();
            gameOn = true;
        }
    }

    void PauseGame()
    {
        Time.timeScale = 0;
    }

    void ResumeGame()
    {
        Time.timeScale = 1;
    }
}
