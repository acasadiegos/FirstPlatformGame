using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawnerLeft : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject CoinLeftPrefab;
    public static CoinSpawnerLeft coinSpawnerLeft;
    void Start()
    {
        coinSpawnerLeft = this;
        CreateCoin();
    }

    // Update is called once per frame
    void Update()
    {
         
    }

    public void CreateCoin()
    {
        float x = Random.Range(-7.07f, 3.34f);
        float y = Random.Range(3.92f, 20.49f);
        Vector3 position = new Vector3(x, y, 0);
        Quaternion rotation = new Quaternion();
        Instantiate(CoinLeftPrefab, position, rotation);
    }
}
