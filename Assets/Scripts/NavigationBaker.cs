//https://github.com/Unity-Technologies/NavMeshComponents.git#package
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavigationBaker : MonoBehaviour {

    public NavMeshSurface surface;

    int i=0;
    // Use this for initialization
    void Update () 
    {
        if(i==200){
            surface.BuildNavMesh (); 
        }    
        i++; 
    }

}