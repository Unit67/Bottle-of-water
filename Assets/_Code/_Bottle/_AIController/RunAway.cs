using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunAway : IBottleAI
{
    EnemyStates enemy;

    public RunAway(EnemyStates enemy)
    {
        this.enemy = enemy;
    }

    public void OnTriggerEnter(Collider enemy)
    {
        
    }

    public void Patrol()
    {
        
    }

    public void ToChase()
    {
        
    }

    public void UpdateActions()
    {
        throw new System.NotImplementedException();
    }

    void IBottleAI.RunAway()
    {
        
    }
}
