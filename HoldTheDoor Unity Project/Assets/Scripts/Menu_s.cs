using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu_s : MonoBehaviour
{
    public void Play_scene()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void Menu_scene()
    {
        SceneManager.LoadScene(0);
    }

    public void Quit_scene()
    {
        Application.Quit();
    }
}
