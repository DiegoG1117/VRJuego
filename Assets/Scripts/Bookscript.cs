using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookInfraestructuraController : MonoBehaviour
{
     void Start()
    {
        infraestructuraObject.SetActive(false);
    }
    public GameObject infraestructuraObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            infraestructuraObject.SetActive(true);
        }

        else
        {
            infraestructuraObject.SetActive(false);
        }
        
    }

}