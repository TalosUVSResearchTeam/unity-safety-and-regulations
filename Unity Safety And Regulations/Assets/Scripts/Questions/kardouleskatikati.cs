using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kardouleskatikati : MonoBehaviour
{

    public GameObject kardoules1, kardoules2, kardoules3;
    public int kar;
    void Start()
    {
        kar = 2;
    }

    public void kardoulesoof()
    {
        if (kar == 2)
        {
            kardoules3.SetActive(false);
            kar--;
        }
        else if (kar == 1)
        {
            kardoules2.SetActive(false);
            kar--;
        }
        else
        {
            kardoules1.SetActive(false);
        }
    }
void Update()
    {
        
    }
}
