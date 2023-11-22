using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Makeaquestionappear : MonoBehaviour
{
    
    //canvas with questions
    public GameObject questionCanvas, questionCountCanvas, circle1, circle2,code;
    public bool check1, check2, check3;
    public bool btnPress1, btnPress2, btnPress3;
    public GameObject btnPress1GO, btnPress2GO, btnPress3GO;
    
    public int kar;
    public bool isMatch = false;
    public TMP_InputField  mainInputField1, mainInputField2, mainInputField3;
    public string ansMatch1, ansMatch2, ansMatch3;
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
        }else if(check1 && btnPress2){
            btnPress2GO.GetComponent<Image>().color = Color.red;
            code.GetComponent<kardouleskatikati>().kardoulesoof();
        }
        else if(check1 && btnPress3){
            btnPress3GO.GetComponent<Image>().color = Color.red;
            
            code.GetComponent<kardouleskatikati>().kardoulesoof();
        }
        else if(check2 && btnPress2){
            questionCountCanvas.GetComponent<QuestCounterScript>().ChangeText();
            Time.timeScale = 1;
            questionCanvas.SetActive(false);
            Destroy(circle1);
            Destroy(circle2);
        }else if(check2 && btnPress1){
            btnPress1GO.GetComponent<Image>().color = Color.red;

            code.GetComponent<kardouleskatikati>().kardoulesoof();
        }
        else if(check2 && btnPress3){
            btnPress3GO.GetComponent<Image>().color = Color.red;
           
            code.GetComponent<kardouleskatikati>().kardoulesoof();
        }
        if(check3 && btnPress3){
            questionCountCanvas.GetComponent<QuestCounterScript>().ChangeText();
            Time.timeScale = 1;
            questionCanvas.SetActive(false);
            Destroy(circle1);
            Destroy(circle2);
        }else if(check3 && btnPress2){
            btnPress2GO.GetComponent<Image>().color = Color.red;
            code.GetComponent<kardouleskatikati>().kardoulesoof();
        }
        else if(check3 && btnPress1){
            btnPress1GO.GetComponent<Image>().color = Color.red;
            code.GetComponent<kardouleskatikati>().kardoulesoof();
        }
    }
    
    public void CheckMatch(){
        int checkMatch = 0;
        if(mainInputField1.text==ansMatch1){
            checkMatch++;
            mainInputField1.GetComponent<Image>().color = Color.green;
        }else{
            checkMatch=0;
            mainInputField1.GetComponent<Image>().color = Color.red;
            code.GetComponent<kardouleskatikati>().kardoulesoof();
        }
        if(mainInputField2.text==ansMatch2){
            checkMatch++;
            mainInputField2.GetComponent<Image>().color = Color.green;
        }else{
            checkMatch=0;
            mainInputField2.GetComponent<Image>().color = Color.red;
            code.GetComponent<kardouleskatikati>().kardoulesoof();
        }
        if(mainInputField3.text==ansMatch3){
            checkMatch++;
            mainInputField3.GetComponent<Image>().color = Color.green;
        }else{
            checkMatch=0;
            mainInputField3.GetComponent<Image>().color = Color.red;
            code.GetComponent<kardouleskatikati>().kardoulesoof();
        }
        if(checkMatch==3){
            questionCountCanvas.GetComponent<QuestCounterScript>().ChangeText();
            Time.timeScale = 1;
            questionCanvas.SetActive(false);
            Destroy(circle1);
            Destroy(circle2);
        }
    }
}
