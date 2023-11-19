using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject Meter1,Meter2, Meter3, Meter4, mapCanvas;
    public GameObject Count;
    public bool isCountActive, isMapActive, isMeter1Act, isMeter2Act, isMeter3Act, isMeter4Act;
    public bool ispaused;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (ispaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }
    
    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        
        isMeter1Act = Meter1.activeSelf;
        Meter1.SetActive(false);
        isMeter2Act = Meter2.activeSelf;
        Meter2.SetActive(false);
        isMeter3Act = Meter3.activeSelf;
        Meter3.SetActive(false);
        isMeter4Act = Meter4.activeSelf;
        Meter4.SetActive(false);
        isCountActive = Count.activeSelf;
        isMapActive = mapCanvas.activeSelf;
        Count.SetActive(false);
        mapCanvas.SetActive(false);
        Time.timeScale = 0f;
        ispaused = true;
    }
    
    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        if(isCountActive) Count.SetActive(true);
        if(isMapActive) Count.SetActive(true);
        Meter1.SetActive(isMeter1Act);
        Meter2.SetActive(isMeter2Act);
        Meter3.SetActive(isMeter3Act);
        Meter4.SetActive(isMeter4Act);
        Time.timeScale = 1f;
        ispaused = false;
    }

}
