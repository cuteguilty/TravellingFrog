using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public NewBehaviourScript froggy;
    public Dead_Trigger dead;
    public string level;
    public GameObject[] stars;
    public GameObject[] panels;

    void Update()
    {
        if(froggy.goal)
        {
            panels[0].SetActive(true);
            for(int i=0; i < froggy.count- 1; i++)
            {
                stars[i].SetActive(true);
            }
        }

         if(dead.goal && !froggy.goal)
        {
            panels[1].SetActive(true);
        } 
    }
}
