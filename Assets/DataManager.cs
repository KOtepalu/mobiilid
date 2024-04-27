using UnityEngine;
using System.IO;

public class DataManager : MonoBehaviour
{
    // Salvesta skoor faili
    public static void SaveScore(int score, string fileName)
    {
        // Teisenda skoor tekstiks
        string scoreText = score.ToString();

        // Salvesta skoor
        SaveData(scoreText, fileName);
    }

    // Laadi skoor failist
    public static int LoadScore(string fileName)
    {
        // Laadi salvestatud skoor tekstina
        string scoreText = LoadData(fileName);

        // Kontrolli, kas skoor on laetud
        if (scoreText != null)
        {
            // Teisenda tekst tagasi täisarvuks
            int score = int.Parse(scoreText);
            return score;
        }
        else
        {
            // Kui skoori ei leitud, tagasta vaikimisi väärtus
            Debug.LogWarning("Score file not found: " + fileName);
            return 0;
        }
    }

    // Salvesta andmed faili
    public static void SaveData(string dataToSave, string fileName)
    {
        string path = Path.Combine(Application.persistentDataPath, fileName);

        // Kirjuta tekst faili
        File.WriteAllText(path, dataToSave);
    }

    // Laadi andmed failist
    private static string LoadData(string fileName)
    {
        string path = Path.Combine(Application.persistentDataPath, fileName);

        // Kontrolli, kas fail eksisteerib
        if (File.Exists(path))
        {
            // Loe tekst failist
            return File.ReadAllText(path);
        }
        else
        {
            Debug.LogWarning("File not found: " + fileName);
            return null;
        }
    }
}