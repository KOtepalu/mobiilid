using System;
using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.Networking;

public class APIcall : MonoBehaviour
{
  [Serializable]
  public class APIResponse
  {
    public UserData data;
    public SupportData support;
  }

  [Serializable]
  public class UserData
  {
    public int id;
    public string email;
    public string first_name;
    public string last_name;
    public string avatar;
  }

  [Serializable]
  public class SupportData
  {
    public string url;
    public string text;
  }

  public TextMeshProUGUI text;

  void Start()
  {
    RefreshData();
  }

  public void OnRefresh()
  {
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
        APIResponse responseData = JsonUtility.FromJson<APIcall.APIResponse>(jsonResponse);
        UserData userData = responseData.data;
        text.text = userData.first_name;
      }
    }
  }
}
