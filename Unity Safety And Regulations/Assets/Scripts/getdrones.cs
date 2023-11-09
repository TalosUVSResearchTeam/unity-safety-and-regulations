using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getdrones : MonoBehaviour
{

    public int number;
    public GameObject drone1, drone2, drone3, drone4;
    // Use this for initialization
    void Start()
    {
        number = PlayerPrefs.GetInt("index");
        Debug.Log(number);
        if (number == 0){
            drone1.SetActive(true);
            drone2.SetActive(false);
            drone3.SetActive(false);
            drone4.SetActive(false);
        }
        else if (number == 1){
            drone1.SetActive(false);
            drone2.SetActive(true);
            drone3.SetActive(false);
            drone4.SetActive(false);
        }
        else if (number == 2){
            drone1.SetActive(false);
            drone2.SetActive(false);
            drone3.SetActive(true);
            drone4.SetActive(false);
        }
        else{
            drone1.SetActive(false);
            drone2.SetActive(false);
            drone3.SetActive(false);
            drone4.SetActive(true);
        }
    }



    void Update()
    {
        
    }
}
