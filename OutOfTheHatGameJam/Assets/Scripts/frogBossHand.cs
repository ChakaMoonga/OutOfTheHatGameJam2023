using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.EventSystems;

public class frogBossHand : MonoBehaviour
{
    public float speed;
    public Transform target;
    public float counter;
    public float counter2;
    public Vector2 moveDirection;
    Rigidbody2D _rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*IEnumerator PreCharge()
    {
        speed = 25;
        target = GameObject.FindWithTag("Player").transform;
        if (counter < 500)
        {
                Vector3 direction = (target.position + new Vector3(-6, 0, 0) - transform.position).normalized;
                //float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
                //_rigidbody2D.rotation = angle;
                moveDirection = direction;

                _rigidbody2D.velocity = new Vector2(moveDirection.x, moveDirection.y) * speed;
            }
            counter += 1;
            yield return new WaitForSeconds(0.01f);
        yield return StartCoroutine(PreCharge());
        else
        {
            yield return StartCoroutine(Charge());
        }
    }
    IEnumerator Charge()
    {
        speed = 50;
        target = GameObject.FindWithTag("Player").transform;
        if (counter2 < 500)
        {
            Vector3 direction = (target.position + new Vector3(6, 0, 0) - transform.position).normalized;
            //float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            //_rigidbody2D.rotation = angle;
            moveDirection = direction;

            _rigidbody2D.velocity = new Vector2(moveDirection.x, moveDirection.y) * speed;
        }
        counter2 += 1;
        yield return new WaitForSeconds(0.01f);
        yield return StartCoroutine(PreCharge());
    }*/
}
