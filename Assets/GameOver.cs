using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Game"); //käivitab olemasoleva mängu stseeni
    }
    
    public void BackToMain()
    {
        SceneManager.LoadSceneAsync("Main"); //läheb MainMenu vaatesse
    }
}
