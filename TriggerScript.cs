using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlantWatering : MonoBehaviour
{
    public Text interactText;
    public Text scoreText;
    public Transform[] positions; // Lista de posiciones donde se mover� el trigger y la luz
    public Light plantLight;

    private int currentPositionIndex = 0;
    private int score = 0;
    private bool isInsideTrigger = false;

    void Start()
    {
        UpdateInteractText(false);
        UpdateScoreText();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInsideTrigger = true;
            UpdateInteractText(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInsideTrigger = false;
            UpdateInteractText(false);
        }
    }

    void Update()
    {
        if (isInsideTrigger && Input.GetKeyDown(KeyCode.E))
        {
            // Incrementa el puntaje
            score++;
            UpdateScoreText();

            // Mueve el trigger y la luz a la siguiente posici�n
            currentPositionIndex = (currentPositionIndex + 1) % positions.Length;
            transform.position = positions[currentPositionIndex].position;
            plantLight.transform.position = positions[currentPositionIndex].position;

            // Verifica si se han completado 15 puntos y cambia de escena si es as�
            if (score >= 15)
            {
                SceneManager.LoadScene("Ganaste"); // Reemplaza "NombreDeTuEscena" por el nombre de la escena a cargar
            }
        }
    }

    void UpdateInteractText(bool isActive)
    {
        interactText.gameObject.SetActive(isActive);
        interactText.text = "Presiona la tecla E para regar la planta";
    }

    void UpdateScoreText()
    {
        scoreText.text = "Regadas: " + score.ToString();
    }
}