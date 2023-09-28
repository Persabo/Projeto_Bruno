using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUP : MonoBehaviour
{
    public GameObject Objeto;
    public GameObject collec;
    void OnTriggerEnter2D(Collider2D col)
    {
        Objeto.GetComponent<PlayerController>().velocidade = 9.5f;
        collec.SetActive(false);
    }

}