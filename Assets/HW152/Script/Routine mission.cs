using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="RoutineMission", menuName = "ScriptableObject/RoutineMission", order = 1)]
public class RoutineMission : ScriptableObject
{
    [SerializeField] public List<DailyMission> dailyMissionsLists;
}
