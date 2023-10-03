using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Newtonsoft.Json;
using System.Linq;

public class GameScore : MonoBehaviour
{
    private bool IsScoreChecked = false;
    public int EndScore;
    public TMP_Text Score1; // Reference to your TMPro TextMeshProUGUI component in Unity Editor
    public TMP_Text Score2;
    public TMP_Text Score3;
    public TMP_Text Score4;
    public TMP_Text Score5;
    List<int> HighScoresList = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        LoadHighScoreList();
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameObject.Find("Display").GetComponent<TimePls>().timerIsRunning && !IsScoreChecked)
        {
            EndScore = GameObject.Find("sign").GetComponent<PointSign>().points;
            Debug.Log(EndScore);
            HighScoreUpdate();
            IsScoreChecked = true;
            WriteScoreToScoreBoard();
        }
    }

    public void HighScoreUpdate()
    {
        if (HighScoresList.Count < 5 || EndScore > HighScoresList.Min())
        {
            HighScoresList.Add(EndScore);
            HighScoresList = HighScoresList.OrderByDescending(x => x).ToList();
            // Keep only the top 5 scores
            HighScoresList = HighScoresList.Take(5).ToList();
            SaveScoreToHighScoreList();
        }
        else
        {
            Debug.Log("Score too low, didn't make it to the high score list.");
        }

        //Debugin, checkin so everything work u know
        Debug.Log("Count: " + HighScoresList.Count);
        Debug.Log("High Scores: " + string.Join(", ", HighScoresList));
    }

    public void SaveScoreToHighScoreList()
    {
        // Convert List<T> to JSON string
        string json = JsonConvert.SerializeObject(HighScoresList);
        // Save JSON string to PlayerPrefs
        PlayerPrefs.SetString("ListData", json);
        PlayerPrefs.Save();
    }

    public void LoadHighScoreList()
    {
        // Load JSON string from PlayerPrefs
        string jsonString = PlayerPrefs.GetString("ListData", "");
        // Convert JSON string back to List<T>
        if (!string.IsNullOrEmpty(jsonString))
        {
            HighScoresList = JsonConvert.DeserializeObject<List<int>>(jsonString);
        }
    }

    public void WriteScoreToScoreBoard()
    {
        if(HighScoresList.Count > 0 && HighScoresList[0]>0 )
        {
            Score1.text = HighScoresList[0].ToString();
        }
        else
        {
            Score1.text = "-";
        }

        if (HighScoresList.Count > 1 && HighScoresList[1] > 0)
        {
            Score2.text = HighScoresList[1].ToString();
        }
        else
        {
            Score2.text = "-";
        }
        if (HighScoresList.Count > 2 && HighScoresList[2] > 0)
        {
            Score3.text = HighScoresList[2].ToString();
        }
        else
        {
            Score3.text = "-";
        }
        if (HighScoresList.Count > 3 && HighScoresList[3] > 0)
        {
            Score4.text = HighScoresList[3].ToString();
        }
        else
        {
            Score4.text = "-";
        }
        if (HighScoresList.Count > 4 && HighScoresList[4] > 0)
        {
            Score5.text = HighScoresList[4].ToString();
        }
        else
        {
            Score5.text = "-";
        }

    }
}
