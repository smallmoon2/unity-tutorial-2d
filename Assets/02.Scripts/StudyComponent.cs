using Unity.VisualScripting;
using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    public ProgrammerB pB; // 큐브 게임오브젝트를 넣고싶다
    public GameObject obj;

    public string changeName;

    void Start()
    {
        obj = GameObject.Find("Main Camera");
        obj.name = changeName;
    }


}
