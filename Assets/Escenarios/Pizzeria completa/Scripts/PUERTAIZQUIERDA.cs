using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUERTAIZQUIERDA : MonoBehaviour
{
    public GameObject PuertaIzquierda;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cerrarPuerta();
    }

    public void cerrarPuerta()
    {

        if (Input.GetKey(KeyCode.Z))
        {
            animator.SetBool("Cerrar", true);
        }
        if (Input.GetKey(KeyCode.X))
        {
            animator.SetBool("Cerrar", false);
        }

    }
}
