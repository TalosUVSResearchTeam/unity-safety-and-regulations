using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelection : MonoBehaviour
{
    public GameObject[] drones;
    public int SelDrone;
    public string index;
   
    void Start()
    {
        
    }

    void Update()
    {
        

    }
    public void Select1()
    {

        SelDrone = 0;
        PlayerPrefs.SetInt("index", 0);

    }
    public void Select2()
    {

        SelDrone = 1;
        PlayerPrefs.SetInt("index", 1);
    }
    public void Select3()
    {
        SelDrone = 2;
        PlayerPrefs.SetInt("index", 2);
    }
    public void Select4()
    {
        SelDrone = 3;
        PlayerPrefs.SetInt("index", 3);
    }
    public int getDrone()
    {
        int loadedNumber = PlayerPrefs.GetInt(index);
        return loadedNumber;
    }
}
