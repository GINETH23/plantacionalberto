using UnityEngine;
using UnityEngine.UI;

public class TriggerTexto : MonoBehaviour
{
    public GameObject textoUI; // Referencia al objeto de texto a mostrar

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Verifica si el personaje entra en el trigger
        {
            textoUI.SetActive(true); // Activa el texto
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) // Verifica si el personaje sale del trigger
        {
            textoUI.SetActive(false); // Desactiva el texto
        }
    }
}