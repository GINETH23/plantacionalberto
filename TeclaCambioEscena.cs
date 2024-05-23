using UnityEngine;
using UnityEngine.SceneManagement;

public class TeclaCambioEscena : MonoBehaviour
{
    public KeyCode teclaCambio; // Tecla que activará el cambio de escena
    [SerializeField] private string nombreEscena; // Nombre de la escena a la que queremos cambiar

    public string NombreEscena
    {
        get { return nombreEscena; }
        set { nombreEscena = value; }
    }

    void Update()
    {
        // Verificar si se ha presionado la tecla para cambiar de escena
        if (Input.GetKeyDown(teclaCambio))
        {
            // Cambiar a la escena especificada por nombre
            SceneManager.LoadScene(nombreEscena);
        }
    }
}
