using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName =("PowerUpEffects / SpeedUp"))]
public class SpeedUp : PowerUpEffects
{
    public float amount;
    public override void Apply(GameObject target)
    {
        target.GetComponent<PlayerController>().velocidade += amount;
    }
}