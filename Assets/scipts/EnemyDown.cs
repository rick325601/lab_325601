using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDown : MonoBehaviour
{
    private float speed = 15.0f;

    private float zDestroy = -40.0f;
    private Rigidbody enemyRb;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        enemyRb.AddForce(Vector3.back * speed);
        
        if (transform.position.z < zDestroy)
        {
            Destroy(gameObject);
        }
    }
}
