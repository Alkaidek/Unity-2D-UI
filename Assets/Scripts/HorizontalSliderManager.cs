using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HorizontalSliderManager : MonoBehaviour {
    public Button btn;
    public Slider slider;

    // Use this for initialization
    void Start()
    {
        slider.value = btn.image.rectTransform.anchoredPosition.x;
    }

    // Update is called once per frame
    void Update()
    {
        btn.image.rectTransform.anchoredPosition = new Vector2(slider.value, btn.image.rectTransform.anchoredPosition.y);
    }
}
