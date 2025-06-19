using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    private Animator animater;
    [SerializeField] private GameObject hitBox;
    [SerializeField] private float moveSpeed = 3f;
    private float h, v;

    private void Start()
    {
        animater = GetComponent<Animator>();
    }
    private void Update()
    {
        Move();
        Attake();
    }

    void Move()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        if (h ==0 && v== 0)
        {
            animater.SetBool("Run", false);

        }
        else
        {
            int scaleX = h > 0 ? 1 : -1;

            transform.localScale = new Vector3(scaleX, 1, 1);
            animater.SetBool("Run", true);
        }
            var dir = new Vector3(h, v, 0).normalized;

        transform.position += dir * moveSpeed * Time.deltaTime;
    }

    void Attake()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(AttackRoutine());
        }
    }

    IEnumerator AttackRoutine()
    {
        hitBox.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        hitBox.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Monster>() != null)
        {
            Monster monster = other.GetComponent<Monster>();
            StartCoroutine(monster.Hit(1));
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.GetComponent<IItem>() != null)
        {
            IItem item = other.gameObject.GetComponent<IItem>();
            item.Get();
        }
    }

}
