using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LibroImaginacion : MonoBehaviour
{
    public GameObject libroImagenObj;
    public GameObject libroDeImaginacionImage;
    public Transform libroImagenParent;

    private bool isInteracting = false;

    private void Update()
    {
        if (isInteracting && Input.GetKeyDown(KeyCode.F))
        {
            ToggleLibroDeImaginacionImage();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInteracting = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInteracting = false;
            CloseLibroDeImaginacionImage();
        }
    }

    private void ToggleLibroDeImaginacionImage()
    {
        libroDeImaginacionImage.SetActive(!libroDeImaginacionImage.activeSelf);

        if (libroDeImaginacionImage.activeSelf)
        {
            // Ajusta la posición y orientación de la imagen del libro en relación al objeto "Libro imaginacion"
            libroDeImaginacionImage.transform.SetParent(libroImagenParent);
            libroDeImaginacionImage.transform.localPosition = Vector3.zero;
            libroDeImaginacionImage.transform.localRotation = Quaternion.identity;

            // Desactiva el objeto "Libro imaginacion" mientras se muestra la imagen
            libroImagenObj.SetActive(false);
        }
        else
        {
            // Activa el objeto "Libro imaginacion" nuevamente
            libroImagenObj.SetActive(true);
        }
    }

    private void CloseLibroDeImaginacionImage()
    {
        if (libroDeImaginacionImage.activeSelf)
        {
            // Cierra la imagen del libro y activa el objeto "Libro imaginacion"
            ToggleLibroDeImaginacionImage();
        }
    }
}
