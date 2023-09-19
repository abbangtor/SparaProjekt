using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashSpawner : MonoBehaviour
{
    // Variable we´re going to put our prefab into
    public GameObject objectToSpawn;
    

    public GameObject name1;
    public GameObject name2;
    public GameObject name3;
   



    // Start is called before the first frame update
    void Start()
    {
        GameObject objectToSpawn = GameObject.Find("name1");

        // Instantiate(objectToSpawn, new Vector3(0, 0, 0), Quaternion.identity);
        Debug.Log(objectToSpawn.name);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
