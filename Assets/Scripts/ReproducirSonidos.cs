using UnityEngine;

public class ReproducirSonidos : MonoBehaviour
{
    public AudioSource audioSource;  // Referencia al componente AudioSource del objeto vacío
    public GameObject objectToDelete;

    private void Start()
    {
       audioSource.Stop();
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
            Collider collider = GetComponent<Collider>();
        if (collider != null)
        {
            collider.enabled = false;
        }
        }
    }
}
