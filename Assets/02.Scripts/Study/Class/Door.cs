using UnityEngine;

public class Door : MonoBehaviour, IDamageable

{
    public void TakeDamage(float damage)
    {
        Debug.Log($"{damage}만큼의 데미지를 입었습니다.");
    }
}
