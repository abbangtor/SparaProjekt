using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InstantiateRandom : MonoBehaviour
{
    public Transform Spawnposition;

    public GameObject[] objectsToInstantiate;

    [SerializeField] private float _interval = 3f;

    private float _time;

    // Start is called before the first frame update
    void Spawn()
    {
        int n = Random.Range(0,objectsToInstantiate.Length);
       // Instantiate(objectsToInstantiate[n], Spawnposition.position, objectsToInstantiate[n].transform.rotation);
        Instantiate(objectsToInstantiate[n], Spawnposition.position, Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        _time += Time.deltaTime;
        while (_time >= _interval)
        {
            Spawn();
            _time -= _interval;
        }
    }
}
