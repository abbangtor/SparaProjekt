using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InstantiateRandom : MonoBehaviour
{
    public Transform Spawnposition;

    public GameObject[] objectsToInstantiate;

    // Start is called before the first frame update
    void Start()
    {
        int n = Random.Range(0,objectsToInstantiate.Length);
       // Instantiate(objectsToInstantiate[n], Spawnposition.position, objectsToInstantiate[n].transform.rotation);
        Instantiate(objectsToInstantiate[n], Spawnposition.position, Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        // Check for input using the new Input System.
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            // Your code for handling spacebar input.
        }
    }
}
