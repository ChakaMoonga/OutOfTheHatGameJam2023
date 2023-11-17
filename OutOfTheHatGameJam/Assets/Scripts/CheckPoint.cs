using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public bool activated = false;
    public static GameObject[] CheckPointsList;
    public Health playerHealth;
    public GameObject player;
    public static GameObject lastCheckPoint;
    void Start()
    {
        CheckPointsList = GameObject.FindGameObjectsWithTag("CheckPoint");
        //playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();
    }

    private void ActivateCheckPoint()
    {
        Debug.Log("checkpoint activation");
        foreach (GameObject cp in CheckPointsList)
        {
            cp.GetComponent<CheckPoint>().activated = false;
            
        }
        activated = true;
        lastCheckPoint = this.gameObject; 
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            ActivateCheckPoint();
            Debug.Log("Player's health: " + playerHealth.health);
        }
    }
    
    
    void Update()
    {
        if (playerHealth.health <= 0)
        {
            player.transform.position = lastCheckPoint.transform.position; // Add this line
            playerHealth.GainHealth(100);
        }
    }
}
