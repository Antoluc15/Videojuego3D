using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 7f;

    private Rigidbody rb;
    private bool isGrounded;

    // Dificultad progresiva
    public float difficultyTimer = 10f; // tiempo entre incrementos
    public float speedIncrement = 1f;   // cuánto aumenta la velocidad
    private float timePassed = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        // Cargar velocidad guardada
        moveSpeed = PlayerPrefs.GetFloat("MoveSpeed", moveSpeed);
    }

    void Update()
    {
        // Movimiento
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(moveX, 0, moveZ);
        rb.linearVelocity = new Vector3(move.x * moveSpeed, rb.linearVelocity.y, move.z * moveSpeed);

        // Salto
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }

        // Curva de dificultad progresiva
        timePassed += Time.deltaTime;
        if (timePassed >= difficultyTimer)
        {
            moveSpeed += speedIncrement;
            timePassed = 0f;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnApplicationQuit()
    {
        // Guardar velocidad cuando se cierra el juego
        PlayerPrefs.SetFloat("MoveSpeed", moveSpeed);
        PlayerPrefs.Save();
    }
}
