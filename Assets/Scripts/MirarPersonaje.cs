using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirarPersonaje : MonoBehaviour
{
    public GameObject player;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Vector3 playerPos = player.transform.position;
        Vector3 enemyPos = transform.position;

        if (playerPos.x < enemyPos.x)
        {
            
            spriteRenderer.flipX = false;
        }
        else if (playerPos.x > enemyPos.x)
        {
            
            spriteRenderer.flipX = true;
        }
    }
}

