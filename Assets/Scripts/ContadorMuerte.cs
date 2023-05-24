using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorMuerte : MonoBehaviour
{
  public Canvas canvasToEnable; 

    // Start is called before the first frame update
    void Start()
    {
        
    }
      private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            canvasToEnable.enabled = true;
        }


    }
    
}
