using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerTilt : MonoBehaviour
{
    public float tiltSpeed;

    void Update()
    {
        float tiltInput = Input.acceleration.x;
        float tiltYInput = Input.acceleration.y;

        // Kui kallutamise sisend puudub, jääb mängija paigale
        if (Mathf.Abs(tiltInput) < 0.1f) 
        {
            return; // Väljub Update meetodist ja jätab samal hetkel mängija paigale
        }

        // Liigutame playerit vastavalt kallutamisele
        Vector2 movement = new Vector2(tiltInput, 0f);
        transform.Translate(movement * tiltSpeed * Time.deltaTime);

        // Kuvame x ja y koordinaadid konsoolile
        Debug.Log("X: " + tiltInput + ", Y: " + tiltYInput);

    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Kui põrkab kokku blockiga, siis peab uuesti laadima selle scene et mäng uuesti hakkaks
        if(collision.gameObject.tag == "block")
        {
            SceneManager.LoadScene("GameTilt");
        }
    }
}
