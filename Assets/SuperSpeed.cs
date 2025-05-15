using UnityEngine;

public class SuperSpeed : MonoBehaviour
{
    public GameObject speedEffect;
    public float superSpeedForce = 500f;
    public int minBounceCount = 3;

    private Rigidbody rb;
    private int bounceCount = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        speedEffect.SetActive(false);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Plataforma"))
        {
            if (bounceCount >= minBounceCount)
            {
                ActivarSuperVelocidad();
            }
            else
            {
                bounceCount = 0; // se reinicia si toca
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CaidaLibre")) // una zona sin plataformas
        {
            bounceCount++;
        }
    }

    void ActivarSuperVelocidad()
    {
        rb.AddForce(Vector3.down * superSpeedForce);
        speedEffect.SetActive(true);
        Invoke("DesactivarEfecto", 1.5f);
        bounceCount = 0;
    }

    void DesactivarEfecto()
    {
        speedEffect.SetActive(false);
    }
}
