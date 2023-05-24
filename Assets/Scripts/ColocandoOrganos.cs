using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColocandoOrganos : MonoBehaviour
{
    public Transform target;
    public GameObject Cerebro;
    public GameObject Corazon;
    public GameObject Ojos;
    public GameObject Pulmon;
    public GameObject objectToDelete; 
    public string scriptNameToRemove;  // Nombre del script que se eliminará


      private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Corazon")
        {
            if (target != null)
        {
            // Igualar la posición y rotación del objeto actual al objeto de destino
            Corazon.transform.position = target.position;
            Corazon.transform.rotation = target.rotation;
            Destroy(objectToDelete);
            Rigidbody rb = Corazon.GetComponent<Rigidbody>();
            if (rb != null)
            {
                Destroy(rb);
            }
            MonoBehaviour scriptToRemove = Corazon.GetComponent(scriptNameToRemove) as MonoBehaviour;
            if (scriptToRemove != null)
            {
                Destroy(scriptToRemove);
            }
    
        }

        }
        if (other.tag == "Pulmon")
        {
            if (target != null)
        {
            // Igualar la posición y rotación del objeto actual al objeto de destino
              Pulmon.transform.position = target.position;
            Pulmon.transform.rotation = target.rotation;
            Destroy(objectToDelete);
            Rigidbody rb = Pulmon.GetComponent<Rigidbody>();
            if (rb != null)
            {
                Destroy(rb);
            }
            MonoBehaviour scriptToRemove = Pulmon.GetComponent(scriptNameToRemove) as MonoBehaviour;
            if (scriptToRemove != null)
            {
                Destroy(scriptToRemove);
            }
        }
        
        }
        if (other.tag == "Ojos")
        {
            if (target != null)
        {
            // Igualar la posición y rotación del objeto actual al objeto de destino
          Ojos.transform.position = target.position;
            Ojos.transform.rotation = target.rotation;
             Destroy(objectToDelete);
            Rigidbody rb = Ojos.GetComponent<Rigidbody>();
            if (rb != null)
            {
                Destroy(rb);
            }
            MonoBehaviour scriptToRemove = Ojos.GetComponent(scriptNameToRemove) as MonoBehaviour;
            if (scriptToRemove != null)
            {
                Destroy(scriptToRemove);
            }
        }
        
        }
        if (other.tag == "Cerebro" && other.name == "Cerebro")
        {
            
            // Igualar la posición y rotación del objeto actual al objeto de destino
            Cerebro.transform.position = target.position;
            Cerebro.transform.rotation = target.rotation;
            Destroy(objectToDelete);
            Rigidbody rb = Cerebro.GetComponent<Rigidbody>();
            if (rb != null)
            {
                Destroy(rb);
            }
            MonoBehaviour scriptToRemove = Cerebro.GetComponent(scriptNameToRemove) as MonoBehaviour;
            if (scriptToRemove != null)
            {
                Destroy(scriptToRemove);
            }
    
        
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
