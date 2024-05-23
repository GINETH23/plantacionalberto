using UnityEngine;
using UnityEngine.UI;

public class TextoEn20 : MonoBehaviour
{
    public Text texto; // Referencia al texto que quieres desvanecer
    private float tiempoInicio;

    void Start()
    {
        tiempoInicio = Time.time; // Guardamos el tiempo de inicio del juego
    }

    void Update()
    {
        if (Time.time - tiempoInicio >= 15f) // Si han pasado 20 segundos
        {
            texto.color = new Color(texto.color.r, texto.color.g, texto.color.b, 0f); // Hacemos que el texto desaparezca estableciendo su alpha a 0
        }
    }
}