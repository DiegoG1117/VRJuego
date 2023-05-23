using UnityEngine;

public class ReproducirSonidos : MonoBehaviour
{
    public AudioSource audioSource;  // Referencia al componente AudioSource del objeto vacío
    public GameObject objectToDelete;

    private void Start()
    {
        // Reproducir el sonido una vez al iniciar el juego
        PlaySound();
    }

    private void PlaySound()
    {
        // Verificar si el AudioSource y el clip de sonido están configurados
        if (audioSource != null && audioSource.clip != null)
        {
            // Reproducir el sonido
            audioSource.Play();
        }
    }

    // Ejemplo de cómo reproducir el sonido en respuesta a un evento
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlaySound();
            Destroy(objectToDelete);
        }
    }
}
