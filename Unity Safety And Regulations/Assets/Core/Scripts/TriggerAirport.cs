using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAirport : MonoBehaviour
{
    public GameObject text,code;
    public bool check = false;
    
    private void OnTriggerEnter(Collider other){
        text.SetActive(true);
        check =true;
        StartCoroutine(KillDrone(5));
    }
    private void OnTriggerExit(Collider other){
        text.SetActive(false);
        check =false;
    }
    public IEnumerator KillDrone(float t)
    {   if(check){
            while(code.GetComponent<kardouleskatikati>().kar>-1){
                yield return new WaitForSeconds(t);
                Debug.Log("kkkkkkk");
                if(check)
                    code.GetComponent<kardouleskatikati>().kardoulesoof();
            }
        }
    }
    
}
