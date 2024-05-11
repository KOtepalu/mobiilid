using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public float moveSpeed;
    Rigidbody2D rb;
    public Timer timer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        timer = FindObjectOfType<Timer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if(touchPos.x < 0)
            {
                rb.AddForce( Vector2.left * moveSpeed );

            } else {
                rb.AddForce( Vector2.right * moveSpeed );
            }


        } else
        {
            rb.velocity = Vector2.zero; //not tapping on the screen, then 0
        }
        

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        //If collides with the player it will reload the block
        if (collision.gameObject.CompareTag("block"))
        {
            Debug.Log("Collision detected with block");

            if (timer != null)
            {
                Debug.Log("Recording end time...");
                timer.RecordEndTime();
                Debug.Log("End time recorded");
            }

            // Trigger the scene transition to "GameOver"
            SceneManager.LoadScene("GameOver");
        }
    }

}