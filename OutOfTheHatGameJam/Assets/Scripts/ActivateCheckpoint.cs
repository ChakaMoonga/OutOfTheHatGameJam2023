using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateCheckpoint : MonoBehaviour
{
    //public GameObject Checkpoint;
    public Animator _cpAnim;

    public static bool checkpointActivated = false;

    void Start()
    {
        _cpAnim = GetComponent<Animator>();
        //_cpAnim.Play("checkpointNotActivated");
    }
    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.GetComponent<PlayerController>())
        {
            checkpointActivated = true;
            _cpAnim.SetBool("activate", true);
            //_cpAnim.Play("activateCheckpoint");
            Debug.Log("activated checkpoint");
        }
    }

    void OnTriggerExit2D (Collider2D other)
    {
        if (other.gameObject.GetComponent<PlayerController>())
        {
            //_cpAnim.Play("checkpointActivated");
        }
    }
}
