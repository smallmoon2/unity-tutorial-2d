using System;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float moveSpeed = 3f;

    public Rigidbody2D carRb;

    private float h;

    void Update()
    {
        h = Input.GetAxis("Horizontal");

        // Transform 이동
        transform.position += Vector3.right * h * moveSpeed * Time.deltaTime;
    }

    void FixedUpdate()
    {
        // Rigidbody의 속도를 활용한 이동
        carRb.linearVelocityX = h * moveSpeed * Time.deltaTime;
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("OnCollisionEnter2D");
    }

    void OnCollisionExit2D(Collision2D other)
    {
        Debug.Log("OnCollisionExit2D");
    }
    void OnCollisionStay2D(Collision2D other)
    {
        Debug.Log("OnCollisionStay2D");
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("OnTriggerEnter2D");
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("OnTriggerExit2D");
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("OnTriggerStay2D");
    }
}