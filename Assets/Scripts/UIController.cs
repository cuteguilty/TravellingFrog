using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] private Text myText;

    private void Start(){
        string[] names = new string[] { "Столица Мексики - Мехико - самый древний город Северной Америки, он отстроен на развалинах ацтекского города Теночтитлана.", "Мексика — это родина перца чили, шоколада и кукурузы.", "Пляжи Канкуна и Тулума входит в десятку лучших пляжей мира." };
        int index = Random.Range(0, names.Length);
        myText.text = names[index];
    }
}