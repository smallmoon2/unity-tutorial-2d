using Unity.VisualScripting;
using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    public ProgrammerB pB; // ť�� ���ӿ�����Ʈ�� �ְ�ʹ�
    public GameObject obj;
    public Transform objTf;

    public string changeName;

    void Start()
    {
        // Player��� Tag�� ���� ���ӿ�����Ʈ�� ã�Ƽ� obj�� �Ҵ�
        obj = GameObject.FindGameObjectWithTag("Player");

        Debug.Log(obj.name); // ���ӿ�����Ʈ�� �̸�
        Debug.Log(obj.tag); // ���ӿ�����Ʈ�� �±�
        Debug.Log(obj.transform.position); // ���ӿ�����Ʈ�� Transform ������Ʈ�� ��ġ
        Debug.Log(obj.transform.rotation); // ���ӿ�����Ʈ�� Transform ������Ʈ�� ȸ��
        Debug.Log(obj.transform.localScale); // ���ӿ�����Ʈ�� Transform ������Ʈ�� ũ��
        

        Debug.Log($"transform ������ : {obj.GetComponent<Transform>().position}");
        Debug.Log($"Mesh ������ : {obj.GetComponent<MeshFilter>().mesh}");
        Debug.Log($"material ������ : {obj.GetComponent<MeshRenderer>().material}");

        obj.GetComponent<MeshRenderer>().enabled = false;

        
        obj.SetActive(false);
        objTf.gameObject.SetActive(true);
    }


}
