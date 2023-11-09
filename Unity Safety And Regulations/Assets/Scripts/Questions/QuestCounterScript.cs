using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestCounterScript : MonoBehaviour
{
    //text
    public TMP_Text  questText;

    //questions answered
    public int numAns=0;

    //questions total
    float totalQuest = 10;

    public void ChangeText() {
       numAns++;
       questText.SetText(numAns + "/" + totalQuest + " questions");
    }
}
