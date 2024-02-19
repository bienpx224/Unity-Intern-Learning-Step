using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MissionDisplay : MonoBehaviour
{
    public TextMeshProUGUI missionExp;
    public TextMeshProUGUI missionTitle;
    public Image missionReward;
    public TextMeshProUGUI missionStatus;
    public TextMeshProUGUI rewardQuanity;
    public Slider sliderProgress;
    public TextMeshProUGUI claimButtonText;
    public Image fillAreaColor;
    public Image rewardIcon;
    public Image claimButtonBackGround;
    public Image missionBackground;
    public Color missionBackgroundColor;
    public UIController uiController;
    public void SetMissionInfor(MissionGroup mission)
    {
        missionExp.text = mission.missionExp.ToString();
        missionTitle.text = mission.missionName;
        missionStatus.text = mission.missionStatus;
        sliderProgress.value = mission.progressBarValue;
        rewardQuanity.text = mission.rewardQuanity.ToString();
        claimButtonText.text = mission.claimButotnText;
        fillAreaColor.sprite = mission.fillAreaColor;
        rewardIcon.sprite = mission.rewardIcon;
        claimButtonBackGround.sprite = mission.claimButotnBackGround;
        missionBackground.sprite = mission.missionBackground;
    }
    public void SetMissionTitle()
    {
        uiController = GetComponentInParent<UIController>();
        uiController.textUI.text = missionTitle.text;
    }
}
