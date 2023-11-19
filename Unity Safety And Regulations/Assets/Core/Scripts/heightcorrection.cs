using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heightcorrection : MonoBehaviour
{
   
    public GameObject trigger;
   
    void Start()
    {
        
    }


    void Update()
    {
        if (trigger.transform.position.y > 120.62)
        {
           trigger.transform.Translate(Vector3.down * 2 * Time.fixedDeltaTime );
        }
       
    }
}
