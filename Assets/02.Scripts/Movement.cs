using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 10f;

    private void Update()
    {
        //    if (Input.GetKey(KeyCode.W)) // ������ ���� ���
        //    {
        //        transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        //    }

        //    if (Input.GetKey(KeyCode.S)) // �ڷ� ���� ���
        //    {
        //        transform.position += Vector3.back * moveSpeed * Time.deltaTime;
        //    }

        //    if (Input.GetKey(KeyCode.A)) // �������� ���� ���
        //    {
        //        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        //    }

        //    if (Input.GetKey(KeyCode.D)) // ���������� ���� ���
        //    {
        //        transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        //    }
        //

        /// Input System (Old - Legacy)
        /// �Է°��� ���� ��ӵ� �ý���
        /// �̵� -> WASD, ȭ��ǥŰ����
        /// ���� -> Space
        /// �ѽ�� -> ���콺 ����

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0, v);
        Debug.Log($"���� �Է� : {dir}");

        transform.position += dir * moveSpeed * Time.deltaTime;
    }
}
