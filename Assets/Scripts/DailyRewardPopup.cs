using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DailyRewardPopup : MonoBehaviour
{
    [SerializeField] private GameObject popupDailyReward;
    [SerializeField] private GameObject claimedImage;
    void Start()
    {
        popupDailyReward.SetActive(false);
    }

    public void OpenPopup()
    {
        popupDailyReward.SetActive(true);
    }

    public void ClosePopup()
    {
        popupDailyReward.SetActive(false);
    }
    public void Claimed()
    {
        claimedImage.SetActive(true);
    }
}
