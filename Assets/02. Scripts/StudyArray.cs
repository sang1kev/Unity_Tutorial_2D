using System;
using UnityEngine;
using System.Collections.Generic;

public class StudyArray : MonoBehaviour
{
    //public int[] arrayNumber = new int[5] {1,2,3,4,5};
    //List<int> listNumber = new List<int>();
    int number1 = 1;
    private int number2 = 2;
    public int number3 = 3;

    [SerializeField]    //����ȭ �ؼ� �����͸� ���� ��unity engine���� �����͸� ���� ���� ��� ����
    private int number4 = 4;

    [SerializeField] int number5 = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Debug.Log($"Array�� ù��° �� : {arrayNumber[0]}");
        //Debug.Log($"Array�� �׼�° �� : {arrayNumber[2]}");
        //Debug.Log($"Array�� ������° �� : {arrayNumber[5]}");
        /*listNumber.Add(5);
        listNumber.Add(4);
        listNumber.Add(3);
        listNumber.Add(2);
        listNumber.Add(1);

        Debug.Log($"���� List�� �ִ� ������ �� : {listNumber.Count}");
        Debug.Log($"���� List�� ������ ������ : {listNumber[listNumber.Count-1]}");*/
    }

}
