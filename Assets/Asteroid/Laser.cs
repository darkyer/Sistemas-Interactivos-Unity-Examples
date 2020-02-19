using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    Rigidbody2D rigidBody;
    public float velocity;
    public float destroyTime;
    public Vector2 horizontalLimits;
    public Vector2 verticalLimits;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.AddRelativeForce(new Vector2(0, velocity));
        Destroy(gameObject, destroyTime);
    }

    private void Update()
    {
        CheckBorders();
    }

    void CheckBorders()
    {
        if (transform.position.x < horizontalLimits.x)
        {
            transform.position = new Vector2(horizontalLimits.y, transform.position.y);
        }

        if (transform.position.x > horizontalLimits.y)
        {
            transform.position = new Vector2(horizontalLimits.x, transform.position.y);
        }

        if (transform.position.y < verticalLimits.x)
        {
            transform.position = new Vector2(transform.position.x, verticalLimits.y);
        }

        if (transform.position.y > verticalLimits.y)
        {
            transform.position = new Vector2(transform.position.x, verticalLimits.x);
        }

    }


}