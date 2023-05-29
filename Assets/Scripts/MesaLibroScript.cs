using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MesaLibroScript : MonoBehaviour
{
    public GameObject LibroInmersion;
    public GameObject libroInteraccion;
    public GameObject libroImaginacion;
    public GameObject Cerebro;
    public int ContadorLibros;


       void Start()
    {
        Cerebro.SetActive(false);
        ContadorLibros = 0;
    }

      private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Imaginacion")
        {
            libroImaginacion.SetActive(false);
            ContadorLibros = ContadorLibros + 1;
        }
         if (other.tag == "Interaccion")
        {
            libroInteraccion.SetActive(false);
            ContadorLibros = ContadorLibros + 1;
        }
         if (other.tag == "Inmersion")
        {
            LibroInmersion.SetActive(false);
            ContadorLibros = ContadorLibros + 1;
        }

    }
    void Update()
    {
        if(ContadorLibros == 3){
                Cerebro.SetActive(true);
        }
    }



}
