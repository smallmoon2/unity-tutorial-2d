using UnityEngine;

public class Gun : MonoBehaviour, IDropItem
{
    public GameObject bulletPrefeb;
    public Transform shootPos;
    public void Grab(Transform grabPos)
    {
        transform.SetParent(grabPos);
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.identity;
        Debug.Log("ÃÑÀ» ÁÖ¿ü´Ù.");
    }

    public void Use()
    {
        GameObject bullet = Instantiate(bulletPrefeb, shootPos.position, Quaternion.identity);
        Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();

        bulletRb.AddForce(shootPos.forward *100f, ForceMode.Impulse);

        Debug.Log("ÃÑÀ» ¹ß»çÇÑ´Ù.");
    }

    public void Drop()
    {
        transform.SetParent(null);
        transform.localPosition = transform.localPosition + new Vector3(0, 0, 2);
        Debug.Log("ÃÑÀ» ¹ö·È´Ù.");
    }
}