using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    public float rayCastDist;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CheckForPlayer()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up, rayCastDist);
    }
}
