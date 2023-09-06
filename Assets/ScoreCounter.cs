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

    //[SerializeField] private AudioSource collectionSoundEffect;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag(_tag))
        {
            //collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            points++;
            _score.text = "Poäng: " + points;
        }
    }
}
