using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5;
    float rawInput;


    void Update()
    {
      Move();  
    }

    void Move()
    {  
      Vector3 delta = new Vector3 (0, rawInput * moveSpeed * Time.deltaTime, 0);
    }

    void OnMove(InputValue value)
    {
        rawInput = value.Get<float>();
        Debug.Log(rawInput);
    }
}
