using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActivacionLaberinto : MonoBehaviour
{
    public GameObject ojosObject; // Referencia al objeto con el tag "ojos"

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bola")
        {
            ojosObject.SetActive(true); // Activa el objeto con el tag "ojos"
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