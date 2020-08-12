using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlertState : IBottleAI
{
    EnemyStates enemy;

    public AlertState(EnemyStates enemy)
    {
        this.enemy = enemy; 
    }

    public void OnTriggerEnter(Collider enemy)
    {
        
    }

    public void Patrol()
    {
        
    }

    public void RunAway()
    {

    }

    public void ToChase()
    {
        
    }

    public void UpdateActions()
    {
        throw new System.NotImplementedException();
    }
}
