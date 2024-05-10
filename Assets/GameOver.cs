using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Game"); //k�ivitab olemasoleva m�ngu stseeni
    }
    
    public void BackToMain()
    {
        SceneManager.LoadSceneAsync("Main"); //l�heb MainMenu vaatesse
    }
}
