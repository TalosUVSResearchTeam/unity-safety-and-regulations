using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableMenus : MonoBehaviour
{   float x=0;
     public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(x!=0){
            x-=Time.deltaTime;
            if (x<=0){
            
                obj.SetActive(true);
            }
        }
        
    }
    public void startCount(){
        x=3;
    }
} 
