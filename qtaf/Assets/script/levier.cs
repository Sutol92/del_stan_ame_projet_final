using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levier : MonoBehaviour
{
    public levier_global script_levier_global;
    public GameObject ampoule1_reussite;
    public GameObject ampoule2_reussite;
    public GameObject ampoule3_reussite;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "levier_control")
        {
            if(other.name == "1")
            {
                script_levier_global.levier1 = true;
                script_levier_global.verification();
                ampoule1_reussite.SetActive(true);
            }
            else if (other.name == "2")
            {
                script_levier_global.levier2 = true;
                script_levier_global.verification();
                ampoule2_reussite.SetActive(true);
            }
            else if (other.name == "3")
            {
                script_levier_global.levier3 = true;
                script_levier_global.verification();
                ampoule3_reussite.SetActive(true);
            }

            Debug.Log("tst");
        }
    }
}
