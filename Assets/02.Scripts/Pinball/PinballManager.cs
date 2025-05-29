using System.Xml.Schema;
using UnityEngine;
using UnityEngine.Rendering;

public class PinballManager : MonoBehaviour
{
    public Rigidbody2D Left;
    public Rigidbody2D Right;

    public int TotalScore;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {

            Left.AddTorque(30f);
            Debug.Log("??");
        }
        else
        {
            Left.AddTorque(-25f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Right.AddTorque(-30f);
        }
        else
        {
            Right.AddTorque(25f);
        }
    }
}
