using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRightController : MonoBehaviour
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
            ScoreManager.scoreManager.RaiseScorePlayer1(1);
            CoinSpawnerRight.coinSpawnerRight.CreateCoin();
            Destroy(gameObject);

        }
        else if (collision.tag == "Player2")
        {
            ScoreManager.scoreManager.RaiseScorePlayer2(1);
            CoinSpawnerRight.coinSpawnerRight.CreateCoin();
            Destroy(gameObject);
        }


    }
}
