using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColocandoOrganos : MonoBehaviour
{
    public Transform target;
    public GameObject objectToSet;
    public GameObject objectToDelete; 
    public string scriptNameToRemove;  // Nombre del script que se eliminará


      private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Corazon")
        {
            if (target != null)
        {
            // Igualar la posición y rotación del objeto actual al objeto de destino
            objectToSet.transform.position = target.position;
            objectToSet.transform.rotation = target.rotation;
        }

        }
        if (other.tag == "Pulmon")
        {
            if (target != null)
        {
            // Igualar la posición y rotación del objeto actual al objeto de destino
              objectToSet.transform.position = target.position;
            objectToSet.transform.rotation = target.rotation;
        }
        
        }
        if (other.tag == "Ojos")
        {
            if (target != null)
        {
            // Igualar la posición y rotación del objeto actual al objeto de destino
          objectToSet.transform.position = target.position;
            objectToSet.transform.rotation = target.rotation;
        }
        
        }
        if (other.tag == "Cerebro")
        {
            
            // Igualar la posición y rotación del objeto actual al objeto de destino
            objectToSet.transform.position = target.position;
            objectToSet.transform.rotation = target.rotation;
            Destroy(objectToDelete);
            Rigidbody rb = objectToSet.GetComponent<Rigidbody>();
            if (rb != null)
            {
                Destroy(rb);
            }
            MonoBehaviour scriptToRemove = objectToSet.GetComponent(scriptNameToRemove) as MonoBehaviour;
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
