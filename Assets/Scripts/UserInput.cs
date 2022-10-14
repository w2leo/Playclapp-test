using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(InputField))]
public class UserInput : MonoBehaviour
{
    private InputField inputField;
    private float currentValue;

    public void CheckInputFloat()
    {
        if (inputField.text.Length >0 && !float.TryParse(inputField.text, out currentValue))
        {
            inputField.text = inputField.text.Substring(0, inputField.text.Length - 1); 
        }
    }

    public float GetFloatValue()
    {
        return currentValue; 
    }

    private void Awake()
    {
        inputField = GetComponent<InputField>();
    }
}
