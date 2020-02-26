using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipClass : MonoBehaviour
{

    public float force = 1;
    public float rotationSpeed = 1;
    public Vector2 horizontalLimits;
    public Vector2 verticalLimits;

    Rigidbody2D rigidbodyclass;

    // Start is called before the first frame update
    void Start()
    {
        rigidbodyclass = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward * rotationSpeed);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.forward * -rotationSpeed);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidbodyclass.AddRelativeForce(Vector3.up * force);
        }

        CheckLimits();
    }

    public void CheckLimits()
    {

        if(transform.position.x < horizontalLimits.x)
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Asteroid"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
    }
    
}
