using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZonaCambio2 : MonoBehaviour
{

    public int numeroEscena;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "antorcha")
        {
            SceneManager.LoadScene(numeroEscena);
        }
    }
}
