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

    [SerializeField]    //직렬화 해서 데이터를 보냄 즉unity engine으로 데이터를 직접 보내 사용 가능
    private int number4 = 4;

    [SerializeField] int number5 = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Debug.Log($"Array의 첫번째 값 : {arrayNumber[0]}");
        //Debug.Log($"Array의 네세째 값 : {arrayNumber[2]}");
        //Debug.Log($"Array의 여섯번째 값 : {arrayNumber[5]}");
        /*listNumber.Add(5);
        listNumber.Add(4);
        listNumber.Add(3);
        listNumber.Add(2);
        listNumber.Add(1);

        Debug.Log($"현재 List에 있는 데이터 수 : {listNumber.Count}");
        Debug.Log($"현재 List의 마지막 데이터 : {listNumber[listNumber.Count-1]}");*/
    }

}
