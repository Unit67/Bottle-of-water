using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBottleAI
{
    void UpdateActions();
    void Patrol();
    void RunAway();
    void OnTriggerEnter(Collider enemy);
    void ToChase();
}
