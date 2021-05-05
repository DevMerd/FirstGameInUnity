using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberGuess : MonoBehaviour
{
    int min, max;
    int estimation;

    void Start()
    {
        startGame();    
    }

    void startGame()
    {
        min = 1;  max = 1501;
        estimation = 750;
        Debug.Log("Number Guessing Game is starting..");
        Debug.Log("Keep a number in your mind");
        Debug.Log("Is the number you hold 750?");
        Debug.Log("Press up button to increase and press down button to decrease ");
        max += 1;

    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = estimation;
            guess();
            Debug.Log("Up button pressed:"+ estimation);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = estimation;
            guess();
            Debug.Log("Down button pressed:"+ estimation);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Congrats !!!");
            Debug.Log("Do you wanna again ?");
            Start();
        }
        
        }
        void guess()
        {
            estimation = (min + max) / 2;
        }   
}
