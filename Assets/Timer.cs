using UnityEngine;

public class Timer : MonoBehaviour
{
    private float startTime;
    private float endTime;

    void Start()
    {
        
        startTime = Time.time;
    }

    void Update()
    {
        endTime = Time.time;
    }

    // Call this method when the player collides with a block
    public void RecordEndTime()
    {
        endTime = Time.time;
        SaveEndTimeToFile(endTime);
    }

    private void SaveEndTimeToFile(float endTime)
    {
        Debug.Log("end time persistentDataPath: " + Application.persistentDataPath);

        string endTimeString = endTime.ToString();

        DataManager.SaveData(endTimeString, "endTime.txt");
    }
}