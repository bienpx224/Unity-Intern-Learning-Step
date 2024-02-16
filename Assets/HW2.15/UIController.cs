using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIController : MonoBehaviour
{
    public GameObject missionCard;
    public Transform missionDisplay;
    public MissonList missionList;
    public int numberOfMissionToShow = 5;
    void Start()
    {
        List<MissionGroup> randomMissionGroups = ChooseRandomMission();
        DisplayMIsisonUI(randomMissionGroups);
       // CreateMissionUI();
    }

   /* public void CreateMissionUI()
    {
        foreach(MissionGroup missionData in missionList.missions)
        {
          GameObject missionUI =  Instantiate(missionCard,missionDisplay);
          MissionDisplay missionUIComponent = missionUI.GetComponent<MissionDisplay>();
           missionUIComponent.SetMissionInfor(missionData);
        }
    }*/

    List<MissionGroup> ChooseRandomMission()
    {
        List<MissionGroup> originalMission = new List<MissionGroup>(missionList.missions);
        List<MissionGroup> randomMissions = new List<MissionGroup>();

        for(int i = 0; i < numberOfMissionToShow; i++)
        {
            if (originalMission.Count == 0)
                break;
            int randomIndex = Random.Range(0, originalMission.Count);
            MissionGroup randomMission = originalMission[randomIndex];

            randomMissions.Add(randomMission);
            originalMission.RemoveAt(randomIndex);
        }
        return randomMissions;
    }
    void DisplayMIsisonUI(List<MissionGroup> missions)
    {
        foreach(MissionGroup mission in missions)
        {
            GameObject missionUI = Instantiate(missionCard, missionDisplay);
            MissionDisplay missionUIComponent = missionUI.GetComponent<MissionDisplay>();
            missionUIComponent.SetMissionInfor(mission);
        }
    }
}
