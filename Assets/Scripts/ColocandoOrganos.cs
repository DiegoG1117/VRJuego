using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColocandoOrganos : MonoBehaviour
{
    public Transform target;
    public Transform target2;
    public GameObject Cerebro;
    public GameObject Corazon;
    public GameObject Ojos;
    public GameObject Pulmon;
    public GameObject objectToDelete; 
    public string scriptNameToRemove;  // Nombre del script que se eliminará
    public GameObject objetoOculto;
    public Animator animator;
    public AudioSource audioSource;
    public GameObject PersonajeFinal;
    public bool organo1;
    public bool organo2;
    public bool organo3;
    public bool organo4;
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
            organo1 = true;
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

            organo2 = true;
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

            organo3 = true;
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
            organo4 = true;
    
        
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        organo1 = false;
         organo2 = false;
          organo3 = false;
           organo4 = false;
        objetoOculto.SetActive(false);
        animator.SetBool("estatua", false);
        audioSource.Stop();
    }

    // Update is called once per frame
    void Update()
    {
         
           if(organo1 == true && organo2 == true && organo3 == true && organo4 == true){

                objetoOculto.SetActive(true);
                animator.SetBool("Fase_Final", true);
                audioSource.Play();
                PersonajeFinal.transform.position = target2.position;
                PersonajeFinal.transform.rotation = target2.rotation;

        }
    }

}

    
