using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButSkidka : MonoBehaviour
{
  [SerializeField] private Text myText;
 
    void Start()
    {
        double sale = PlayerPrefs.GetInt("sale") * 0.01;
      //  sale = 0;
        myText.text = sale.ToString();

    }

    void Update()
    {
        double sale = PlayerPrefs.GetInt("sale") * 0.01;
       // sale = 0;
        myText.text = sale.ToString();
    }
}
