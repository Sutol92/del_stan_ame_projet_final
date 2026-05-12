using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joueur : MonoBehaviour
{
    public GameObject colision_barre;
    public GameObject colision_ouverte;
    public Animator porteAnimator;

    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "porte_ferme")
        {
            porteAnimator.Play("porte_locked");
        }
        else if (other.tag == "porte_ouverte")
        {
            porteAnimator.Play("porte_ouverte");
        }
            

    }
}
