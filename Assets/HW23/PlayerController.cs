using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public Color defaultColor;
    [SerializeField] public Color colorButton1;
    [SerializeField] public Color colorButton2;
    [SerializeField] public SpriteRenderer sr;

    void Start()
    {
        if (sr == null)
        {
            sr.GetComponent<SpriteRenderer>();
        }      
    }
    public void ChangeColor(Color color)
    {
        sr.color = color;
        StopAllCoroutines();
        StartCoroutine(ChangeToDefaultColor());
        
    }
    IEnumerator ChangeToDefaultColor()
    {
        yield return new WaitForSeconds(2f);
        ChangeColor(defaultColor);
    }
}
