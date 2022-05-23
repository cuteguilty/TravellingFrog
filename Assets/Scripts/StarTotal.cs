using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StarTotal : MonoBehaviour
{
    public static int total = 0;
   [SerializeField] private Text myText;

    void Start()
    {
        myText.text = PlayerPrefs.GetInt("total").ToString();
    }

    void Update()
    {
        myText.text = PlayerPrefs.GetInt("total").ToString();
    }
}
