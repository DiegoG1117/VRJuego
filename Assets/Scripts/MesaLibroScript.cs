using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MesaLibroScript : MonoBehaviour
{
    public GameObject LibroInmersion;
    public GameObject libroInteraccion;
    public GameObject libroImaginacion;
    public GameObject Cerebro;

    private bool correctPlacement = false;

    private void Update()
    {
        // Verificar si los tres libros correctos están en la mesa
        if (LibroInmersion.activeSelf && libroInteraccion.activeSelf && libroImaginacion.activeSelf)
        {
            correctPlacement = true;
            // Aquí puedes realizar cualquier acción o evento cuando los libros correctos estén en la mesa
            // Por ejemplo, puedes llamar a una función para activar un evento o mostrar un mensaje de éxito
            RealizarEvento();
        }
        else
        {
            correctPlacement = false;
        }
    }

    private void RealizarEvento()
    {
        // Implementa aquí la lógica del evento que deseas que suceda cuando los tres libros están en la mesa
        Debug.Log("¡Se han colocado los tres libros correctos en la mesa!");
        Cerebro.SetActive(true);
    }
}
