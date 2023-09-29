using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkräpUpplockning : MonoBehaviour
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

    private AudioSource _audioSource;

    // Start is called before the first frame update
    void Start()
    {
        _tipTransform = _tipTransform.GetComponent<Transform>();
        arrow = arrow.GetComponent<Transform>();
        _audioSource = GetComponent<AudioSource>();
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
                    stuckTrash = true;
                    PlayPokeSound();
                    /*_trash.GetComponent<Collider>().enabled = false;*/
                    _trash.transform.SetParent(arrow);

                }
            }
        }
    }

    private void PlayPokeSound()
    {
        _audioSource.Stop();
        _audioSource.Play();
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