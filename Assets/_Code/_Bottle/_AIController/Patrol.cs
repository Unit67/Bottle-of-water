using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : IBottleAI
{
    EnemyStates enemy;

    public Patrol(EnemyStates enemy)
    {
        this.enemy = enemy;
    }

    public void OnTriggerEnter(Collider enemy)
    {
        
    }

    public void RunAway()
    {
        
    }

    public void UpdateActions()
    {
        throw new System.NotImplementedException();
    }

    void IBottleAI.Patrol()
    {
        
    }

    void IBottleAI.ToChase()
    {

    }

}
