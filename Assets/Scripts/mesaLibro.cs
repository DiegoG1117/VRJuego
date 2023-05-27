using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MesaLibro : MonoBehaviour
{
    public int contadorLibrosCorrectos = 0;
    public int cantidadLibrosCorrectosNecesarios = 3;
    public UnityEvent eventoLibrosCorrectosColocados;

    // Método llamado por los libros para indicar que un libro correcto fue colocado
    public void LibroCorrectoColocado()
    {
        contadorLibrosCorrectos++;

        // Verificar si se han colocado todos los libros correctos
        if (contadorLibrosCorrectos == cantidadLibrosCorrectosNecesarios)
        {
            eventoLibrosCorrectosColocados.Invoke();
        }
    }

    // Método llamado por los libros para indicar que un libro incorrecto fue colocado
    public void LibroIncorrectoColocado()
    {
        // Implementa aquí el evento o acción que deseas cuando se coloque un libro incorrecto
    }
}
