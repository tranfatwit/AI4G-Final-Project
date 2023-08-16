using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIController : MonoBehaviour
{
    public Transform goal;

    int i=0;

    // Update is called once per frame
    void Update()
    {
       if(i==200){
            NavMeshAgent agent = GetComponent<NavMeshAgent>();
            agent.destination = new Vector3(goal.position.x,goal.position.y,goal.position.z+5);
        }    
        i++; 
    }
}
