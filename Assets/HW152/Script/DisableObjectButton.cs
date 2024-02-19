using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableObjectButton : MonoBehaviour
{
    [SerializeField] private Transform gameObjectToQuit;
    public void OnExitClick(){
        gameObjectToQuit.gameObject.SetActive(false);
    }
}
