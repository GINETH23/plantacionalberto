using UnityEngine;

public class SalirDelJuego : MonoBehaviour
{
    public KeyCode teclaSalir; // Tecla que activará la salida del juego

    void Update()
    {
        // Verificar si se ha presionado la tecla para salir del juego
        if (Input.GetKeyDown(teclaSalir))
        {
#if UNITY_EDITOR
            // En el Editor de Unity, detener la reproducción
            UnityEditor.EditorApplication.isPlaying = false;
#else
            // En una compilación, salir de la aplicación
            Application.Quit();
#endif
        }
    }
}
