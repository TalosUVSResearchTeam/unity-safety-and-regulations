using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowQuestion : MonoBehaviour
{
    public int number;
    public GameObject q0, q1, q2, q3;
    // Start is called before the first frame update
    void Start()
    {
        number = PlayerPrefs.GetInt("index");
        if(number==0) q0.SetActive(true);
        else if(number==1) q1.SetActive(true);
        else if(number==2) q2.SetActive(true);
        else if(number==3) q3.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
