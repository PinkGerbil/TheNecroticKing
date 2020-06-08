using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ressurect : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        print("body found");
        CheckForDead(other.gameObject);
    }
    //private void OnCollisionEnter(Collision collision)
    //{
    //    
    //}

    private void CheckForDead(GameObject Body)
    {
        if (Body.GetComponent<DeathCheck>() != null)
        {
            print("death check exists");
            if (Body.GetComponent<DeathCheck>().GetDead() == true)
            {
                print("dead is true");
                if (Input.GetKeyDown(KeyCode.E))
                {
                    print("e pressed");
                    Body.GetComponent<DeathCheck>().MakeUndead();
                }
            }
        }
    }
}
