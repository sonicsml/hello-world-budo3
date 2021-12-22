using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    private int a1;
    private float a2;
    private string a3;
    private bool a4;

    private Vector2 v2;
    private Vector3 v3;
    
    
    private void Awake()
    {
  //      Debug.Log(message:$"Awake");    
    }

    // Start is called before the first frame update
    private void Start()
    {
   //     Debug.Log(message: $"Start");
    }

    // Update is called once per frame
    private void Update()
    {
   //     Debug.Log(message: $"Update");
   // string str = string.Empty;
   //   var age = 10;
   //   int age2 = age;

            
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log(message:$"GetKeyDown {Time.frameCount}");
        }

        float axis = Input.GetAxis("Horizontal");
        Debug.Log(message:$"GetAxis axis {axis}");

        float move = axis * 10;
        Vector3 pos = transform.position;
        pos.x += move;
        transform.position = pos;
        
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(message:$"GetKey {Time.frameCount}");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(message:$"GetKeyUp {Time.frameCount}");
        }
    }
    private void Test()
    {
        Debug.Log(message:$"Test");
    }
}
