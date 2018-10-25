using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setText : MonoBehaviour {
    private GameObject txt2;
    public string txt;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void TextChange()
    {
        txt2 = GameObject.Find("MainText");
        txt2.GetComponent<TextDisplay>().setText(txt);
        //Debug.Log(textdisp.userTxt);
    }
}
