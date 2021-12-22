using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class ChoiceNumber : MonoBehaviour
{
    [SerializeField] private int max;
    public int min;
    private int guess;

    private void Start()
    {
        Debug.Log(message:$"Загадай число от {min} до {max}");
        CalcGuess();
    }

    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            min = guess;
            CalcGuess();
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            max = guess;
            CalcGuess();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(message:$"Ура! Победа");
        }
    }
    

    private void CalcGuess()
    {
        guess = (min + max) / 2;
        Debug.Log(message:$"Твоё число {guess}?");
    }
}
