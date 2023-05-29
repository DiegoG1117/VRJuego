using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Libro : MonoBehaviour
{
    public string nombre;
    public bool esCorrecto = false;
    public bool estaColocado = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Mesa"))
        {
            MesaLibro mesa = other.GetComponent<MesaLibro>();
            if (mesa != null)
            {
                mesa.CheckLibro(this);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Mesa"))
        {
            MesaLibro mesa = other.GetComponent<MesaLibro>();
            if (mesa != null)
            {
                mesa.RemoveLibro(this);
            }
        }
    }
}

public class MesaLibro : MonoBehaviour
{
    private int librosCorrectos = 0;

    public void CheckLibro(Libro libro)
    {
        if (!libro.estaColocado)
        {
            if (libro.nombre == "Libro Inmersion" || libro.nombre == "Libro imaginacion" || libro.nombre == "Libro Interaccion")
            {
                libro.esCorrecto = true;
                libro.estaColocado = true;
                librosCorrectos++;

                if (librosCorrectos == 3)
                {
                    // Activar el evento "Cerebro" cuando se coloquen los 3 libros correctos
                    //EventManager.TriggerEvent("Cerebro");
                }
            }
            else if (libro.nombre == "Libro Infrastructura" || libro.nombre == "Libro integracion")
            {
                libro.estaColocado = true;
            }
        }
    }

    public void RemoveLibro(Libro libro)
    {
        if (libro.estaColocado)
        {
            libro.estaColocado = false;

            if (libro.esCorrecto)
            {
                libro.esCorrecto = false;
                librosCorrectos--;
            }
        }
    }
}
