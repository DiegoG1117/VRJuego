using UnityEngine;

public class BookInfraestructuraController : MonoBehaviour
{
    public GameObject infraestructuraObject;

       void Start()
    {
        infraestructuraObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            infraestructuraObject.SetActive(true);
        }
    }
}
