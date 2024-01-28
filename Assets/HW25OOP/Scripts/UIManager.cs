using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UIManager : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI bulletFired;
    [SerializeField] public TMP_Text enemyHP;
    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        bulletFired.text = GunController.Instnace.bulletCount.ToString();
    }
    private void UpdateBullet()
    {

    }
}
