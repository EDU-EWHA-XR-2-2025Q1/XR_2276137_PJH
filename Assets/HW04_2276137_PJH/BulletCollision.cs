using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PutRepo"))
        {
            GameManager.Instance.putCount++;
            GameManager.Instance.UpdateUI();
            Destroy(gameObject);
        }
    }
}
