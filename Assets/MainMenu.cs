using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        PlayerPrefs.SetString("LastVisitedGame", "Game");
        SceneManager.LoadSceneAsync("Game");
    }

    public void PlayTiltGame()
    {
        PlayerPrefs.SetString("LastVisitedGame", "GameTilt");
        SceneManager.LoadSceneAsync("GameTilt");
    }


    public void QuitGame() {
        Application.Quit();
    }
}