using UnityEngine;

public class DoorEvent : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        animator.SetTrigger("Open");
        Debug.Log(other.name);

    }
}
