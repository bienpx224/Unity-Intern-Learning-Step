using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorController : MonoBehaviour
{
    [SerializeField] public GameObject Red;
    [SerializeField] public GameObject Blue;
    [SerializeField] public GameObject Yellow;

   // Coroutine blueSprite;
    //Coroutine yellowSprite;

    public void changeBlue()
    {
        // blueSprite = StartCoroutine(changingBlue());
        // StopCoroutine(yellowSprite);
        StartCoroutine(changingBlue());
    }
    public void changeYellow()
    {
        // yellowSprite = StartCoroutine(changingYellow());
        // StopCoroutine(blueSprite);
        StartCoroutine(changingYellow());
    }
    IEnumerator changingBlue()
    {
        Red.SetActive(false);
        Blue.SetActive(true);
        yield return new WaitForSeconds(2f);
        Blue.SetActive(false);
        Red.SetActive(true);
    }
    IEnumerator changingYellow()
    {
        Red.SetActive(false);
        Yellow.SetActive(true);
        yield return new WaitForSeconds(2f);
        Yellow.SetActive(false);
        Red.SetActive(true);
    }
}
