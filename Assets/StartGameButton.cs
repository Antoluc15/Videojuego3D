using UnityEngine;

public class StartGameButton : MonoBehaviour
{
    public GameObject CAPSUGAME;
    public GameObject player;

    public void StartGame()
    {
        CAPSUGAME.SetActive(false);    // Oculta el menú
        player.SetActive(true);     // Activa al jugador u otros objetos del juego
        Time.timeScale = 1;         // Reanuda el tiempo si estaba en pausa
    }
}

