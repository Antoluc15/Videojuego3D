using UnityEngine;

public class ObstacleMover : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        // Mover hacia atrás en Z (como si el jugador corriera hacia adelante)
        transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
    }
}
