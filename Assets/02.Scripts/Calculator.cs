using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    public int number1, number2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int addResult = AddMethod(); // 함수 호출

        int minusResult = MinusMethod(); // 함수 호출

        Debug.Log($"더한 값 : {addResult} / 뺀 값 : {minusResult}");
    }

    // Update is called once per frame

    void AddMethod()
    {
        int result = number1 + number2;

    }

    void MinusMethod()
    {
        int result = number1 - number2;

    }
    void Update()
    {
        
    }
}
