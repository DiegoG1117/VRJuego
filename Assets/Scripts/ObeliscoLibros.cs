using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObeliscoLibros : MonoBehaviour
{
    public GameObject acertijoLibrosImage;
    private bool isInteracting = false;

    private void Update()
    {
        // Detectar la interacción del usuario con el objeto
        if (isInteracting && !Input.GetMouseButton(0))
        {
            // Si el usuario deja de interactuar, cerrar la imagen del acertijo
            CloseAcertijoLibrosImage();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Detectar cuando el jugador interactúa con el objeto
        if (other.CompareTag("Player"))
        {
            isInteracting = true;
            ShowAcertijoLibrosImage();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Detectar cuando el jugador deja de interactuar con el objeto
        if (other.CompareTag("Player"))
        {
            isInteracting = false;
            CloseAcertijoLibrosImage();
        }
    }

    private void ShowAcertijoLibrosImage()
    {
        // Activar la imagen del acertijo
        acertijoLibrosImage.SetActive(true);
    }

    private void CloseAcertijoLibrosImage()
    {
        // Desactivar la imagen del acertijo
        acertijoLibrosImage.SetActive(false);
    }
}
