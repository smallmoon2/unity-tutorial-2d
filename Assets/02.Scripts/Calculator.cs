using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    public int number1, number2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int addResult = AddMethod(); // �Լ� ȣ��

        int minusResult = MinusMethod(); // �Լ� ȣ��

        Debug.Log($"���� �� : {addResult} / �� �� : {minusResult}");
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
