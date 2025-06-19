using UnityEngine;

public class Potion : MonoBehaviour, IItem
{
    private Inventory inventory;

    public GameObject Obj { get; set; }
 

    public enum PotionType { Gold, Hp, Mp }
    public PotionType potionType;

    void Start()
    {
        inventory = FindFirstObjectByType<Inventory>();

        Obj = gameObject;
    }

    void OnMouseDown()
    {
        Get();
    }

    public void Get()
    {
        Debug.Log($"{this.name}¿ª »πµÊ«ﬂΩ¿¥œ¥Ÿ.");

        inventory.AddItem(this);

        gameObject.SetActive(false);
    }
}