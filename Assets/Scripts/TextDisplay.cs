using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDisplay : MonoBehaviour {

    public Text txtContent;
    public string userTxt;
    private void Start()
    {
        txtContent.color = Color.gray;
        float r = 255;  // red component
        float g = 122;  // green component
        float b = 0;  // blue component
        float a = 0.5f;  // blue component
        txtContent.color = new Color(r, g, b, a);
        setText(userTxt);
    }

    private void Update()
    {
    }
    public void setText(string txt)
    {
        Debug.Log("setText");
        txtContent.text = txt;
    }
}
