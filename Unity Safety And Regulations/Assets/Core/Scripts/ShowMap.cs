using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMap : MonoBehaviour
{
    public GameObject MapCanvas;
    bool CanvasIsOn = false;
    void Start() {
        MapCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M)){
            if (CanvasIsOn == true){
                CanvasIsOn = false;
                MapCanvas.SetActive(CanvasIsOn); 
            }else{
                CanvasIsOn = true;
                MapCanvas.SetActive(CanvasIsOn); 
            }
        }
    }
}
