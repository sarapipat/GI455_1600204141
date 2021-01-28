using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class TextText : MonoBehaviour
{
    public GameObject InputField;
    public Text result;
    public Text data;
    public string[] textData;

    void Start()
    {
        for (int i = 0; i < textData.Length; i++)
        {
            print(textData[i]);
            data.text += textData[i] + "\n";
        }
    }

    public void TextCheck()
    {
        name = InputField.GetComponent<Text>().text;

        if (textData.Contains(name))
        {
            print(name + " is found");
            result.text = "[ " + name + " ] is found.";
        }
        else
        {
            print(name + " is not found");
            result.text = "[ " + name + " ] is not found.";
        }
    }
}