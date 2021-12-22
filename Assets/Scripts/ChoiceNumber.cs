using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class ChoiceNumber : MonoBehaviour
{
    [SerializeField] private int _max;
    [SerializeField] private int _min;
    private int _counterSteps;
    private int _guess;

    private void Start()
    {
        Debug.Log(message:$"Загадай число от {_min} до {_max}");
        CalcGuess();
        _counterSteps = 0;
    }
 
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            _min = _guess;
            CalcGuess();
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _max = _guess;
            CalcGuess();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(message:$"Ура! Победа");
        }
    }
    

    private void CalcGuess()
    {
        _guess = (_min + _max) / 2;
        Debug.Log(message:$"Твоё число {_guess}?");
        Debug.Log(message:$"Кол-во шагов {_counterSteps}?");
        _counterSteps += 1;
    }
    
}
