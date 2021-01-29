using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallSpawner : MonoBehaviour
{
    float timer;
    public GameObject FireBallPrefab;
    public GameObject Player;
    
    void Update()
    {
        /*
        timer += Time.deltaTime;

        if(timer >= 1.2f)
        {
            timer = 0;
            float x = Random.Range(Player.transform.position.x - 9f, Player.transform.position.x + 9f);
            if(x< -3.06f)
            {
                x = Random.Range(Player.transform.position.x + 2f, Player.transform.position.x + 9f);
            }
            else if (x> 105.94f)
            {
                x = Random.Range(Player.transform.position.x - 9f, 105.94f);
            }

            Vector3 position = new Vector3(x, FireBallPrefab.transform.position.y, 0);
            Instantiate(FireBallPrefab, position, FireBallPrefab.transform.rotation);

        }
        */
    }
}
