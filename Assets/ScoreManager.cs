using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public Text scoreText;
    public static int scoreCount;
    public Text hiScoreText;
    public static int hiScoreCount;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("persistentDataPath: " + Application.persistentDataPath);

        hiScoreCount = DataManager.LoadScore("highscore.txt");

        if (PlayerPrefs.HasKey("HighScore"))
        {
            int playerPrefsHighScore = PlayerPrefs.GetInt("HighScore");
            // Võrdle salvestatud kõrge skoori DataManageri salvestatud kõrge skooriga
            if (playerPrefsHighScore > hiScoreCount)
            {
                // Salvestage uus kõrge skoor DataManageriga
                DataManager.SaveScore(playerPrefsHighScore, "highscore.txt");
                hiScoreCount = playerPrefsHighScore;
            }
        }  
    }

    // Update is called once per frame
    void Update()
    {
        if(scoreCount > hiScoreCount)
        {
            hiScoreCount = scoreCount;
            // Salvestage uus kõrge skoor
            DataManager.SaveScore(hiScoreCount, "highscore.txt");
            // Salvestage uus kõrge skoor ka PlayerPrefs'iga
            PlayerPrefs.SetInt("HighScore", hiScoreCount);
        }

        scoreText.text = "Score: " + Mathf.Round(scoreCount);
        DataManager.SaveScore(scoreCount, "score.txt");

        hiScoreText.text = "Hi-Score: " + Mathf.Round(hiScoreCount);
        
    }
}
