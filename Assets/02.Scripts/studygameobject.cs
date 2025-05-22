using UnityEngine;

public class studygameobject : MonoBehaviour
{
    public GameObject prefab;

    public GameObject desobject;

    public Vector3 pos;
    public Quaternion rot;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CreateAmongus();
    }

    public void CreateAmongus()
    {
        GameObject obj = Instantiate(prefab);
        obj.name = "어몽어스 캐릭터";
        Debug.Log($"캐릭터의 자식 오브젝트의 수 : {obj.transform.childCount}");
        Debug.Log($"캐릭터의 자식 오브젝트의 수 : {obj.transform.GetChild(0).name}");
        Debug.Log($"{obj.transform.GetChild(obj.transform.childCount - 1).name}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
