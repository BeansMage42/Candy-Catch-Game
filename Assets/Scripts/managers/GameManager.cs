using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject[] Candy = new GameObject[6];
    [SerializeField] private int candyCount = 0;
    private int candyIndex;
    private float delay;
    private float random;
    [SerializeField] private int score;
    [SerializeField] private TMP_Text scoreText;
    private int candiesDestroyed;
    private bool inMenu = false;
    
    private void Start()
    {
        CreateCandy();
        GamePlay();

    }

    private void Update()
    {
        if(candiesDestroyed == 15 && !inMenu )
        {
            inMenu = true;
            EndGame();
        }
    }
    private void CreateCandy()
    {

        Debug.Log("Candy created");
            random = Random.Range(1, 100);
        if(random < 10)
        {
            candyIndex = 0;
        }else if(random >10 && random < 25)
        {
            candyIndex = 1;
        }
        else if(random >25 && random < 50)
        {
            candyIndex = 2;
        }
        else if (random > 50 && random < 55)
        {
            candyIndex = 3;
        }
        else if(random > 55 && random < 75)
        {
            candyIndex = 4;
        }
        else if (random > 75)
        {
            candyIndex = 5;
        }
        
            Instantiate(Candy[candyIndex],new Vector2(Random.Range(-10,10),transform.position.y), transform.rotation);
            
            

    }
    public void AddScore(int points)
    {
        scoreText.text = "+" + points.ToString();
        score += points;
        Debug.Log("Score");
    }

    private void GamePlay()
    {

        while(candyCount < 15)
        {
            
                
                delay += Random.Range(1, 4);
                Invoke("CreateCandy", delay);
                candyCount++;
           
        }
    }

    public void ObjectDestroyed()
    {
        candiesDestroyed++;
    }
    public void EndGame()
    {
        Inputs.MenuMode();
        scoreText.text = "Final Score: " + score.ToString();

    }

    
}
