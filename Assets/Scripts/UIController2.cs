using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController2 : MonoBehaviour
{
    [SerializeField] private Text myText;

    private void Start()
    {
        string[] names = new string[] { "��������� �� 2/3 ������� ��������������� � �������� ����� �������� ������� � ������.", "�������� ������� �������� �����, �������������� ��������� Economist Intelligence Unit, ��������� � ������ �����, � ������� ����� ��������.", "� ������� �� ������ �����, ����������� � ��������� ����� ���������. ����� ����� ����������� ������ ���������� 25% �� ������ ���������� ���������." };
        int index = Random.Range(0, names.Length);
        myText.text = names[index];
    }
}
