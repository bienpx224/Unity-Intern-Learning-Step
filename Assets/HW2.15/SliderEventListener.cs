using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderEventListener : MonoBehaviour
{
    public Sprite backgroundItem;
    public Image item1BG;
    void Start()
    {
        SliderEventManager.OnSliderValueChanged += RespondToSliderValueChanged;
    }
    private void OnDestroy()
    {
        SliderEventManager.OnSliderValueChanged -= RespondToSliderValueChanged;
    }
    void RespondToSliderValueChanged(float value)
    {
        if(value == 20)
        {
            item1BG.sprite = backgroundItem;
        }
    }

}
