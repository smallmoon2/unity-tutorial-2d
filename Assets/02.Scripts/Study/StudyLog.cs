using System;
using UnityEngine;

public class StudyLog : MonoBehaviour
{
    public float moveSpeed = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //this.transform.position = this.transform.position + Vector3.forward * moveSpeed;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) // ������ ���� ���
        {
            transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.S)) // �ڷ� ���� ���
        {
            transform.position += Vector3.back * moveSpeed * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.A)) // �������� ���� ���
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.D)) // ���������� ���� ���
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
    }
}
