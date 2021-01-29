using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawnerMiddle : MonoBehaviour
{
    public GameObject CoinMiddletPrefab;
    public static CoinSpawnerMiddle coinSpawnerMiddle;
    void Start()
    {
        coinSpawnerMiddle = this;
        CreateCoin();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CreateCoin()
    {
       
        Vector3 position = new Vector3(10.99f, 18.42f, 0);
        Quaternion rotation = new Quaternion();
        Instantiate(CoinMiddletPrefab, position, rotation);
    }
}
