using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BookInteraccionController : MonoBehaviour
{
    public GameObject libroInteraccion;
    public Image imagenLibro;

    private bool mostrarImagen;

    private void Start()
    {
        // Desactiva la imagen del libro al inicio
        libroInteraccion.SetActive(false);
        imagenLibro.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el jugador ha entrado en el colisionador del libro de interacción
        if (other.CompareTag("Player"))
        {
            // Activa la imagen del libro
            mostrarImagen = true;
            libroInteraccion.SetActive(true);
            imagenLibro.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Verifica si el jugador ha salido del colisionador del libro de interacción
        if (other.CompareTag("Player"))
        {
            // Desactiva la imagen del libro
            mostrarImagen = false;
            libroInteraccion.SetActive(false);
            imagenLibro.enabled = false;
        }
    }
}
