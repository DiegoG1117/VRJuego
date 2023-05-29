using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccionadorDomino : MonoBehaviour
{

    public Animator animator;
    public AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Domino")
        {
           animator.SetBool("estatua", true);
           audioSource.Play();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        audioSource.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
