using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinPanel : MonoBehaviour
{
    public GameObject panelWin;
    
    void Update()
    {
        panelWin.SetActive(true);
    }
}
