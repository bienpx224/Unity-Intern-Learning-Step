using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject missionCard;
    public Transform missionDisplay;
    public MissonList missionList;
    public int numberOfMissionToShow = 5;
    List<MissionDisplay> spawnedMission = new List<MissionDisplay>();
    public TextMeshProUGUI textUI;
    public TextMeshProUGUI missionName;
    public Slider milestoneProgressBar;
    public TextMeshProUGUI milestonePoints;
    //public Sprite backgroundItem;
    //public Image item1BG;
    void Start()
    {
        //List<MissionGroup> randomMissionGroups = ChooseRandomMission();
        //DisplayMIsisonUI(randomMissionGroups);
        for (int i = 0; i < missionList.missions.Count; i++)
        {
            // Lấy dữ liệu từ phần tử thứ i trong danh sách missionList
            MissionGroup missionGroup = missionList.missions[i];

            // Thiết lập index cho phần tử
            missionGroup.index = i;
        }
    } 
    private void OnEnable()
    {
        ClearSpwanedData();
        CreateMissionUI();
    }
    private void Update()
    {
        UpdatePrgressBar();
      //  ChangingBackGroundItem();
    }
    public void CreateMissionUI()
    {
        foreach (MissionGroup missionData in missionList.missions)
        {
            GameObject missionUI = Instantiate(missionCard, missionDisplay);
            MissionDisplay missionUIComponent = missionUI.GetComponent<MissionDisplay>();
            missionUIComponent.SetMissionInfor(missionData);
            spawnedMission.Add(missionUIComponent);
        }
    }
    public void ClearSpwanedData()
    {

        foreach (MissionDisplay misssionData in spawnedMission)
        {
            Destroy(misssionData.gameObject);
        }
        spawnedMission.Clear();
    }
    /*List<MissionGroup> ChooseRandomMission()
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
    }*/
    public void UpdatePrgressBar()
    {
        milestonePoints.text = Mathf.RoundToInt(milestoneProgressBar.value).ToString();
    }
   /* public void ChangingBackGroundItem()
    {
        if (Mathf.RoundToInt(milestoneProgressBar.value) >= 20)
        {
            item1BG.sprite = backgroundItem;
        }
    }*/
}
