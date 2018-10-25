using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class ExampleScript : MonoBehaviour {
    private TextDisplay txt;
    private GameObject txt2;
    private Text txt3;
    // Use this for initialization
    private DateTime date;
    private TextDisplay textdisp;

    private void Awake()
    {
    }
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        //txt = GetComponent<TextDisplay>() as TextDisplay;
        //Debug.Log("bla bla bla");
        //Debug.Log(txt);
        //txt2 = GameObject.Find("MainText");
        //Debug.Log(txt2.GetComponent<TextDisplay>().txtContent.text);
    }
    public void Hello()
    {
        Debug.Log("Hej Haj Heloł!" + DateTime.Now);
    }
    public void TextChanged(string newText)
    {
        txt2 = GameObject.Find("MainText");
        txt2.GetComponent<TextDisplay>().setText(newText);
        Debug.Log(newText);
        //Debug.Log(textdisp.userTxt);
    }
}
