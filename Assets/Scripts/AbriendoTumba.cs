using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbriendoTumba : MonoBehaviour
{
    
    public Animator animator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
           animator.SetBool("Tumba", true);
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
