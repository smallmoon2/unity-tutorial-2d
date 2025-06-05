using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class NumberKeyPad : MonoBehaviour
{
    public string password;
    public string keyPadNumber;
    public GameObject doorLock;

    public Animator anim;

    public void OninputNumber(string numString)
    {
        keyPadNumber += numString;

        Debug.Log($"���� �����ȣ �Է� :{keyPadNumber}");

    }

    public void OncheckNumber()
    {
        if(keyPadNumber == password)
        {
            Debug.Log("��й�ȣ �Է� �Ϸ�");
            anim.SetTrigger("Door Open");
            doorLock.SetActive(false);
        }
        else
        {
            Debug.Log("��й�ȣ ����");
            keyPadNumber = "";
        }
    }
}
