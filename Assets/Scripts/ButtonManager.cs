using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour {
    public int state;
    Animator animator;
    public Button btn;
    public Color newColor;

    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
        animator.SetInteger("State", state);
        if(btn != null)
        {
            ColorBlock cb = btn.colors;
            cb.normalColor = newColor;
            btn.colors = cb;
            Debug.Log(btn.colors.normalColor);

        }
    }
	
	// Update is called once per frame
	void Update () {
        //state = Random.Range(0, 2);
        //Debug.Log(state);
        //animator.SetInteger("State", state);
	
	}
}
