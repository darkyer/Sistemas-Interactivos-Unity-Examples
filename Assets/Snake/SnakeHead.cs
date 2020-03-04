using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// tipo de variable creada que solo puede tener uno de los 4 valores definidos
public enum Direction
{
    Up,
    Down,
    Left,
    Right
}

public class SnakeHead : MonoBehaviour
{
    public Direction direction;         // variable de tipo Direction (la definida arriba) que aún no tiene valor
    public float time = 0.2f;           // variable tipo float (numeros con decimales)
    public float step = 0.016f;         // variable tipo float (numeros con decimales)
    public Vector2 verticalLimits;      // Variable tipo Vector2 (que tiene "X" y "Y") y que cada uno puede tener un valor diferente
    public Vector2 horizontalLimits;    // Variable tipo Vector2 (que tiene "X" y "Y") y que cada uno puede tener un valor diferente
    public GameObject tailPrefab;       // variable tipo GameObject (un objeto de la escena o del proyecto)
    public List<Transform> tail;        // lista de tipo transform, es un grupo de "transforms" (transform = el componente de unity que guarda la posición y rotación del objeto)


    Vector3 lastPos;    // variable tipo Vector3 (que tiene "X", "Y" y "Z") que guarda la posición del player antes de moverlo
 
    void Start()    // esta función es predefinida por unity y se ejecuta una sola vez al darle "play"
    {
        InvokeRepeating("Move", time, time);        // esta es una funcion de unity que llama la funcion "move" cada X tiempo definido en los dos parametros
    }

    
    void Update()    // esta función es predefinida por unity y se ejecuta cada frame (generalmente usadas para detectar inputs) 
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))     // if que checa el input de la flecha izquierda o A y cambia la direction a left
            direction = Direction.Left;
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))       // if que checa el input de la flecha arriba o W y cambia la direction a up
            direction = Direction.Up;
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))    // if que checa el input de la flecha derecha o D y cambia la direction a right
            direction = Direction.Right;
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))     // if que checa el input de la flecha abajo o S y cambia la direction a down
            direction = Direction.Down;

        // en esta función solo se checa el input del jugador, y según la tecla presionada cambia el valor de la variable direction.
    }

    private void Move() // esta funcion es la que realmente mueve al jugador dependiendo del estado de la variable direction
    {
        lastPos = transform.position; // guardamos la posicion actual del player en la variable lastPos (Vector3) antes de mover al player, esto sirve para mover las colas

        Vector3 nextPos = Vector3.zero;  // creamos un vector3 con valor 0 en x,y,z

        if (direction == Direction.Down)        // si la direction es down ponemos el vector 3 en dirección hacia abajo (0,-1,0)
            nextPos = Vector2.down;
        else if (direction == Direction.Left)   // si la direction es left ponemos el vector 3 en dirección hacia izquierda (-1,0,0)
            nextPos = Vector2.left;
        else if (direction == Direction.Up)     // si la direction es up ponemos el vector 3 en dirección hacia arriba (0,1,0)
            nextPos = Vector2.up;
        else if (direction == Direction.Right)  // si la direction es right ponemos el vector 3 en dirección hacia abajo (1,0,0)
            nextPos = Vector2.right;

        nextPos *= step;    // despues de definir la dirección que tomará el player, multiplicamos el vector que tenemos de nextPos por el valor de distancia que queremos realizar
                            // entonces si nos movemos a la derecha (1,0,0) se multiplica por step (EJ: 0.2) entonces el vector queda en (0.2,0,0)
                            // hasta ahorita no hemos movido al player, solo hemos creado una variable vector3 con la dirección que tomará el player

        transform.position += nextPos; // esta es la línea que le suma la distancia a la posición del player

        MoveTail(); // funcion que mueve las colas
    }

    void MoveTail()
    {
        for (int i = 0; i < tail.Count; i++) // for que checa la lista de las colas y las mueve
        {
            Vector3 temp = tail[i].position;    // guarda la posición de la cola antes de moverla
            tail[i].position = lastPos;         // le pone la última posición del player a la cola
            lastPos = temp;                     // actualiza la ultima posición del player con la de la cola
        }
    }


    void OnTriggerEnter2D(Collider2D col)       // función de unity para detectar colisiones (se requiere un collider en el objeto con "trigger" activado y al menos uno de los objetos de colisión necesita un rigidbody2D
    {
        if (col.CompareTag("Block"))    // checa si el objeto con el que hubo colisión tiene el tag "Block", y si lo tiene ejecuta el código que carga la escena 0 del build settings
        {
            Debug.Log("Juego Terminado " + col.name);
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
        else if (col.CompareTag("Food"))    // checa si el objeto con el que hubo colisión tiene el tag "Food", y si lo tiene ejecuta el código que instancía una nueva cola y cambia
                                            // la posición de la comida aleatoriamente dentro de los límites predefinidos
        {
            tail.Add(Instantiate(tailPrefab, tail[tail.Count - 1].position, Quaternion.identity).transform);
            col.transform.position = new Vector2(Random.Range(horizontalLimits.x, horizontalLimits.y),
                Random.Range(verticalLimits.x, verticalLimits.y));
        }
    }
}
