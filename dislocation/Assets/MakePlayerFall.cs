using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePlayerFall : MonoBehaviour
{

    public GameObject uiText;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<Rigidbody>().freezeRotation = false;
            uiText.SetActive(true);
        }
    }
}
