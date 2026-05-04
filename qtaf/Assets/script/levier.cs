using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levier : MonoBehaviour
{
    public levier_global script_levier_global;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "levier_control")
        {
            if(other.name == "1")
            {
                script_levier_global.levier1 = true;
                script_levier_global.verification();
                Debug.Log("levier 1 ");
            }
            else if (other.name == "2")
            {
                script_levier_global.levier2 = true;
                script_levier_global.verification();
                Debug.Log("levier 2");
            }
            else if (other.name == "3")
            {
                script_levier_global.levier3 = true;
                script_levier_global.verification();
                Debug.Log("levier 3");
            }

            Debug.Log("tst");
        }
    }
}
