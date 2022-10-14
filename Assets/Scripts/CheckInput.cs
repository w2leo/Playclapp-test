using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(InputField))]

public class CheckInput : MonoBehaviour
{
    private InputField inputField;

    private void Awake()
    {
        inputField = GetComponent<InputField>();
    }
    public void CheckInputFloat()
    {
        float newFloat;
        if (float.TryParse(inputField.text, out newFloat))
        {
            return;
        }
        else
        { 
            inputField.text = inputField.text.Substring(0, inputField.text.Length - 1);
        }

    }
}
