using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [SerializeField] private bool Player1;
    [SerializeField] private float Speed = 10f;
    [SerializeField] private float movement;
    [SerializeField] private Rigidbody2D rb;
    
    void Update()
    {
        if (Player1)
        {
            movement = Input.GetAxisRaw("Player1Key");
        }
        else
        {
            movement = Input.GetAxisRaw("Player2Key");
        }
        rb.velocity = new Vector2(0, Speed * movement);

    }
}
