using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed;
    private Rigidbody rb;
    private float xRange = 30.0f;
    private float zRange = 15.0f; 

    private Timer timer;
    
    private gameManager GameManager;

    void Start ()
    {
        //vind de game objecten
        rb = GetComponent<Rigidbody>();
        GameManager = GameObject.Find("Game Manager").GetComponent<gameManager>();
        timer = GameObject.Find("Text").GetComponent<Timer>();
    }

    void FixedUpdate ()
    {
        if (GameManager.IsGameActive)
        {
            //geeft de player inputs
            float moveHorizontal = Input.GetAxis ("Horizontal");
            float moveVertical = Input.GetAxis ("Vertical");

            //geeft movement aan de player
            Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
            rb.AddForce (movement * speed);
        }
        
        //zorgt dat de player niet van de map af kan rollen
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange );
        }
        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange );
        }
    }
    
    void OnCollisionEnter(Collision collision)
    {
        //detecteerd collisions
        if (collision.gameObject.CompareTag("enemy"))
        {
            //geeft een singaal aan game manager
            Debug.Log("oof");
            GameManager.GameOver();
        }
    }
}