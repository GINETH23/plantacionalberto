using UnityEngine;
using UnityEngine.SceneManagement;

public class SeguirObjeto : MonoBehaviour
{
    // Referencia al objeto que queremos seguir
    public Transform objetoAseguir;

    // Velocidad a la que el objeto seguirá al objetivo
    public float velocidad = 5f;

    void Update()
    {
        // Comprobamos si tenemos un objetivo al que seguir
        if (objetoAseguir != null)
        {
            // Calculamos la dirección hacia el objetivo
            Vector3 direccion = objetoAseguir.position - transform.position;

            // Normalizamos la dirección para evitar que el objeto se mueva más rápido cuando esté más cerca del objetivo
            direccion.Normalize();

            // Calculamos el movimiento basado en la dirección y la velocidad
            Vector3 movimiento = direccion * velocidad * Time.deltaTime;

            // Movemos el objeto hacia el objetivo
            transform.Translate(movimiento);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Verificamos si el objeto con el que colisionamos tiene la etiqueta "Player"
        if (collision.gameObject.CompareTag("Player"))
        {
            // Cambiar a la siguiente escena
            SceneManager.LoadScene("Perdiste");
        }
    }
}