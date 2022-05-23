using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonSkidka : MonoBehaviour
{
   [SerializeField] private Text myText;
    public void ButClick(){
    
        int decriment = PlayerPrefs.GetInt("total") - 1;
        int sale = 0;
        if (decriment >= 0) {
            PlayerPrefs.SetInt("total", decriment);
            sale = PlayerPrefs.GetInt("sale") + 1;
            PlayerPrefs.SetInt("sale", sale);
        }
        
    }
}
