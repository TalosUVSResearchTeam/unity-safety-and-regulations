using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitHeight : MonoBehaviour
{
    public GameObject trigger;
    public GameObject text;
    void Start()
    {
        text.SetActive(false);
    }
   

    void Update()
    {
    if(trigger.transform.position.y > 116.62)
        {
            text.SetActive(true);
        }
        else
        {
            text.SetActive(false);
        }
    }
  
}
