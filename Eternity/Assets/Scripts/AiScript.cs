using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiScript : MonoBehaviour
{
    public NavMeshAgent agent;

    public float goalDistance = 40;
    private void Start()
    {
        Vector3 target = transform.position + Vector3.forward * goalDistance ;
        agent.SetDestination(target);
    }
}
