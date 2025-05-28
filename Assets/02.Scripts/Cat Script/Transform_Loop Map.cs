using UnityEngine;

public class Transform_LoopMap : MonoBehaviour
{
    public float MoveSpeed = 3f;
    public float randomPosY;
    float height = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        height = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * MoveSpeed * Time.fixedDeltaTime;
        Debug.Log(Time.fixedDeltaTime);
        if (transform.position.x <= -30f)
        {

            randomPosY = Random.Range(-8f, -2.5f);
            transform.position = new Vector3(30f, randomPosY, 0f);

        }

       
    }
}
