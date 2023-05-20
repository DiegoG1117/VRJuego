using UnityEngine;

public class ExitOnTouch : MonoBehaviour
{
    // Cambia este valor en el inspector si es necesario
    public string interactableTag = "Interactable";

    private bool canExit = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(interactableTag))
        {
            canExit = true;
        }
    }

    private void Update()
    {
        // Verifica si se toca un objeto interactable y si se está tocando con las manos
        if (canExit && OVRInput.Get(OVRInput.Button.PrimaryHandTrigger) && OVRInput.Get(OVRInput.Button.SecondaryHandTrigger))
        {
            // Salir de la aplicación
            Application.Quit();
        }
    }
}
