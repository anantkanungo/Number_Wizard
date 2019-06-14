using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int _max , _min ,_guess;
    
    // Start is called before the first frame update
    void Start() 
    {
        StartGame();
    }

    void StartGame()
    {
        _max = 1000;
        _min = 1;
        _guess = 500;
        Debug.Log("Hey,Welcome to Number Wizard");
        Debug.Log("Pick a number, Don't tell me");
        Debug.Log("Highest number you can pick : " + _max);
        Debug.Log("Lowest number you can pick : " + _min);
        Debug.Log("Is your number is Higher or Lower than : " +_guess);
        Debug.Log("Press Up = Higher, Press Down =Lower, Press Enter =Correct");
        _max = _max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            _max = _guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _min = _guess;
            NextGuess();
                        
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I got it because i'm a psychic");
            StartGame();
        }
        
    }

    void NextGuess()
    {
        _guess = (_max + _min) / 2;
        Debug.Log("Press Up  if your Number is Higher than :" + _guess);
        Debug.Log("press Down if your number is Lower than :" + _guess);
        Debug.Log("Press Enter If the number is correct");

    }
}
