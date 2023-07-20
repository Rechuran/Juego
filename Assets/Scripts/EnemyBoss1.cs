using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyBoss1 : MonoBehaviour
{
    [SerializeField] private float vida;
    [SerializeField] private GameManager gameManager;


    public void TomarDa�o(float da�o)
    {
        vida -= da�o;

        if (vida <= 0)
        {

            Destroy(gameObject);
          
            gameManager.cambioNivel();
        }
    }
}
