using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRight : MonoBehaviour
{
    private float speed = 15.0f;

    private float xDestroy = 40.0f;
    private Rigidbody enemyRb;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        enemyRb.AddForce(Vector3.right * speed);
        
        if (transform.position.x > xDestroy)
        {
            Destroy(gameObject);
        }
        
    }
}