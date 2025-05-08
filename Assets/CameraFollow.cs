using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // El jugador
    public Vector3 offset = new Vector3(0f, 5f, -10f); // Posición relativa
    public float smoothSpeed = 0.125f; // Suavidad del seguimiento

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        transform.LookAt(target); // Opcional: la cámara siempre mira al jugador
    }
}
