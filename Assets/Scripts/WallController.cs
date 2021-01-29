using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
    // Start is called before the first frame update
    bool touchplayer1;
    bool touchplayer2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (touchplayer2 && Input.GetKey(KeyCode.S))
        {
            Destroy(gameObject);
        }
        else if (touchplayer1 && Input.GetKey("down"))
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player2" && ScoreManager.scoreManager.GetPlayer2CanDestroy() == true)
        {
            touchplayer2 = true;
        }
        else if (collision.transform.tag == "Player" && ScoreManager.scoreManager.GetPlayer1CanDestroy() == true)
        {
            touchplayer1 = true;
        }


    }


}
