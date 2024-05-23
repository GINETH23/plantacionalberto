using UnityEngine;
using UnityEngine.UI;

public class CollectAndActivate : MonoBehaviour
{
    public GameObject objectToActivate; // Objeto a activar una vez que se recojan los objetos
    public int totalObjectsToCollect = 6; // Total de objetos que el jugador debe recolectar
    private int collectedObjects = 0; // Contador de objetos recolectados
    public Text scoreText; // Texto para mostrar la cantidad de puntos recolectados

    private static int totalScore = 0; // Variable estática para almacenar el puntaje total

    void Start()
    {
        UpdateScoreText();
    }

    // Método llamado cuando el jugador entra en contacto con un objeto recolectable
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            collectedObjects++; // Incrementa el contador de objetos recolectados
            totalScore++; // Aumenta el puntaje total
            UpdateScoreText(); // Actualiza el texto de los puntos

            // Verifica si se han recolectado todos los objetos
            if (totalScore == totalObjectsToCollect)
            {
                // Activa el objeto especificado una vez que se hayan recolectado todos los objetos
                if (objectToActivate != null)
                {
                    objectToActivate.SetActive(true);
                }
            }

            // Desactiva este objeto una vez que se recolecta
            gameObject.SetActive(false);
        }
    }

    // Método para actualizar el texto de los puntos
    void UpdateScoreText()
    {
        scoreText.text = "Plantas = " + totalScore.ToString() + "/" + totalObjectsToCollect.ToString();
    }
}