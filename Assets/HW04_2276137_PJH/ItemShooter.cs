using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemShooter : MonoBehaviour
{
    public GameObject itemPrefab;         // 발사할 아이템 프리팹
    public Transform firePosition;        // 아이템 생성 위치
    public Transform aimTarget;           // 조준점 위치
    public float shootForce = 5f;

    public void Fire()
    {
        if (GameManager.Instance.pickCount <= 0) return;

        GameObject bullet = Instantiate(itemPrefab, firePosition.position, Quaternion.identity);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        if (rb != null)
        {
            Vector3 dir = (aimTarget.position - firePosition.position).normalized;
            rb.AddForce(dir * shootForce, ForceMode.Impulse);
        }

        GameManager.Instance.UpdateUI();
    }
}
