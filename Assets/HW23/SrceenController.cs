using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SrceenController : MonoBehaviour
{
    [SerializeField] private PlayerController player;
    void Start()
    {
        player.ChangeColor(player.defaultColor);
    }

    public void OnChangePlayerColor(int colorIndex)
    {
        switch(colorIndex)
        {
            case 0:
                player.ChangeColor(player.defaultColor);
                break;
            case 1:
                player.ChangeColor(player.colorButton1);
                break;
            case 2:
                player.ChangeColor(player.colorButton2);
                break;
        }
    }


    // Update is called once per frame
 
}
