using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FollowArma : MonoBehaviour
{
    public Transform characterTransform;

    void Update()
    {
        if (characterTransform != null)
        {
            Vector3 targetPosition = characterTransform.position;


            transform.position = targetPosition;
        }
    }
}

