using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float force;
    public Vector2 horizontalLimits;
    public Vector2 verticalLimits;
    Rigidbody2D rigidBody;
    public GameObject smallAsteroidPrefab;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.AddForce(new Vector2(Random.Range(-force, force), Random.Range(-force, force)));
    }

    // Update is called once per frame
    void Update()
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Laser"))
        {
            DestroyAsteroid();
            Destroy(collision.gameObject);
        }
    }

    public void DestroyAsteroid()
    {
        Debug.LogFormat("instatiating {0} in {1}", gameObject.name, transform.position);
        Instantiate(smallAsteroidPrefab, gameObject.transform.position, transform.rotation);
        Instantiate(smallAsteroidPrefab, gameObject.transform.position, transform.rotation);
        Destroy(gameObject);
    }

}
