using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColorWhenClickButton : MonoBehaviour
{
    public SpriteRenderer squareSprite;
    public Color blue;
    public Color yellow;
    private Color originalSquareColor;

    void Start()
    {
        originalSquareColor = squareSprite.color;
    }

    public void BlueColor()
    {
        squareSprite.color = blue;
        StartCoroutine(ResetColorAfterDelay());
    }
    public void YellowColor()
    {
        squareSprite.color = yellow;
        StartCoroutine(ResetColorAfterDelay());
    }
    IEnumerator ResetColorAfterDelay()
    {
        yield return new WaitForSeconds(2f);
        squareSprite.color = originalSquareColor;
    }
}
