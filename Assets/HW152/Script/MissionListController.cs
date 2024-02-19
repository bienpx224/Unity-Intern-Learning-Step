using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionListController : MonoBehaviour
{
    [SerializeField] private RoutineMission routineMission;
    [SerializeField] private Transform missionPrefab;
    [SerializeField] private List<Transform> dailyMissions = new List<Transform>();
    [SerializeField] private int numberOfMissions = 3;
    [SerializeField] private MissionController dailyMissionConTroller;
    List<DailyMission> dailyMissionsLists;
    public void Start(){
        if(dailyMissions.Count > 0) return;
        SetMissionList();
        for (int i = 0 ; i < numberOfMissions ; i++){
            //SetMissionRandom();
            SetMission(i);
        }
    }
    public void SetMissionList(){
        dailyMissionsLists =new List<DailyMission>(routineMission.dailyMissionsLists);
    }
    public void SetMissionRandom(){
        if(dailyMissionsLists.Count <= 0) return; 
        dailyMissionConTroller = missionPrefab.GetComponentInChildren<MissionController>();
        int randomNumber = Random.Range(0, dailyMissionsLists.Count-1);
        dailyMissionConTroller.dailyMission = dailyMissionsLists[randomNumber];
        dailyMissionsLists.RemoveAt(randomNumber);
        Transform instantiate = Instantiate(missionPrefab,transform);
        dailyMissions.Add(instantiate);
    }
    public void SetMission(int index){
        if(dailyMissionsLists.Count <= 0) return; 
        dailyMissionConTroller = missionPrefab.GetComponentInChildren<MissionController>();
        dailyMissionConTroller.dailyMission = dailyMissionsLists[index];
        Transform instantiate = Instantiate(missionPrefab,transform);
        dailyMissions.Add(instantiate);
    }
    // public void InstanceMissionPrefab(){

    // }
}
