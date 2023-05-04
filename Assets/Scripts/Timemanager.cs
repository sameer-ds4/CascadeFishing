using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timemanager : MonoBehaviour
{
    public float time;
    public int timeinsec;
    public GameObject playbutton;
    public GameObject replaybutton;
    public GameObject timedisplayed;
    public TextMeshProUGUI timedisplay;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        playbutton.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        time -= 1 * Time.deltaTime;
        timeinsec = Mathf.RoundToInt(time);
        timedisplay.text = timeinsec.ToString();
        if(time <= 0)
        {
            pause();
        }
    }

    public void pause()
    {
        timedisplayed.SetActive(false);
        replaybutton.SetActive(true);
        Time.timeScale = 0f;
    }

    public void play()
    {
        playbutton.SetActive(false);
        Time.timeScale = 1;
    }

    public void replay()
    {
        SceneManager.LoadScene(0);
    }
}
