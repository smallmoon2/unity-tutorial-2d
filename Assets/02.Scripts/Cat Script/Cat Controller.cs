using System;
using UnityEngine;
using Cat;
using System.Collections;

public class CatController : MonoBehaviour
{
    public SoundManager soundManager;
    public VideoManager videoManager;
    public GameObject gameOverUI;
    public GameObject fadeUI;

    public GameObject happyVideo;
    public GameObject sadVideo;

    private Rigidbody2D catRb;
    private Animator catAnim;

    public UIManager UIManagers;

    public int jumpCount = 0;
    public float jumpPower = 30f;
    public float limitPower = 25f;

    void Start()
    {
        catRb = GetComponent<Rigidbody2D>();
        catAnim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < 10)
        {
            catAnim.SetTrigger("Jump");
            catAnim.SetBool("isGround", false);
            jumpCount++;
            soundManager.OnJumpSound();
            catRb.AddForceY(jumpPower, ForceMode2D.Impulse);

            if (catRb.linearVelocityY > limitPower) // �ڿ������� ������ ���� �ӵ� ����
                catRb.linearVelocityY = limitPower;
        }

        var catRotation = transform.eulerAngles;
        catRotation.z = catRb.linearVelocityY * 2.5f;
        transform.eulerAngles = catRotation;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Apple"))
        {
            other.gameObject.SetActive(false);
            other.transform.parent.GetComponent<ItemEvent>().particle.SetActive(true);

            GameManager.score++;

            if (GameManager.score == 10) // ����� 10�� �Ծ ����
            {
                fadeUI.SetActive(true);
                fadeUI.GetComponent<FadeRoutine>().OnFade(3f, Color.white);
                this.GetComponent<CircleCollider2D>().enabled = false;

                StartCoroutine(EndingRoutine(true));
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Pipe")) // �������� �ε����� ����
        {
            soundManager.OnColliderSound();

            gameOverUI.SetActive(true); // ���� ���� �ѱ�
            fadeUI.SetActive(true); // ���̵� �ѱ�
            fadeUI.GetComponent<FadeRoutine>().OnFade(3f, Color.black); // ���̵� ����
            this.GetComponent<CircleCollider2D>().enabled = false;

            StartCoroutine(EndingRoutine(false));
        }

        if (other.gameObject.CompareTag("Ground"))
        {
            catAnim.SetBool("isGround", true);
            jumpCount = 0;
        }
    }


    IEnumerator EndingRoutine(bool isHappy)
    {
        yield return new WaitForSeconds(5);
        videoManager.VideoPlay(isHappy);

        fadeUI.SetActive(false);
        gameOverUI.SetActive(false);
        UIManagers.playUI.SetActive(false);
        soundManager.audioSource.mute = true;
    }

}