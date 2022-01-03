using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicNumbers : MonoBehaviour
{
  private int _sumNumbers;
  private int _counterSteps;


  // Start is called before the first frame update
  void Start()
  {
    print("Введите число от 1 до 9");
  }

  // Update is called once per frame
  void Update()
  {
    if ((Input.GetKeyDown(KeyCode.Alpha1)) || (Input.GetKeyDown(KeyCode.Keypad1)))
    {
      _sumNumbers += 1;
      _counterSteps++;
      CheckSum();
    }

    if ((Input.GetKeyDown(KeyCode.Alpha2)) || (Input.GetKeyDown(KeyCode.Keypad2)))
    {
      _sumNumbers += 2;
      _counterSteps++;
      CheckSum();
    }

    if ((Input.GetKeyDown(KeyCode.Alpha3)) || (Input.GetKeyDown(KeyCode.Keypad3)))
    {
      _sumNumbers += 3;
      _counterSteps++;
      CheckSum();
    }

    if ((Input.GetKeyDown(KeyCode.Alpha4)) || (Input.GetKeyDown(KeyCode.Keypad4)))
    {
      _sumNumbers += 4;
      _counterSteps++;
      CheckSum();
    }

    if ((Input.GetKeyDown(KeyCode.Alpha5)) || (Input.GetKeyDown(KeyCode.Keypad5)))
    {
      _sumNumbers += 5;
      _counterSteps++;
      CheckSum();
    }

    if ((Input.GetKeyDown(KeyCode.Alpha6)) || (Input.GetKeyDown(KeyCode.Keypad6)))
    {
      _sumNumbers += 6;
      _counterSteps++;
      CheckSum();
    }

    if ((Input.GetKeyDown(KeyCode.Alpha7)) || (Input.GetKeyDown(KeyCode.Keypad7)))
    {
      _sumNumbers += 7;
      _counterSteps++;
      CheckSum();
    }

    if ((Input.GetKeyDown(KeyCode.Alpha8)) || (Input.GetKeyDown(KeyCode.Keypad8)))
    {
      _sumNumbers += 8;
      _counterSteps++;
      CheckSum();
    }

    if ((Input.GetKeyDown(KeyCode.Alpha9)) || (Input.GetKeyDown(KeyCode.Keypad9)))
    {
      _sumNumbers += 9;
      _counterSteps++;
      CheckSum();
    }

    if (Input.GetKeyDown(KeyCode.Space))
    {
      _sumNumbers = 0;
      _counterSteps = 0;
      CheckSum();
      print("Введите число от 1 до 9");
    }
  }

  private void CheckSum()
  {
    print($"Сумма: {_sumNumbers}");
    if (_sumNumbers >= 50)
    {
      print($"Игра закончена! Количество шагов: {_counterSteps}");
    }
  }
}