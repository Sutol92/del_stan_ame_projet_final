using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class joueur : MonoBehaviour
{
    public GameObject collision_barre;
    public GameObject collision_ouverte;
    public Animator porteAnimator;


    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "porte_ferme")
        {
            
            porteAnimator.Play("porte locked");
            collision_barre.GetComponent<AudioSource>().Play();
            collision_ouverte.GetComponent<AudioSource>().Play();
        }
        else if (other.tag == "porte_ouverte")
        {
            porteAnimator.Play("porte ouverte");
        }
        
        if (other.tag == "collision_fin")
        {
            SceneManager.LoadScene(2);
        }

    }
}
