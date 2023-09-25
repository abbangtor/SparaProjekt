using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PointSign : MonoBehaviour
{
    private int latest_points = 0;
    public int points = 0;
    [SerializeField] private Text _score;


    // Update is called once per frame
    void Update()
    {
        if (latest_points != points)
        {
            latest_points = points;
            _score.text = "Poäng: " + points;
        }
    }
}
