using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;


public class ScriptInMainScene : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI textField;

    private void Start()
    {
        string userInput = UIScrip.Instance.input_text.text; //D��ER SAHNEDEK� CLASS �A�IRILIYOR
        textField.text = userInput;

        Debug.Log("Hello " + userInput);
    }
}
