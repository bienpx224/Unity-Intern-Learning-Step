using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderEventManager : MonoBehaviour
{
    public delegate void SliderValueChanged(float value);

    public static event SliderValueChanged OnSliderValueChanged;

    public Slider slider;
    private void Start()
    {
        slider.onValueChanged.AddListener(HandleSliderValueChanged);
    }
    void HandleSliderValueChanged(float value)
    {
        if (OnSliderValueChanged != null)
        {
            OnSliderValueChanged(value);
        }
    }

}
