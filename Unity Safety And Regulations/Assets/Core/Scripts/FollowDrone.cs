using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowDrone : MonoBehaviour
{
    public GameObject drone, mapPoint;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        //dronePos = drone.transform;
        //mapPointPos= mapPoint.transform;
    }

    // Update is called once per frame
    void Update()
    {   
        transform.position = drone.transform.position + offset;
    }
}
