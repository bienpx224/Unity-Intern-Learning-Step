using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TableContentController : MonoBehaviour
{
    [SerializeField] public Transform informationText;
    [SerializeField] private RewardBarController rewardBarController;

    public float xPFromMission;

    public void SetInformationText(string text){
        TextMeshProUGUI textMeshProUGUI= informationText.GetComponent<TextMeshProUGUI>();
        textMeshProUGUI.text = text;
    }
    public void SetMissionBarProgress(){
        rewardBarController.SetMissionBarProgress(xPFromMission);
    }
}
