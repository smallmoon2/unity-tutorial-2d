using UnityEngine;

public class Pinball : MonoBehaviour
{
    public PinballManager pinballManager;
    public int Scorepoint = 10;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            pinballManager.TotalScore += Scorepoint;

            Debug.Log($"현재점수 : {pinballManager.TotalScore}");
        }

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("gameover"))
        {

            Debug.Log($"게임오버");
        }

    }
}
