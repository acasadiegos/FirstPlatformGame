using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    float timer;
    float xforce = 7000f;

    public GameObject Player;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 2f)
        {
            if (gameObject.GetComponent<SpriteRenderer>().flipX == false)
            {

                gameObject.GetComponent<SpriteRenderer>().flipX = true;
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2( xforce * -1f, 0));


            }
            else
            {
                gameObject.GetComponent<SpriteRenderer>().flipX = false;
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(xforce, 0));


            }

            

            timer = 0;
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Player" && Player.GetComponent<SpriteRenderer>().flipX != gameObject.GetComponent<SpriteRenderer>().flipX)
        {
            SceneManager.LoadScene("SampleScene");
        }
        else if (collision.transform.tag == "Player" && Input.GetKey("a"))
        {
            Destroy(gameObject);
        }

    }


}
