using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStates : MonoBehaviour
{
    [HideInInspector]
    public AlertState alertState;
    [HideInInspector]
    public Patrol patrol;
    [HideInInspector]
    public RunAway runAway;
    [HideInInspector]
    public IBottleAI currentState;

    private void Awake()
    {
        alertState = new AlertState(this);
        patrol = new Patrol(this);
        runAway = new RunAway(this);
    }

    private void Start()
    {
        currentState = patrol;
    }

    private void Update()
    {
        currentState.UpdateActions();
    }

    private void OnTriggerEnter(Collider other)
    {
        currentState.OnTriggerEnter(other);
    }
}
