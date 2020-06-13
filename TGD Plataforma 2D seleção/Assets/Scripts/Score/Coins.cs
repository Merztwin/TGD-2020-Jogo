using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public GameObject Score;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameObject.GetComponent<AudioSource>().Play();
            Score.GetComponent<ScoreSystem>().points += 1;
            Destroy(gameObject);
        }
    }
}

