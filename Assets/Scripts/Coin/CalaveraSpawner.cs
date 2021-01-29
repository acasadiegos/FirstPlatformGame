using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalaveraSpawner : MonoBehaviour
{
    public GameObject CalaveraPrefab;
    public static CalaveraSpawner calaveraSpawner;
    void Start()
    {
        calaveraSpawner = this;
        CreateCalavera();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CreateCalavera()
    {

        Vector3 position = new Vector3(20.87f, 14.39f, 0);
        Quaternion rotation = new Quaternion();
        Instantiate(CalaveraPrefab, position, rotation);
    }

}
