using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIScrip : MonoBehaviour
{
    public TMP_InputField input_text;
    public static UIScrip Instance;
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void InputReceiverAndSceneChange()
    {
        string text = input_text.text;
        Debug.Log(text);
        SceneManager.LoadScene("Main"); // DÝÐER SAHNEYE GEÇÝYOR
    }
}
