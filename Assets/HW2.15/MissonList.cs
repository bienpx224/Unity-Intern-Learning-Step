using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MisionList", menuName = "ScriptableObject/MisionList", order = 1)]
public class MissonList : ScriptableObject
{
   public List<MissionGroup> missions= new List<MissionGroup>();
}
