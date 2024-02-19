using System.Collections;
using System.Collections.Generic;
using UnityEditor.EditorTools;
using UnityEngine;

public class EnablePopUp : MonoBehaviour
{
    [SerializeField] private Transform gameObjectToOpen;
    public void OnOpenClick(){
        gameObjectToOpen.gameObject.SetActive(true);
    }
}
