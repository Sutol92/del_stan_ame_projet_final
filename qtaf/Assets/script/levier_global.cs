using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levier_global : MonoBehaviour
{
    public GameObject ampoule_3;
    public GameObject ampoule_piece;
    public GameObject colision_barre;
    public GameObject colision_ouverte;
    public GameObject collision_porte_gauche;
    public GameObject colliion_porte_droite;
    public bool levier1;
    public bool levier2;
    public bool levier3;
    public void verification()
    {
        if (levier1 == true && levier2 == true && levier3 == true) { 
          ampoule_3.SetActive(true);
          ampoule_piece.SetActive(true);
          colision_ouverte.SetActive(true);
          colision_barre.SetActive(false);
          colliion_porte_droite.SetActive(false);
          collision_porte_gauche.SetActive(false);

        }
    }
}
