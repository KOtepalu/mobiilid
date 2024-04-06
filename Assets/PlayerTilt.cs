using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerTilt : MonoBehaviour
{
    public float tiltSpeed;

    // Update is called once per frame
    void Update()
    {
        float tiltInput = Input.acceleration.x;

        // Kui kallutamise sisend puudub, jääb mängija paigale
        if (Mathf.Abs(tiltInput) < 0.1f) // Võite muuta seda väärtust vastavalt soovitud tundlikkusele
        {
            return; // Väljub Update meetodist ja jätab mängija paigale
        }

        // Mängija liigutamine vastavalt kallutamisele
        Vector2 movement = new Vector2(tiltInput, 0f);
        transform.Translate(movement * tiltSpeed * Time.deltaTime);
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //If collides with the player it will reload the block
        if(collision.gameObject.tag == "block")
        {
            SceneManager.LoadScene("GameTilt");
        }
    }
}
