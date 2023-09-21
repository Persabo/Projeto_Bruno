using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSlightMove : MonoBehaviour
{
    public float speed = 2f;
    public float height = 0.05f;
    public float startY = 3.25f;

    public PowerUpEffects powerUpEffect;

    void Update()
    {
        var pos = transform.position;
        var newY = startY + height * Mathf.Sin(Time.time * speed);
        transform.position = new Vector2(pos.x, newY);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
            powerUpEffect.Apply(collision.gameObject);
        }
    }

}

