using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI bulletBoard;
    // private void Start()
    // {
    //     GunController.OnFire += UpdateBulletText;
    // }
    // private void UpdateBulletText()
    // {
    //     bulletBoard.text = "Bullet: " + PlayerController.Instance.bulletInMag;
    // }
    private void Update(){
        bulletBoard.text = "Bullet: " + PlayerController.Instance.bulletInMag;
    }
}
