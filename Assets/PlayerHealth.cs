using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public float fallLimit = -10f;

    void Update()
    {
        if (transform.position.y < fallLimit)
        {
            // Reiniciar la escena si cae
            RestartGame();
        }
    }

    void RestartGame()
    {
        // Reinicia el juego cargando la misma escena
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

