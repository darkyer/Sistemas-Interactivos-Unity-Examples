using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidClass : MonoBehaviour
{
    public float force = 1;
    public Vector2 horizontalLimits;
    public Vector2 verticalLimits;

    Rigidbody2D rigidbodyclass;
    // Start is called before the first frame update
    void Start()
    {
        rigidbodyclass = GetComponent<Rigidbody2D>();
        rigidbodyclass.AddForce(new Vector2(Random.Range(-force, force), Random.Range(-force, force)));
    }

    // Update is called once per frame
    void Update()
    {
        CheckLimits();
    }

    public void CheckLimits()
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
