using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mision2luces : MonoBehaviour
{
    public GameObject luz1;
    public GameObject luz2;
    public GameObject luz3;
    public GameObject luz4;
    public GameObject luz5;
    public GameObject luz6;
    public GameObject luz7;
    public GameObject luz8;
    public GameObject luz9;
    public GameObject luz10;
    public GameObject luz11;
    public GameObject luz12;
    public GameObject luz13;
    public GameObject luz14;
    public GameObject luz15;
    public GameObject luz16;

    private void OnTriggerEnter (Collider other)
    {
        if (other.transform.name == "area1")
        {
            luz1.SetActive(false);
        }
    }
}
