using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject spawnee;
    public bool stopSpawning;
    public float spawnTime;
    public float spawnDelay;
    int screenWidth;
    int screenHeight;
    Vector3 screenToWorldPos;

    public Text scoreRef;
    public int score;
    public int currentScore;
    //float currentTime;
    
    public int CurrentScore()
    {
        return score;
    }

    void Start()
    {
        InvokeRepeating("SpawnBall", spawnTime, spawnDelay);
        InvokeRepeating("SpawnShoe", spawnTime, spawnDelay);
        score = 0;
    }

    public void SpawnBall()
    {
        Instantiate(spawnee, RandomPosition(), transform.rotation);
    }

    public void SpawnShoe()
    {
        Instantiate(spawnee, RandomPosition(), transform.rotation);
    }
    //Shoespawn?
    Vector3 RandomPosition() 
    {
        screenWidth = Screen.width;
        screenHeight = Screen.height;
        screenToWorldPos = Camera.main.ScreenToWorldPoint(
            new Vector3(Random.Range(0, screenWidth), screenHeight, 1));
           return screenToWorldPos; 
    
    }

    public void IncreaseScore(int reward)
    {
        score += reward;
        scoreRef.text = "Score:" + score.ToString();
    }

    public void DecreaseScore(int reward)
    {
        score -= reward;
        scoreRef.text = "Score:" + score.ToString();
    }
    
    // Update is called once per frame
     void Update()
    {
       
    }
}
