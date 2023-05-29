using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerBook : MonoBehaviour
{
    private GameObject currentBook;
    private Renderer bookRenderer;

    private void Update()
    {
        if (currentBook != null && !currentBook.GetComponent<Collider>().bounds.Intersects(GetComponent<Collider>().bounds))
        {
            HideBookImage();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Book"))
        {
            currentBook = other.gameObject;
            bookRenderer = currentBook.GetComponentInChildren<Renderer>();
            ShowBookImage();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Book"))
        {
            HideBookImage();
            currentBook = null;
            bookRenderer = null;
        }
    }

    private void ShowBookImage()
    {
        if (bookRenderer != null)
        {
            bookRenderer.enabled = true;
        }
    }

    private void HideBookImage()
    {
        if (bookRenderer != null)
        {
            bookRenderer.enabled = false;
        }
    }
}
