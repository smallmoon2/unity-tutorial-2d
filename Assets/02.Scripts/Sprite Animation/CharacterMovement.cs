using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Rigidbody2D characterRb;
    public SpriteRenderer[] renderers;

    public GameObject[] renderObjs;

    public float moveSpeed;
    public float jumpPower = 10f;
    private float h;

    private bool isGround;

    void Start()
    {
        characterRb = GetComponent<Rigidbody2D>();

        renderers = GetComponentsInChildren<SpriteRenderer>(true);
    }

    void Update()
    {
        h = Input.GetAxis("Horizontal"); // Ű �Է�

        Jump();
    }

    void FixedUpdate()
    {
        Move();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        isGround = true;
        renderers[2].gameObject.SetActive(false); // Run
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        isGround = false;
        renderers[0].gameObject.SetActive(false); // Idle
        renderers[1].gameObject.SetActive(false); // Run
        renderers[2].gameObject.SetActive(true); // Run
    }


    /// <summary>
    /// ĳ���� �����ӿ� ���� �̹����� Flip ���°� ���ϴ� ���
    /// </summary>
    private void Move()
    {
        if (!isGround)
        {
            return;
        }
        if (h != 0) // ������ ��
        {
            renderers[0].gameObject.SetActive(false); // Idle
            renderers[1].gameObject.SetActive(true); // Run

            characterRb.linearVelocityX = h * moveSpeed; // �������� �̵�

            if (h > 0)
            {
                renderers[0].flipX = false;
                renderers[1].flipX = false;
            }
            else if (h < 0)
            {
                renderers[0].flipX = true;
                renderers[1].flipX = true;
            }
        }
        else if (h == 0)// �������� ���� ��
        {
            renderers[0].gameObject.SetActive(true); // Idle
            renderers[1].gameObject.SetActive(false); // Run
        }
    }

    /// <summary>
    /// ĳ���Ͱ� +Y �������� �����ϴ� ���
    /// </summary>
    private void Jump()
    {
        if (Input.GetButtonDown("Jump")) // Input.GetKeyDown(KeyCode.Space)
        {
            characterRb.AddForceY(jumpPower, ForceMode2D.Impulse);

        }
    }
}
