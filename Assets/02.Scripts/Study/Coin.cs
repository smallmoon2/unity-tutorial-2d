using System;
using UnityEngine;

public class Coin : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("���� ȹ��!!");
            Destroy(gameObject);
            Movement.CoinCount++;
        }
    }
}