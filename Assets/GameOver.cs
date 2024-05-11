using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void PlayGame()
{
    // Check for PlayerPrefs data indicating previous visits
    if (PlayerPrefs.HasKey("VisitedGameTilt"))
    {
        // Load GameTilt scene if player has visited it before
        SceneManager.LoadSceneAsync("GameTilt");
    }
    else if (PlayerPrefs.HasKey("VisitedGame"))
    {
        // Load Game scene if player has visited it before
        SceneManager.LoadSceneAsync("Game");
    }
    else
    {
        // Default behavior if no previous visits are recorded (optional)
        // You can choose to load a specific scene here (e.g., first level)
        // or display a message explaining the options
        Debug.Log("No previous visits detected. Loading default scene...");
        // SceneManager.LoadSceneAsync("DefaultScene");  // Replace with your default scene name (if applicable)
    }
}
    
    public void BackToMain()
    {
        SceneManager.LoadSceneAsync("Main"); //l�heb MainMenu vaatesse
    }
}
