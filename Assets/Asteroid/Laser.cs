using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    Rigidbody2D rigidBody;
    public float velocity;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.AddRelativeForce(new Vector2(0, velocity));

    }
}