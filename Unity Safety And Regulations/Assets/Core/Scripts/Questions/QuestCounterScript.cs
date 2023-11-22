using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

using UnityEngine.SceneManagement;
public class QuestCounterScript : MonoBehaviour
{
    //text
    public TMP_Text  questText;

    //questions answered
    public int numAns=0;

    //questions total
    public float totalQuest = 10;
    public void Start(){
        questText.SetText(numAns + "/" + totalQuest + " questions");
    }
    public void ChangeText() {
       numAns++;
       questText.SetText(numAns + "/" + totalQuest + " questions");
       if(numAns==totalQuest) LoadScene();
    }
    public void LoadScene()    {
        SceneManager.LoadScene("Win Scene");
        Time.timeScale=1;
    }
}
