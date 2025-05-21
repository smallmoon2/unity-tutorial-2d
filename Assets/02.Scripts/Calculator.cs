using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    public int number1, number2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int addResult = 0;

        int minusResult = 0;

        Debug.Log($"´õÇÑ °ª : {addResult} / »« °ª : {minusResult}");
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
