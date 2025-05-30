using System;
using UnityEngine;

public class Coin : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("ÄÚÀÎ È¹µæ!!");
            Destroy(gameObject);
            Movement.CoinCount++;
        }
    }
}