using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class studyArray : MonoBehaviour
{
    public int[] arrayNumber = new int[5] {1,2,3,4,5};

    public List<int> ListNumber = new List<int>();

    //int number1 = 1;

    //private int number2 = 2;

    public int number3 = 3;

    [SerializeField]
    private int number4 = 4;
    //private int number5 = 5;


    void Start()
    {


        ListNumber.Add(6);
        ListNumber.Add(7);
        ListNumber.Add(8); 
        ListNumber.Add(9); 
        ListNumber.Add(10);  
        Debug.Log($"현재 List의 데이터수 : {ListNumber.Count}");
        Debug.Log($"List의 마지막번 값 : {ListNumber[ListNumber.Count-1]}");


    }

}
