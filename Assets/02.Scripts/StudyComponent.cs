using Unity.VisualScripting;
using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    public ProgrammerB pB; // ť�� ���ӿ�����Ʈ�� �ְ�ʹ�
    public GameObject obj;

    public string changeName;

    void Start()
    {
        obj = GameObject.Find("Main Camera");
        obj.name = changeName;
    }


}
