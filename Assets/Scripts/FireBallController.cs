using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FireBallController : MonoBehaviour
{
  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ground" || collision.transform.tag == "Player" || collision.transform.tag == "Enemy")
        {
            gameObject.GetComponent<Animator>().SetBool("explode", true);
        }

        if (collision.transform.tag == "Player")
        {
            SceneManager.LoadScene("SampleScene");

        }
    }
}
