using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    private PointSign pointSign;
    [SerializeField] private string _tag;

    List<string> trashList = new List<string>()
    {
        "Metal",
        "Plastic",
        "Paper",
        "Compost",
        "Pant"
    };

    public AudioClip correctSound;
    public AudioClip wrongSound;
    public AudioSource audioSource;

    //[SerializeField] private AudioSource collectionSoundEffect;

    private void Start()
    {
        pointSign = GameObject.Find("sign").GetComponent<PointSign>();
        audioSource= GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        for (int i = 0; i < trashList.Count; i++)
        {
            if (collision.gameObject.CompareTag(trashList[i]))
            {
                Debug.Log(collision.tag);

                collision.GetComponentInParent<SkräpUpplockning>().stuckTrash = false;
                Destroy(collision.transform.parent.gameObject);
                Destroy(collision.gameObject);

                if (collision.gameObject.CompareTag(_tag))
                {
                    pointSign.points++;
                    PlayCorrectSound();
                    if (_tag == "Pant")
                    {
                        pointSign.points++;
                    }
                }
                else
                {
                    pointSign.points--;
                    PlayWrongSound();
                }

            }
        }
    }

    private void PlayCorrectSound()
    {
        audioSource.PlayOneShot(correctSound, 0.7f);
    }

    private void PlayWrongSound()
    {
        audioSource.PlayOneShot(wrongSound, 0.7f);
    }
}
