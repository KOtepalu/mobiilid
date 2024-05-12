using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void PlayGame()
    {
        string lastVisitedGame = PlayerPrefs.GetString("LastVisitedGame", "Main");
        SceneManager.LoadSceneAsync(lastVisitedGame);
    }
    
    public void BackToMain()
    {
        SceneManager.LoadSceneAsync("Main"); //l�heb MainMenu vaatesse
    }

}