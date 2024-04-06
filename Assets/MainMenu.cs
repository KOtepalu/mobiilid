using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame() {
        SceneManager.LoadSceneAsync("Game"); // Käivitab olemasoleva mängu stseeni
    }

    public void PlayTiltGame() {
        SceneManager.LoadSceneAsync("GameTilt"); // Laeb sisse tilt-mängu stseeni
    }

    public void QuitGame() {
        Application.Quit();
    }
}