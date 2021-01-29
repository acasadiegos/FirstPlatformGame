using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawnerRight : MonoBehaviour
{
    public GameObject CoinRightPrefab;
    public static CoinSpawnerRight coinSpawnerRight;
    void Start()
    {
        coinSpawnerRight = this;
        CreateCoin();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CreateCoin()
    {
        float x = Random.Range(29.49f, 39.13f);
        float y = Random.Range(3.92f, 20.49f);
        Vector3 position = new Vector3(x, y, 0);
        Quaternion rotation = new Quaternion();
        Instantiate(CoinRightPrefab, position, rotation);
    }
}
