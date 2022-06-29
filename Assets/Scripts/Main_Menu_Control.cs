using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu_Control : MonoBehaviour
{
    //Plays game
    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    //Loads credit scene
    public void LoadCreditsScene()
    {
        SceneManager.LoadScene("Credits");
    }

    //Loads main menu
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
