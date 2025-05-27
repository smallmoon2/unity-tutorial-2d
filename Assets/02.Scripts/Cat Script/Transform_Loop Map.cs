using UnityEngine;

public class Transform_LoopMap : MonoBehaviour
{
    public float MoveSpeed = 3f;

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

            transform.position = new Vector3(30f, height, 0f);
        }
    }
}
