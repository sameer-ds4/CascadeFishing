using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Scoremanager : MonoBehaviour
{
    public static Scoremanager instance;

    public int score;
    public TextMeshProUGUI scoredisplay;

    public void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    public void Start()
    {
        score = 0;
        scoredisplay.text = score.ToString();
    }

    public void scoring()
    {
        score++;
        scoredisplay.text = score.ToString();
    }
}
