using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] protected Vector3 worldPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
  
    private void FixedUpdate()
    {
        worldPosition = InputManager.Instnace.MouseWorldPos;
        Vector2 direction = new Vector2(worldPosition.x - transform.position.x, worldPosition.y - transform.position.y);
        transform.up = direction;
    }

}
