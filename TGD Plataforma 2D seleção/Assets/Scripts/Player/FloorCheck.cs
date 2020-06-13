using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorCheck : MonoBehaviour
{
    //PlayerObject
    GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        Player = gameObject.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Detects Collision
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.CompareTag("Ground"))
        {
            Player.GetComponent<PlayerMovement>().isGrounded = true;
        }

    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground")&&Input.GetAxis("Horizontal") != 0.0f && !gameObject.GetComponent<AudioSource>().isPlaying)
        {
            gameObject.GetComponent<AudioSource>().Play();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {

        if (collision.collider.CompareTag("Ground"))
        {
            Player.GetComponent<PlayerMovement>().isGrounded = false;
        }

    }
}