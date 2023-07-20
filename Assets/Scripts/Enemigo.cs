using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using Unity.VisualScripting;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] private float vida;
    public GameManager gameManager;
    public void TomarDa�o(float da�o)
    {
        vida -= da�o;

        if (vida <= 0) 
        {

            gameManager.ActivarBoss();
            Destroy(gameObject);
        }
    }
}

