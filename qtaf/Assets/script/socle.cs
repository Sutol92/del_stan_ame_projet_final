using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class socle : MonoBehaviour
{
    public GameObject ampoule;
    public GameObject ampoule_2;
    public GameObject reussite_ampoule;
    public GameObject colision_barre;
    public GameObject colision_ouverte;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("socle_1"))
        {
            ampoule.SetActive(true);
        }
        else if (other.CompareTag("socle_2"))
        {
            ampoule_2.SetActive(true);
            reussite_ampoule.SetActive(true);
        }
        

    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("socle_1"))
        {
            ampoule.SetActive(false);
        }
        else if (other.CompareTag("socle_2"))
        {
            ampoule_2.SetActive(false);
        }
    }

    }
