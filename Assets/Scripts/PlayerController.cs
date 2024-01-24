using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sprite;
    [Header("List Color")] 
    [SerializeField] public Color colorButtonDefault;
    [SerializeField] public Color colorButton1;
    [SerializeField] public Color colorButton2;
    // Start is called before the first frame update
    void Start()
    {
        if (sprite == null)
        {
            sprite = GetComponent<SpriteRenderer>();
        }
    }

    public void ChangeColor(Color color)
    {
        sprite.color = color;
        StopAllCoroutines();
        StartCoroutine(IEReturnDefaultColor());
    }

    private IEnumerator IEReturnDefaultColor()
    {
        yield return new WaitForSeconds(2f);
        ChangeColor(colorButtonDefault);
    }
}
