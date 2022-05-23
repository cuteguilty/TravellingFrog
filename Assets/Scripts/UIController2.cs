using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController2 : MonoBehaviour
{
    [SerializeField] private Text myText;

    private void Start()
    {
        string[] names = new string[] { "Швейцария на 2/3 покрыта возвышенностями и является самой гористой страной в Европе.", "Согласно Индексу качества жизни, разработанному компанией Economist Intelligence Unit, Швейцария — лучшее место, в котором можно родиться.", "В отличие от других стран, иностранцам в Швейцарии очень комфортно. Общее число иностранных гостей составляет 25% от общего количества населения." };
        int index = Random.Range(0, names.Length);
        myText.text = names[index];
    }
}
