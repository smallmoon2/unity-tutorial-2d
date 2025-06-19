using System.Collections;
using UnityEngine;

public abstract class Monster : MonoBehaviour
{
    public SpawnManager spawner;
    private SpriteRenderer sRenderer;
    private Animator animator;

    [SerializeField] protected float hp = 3f;
    [SerializeField] protected float moveSpeed = 3f;

    private int dir = 1;
    private bool isMove = true;
    private bool isHit = false;
    public abstract void Init();

    void Start()
    {
        spawner = FindFirstObjectByType<SpawnManager>();
        sRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        Init();
    }

    void OnMouseDown()
    {
        //Hit(1);
        StartCoroutine(Hit(1f));
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        if (!isMove)
            return;
        transform.position += Vector3.right * dir * moveSpeed * Time.deltaTime;

        if (transform.position.x > 8f)
        {
            dir = -1;
            sRenderer.flipX = true;
        }
        else if (transform.position.x < -8f)
        {
            dir = 1;
            sRenderer.flipX = false;
        }

    }

    public IEnumerator Hit(float damage)
    {
        if (isHit)
            yield break;

        isHit = true;
        isMove = false;
        animator.SetTrigger("Hit");
        hp -= damage;

        if (hp <= 0)
        {
            Debug.Log("¸ó½ºÅÍ Á×À½");
            animator.SetTrigger("Death");
            yield return new WaitForSeconds(0.8f);
            Destroy(gameObject);
            spawner.DropCoin(transform.position);
        }
        yield return new WaitForSeconds(0.5f);
        isHit = false;
        isMove = true;
    }

}