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
        if(number==0){ 
            q0.SetActive(true);
            q1.SetActive(false);
            q2.SetActive(false);
            q3.SetActive(false);
        }
        else if(number==1){ 
            q0.SetActive(false);
            q1.SetActive(true);
            q2.SetActive(false);
            q3.SetActive(false);
        }
        else if(number==2){ 
            q0.SetActive(false);
            q1.SetActive(false);
            q2.SetActive(true);
            q3.SetActive(false);
        }
        else if(number==3){ 
            q0.SetActive(false);
            q1.SetActive(false);
            q2.SetActive(false);
            q3.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
