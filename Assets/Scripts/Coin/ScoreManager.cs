using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static ScoreManager scoreManager;
    public GameObject player1;
    public GameObject player2;
    int scorePlayer1 = 0;
    int scorePlayer2 = 0;
    bool player1CanDestroy;
    bool player2CanDestroy;
    bool player1CanKill;
    bool player2CanKill;

    float timer;
    void Start()
    {
        scoreManager = this;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 6f)
        {
            timer = 0;
            player1.GetComponent<SpriteRenderer>().color = Color.white;
            player2.GetComponent<SpriteRenderer>().color = Color.white;
            player1CanDestroy = false;
            player2CanDestroy = false;
        }
    }

    public void RaiseScorePlayer1(int s)
    {
        scorePlayer1 += s;

        if (scorePlayer1 == 3)
        {
            player1.GetComponent<SpriteRenderer>().color = Color.yellow;
            player1CanDestroy = true;
            timer = 0;
            scorePlayer1 = 0;
        }
    }

    public void RaiseScorePlayer2(int s)
    {
        scorePlayer2 += s;

        if (scorePlayer2 == 3)
        {
            
            player2.GetComponent<SpriteRenderer>().color = Color.yellow;
            player2CanDestroy = true;
            timer = 0;
            scorePlayer2 = 0;
        }
    }

    public void ActivateKillPlayer1()
    {
        player1CanKill = true;
    }

    public void ActivateKillPlayer2()
    {
        player1CanKill = true;
    }

    public bool GetPlayer1CanDestroy()
    {
        return player1CanDestroy;
    }

    public bool GetPlayer2CanDestroy()
    {
        return this.player2CanDestroy;
    }

    public bool GetPlayer1CanKill()
    {
        return this.player1CanKill;
    }

    public bool GetPlayer2CanKill()
    {
        return this.player2CanKill;
    }
}
