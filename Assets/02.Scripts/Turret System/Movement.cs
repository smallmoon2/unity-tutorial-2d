using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 10f;

    public static int CoinCount;

    private void Update()
    {
        

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0, v);

        Vector3 normalDir = dir.normalized;

        transform.position += normalDir * moveSpeed * Time.deltaTime;

        //Debug.Log($"현재 입력 : {normalDir}");

        transform.LookAt(transform.position + normalDir) ;
    }
}
