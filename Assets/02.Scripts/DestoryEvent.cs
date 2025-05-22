using UnityEngine;

public class DestoryEvent : MonoBehaviour
{
    public float destroyTime = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(this.gameObject, destroyTime);
        
    }

    void OnDestroy()
    {
        Debug.Log($"{this.gameObject.name}�� �ı��Ǿ����ϴ�.");
    }
    // Update is called once per frame

}
