using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    bool canJump;
    float trampolinforce = 2200f;

    
    void FixedUpdate()
    {

        gameObject.transform.rotation = new Quaternion(0,0,0,0);
        float xforce = 900f;
        float yforce = 700f;


        if (Input.GetKey("left"))
        {
            if(canJump==false)
            {
                xforce = xforce*0.4f;
            }

            xforce = xforce * -1;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(xforce * Time.deltaTime, 0));
            gameObject.GetComponent<Animator>().SetBool("moving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;

        }
        else if (Input.GetKey("right"))
        {
            if (canJump == false)
            {
                xforce = xforce*0.4f;
            }

            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(xforce * Time.deltaTime, 0));
            gameObject.GetComponent<Animator>().SetBool("moving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }



        if (Input.GetKeyDown("up") && canJump)
        {
            gameObject.GetComponent<Animator>().SetBool("jumping", true);
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, yforce));
            canJump = false;
        }


        if (Input.GetKeyDown("down"))
        {
            gameObject.GetComponent<Animator>().SetTrigger("attacking");
        }

        



        

        if (!Input.GetKey("left") && !Input.GetKey("right"))
        {
            gameObject.GetComponent<Animator>().SetBool("moving", false);
        }

       


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ground")
        {
            gameObject.GetComponent<Animator>().SetBool("jumping", false);
            canJump = true;
        }
        else if (collision.transform.tag == "Trampolin")
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, trampolinforce));
        }
        else if (collision.transform.tag == "Player2" && Input.GetKey(KeyCode.S) && ScoreManager.scoreManager.GetPlayer2CanKill() == true)
        {
            Destroy(gameObject);
        }

    }

  


}
