using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObelisco : MonoBehaviour
{
    public Texture2D acertijoLibrosTexture;

    private bool isPlayerInteracting = false;
    private bool isShowingImage = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInteracting = true;
            ShowImage();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInteracting = false;
            HideImage();
        }
    }

    private void ShowImage()
    {
        if (!isShowingImage)
        {
            // Ajustar la cámara para mostrar la imagen en pantalla completa
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
            Camera.main.backgroundColor = Color.black;

            // Crear un material para la imagen y asignarle la textura
            Material imageMaterial = new Material(Shader.Find("Unlit/Texture"));
            imageMaterial.mainTexture = acertijoLibrosTexture;

            // Aplicar el material a un objeto en pantalla completa
            GameObject imagePlane = GameObject.CreatePrimitive(PrimitiveType.Quad);
            imagePlane.transform.position = new Vector3(0f, 0f, 10f);
            imagePlane.transform.localScale = new Vector3(20f, 20f, 1f);
            imagePlane.GetComponent<Renderer>().material = imageMaterial;

            isShowingImage = true;
        }
    }

    private void HideImage()
    {
        if (isShowingImage)
        {
            // Restaurar la configuración de la cámara
            Camera.main.clearFlags = CameraClearFlags.Skybox;
            Camera.main.backgroundColor = Color.clear;

            // Destruir el objeto de la imagen
            GameObject imagePlane = GameObject.Find("ImagePlane");
            if (imagePlane != null)
            {
                Destroy(imagePlane);
            }

            isShowingImage = false;
        }
    }

    private void Update()
    {
        if (isPlayerInteracting && Input.GetKeyDown(KeyCode.E))
        {
            // Aquí puedes agregar la lógica para mostrar el acertijo o realizar otras acciones.
        }
    }
}
