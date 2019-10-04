using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    public float speed = 1;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();  
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) { 
            _rigidbody.velocity = Vector2.up * speed;
        }
    }
}