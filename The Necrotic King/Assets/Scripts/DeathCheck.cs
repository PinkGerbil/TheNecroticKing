using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DeathCheck : MonoBehaviour
{
    public bool Dead;
    public bool Alive; //work on later
    public bool Undead;

    public Material deadShow;
    public Material aliveShow;
    public Material undeadShow;

    public void HasDied()
    {
        Dead = true;
    }

    public void MakeUndead()
    {
        Dead = false;
        Alive = false;
        Undead = true;
    }

    public bool GetDead()
    {
        return Dead;
    }

    public void Update()
    {
        if(Dead == true)
        {
            this.gameObject.GetComponent<Renderer>().material = deadShow;
        }
        if (Alive == true)
        {
            this.gameObject.GetComponent<Renderer>().material = aliveShow;
        }
        if(Undead == true)
        {
            this.gameObject.GetComponent<Renderer>().material = undeadShow;
        }

        //work on later
        //get to seek to player and if player in combat attack who they are in combat with
    }
}