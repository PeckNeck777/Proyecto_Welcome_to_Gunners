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
        if (other.transform.name == "area2")
        {
            luz2.SetActive(false);
        }
        if (other.transform.name == "area3")
        {
            luz3.SetActive(false);
        }
        if (other.transform.name == "area4")
        {
            luz4.SetActive(false);
        }
        if (other.transform.name == "area5")
        {
            luz5.SetActive(false);
        }
        if (other.transform.name == "area6")
        {
            luz6.SetActive(false);
        }
        if (other.transform.name == "area7")
        {
            luz7.SetActive(false);
        }
        if (other.transform.name == "area8")
        {
            luz8.SetActive(false);
        }
        if (other.transform.name == "area9")
        {
            luz9.SetActive(false);
        }
        if (other.transform.name == "area10")
        {
            luz10.SetActive(false);
        }
        if (other.transform.name == "area11")
        {
            luz11.SetActive(false);
        }
        if (other.transform.name == "area12")
        {
            luz12.SetActive(false);
        }
        if (other.transform.name == "area13")
        {
            luz13.SetActive(false);
        }
        if (other.transform.name == "area14")
        {
            luz14.SetActive(false);
        }
        if (other.transform.name == "area15")
        {
            luz15.SetActive(false);
        }
        if (other.transform.name == "area16")
        {
            luz16.SetActive(false);
        }
    }
}
