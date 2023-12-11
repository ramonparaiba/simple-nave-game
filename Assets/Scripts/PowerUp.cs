using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    private PlayerScore playerScore;

    private void Start()
    {
        playerScore = GameObject.FindObjectOfType<PlayerScore>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
       if (other.gameObject.tag == "Player")
        {
            playerScore.AddScore(300);
            Destroy(gameObject);
        } 
    }
}
