using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player2Controller : MonoBehaviour
{
    bool canJumpP2;
    
    float trampolinforce = 2200f;
    void FixedUpdate()
    {

        gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);
        float xforce = 900f;
        float yforce = 700f;


        if (Input.GetKey(KeyCode.A))
        {
            if (canJumpP2 == false)
            {
                xforce = xforce * 0.4f;
            }

            xforce = xforce * -1;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(xforce * Time.deltaTime, 0));
            gameObject.GetComponent<Animator>().SetBool("moving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;

        }
        else if (Input.GetKey(KeyCode.D))
        {
            if (canJumpP2 == false)
            {
                xforce = xforce * 0.4f;
            }

            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(xforce * Time.deltaTime, 0));
            gameObject.GetComponent<Animator>().SetBool("moving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }



        if (Input.GetKeyDown(KeyCode.W) && canJumpP2)
        {
            gameObject.GetComponent<Animator>().SetBool("jumping", true);
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, yforce));
            canJumpP2 = false;
        }


        if (Input.GetKeyDown(KeyCode.S))
        {
            gameObject.GetComponent<Animator>().SetTrigger("attacking");
        }





        

        if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            gameObject.GetComponent<Animator>().SetBool("moving", false);
        }




    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ground")
        {
            gameObject.GetComponent<Animator>().SetBool("jumping", false);
            canJumpP2 = true;
        }
        else if (collision.transform.tag == "Trampolin")
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, trampolinforce));
        }
        else if (collision.transform.tag == "Player" && Input.GetKey("down") && ScoreManager.scoreManager.GetPlayer1CanKill() == true)
        {
            Destroy(gameObject);
        }

    }


}
