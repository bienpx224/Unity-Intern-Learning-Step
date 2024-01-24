using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColorWhenClickButton : MonoBehaviour
{
    public SpriteRenderer squareSprite;
    public Button button1;
    public Button button2;
    private Color button1Color;
    private Color button2Color;
    private Color originalSquareColor;

    void Start()
    {
        originalSquareColor = squareSprite.color;
        button1Color = button1.image.color;
        button2Color = button2.image.color;
    }

    public void BlueColor()
    {
        ChangeColor(button1Color);
        StartCoroutine(ResetColorAfterDelay());
    }
    public void YellowColor()
    {
        ChangeColor(button2Color);
        StartCoroutine(ResetColorAfterDelay());
    }
    public void ChangeColor(Color buttonColor)
    {
        squareSprite.color = buttonColor;
    }
    IEnumerator ResetColorAfterDelay()
    {
        yield return new WaitForSeconds(2f);
        squareSprite.color = originalSquareColor;
    }
}
