using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class user_name : MonoBehaviour
{
    public TextMeshProUGUI nameText;

    public void NewName()
    {
        user j = API.GetNewName();
        nameText.text = j.first_name; 
    }
}
