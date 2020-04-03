using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    private int currScore = 0;
    public Text score;
    public Text gameOver;
    private Touch screenTouch;
    private Vector3 position;
    
    


    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
        position = transform.position;
        UpdateScore();
        

    }
    //Script for PC
    /*void FixedUpdate()
     {
         
             float moveHorizontal = Input.GetAxis("Horizontal");
             float moveVertical = Input.GetAxis("Vertical");
             Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
             rb.AddForce(movement * speed);
        
     }*/

        //Script for Android
    void Update()
     {
        if (Input.touchCount > 0)
        {
            screenTouch = Input.GetTouch(0);
            
            if (screenTouch.phase == TouchPhase.Moved)
            {
                Vector3 movement = new Vector3(transform.position.x + screenTouch.deltaPosition.x * speed, 
                    0f, transform.position.z + screenTouch.deltaPosition.y * speed);

                rb.AddForce(movement * speed);
            }
        }
        
    }


    void OnTriggerEnter(Collider pickup)
    {
        if (pickup.gameObject.CompareTag("Target"))
        {
            if (gameOver.text != "Game Over !")
            {
                Debug.Log("Entering the Audio Player");
                currScore = currScore + 1;
                UpdateScore();

                GetComponent<AudioSource>().Play();
                pickup.transform.position = position;
                position = transform.position;

            }
        }
    }
    
    public void UpdateScore()
    {
        score.text = "Score : " + currScore.ToString();
    }
    
}
