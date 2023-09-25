using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public PointSign pointSign;
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

    private void Start()
    {
        pointSign = GameObject.Find("sign").GetComponent<PointSign>();
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
                    if (_tag == "Pant")
                    {
                        pointSign.points++;
                    }
                }
                else
                {
                    pointSign.points--;
                }

            }
        }
    }
}
