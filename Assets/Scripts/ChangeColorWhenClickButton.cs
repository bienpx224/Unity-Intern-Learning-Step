using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColorWhenClickButton : MonoBehaviour
{
    public Image image;
    public Color blue;
    public Color yellow;
    private Color originalColor;

    void Start()
    {
        originalColor = image.color;
    }

    public void BlueColor()
    {
        image.color = blue;
        StartCoroutine(ResetColorAfterDelay());
    }
    public void YellowColor()
    {
        image.color = yellow;
        StartCoroutine(ResetColorAfterDelay());
    }
    IEnumerator ResetColorAfterDelay()
    {
        yield return new WaitForSeconds(2f);

        image.color = originalColor;
    }
}
