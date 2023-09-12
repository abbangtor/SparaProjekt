using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkräpUppplockning : MonoBehaviour
{
    [SerializeField] private Transform _tipTransform;
    public GameObject _trash;
    public bool stuckTrash = false;
    [SerializeField] private Transform arrow;

    List<string> trashList = new List<string>()
    {
        "Metal",
        "Plastic",
        "Paper",
        "Compost",
        "Pant"
    };
    // Start is called before the first frame update
    void Start()
    {
        _tipTransform = _tipTransform.GetComponent<Transform>();
        arrow = arrow.GetComponent<Transform>();
    }

  
    private void OnCollisionEnter(Collision other)
    {
        if (!stuckTrash)
        {
            for (int i = 0; i < trashList.Count; i++)
            {
                if (other.gameObject.CompareTag(trashList[i]))
                {
                    _trash = other.gameObject;
                    /*foodTransform = other.GetComponent<Transform>();*/
                    stuckTrash = true;
                    _trash.GetComponent<Collider>().isTrigger = false;
                    _trash.transform.SetParent(arrow);

                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (stuckTrash)
        {
            _trash.transform.SetPositionAndRotation(_tipTransform.position, transform.rotation);
            _trash.GetComponent<Rigidbody>().isKinematic = true;

        }

    }
}
