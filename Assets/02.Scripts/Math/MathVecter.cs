using UnityEngine;

public class MathVecter : MonoBehaviour
{
    public Vector3 vec1 = new Vector3(3, 0, 0);
    public Vector3 vec2 = new Vector3(0, 4, 0);
    private void Start()
    {
       float size = Vector3.Magnitude(vec1 + vec2);

        Debug.Log(size);

       float distance = Vector3.Distance(vec1,vec2);

        Debug.Log(distance);
    }
}
