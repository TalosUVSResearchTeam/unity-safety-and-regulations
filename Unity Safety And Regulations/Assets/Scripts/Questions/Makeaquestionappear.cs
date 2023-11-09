using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Makeaquestionappear : MonoBehaviour
{
    
    //canvas with questions
    public GameObject questionCanvas, questionCountCanvas, circle1, circle2;
    public bool check1, check2, check3;
    public bool btnPress1, btnPress2, btnPress3;


    void Start(){
        questionCanvas.SetActive(false);
    }
    public void ClickedBtn(){
        Time.timeScale = 1;
        questionCanvas.SetActive(false);
    }
    private void OnTriggerEnter(Collider other){
        Time.timeScale = 0;
        PortalShowCanvas();
    }
    void PortalShowCanvas(){
        questionCanvas.SetActive(true);
    }
    public void SetCheck1(bool btnCheck1){
        btnPress1 = btnCheck1;
    }
    public void SetCheck2(bool btnCheck2){
        btnPress2 = btnCheck2;
    }
    public void SetCheck3(bool btnCheck3){
        btnPress3 = btnCheck3;
    }
    public void CheckAns(){
        if(check1 && btnPress1){
            questionCountCanvas.GetComponent<QuestCounterScript>().ChangeText();
            Time.timeScale = 1;
            questionCanvas.SetActive(false);
            Destroy(circle1);
            Destroy(circle2);
        }else{

        }
    }
}
