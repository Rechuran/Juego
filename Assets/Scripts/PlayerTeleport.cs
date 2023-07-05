using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{

    private GameObject currentTeleporter;
    // Start is called before the first frame update

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (currentTeleporter != null)
            {
                transform.position = currentTeleporter.GetComponent<Teleporter>().GetDestination().position;
            }
        }
    }
    public void OnTriggerEnter2D(Collider2D colission)
    {
        if (colission.CompareTag("Teleporter"))
        {
            currentTeleporter = colission.gameObject;
        }
    }

    public void OnTriggerExit2D(Collider2D colission)
    {
        if (colission.CompareTag("Teleporter"))
        {
            if (colission.gameObject == currentTeleporter)
            {
                currentTeleporter = null;
            }
        }
    }

    // Update is called once per frame

}
