using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play_sound : MonoBehaviour
{

    private int goog;
    public AudioSource playSound;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            if (goog == 1)
            {
                playSound.Play();
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("player"))
        {
            goog = 1;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("player"))
        {
            goog = 0;
        }
    }
}
