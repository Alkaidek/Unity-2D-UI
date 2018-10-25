using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderManager : MonoBehaviour {
    public Button btn;
    public Slider slider;

	// Use this for initialization
	void Start () {
        slider.value = btn.image.rectTransform.anchoredPosition.y;
    }
	
	// Update is called once per frame
	void Update () {
        btn.image.rectTransform.anchoredPosition = new Vector2(btn.image.rectTransform.anchoredPosition.x, slider.value);
    }
}
