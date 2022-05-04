using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveName : MonoBehaviour
{
    public Text namePan;

    public InputField inputField;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("Name")) namePan.gameObject.SetActive(true);
        else
        {
            inputField.enabled = false;
            Debug.Log(PlayerPrefs.GetString("Name"));
            namePan.text = PlayerPrefs.GetString("Name");
        }
    }

    public void CheckName(string name)
    {
        if (!string.IsNullOrEmpty(name) && name.Length >= 3)
        {
            PlayerPrefs.SetString("Name", name);
            Debug.Log("Your name: " + name);
        }
        else Debug.Log("Enter the correct name!");
    }


}
