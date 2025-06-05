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

        Debug.Log($"현재 비빌번호 입력 :{keyPadNumber}");

    }

    public void OncheckNumber()
    {
        if(keyPadNumber == password)
        {
            Debug.Log("비밀번호 입력 완료");
            anim.SetTrigger("Door Open");
            doorLock.SetActive(false);
        }
        else
        {
            Debug.Log("비밀번호 오류");
            keyPadNumber = "";
        }
    }
}
