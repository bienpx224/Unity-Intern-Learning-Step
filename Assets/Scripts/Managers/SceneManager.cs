using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    [SerializeField] private PlayerController player;
    
    // Start is called before the first frame update
    void Start()
    {
        player.ChangeColor(player.colorButtonDefault);
    }

    #region UI Interactive

    public void OnChangePlayerColorClicked(int colorIndex)
    {
        switch (colorIndex)
        {
            case 0: 
                player.ChangeColor(player.colorButtonDefault);
                break;
            case 1: 
                player.ChangeColor(player.colorButton1);
                break;
            case 2: 
                player.ChangeColor(player.colorButton2);
                break;
        }
    }

    #endregion
}
