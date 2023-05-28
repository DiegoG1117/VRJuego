using UnityEngine;

public class ReproducirPistas : MonoBehaviour
{
    public AudioSource audioSource;  // Referencia al componente AudioSource del objeto vacío
    public GameObject objectToDelete;
    public string selectedTag;
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
        if (other.CompareTag(selectedTag))
        {
            PlaySound();
            Destroy(objectToDelete);
        }
    }
}
