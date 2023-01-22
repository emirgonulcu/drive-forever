using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class YourScoreTextScript : MonoBehaviour
{
    public Text your_score;

    void Start()
    {
        your_score.text = ScoreManager.score.ToString();
    }
}
