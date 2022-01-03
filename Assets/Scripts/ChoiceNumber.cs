using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class ChoiceNumber : MonoBehaviour
{
  [SerializeField] private int _max;
  [SerializeField] private int _min;
  private int _maxRange;
  private int _minRange;
  private int _counterSteps;
  private int _guess;

  private void Start()
  {
    ChangeToDefaultValues();
    Debug.Log(message: $"Загадай число от {_minRange} до {_maxRange}");
  }

  private void Update()
  {
    if (Input.GetKeyDown(KeyCode.DownArrow))
    {
      _maxRange = _guess;
      CalcGuess();
    }

    if (Input.GetKeyDown(KeyCode.UpArrow))
    {
      _minRange = _guess;
      CalcGuess();
    }

    if (Input.GetKeyDown(KeyCode.Space))
    {
      ChangeToDefaultValues();
    }
  }

  private void CalcGuess()
  {
    _guess = (_minRange + _maxRange) / 2;
    _counterSteps += 1;
    Debug.Log(message: $"Твоё число: {_guess}? Кол-во шагов: {_counterSteps}?");
  }

  private void ChangeToDefaultValues()
  {
    _minRange = _min;
    _maxRange = _max;
    _counterSteps = 0;
    // _guess = 0;
    ShowInfo();
  }

  private void ShowInfo()
  {
    Debug.Log(message: $"число: {_guess}, шагов: {_counterSteps}, от: {_minRange}, до: {_maxRange}");
  }
}