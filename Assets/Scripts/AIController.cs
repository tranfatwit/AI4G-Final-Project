using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIController : MonoBehaviour
{
    public Transform goal;

    void Start() {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = new Vector3(goal.position.x,goal.position.y,goal.position.z+5);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
