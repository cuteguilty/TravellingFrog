using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] private Text myText;

    private void Start(){
        string[] names = new string[] { "������� ������� - ������ - ����� ������� ����� �������� �������, �� �������� �� ���������� ���������� ������ ������������.", "������� � ��� ������ ����� ����, �������� � ��������.", "����� ������� � ������ ������ � ������� ������ ������ ����." };
        int index = Random.Range(0, names.Length);
        myText.text = names[index];
    }
}