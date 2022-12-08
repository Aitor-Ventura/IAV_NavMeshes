using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentManager : MonoBehaviour
{
    private Transform playerController;
    GameObject[] agents;
    
    private void Start()
    {
        agents = GameObject.FindGameObjectsWithTag("ai");
        playerController = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        foreach (GameObject a in agents){
            a.GetComponent<AIControl>().agent.SetDestination(playerController.position);
        }
    }
}
