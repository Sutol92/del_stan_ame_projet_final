using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class socle : MonoBehaviour
{
    public GameObject ampoule;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("socle_1"))
        {
            ampoule.SetActive(true);
        }


    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("socle_1"))
        {
            ampoule.SetActive(false);
        }
    }

    }
