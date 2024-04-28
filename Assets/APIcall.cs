using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Networking;
using System;

public class APIcall : MonoBehaviour
{
    [Serializable]
    public class UserData
    {
        public string first_name;
    }

    public TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        // Call the API when the script starts
        RefreshData();
    }

    public void OnRefresh ()
    {
        // Call the API when the button is clicked
        RefreshData();
    }

    void RefreshData()
    {
        StartCoroutine(GetRequest("https://reqres.in/api/users/2"));
    }

    IEnumerator GetRequest(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            yield return webRequest.SendWebRequest();

            if (webRequest.result == UnityWebRequest.Result.ConnectionError || 
                webRequest.result == UnityWebRequest.Result.DataProcessingError)
            {
                Debug.LogError($"Error: {webRequest.error}");
            }
            else if (webRequest.result == UnityWebRequest.Result.Success)
            {
                string jsonResponse = webRequest.downloadHandler.text;
                UserData userData = JsonUtility.FromJson<UserData>(jsonResponse);
                text.text = userData.first_name;
            }
        }
    }
}


