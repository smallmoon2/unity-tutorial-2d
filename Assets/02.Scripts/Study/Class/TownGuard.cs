using UnityEngine;

public class TownGuard : MonoBehaviour, IMove, IAttack

{
    public void Attack()
    {
        Debug.Log("Attack");
    }

    public void Move()
    {
        Debug.Log("Move");
    }
}
