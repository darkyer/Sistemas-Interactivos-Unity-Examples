using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction
{
    Up,
    Down,
    Left,
    Right
}

public class SnakeHead : MonoBehaviour
{
    public Direction direction;
    public float time = 0.2f;
    public float step = 0.016f;
    public Vector2 verticalLimits;
    public Vector2 horizontalLimits;
    public GameObject tailPrefab;
    public List<Transform> tail;


    Vector3 lastPos;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Move", time, time);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
            direction = Direction.Left;
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
            direction = Direction.Up;
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
            direction = Direction.Right;
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
            direction = Direction.Down;
    }

    private void Move()
    {
        lastPos = transform.position;

        Vector3 nextPos = Vector3.zero;

        if (direction == Direction.Down)
            nextPos = Vector2.down;
        else if (direction == Direction.Left)
            nextPos = Vector2.left;
        else if (direction == Direction.Up)
            nextPos = Vector2.up;
        else if (direction == Direction.Right)
            nextPos = Vector2.right;

        nextPos *= step;
        transform.position += nextPos;

        MoveTail();
    }

    void MoveTail()
    {
        for (int i = 0; i < tail.Count; i++)
        {
            Vector3 temp = tail[i].position;
            tail[i].position = lastPos;
            lastPos = temp;
        }
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Block"))
        {
            Debug.Log("Juego Terminado " + col.name);
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
        else if (col.CompareTag("Food"))
        {
            tail.Add(Instantiate(tailPrefab, tail[tail.Count - 1].position, Quaternion.identity).transform);
            col.transform.position = new Vector2(Random.Range(horizontalLimits.x, horizontalLimits.y),
                Random.Range(verticalLimits.x, verticalLimits.y));
        }
    }
}
