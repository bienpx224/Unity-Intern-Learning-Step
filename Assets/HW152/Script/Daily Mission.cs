using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "DailyMission", menuName = "ScriptableObject/DailyMission", order = 1)]
public class DailyMission : ScriptableObject
{
    public string missionName;
    [Space(15)]
    [Header("Rewards")]
    public bool isRewardXp = true;
    public bool isRewardGold = false;
    public bool isRewardDiamold = false;
    public int rewardXP = 10;
    public int rewardGold = 0;
    public int rewardDiamold = 0;
    [Space(15)]
    [Header("Mission Types")]
    public bool isLoginMission = false;
    public bool isSurvivalMission = false;
    public bool isCreatingMission = false;
    public bool isKillingMission = false;
    [Space(15)]
    [Header("Mission Progression")]
    public int missionGoal  = 0;
    public int missionProgress = 0;
    public bool isDone = false;


    public void LoginMission(){
        isDone = true;
    }
    public void SurvivalMission(){
        if(missionGoal == missionProgress){
            isDone = true;
        }
    }
    public void CreatingMission(){
        if(missionGoal == missionProgress){
            isDone = true;
        }
    }
    public void KillingMission(){
        if(missionGoal == missionProgress){
            isDone = true;
        }
    }
    public void ResetProgress(){
        missionProgress = 0;
        isDone = false;
    }
}
