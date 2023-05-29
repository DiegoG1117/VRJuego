using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookImaginacionController : MonoBehaviour
{
    public Texture imaginacionTexture;
    private Renderer bookRenderer;

    private void Start()
    {
        bookRenderer = GetComponentInChildren<Renderer>();

        if (bookRenderer != null)
        {
            bookRenderer.enabled = true; // Inicialmente oculto
        }
    }
}

