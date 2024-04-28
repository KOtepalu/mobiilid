using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.Net;
using System.IO;

public class API
{
    public static user GetNewName()
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://reqres.in/api/users/2");
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string json = reader.ReadToEnd();
        return JsonUtility.FromJson<user>(json);
    }


}
