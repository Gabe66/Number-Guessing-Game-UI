using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberGuessingGame : MonoBehaviour
{
    [SpecicalizeField]private int guess = 5;
    [SpecicalizeField]private int minValue = 1;
    [SpecicalizeField]private int maxValue = 10;


    private int guess; 
    // Start is called before the first frame update
    void Start()
    {
       StartGame();
    } 

    // Update is called once per frame
    void Update()
    {
    
        if(Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            minValue = guess;
            guess = (maxValue + minValue) / 2;
            Debug.Log("Is it higher or lower than: " + guess);
        }
    
     if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            maxValue = guess;
            guess = (maxValue + minValue) / 2;
            Debug.Log("Is it higher or lower than: " + guess);
        }
      
     if(Input.GetKeyDown(KeyCode.Return))
        {      
            Debug.Log("I guessed your number i'm a genius!");
            Debug.Log("");
            StartGame();
        }
    
    }
    
    void StartGame()
    {
        guess =5;
        minValue = 1;
        maxValue = 10;

        Debug.Log("Welcome to our Number Guessing Game.");
       Debug.Log("The number range is from "+ minValue +"and" + maxValue);
       Debug.Log("Guess a number between the given range.");
       Debug.Log("Tell me if your number is higher or lower that: " + guess + "?");
       Debug.Log("Push up arrow = Higher, Push down arrow = Lower, Push Enter = Correct");
       maxValue = maxValue +1;
    }
}
