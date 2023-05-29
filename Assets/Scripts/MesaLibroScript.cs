using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MesaLibroScript : MonoBehaviour
{
    public GameObject LibroInmersion;
    public GameObject libroInteraccion;
    public GameObject libroImaginacion;
    public GameObject Cerebro;
    public bool libro1;
    public bool libro2;
    public bool libro3;


       void Start()
    {
        Cerebro.SetActive(false);
        libro1 = false;
        libro2 = false;
        libro3 = false;
    }

      private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Imaginacion")
        {
            libroImaginacion.SetActive(false);
                libro1 = true;
        }
         if (other.tag == "Interaccion")
        {
            libroInteraccion.SetActive(false);
            libro2 = true;
            
        }
         if (other.tag == "Inmersion")
        {
            LibroInmersion.SetActive(false);
            libro3 = true;
          
        }

    }
    void Update()
    {
        if(libro1 == true && libro2 == true && libro3 == true){
                Cerebro.SetActive(true);
        }
    }



}
