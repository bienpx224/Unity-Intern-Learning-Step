using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollListAnchor : MonoBehaviour
{
    void Start(){
        transform.position = new Vector2(transform.position.x,-999f);
    }
        
}
