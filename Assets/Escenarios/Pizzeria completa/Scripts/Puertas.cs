using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puertas : MonoBehaviour
{
    public GameObject puertaDerecha;
    public Animator animator;
    public AudioSource abrir;
    public AudioSource cerrar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cerrarouertas();
    }
    public void cerrarouertas()
    {
           
        if (Input.GetKey(KeyCode.K))
        {
           animator.SetBool("cerrar", true);
            cerrar.Play();
        }
        if (Input.GetKey(KeyCode.L))
        {
            animator.SetBool("cerrar", false);
            abrir.Play();
        }
        

    }
}
