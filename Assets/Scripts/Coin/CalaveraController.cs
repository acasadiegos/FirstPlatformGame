using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalaveraController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            ScoreManager.scoreManager.ActivateKillPlayer1();
            CalaveraSpawner.calaveraSpawner.CreateCalavera();
            Destroy(gameObject);

        }
        else if (collision.tag == "Player2")
        {
            ScoreManager.scoreManager.ActivateKillPlayer2();
            CalaveraSpawner.calaveraSpawner.CreateCalavera();
            Destroy(gameObject);

        }


    }
}
