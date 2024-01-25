using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovemetnHW25 : MonoBehaviour
{
    [SerializeField] protected Vector3 worldPos25;
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        worldPos25 = InputManagerHW25.Instance25.MouseWorldPos25;
        Vector2 direction25 = new Vector2(worldPos25.x - transform.parent.position.x, worldPos25.y - transform.parent.position.y);
        transform.parent.up = direction25;
    }
   
}
