using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "MisionGroup", menuName = "ScriptableObject/MisionGroup", order = 1)] 
public class MissionGroup : ScriptableObject
{
    [SerializeField] public string missionName;
    [SerializeField] public int missionExp;
    [SerializeField] public string missionStatus;
    [SerializeField] public float progressBarValue;
    [SerializeField] public Sprite rewardIcon;
    [SerializeField] public int rewardQuanity;
    [SerializeField] public string claimButotnText;
    [SerializeField] public Sprite claimButotnBackGround;
    [SerializeField] public Sprite fillAreaColor;
    [SerializeField] public Sprite missionBackground;
}
