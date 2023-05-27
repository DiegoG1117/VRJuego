using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class Libro : MonoBehaviour
{
    public bool esCorrecto = false;
    public MesaLibro mesaLibro;
    public string nombreLibro = Imaginacion;

    // Método llamado cuando el jugador interactúa con el libro
    public void Agarrar()
    {
        // Desactivar la física del libro para que pueda ser manipulado
        GetComponent<Rigidbody>().isKinematic = true;

        // Desactivar el collider para evitar interacciones no deseadas
        GetComponent<Collider>().enabled = false;

        // Mostrar mensaje con el nombre del libro
        Debug.Log("Has agarrado el libro: " + nombreLibro);
    }

    // Método llamado cuando el jugador suelta el libro
    public void Soltar()
    {
        // Activar la física del libro para que vuelva a tener interacción con el entorno
        GetComponent<Rigidbody>().isKinematic = false;

        // Activar el collider para que vuelva a interactuar con otros objetos
        GetComponent<Collider>().enabled = true;

        // Verificar si el libro es el correcto y notificar a la mesa
        if (esCorrecto)
        {
            mesaLibro.LibroCorrectoColocado(true);
        }
        else
        {
            mesaLibro.LibroIncorrectoColocado();
        }
    }
}
