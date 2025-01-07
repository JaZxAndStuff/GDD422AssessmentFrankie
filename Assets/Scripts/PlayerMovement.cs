using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb2D;
    Vector2 moveDir;
   void OnMove(InputValue value)
    {
        moveDir = value.Get<Vector2>();
    }

    // Update is called once per frame
    void Update()
    {
        Run();
    }

    private void Run()
    {
        rb2D.velocity = moveDir * 5;
    }
}
