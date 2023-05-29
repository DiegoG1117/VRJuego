using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookInmersionController : MonoBehaviour
{
    public GameObject plano;

    private bool jugadorInteractuando;
    private Vector3 planoScale;

    private void Start()
    {
        planoScale = plano.transform.localScale;
        OcultarPlano();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            jugadorInteractuando = true;
            MostrarPlano();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            jugadorInteractuando = false;
            OcultarPlano();
        }
    }

    private void MostrarPlano()
    {
        // Escala el plano para que sea visible
        plano.transform.localScale = planoScale;
    }

    private void OcultarPlano()
    {
        // Escala el plano para que sea invisible
        plano.transform.localScale = Vector3.zero;
    }

    private void Update()
    {
        if (jugadorInteractuando && Input.GetKeyDown(KeyCode.E))
        {
            // Realiza la acción deseada cuando el jugador interactúa con el objeto
            Debug.Log("El jugador interactuó con el objeto.");
        }
    }
}