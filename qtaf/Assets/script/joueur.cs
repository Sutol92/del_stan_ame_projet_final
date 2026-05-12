using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joueur : MonoBehaviour
{
    public levier_global script_levier_global;
    public GameObject porte;
    public GameObject colision_barre;
    public GameObject colision_ouverte;
    public Animator porteAnimator;

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("porte_ferme"))
        {
            porteAnimator.Play("porte_locked");
        }
        else if (other.CompareTag("porte_ouverte"))
        {
            porteAnimator.Play("porte_ouverte");
        }
            

    }
}
