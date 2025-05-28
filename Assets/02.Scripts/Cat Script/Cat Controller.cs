using Unity.VisualScripting;
using UnityEngine;

public class CatController : MonoBehaviour
{
    private Rigidbody2D catRb;
    public float jumpPower = 10f;

    public bool isGround = true;
    public int jumpCount = 0;
    void Start()
    {
        catRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 스페이스 키 입력
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < 2)
        {
            // 점프 = y축 방향으로 이동 X

            catRb.AddForceY(jumpPower, ForceMode2D.Impulse);
            jumpCount++;

        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            jumpCount = 0;
            isGround = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGround = false;
        }
    }

}