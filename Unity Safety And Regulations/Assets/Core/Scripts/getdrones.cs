using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getdrones : MonoBehaviour
{

    public int number;
    public GameObject drone1, drone2, drone3, drone4;
    public GameObject cameraDrone1, cameraDrone2, cameraDrone3, cameraDrone4;
    public GameObject cm1, cm2, cm3, cm4;
    public GameObject meterCount1, meterCount2, meterCount3, meterCount4;
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
            
            cm1.SetActive(true);
            cm2.SetActive(false);
            cm3.SetActive(false);
            cm4.SetActive(false);

            meterCount1.SetActive(true);
            meterCount2.SetActive(false);
            meterCount3.SetActive(false);
            meterCount4.SetActive(false);

            cameraDrone1.SetActive(true);
            cameraDrone2.SetActive(false);
            cameraDrone3.SetActive(false);
            cameraDrone4.SetActive(false);
            
        }
        else if (number == 1){
            drone1.SetActive(false);
            drone2.SetActive(true);
            drone3.SetActive(false);
            drone4.SetActive(false);
            
            cm1.SetActive(false);
            cm2.SetActive(true);
            cm3.SetActive(false);
            cm4.SetActive(false);

            meterCount1.SetActive(false);
            meterCount2.SetActive(true);
            meterCount3.SetActive(false);
            meterCount4.SetActive(false);

            cameraDrone1.SetActive(false);
            cameraDrone2.SetActive(true);
            cameraDrone3.SetActive(false);
            cameraDrone4.SetActive(false);
        }
        else if (number == 2){
            drone1.SetActive(false);
            drone2.SetActive(false);
            drone3.SetActive(true);
            drone4.SetActive(false);

            cm1.SetActive(false);
            cm2.SetActive(false);
            cm3.SetActive(true);
            cm4.SetActive(false);

            meterCount1.SetActive(false);
            meterCount2.SetActive(false);
            meterCount3.SetActive(true);
            meterCount4.SetActive(false);

            cameraDrone1.SetActive(false);
            cameraDrone2.SetActive(false);
            cameraDrone3.SetActive(true);
            cameraDrone4.SetActive(false);
        }
        else{
            drone1.SetActive(false);
            drone2.SetActive(false);
            drone3.SetActive(false);
            drone4.SetActive(true);

            cm1.SetActive(false);
            cm2.SetActive(false);
            cm3.SetActive(false);
            cm4.SetActive(true);

            meterCount1.SetActive(false);
            meterCount2.SetActive(false);
            meterCount3.SetActive(false);
            meterCount4.SetActive(true);

            cameraDrone1.SetActive(false);
            cameraDrone2.SetActive(false);
            cameraDrone3.SetActive(false);
            cameraDrone4.SetActive(true);
        }
    }



    void Update()
    {
        
    }
}
