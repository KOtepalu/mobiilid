using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame() {
        PlayerPrefs.SetString("VisitedGame", "true");

        SceneManager.LoadSceneAsync("Game"); 
    }

    public void PlayTiltGame() {
        PlayerPrefs.SetString("VisitedGameTilt", "true");

        SceneManager.LoadSceneAsync("GameTilt"); // Laeb sisse tilt-mängu stseeni
    }

    public void QuitGame() {
        Application.Quit();
    }
}