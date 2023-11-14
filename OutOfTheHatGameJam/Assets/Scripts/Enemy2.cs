using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    public float maxRayCastDist;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckForPlayer();
    }

    private void CheckForPlayer()
    {
        Debug.DrawRay(transform.position, -Vector2.up, Color.green, maxRayCastDist);
        
        RaycastHit[] hits;
        hits = Physics.RaycastAll(transform.position, -Vector2.up, maxRayCastDist);

        for (int i = 0; i < hits.Length; i++)
        {
            RaycastHit hit = hits[i];

            if (hit.collider != null)
            {
                if (hit.transform.tag == "Player")
                {
                    print("HIT");
                }
            }
        }
    }
}
