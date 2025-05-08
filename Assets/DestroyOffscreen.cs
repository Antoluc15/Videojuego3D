using UnityEngine;

public class DestroyOffscreen : MonoBehaviour
{
    public float destroyZ = -20f;

    void Update()
    {
        if (transform.position.z < destroyZ)
        {
            Destroy(gameObject);
        }
    }
}
