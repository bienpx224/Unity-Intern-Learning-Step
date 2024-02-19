using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RewardBarItemController : MonoBehaviour
{
    [SerializeField] int xPRequire;
    [SerializeField] TextMeshProUGUI xPText;

    private RewardBarController rewardBarController;

    public void XPCheck()
    {
        if (rewardBarController.missionBarProgressSlider.value >= xPRequire)
        {
            transform.localScale = new Vector3(1.03f, 1.03f, 1.03f);
        }
    }
}
