using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // instantiation params
    int minNumber = 1;
    int maxNumber = 1000;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    private void StartGame()
    {
        Debug.Log("Computer: Gday mate, here is the number wizard game, guess a number between " + minNumber + " and " + maxNumber);
        Debug.Log("Player: Dont tell me what it is ... is it " + guess);
        maxNumber = maxNumber + 1;
    }

    // Update is called once per frame
    void Update()
    {
        // check if player has pressed up
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            minNumber = guess;
            UpdateGuess();
        }

        // check if down has been pressed
        else if (Input.GetKeyDown(KeyCode.DownArrow)) 
        { 
            maxNumber = guess;
            UpdateGuess();
        }

        // check if Enter (Return) key is pressed
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I've finished the game !!");
        }

        // account for three cases
        if (guess == 1 || guess == 1000 || minNumber == maxNumber)
        {
            ResetGuess();
        }

    }

    private void UpdateGuess()
    {
        guess = (minNumber + maxNumber) / 2;

        Debug.Log("Is the number " + guess);
    }

    private void ResetGuess()
    { 
        guess = 500;
        minNumber = 1;
        maxNumber = 1000;
        maxNumber = maxNumber + 1;
    }
}
