using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RewardBarController : MonoBehaviour
{
    [SerializeField] public Slider missionBarProgressSlider;
    [SerializeField] private Image sliderFill;
    [SerializeField] private TextMeshProUGUI dailyScoreText;
    public float missionBarProgress = 0;
    public void SetMissionBarProgress(float xPFromMission)
    {
        missionBarProgress += xPFromMission;
        dailyScoreText.text = missionBarProgress.ToString();
        missionBarProgressSlider.value = missionBarProgress;
    }
}
