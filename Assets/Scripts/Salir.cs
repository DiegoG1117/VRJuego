using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salir : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "antorcha")
        {
            Application.Quit();
        }
    }

}
