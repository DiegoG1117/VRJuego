using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookInfraestructuraController : MonoBehaviour
{
    public Texture infraestructuraTexture;
    private Renderer bookRenderer;

    private void Start()
    {
        bookRenderer = GetComponentInChildren<Renderer>();

        if (bookRenderer != null)
        {
            bookRenderer.enabled = false; // Inicialmente oculto
        }
    }
}