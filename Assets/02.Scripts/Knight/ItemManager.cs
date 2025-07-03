using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    public GameObject inventoryUI;
    public Button inventoryButton;
    [SerializeField] private GameObject[] items;
    [SerializeField] private Transform slotGroup;
    public Slot[] slots;

    void Start()
    {
        slots = slotGroup.GetComponentsInChildren<Slot>(true);

        inventoryButton.onClick.AddListener(OnInventory);
    }
    public void OnInventory()
    {
        inventoryUI.SetActive(!inventoryUI.activeSelf);
    }

    public void DropItem(Vector3 dropPos)
    {
        var randomIndex = Random.Range(0, items.Length); // 랜덤 인덱스 설정

        GameObject item = Instantiate(items[randomIndex], dropPos, Quaternion.identity); // 아이템 생성

        Rigidbody2D itemRb = item.GetComponent<Rigidbody2D>();

        itemRb.AddForceX(Random.Range(-2f, 2f), ForceMode2D.Impulse);
        itemRb.AddForceY(3f, ForceMode2D.Impulse);

        float ranPower = Random.Range(-1.5f, 1.5f);
        itemRb.AddTorque(ranPower, ForceMode2D.Impulse);
    }
        
    public void GetItem(IItemObject item)
    {
        foreach (var slot in slots)
        {
            if (slot.isEmpty)
            {
                slot.AddItem(item);
                break;
            }
        }
    }
}