using Unity.VisualScripting;
using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    public ProgrammerB pB; // 큐브 게임오브젝트를 넣고싶다
    public GameObject obj;
    public Transform objTf;

    public string changeName;

    void Start()
    {
        // Player라는 Tag를 가진 게임오브젝트를 찾아서 obj에 할당
        obj = GameObject.FindGameObjectWithTag("Player");

        Debug.Log(obj.name); // 게임오브젝트의 이름
        Debug.Log(obj.tag); // 게임오브젝트의 태그
        Debug.Log(obj.transform.position); // 게임오브젝트의 Transform 컴포넌트의 위치
        Debug.Log(obj.transform.rotation); // 게임오브젝트의 Transform 컴포넌트의 회전
        Debug.Log(obj.transform.localScale); // 게임오브젝트의 Transform 컴포넌트의 크기
        

        Debug.Log($"transform 데이터 : {obj.GetComponent<Transform>().position}");
        Debug.Log($"Mesh 데이터 : {obj.GetComponent<MeshFilter>().mesh}");
        Debug.Log($"material 데이터 : {obj.GetComponent<MeshRenderer>().material}");

        obj.GetComponent<MeshRenderer>().enabled = false;

        
        obj.SetActive(false);
        objTf.gameObject.SetActive(true);
    }


}
