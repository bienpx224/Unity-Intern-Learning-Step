using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MissionController : MonoBehaviour
{
    [Header("Mission Genaral")]
    [SerializeField] private TextMeshProUGUI missionName;
    [SerializeField] private TextMeshProUGUI dailyXP;
    [SerializeField] private Transform itemTransform;
    [Space(15)]
    [Header("Mission Rewards")]
    [SerializeField] private TextMeshProUGUI rewardQuantityText;
    [SerializeField] private Image rewardImage;
    [SerializeField] private Sprite diamold;
    [SerializeField] private Sprite goldCoin;
    [SerializeField] private TextMeshProUGUI claimButtonText;
    [Space(15)]
    [Header("Mission Progress")]
    [SerializeField] private Transform missionProgress;
    [SerializeField] private Transform fillArea;
    [SerializeField] private TextMeshProUGUI missionProgressText;
    [Space(15)]
    [Header("Mission Type")]
    public DailyMission dailyMission;

    private TableContentController tableContentController;
    private Slider slider;
    private delegate void onSelectedEvent();
    private event onSelectedEvent selectedEvent;
    private void OnEnable()
    {
        GetComponents();
        SetMissionProperty();
        MissionProgressControl();
    }
    private void SetMissionProperty()
    {
        missionName.text = dailyMission.missionName;
        dailyXP.text = dailyMission.rewardXP.ToString();
        if (dailyMission.isRewardGold)
        {
            rewardImage.sprite = goldCoin;
            rewardQuantityText.text = dailyMission.rewardGold.ToString();
        }
        else if (dailyMission.isRewardDiamold)
        {
            rewardImage.sprite = diamold;
            rewardQuantityText.text = dailyMission.rewardDiamold.ToString();
        }
    }
    private void GetComponents()
    {
        slider = missionProgress.GetComponentInChildren<Slider>();
    }
    private void MissionProgressControl()
    {
        SliderControl();
        missionProgressText.text = dailyMission.missionProgress.ToString() + "/" + dailyMission.missionGoal.ToString();
        if (slider.value == 1)
        {
            dailyMission.isDone = true;
            missionProgressText.text = "Complete";
            fillArea.gameObject.SetActive(true);
            claimButtonText.text = "Claim";
        }
        else if (slider.value > 0)
        {
            fillArea.gameObject.SetActive(true);
        }
    }
    private void SliderControl()
    {
        if (dailyMission.missionGoal == 0) return;
        slider.value = (float)dailyMission.missionProgress / (float)dailyMission.missionGoal;
    }
    public void OnSelected()
    {
        tableContentController = GetComponentInParent<TableContentController>();
        tableContentController.SetInformationText(missionName.text + ": " + missionProgressText.text);
    }
    public void EnableClaimRewards()
    {
        if (dailyMission.isDone)
        {
            tableContentController = GetComponentInParent<TableContentController>();
            tableContentController.xPFromMission = dailyMission.rewardXP;
            tableContentController.SetMissionBarProgress();
            itemTransform.gameObject.SetActive(false);
        }
    }
}
