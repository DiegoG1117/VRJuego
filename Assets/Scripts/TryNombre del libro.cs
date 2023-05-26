using System.Collections;
using System.Collections.Generic;
using UnityEngine;

pusing UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    private bool isInteractable = false;

    private void OnMouseDown()
    {
        if (isInteractable)
        {
            ShowPopup("Libro de interacción");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInteractable = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInteractable = false;
        }
    }

    private void ShowPopup(string message)
    {
        // Crea una ventana emergente con el mensaje
        Debug.Log("Mensaje emergente: " + message);
        // Puedes utilizar aquí una interfaz gráfica personalizada o mostrar el mensaje en una ventana emergente estándar.
    }
}

