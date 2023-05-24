using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ContadorMuerte : MonoBehaviour
{
    public Canvas canvasToEnable;
    public TextMeshProUGUI contadorText;
    public float tiempoInicial = 10f;

    private float tiempoRestante;

    private void Start()
    {
        canvasToEnable.enabled = false;
        contadorText.text = tiempoInicial.ToString();
        tiempoRestante = tiempoInicial;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            canvasToEnable.enabled = true;
            InvokeRepeating("ActualizarContador", 1f, 1f);
        }
    }

    private void ActualizarContador()
    {
        tiempoRestante -= 1f;
        contadorText.text = tiempoRestante.ToString();

        if (tiempoRestante <= 0f)
        {
            CancelInvoke("ActualizarContador");
            SceneManager.LoadScene(0); // Carga la escena número 0
        }
    }
}
