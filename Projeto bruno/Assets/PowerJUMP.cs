using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerJUMP : MonoBehaviour
{
    public GameObject Objeto;
    public GameObject collec;
    void OnTriggerEnter2D(Collider2D col)
    {
        Objeto.GetComponent<PlayerController>().forcaPulo = 12f;
        collec.SetActive(false);
    }

}
