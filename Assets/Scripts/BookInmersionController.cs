using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookInmersionController : MonoBehaviour
{
    public Texture inmersionTexture;
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
