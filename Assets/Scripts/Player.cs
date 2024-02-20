using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rigidbody2;
    private float inputValue;
    public float moveSpeed = 25;
    private Vector2 direction;
    Vector2 starPossition;

    private void Start()
    {
        starPossition = transform.position;
    }


    void Update()
    {
        inputValue = Input.GetAxisRaw("Horizontal");

        if(inputValue == 1)
        {
            direction = Vector2.right;
        }
        else if(inputValue == -1) 
        {
            direction = Vector2.left;
        }
        else
        {
            direction = Vector2.zero;
        }

        rigidbody2.AddForce(direction * moveSpeed * Time.deltaTime * 100);
    }
    
    public void ResetPlayer()
    {
        transform.position = starPossition;
        rigidbody2.velocity = Vector2.zero;
    }
}
