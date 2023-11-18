using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MeterCounterScript : MonoBehaviour
{
    //text
    public TMP_Text  meterText;

    //drone height
    public GameObject drone;
    float height;

    // Update is called once per frame
    void Update()
    {
       //change the text 
       height = drone.transform.position.y;
       meterText.SetText(height.ToString("F2") + " meters");
    }
}
