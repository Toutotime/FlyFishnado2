using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BootFaller : MonoBehaviour
{
    

    public float speed = 5f;
    public GameManager manager;
    public int basicScore = -1;
    
    Vector3 screenHeight;
    float currentScreenHeight;
    float scoreMultipleRatio = 4;
    float maxScoreMultiplier;

    // Start is called before the first frame update
    void Start()
    {
        screenHeight = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height));
        currentScreenHeight = screenHeight.y;
        
        manager = (GameManager) FindObjectOfType(typeof(GameManager));    
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Vector3.up * Time.deltaTime * speed);

    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "GameController")
        {
            if(transform.position.y > maxScoreMultiplier)
            {
                manager.IncreaseScore(basicScore);
            }
            

            Destroy(this.gameObject);
            
        }
    }
}
