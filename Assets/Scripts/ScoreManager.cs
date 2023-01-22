using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public static float score;
    void Start()
    {
        score = 0;
    }
    void Update()
    {
        scoreText.text = score.ToString();
    }
}
