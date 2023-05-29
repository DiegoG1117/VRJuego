using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObelisco : MonoBehaviour
{
    public GameObject infraestructuraObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            infraestructuraObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            infraestructuraObject.SetActive(false);
        }
    }
}