using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    float currentTime;
    public float startingTime = 10f;
    [SerializeField] Text countdownText;

    public int basicScore;


    public GameObject winBox;
    public GameObject loseBox;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
        

    }

    // Update is called once per frame
    void Update()
    {
        currentTime += 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if(currentTime >= 0)
        {
            currentTime = 0;

            if (basicScore <= 5)
            {
                 SceneManager.LoadScene("EndScreens");
              
            }

            else 
            {
                SceneManager.LoadScene("EndScreens");
               
            }

            //Enter  IF/ELSE SCORE AND END SCREENS
        }
    }
}
