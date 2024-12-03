using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teletransportarse : MonoBehaviour
{
    public Transform Destino;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<CharacterController>().enabled = false;
            other.transform.position = Destino.position;
            other.GetComponent<CharacterController>().enabled = true;
        }
    }
}
