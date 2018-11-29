using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WayPointManager : MonoBehaviour {

    public static WayPointManager Instance;
    public List<Path> Paths = new List<Path>();
    void Awake()
    {
        Instance = this;            
    }

    public Vector3 GetSpawnPosition(int pathIndex)
    {
        return Paths[pathIndex].WayPoints[0].position;
    }


    [System.Serializable]                                           // makes this available in the editor
    public class Path
    {
        public List<Transform> WayPoints = new List<Transform>();   // creates a dictionary
    }
    
}
