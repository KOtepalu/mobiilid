using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class DataSender : MonoBehaviour
{
    // Define the data structure you want to send
    [System.Serializable]
    public class MyData
    {
        public string name;
        public int age;
    }

    IEnumerator SendData(string url, MyData data)
    {
        // Convert data to JSON string
        string jsonData = JsonUtility.ToJson(data);

        // Create UnityWebRequest
        UnityWebRequest request = new UnityWebRequest(url, "POST");
        byte[] bodyRaw = System.Text.Encoding.UTF8.GetBytes(jsonData);
        request.uploadHandler = (UploadHandler)new UploadHandlerRaw(bodyRaw);
        request.downloadHandler = (DownloadHandler)new DownloadHandlerBuffer();
        request.SetRequestHeader("Content-Type", "application/json");

        // Send the request
        yield return request.SendWebRequest();

        // Check for errors
        if (request.result == UnityWebRequest.Result.Success)
        {
            Debug.Log("Data sent successfully");
            Debug.Log("Response: " + request.downloadHandler.text);
        }
        else
        {
            Debug.LogError("Error sending data: " + request.error);
        }
    }

    // Example usage
    void Start()
    {
        // Create data object
        MyData data = new MyData();
        data.name = "John";
        data.age = 30;

        // Start coroutine to send data
        StartCoroutine(SendData("https://reqres.in/api/users", data));
    }

        public void SendDataToServer ()
    {
        Start();
    }
}
