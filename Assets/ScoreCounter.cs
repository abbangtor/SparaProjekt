using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    private int points = 0;
    [SerializeField] private Text _score;
    [SerializeField] private string _tag;

    List<string> trashList = new List<string>()
    {
        "Metal",
        "Plastic",
        "Paper",
        "Compost",
        "Pant"
    };

    //[SerializeField] private AudioSource collectionSoundEffect;

    private void OnTriggerEnter(Collider collision)
    {
        

        for (int i = 0; i < trashList.Count; i++)
        {
            if (collision.gameObject.CompareTag(trashList[i]))
            {
                Debug.Log(collision.tag);

                collision.GetComponentInParent<Skr�pUppplockning>().stuckTrash = false;
                Destroy(collision.transform.parent.gameObject);
                Destroy(collision.gameObject);

                if (collision.gameObject.CompareTag(_tag))
                {
                    points++;
                }
                else
                {
                    points--;
                }

                _score.text = "Po�ng: " + points;

            }
        }
    }
}
