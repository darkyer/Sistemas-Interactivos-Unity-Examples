using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public float force;
    public float rotationSpeed = 3;
    Rigidbody2D rigidBody;
    public GameObject laserPrefab;

    public Vector2 horizontalLimits;
    public Vector2 verticalLimits;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * rotationSpeed);

        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.forward * -rotationSpeed);
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            rigidBody.AddRelativeForce(Vector2.up * force);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laserPrefab, transform.position, transform.rotation);
        }

        CheckBorders();
    }

    void CheckBorders()
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


