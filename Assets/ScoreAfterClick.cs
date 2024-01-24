using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreAfterClick : MonoBehaviour
{
    [SerializeField] private Text score;
    [SerializeField] private int count= 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateScore();        
    }
    private void UpdateScore(){
        
        if(InputManager.Instance.isClick)
        {
            count = Fire.Instance.count;
            score.text=count.ToString();
        }

    }
}
