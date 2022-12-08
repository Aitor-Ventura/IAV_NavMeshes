using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIControl : MonoBehaviour
{
    public NavMeshAgent agent;
    private Animator animator;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();

        float scale = Random.Range(0.25f, 0.75f);
        transform.localScale = Vector3.one * scale;
        agent.height = scale;
        
        agent.speed = 5f * (1 - scale);
        agent.angularSpeed = 200 * (1 - scale);
        agent.acceleration = 5f * (1 - scale);
        animator.speed *= (1 - scale);
    }

    
}
