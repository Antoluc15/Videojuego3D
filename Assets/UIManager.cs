using UnityEngine;
using UnityEngine.UI; // Añade esta línea
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [Header("Menús")]
    public GameObject menuPrincipal;
    public GameObject menuOpciones;
    public GameObject menuPausa;

    [Header("Botones")]
    public Button botonJugar;
    public Button botonOpciones;
    public Button botonSalir;

    void Start()
    {
        // Asignar funciones a los botones
        botonJugar.onClick.AddListener(() => IniciarJuego());
        botonOpciones.onClick.AddListener(() => MostrarOpciones());
        botonSalir.onClick.AddListener(() => SalirJuego());

        // Mostrar menú principal al inicio
        MostrarMenuPrincipal();
    }

    public void IniciarJuego()
    {
        SceneManager.LoadScene("Nivel1");
    }

    public void MostrarOpciones()
    {
        menuPrincipal.SetActive(false);
        menuOpciones.SetActive(true);
    }

    public void MostrarMenuPrincipal()
    {
        menuPrincipal.SetActive(true);
        menuOpciones.SetActive(false);
    }

    public void SalirJuego()
    {
        Application.Quit();
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}