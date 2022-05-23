using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelScore : MonoBehaviour
{

    void Start()
    {
       Debug.Log(PlayerPrefs.GetInt("mexico")); 
    }

}
