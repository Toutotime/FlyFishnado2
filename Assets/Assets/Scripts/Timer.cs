using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float currentTime;
    public float startingTime = 10f;
    [SerializeField] Text countdownText;

    //public GameManager manager;
    //need to get score from gamemanager script to compare when timer ends
    public int score;

    void Start()
    {
        currentTime = startingTime;    
    }

    public void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");
       // score = GetComponent<GameManager>().CurrentScore();

        if (currentTime <= 0)
        {
            currentTime = 0;
         if ( score <= 10)
            {
               SceneManager.LoadScene("WinScreen");
            }
        else
            {
                SceneManager.LoadScene("Lose Scene");
            }
        }  
    }
}
