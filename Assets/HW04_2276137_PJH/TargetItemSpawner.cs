using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetItemSpawner : MonoBehaviour
{
    public GameObject itemPrefab;
    public int itemCount = 10;
    private bool hasSpawned = false;

    void OnEnable()
    {
        if (!hasSpawned)
        {
            SpawnItemsSafely();
            hasSpawned = true;
        }
    }

    void SpawnItemsSafely()
    {
        // GameManager.Instance가 아직 null일 수 있으므로 예외 방지용
        int picked = 0;
        if (GameManager.Instance != null)
        {
            picked = GameManager.Instance.pickCount;
        }

        int remaining = Mathf.Clamp(itemCount - picked, 0, itemCount); // 음수 방지

        for (int i = 1; i < remaining; i++)
        {
            Vector3 randomOffset = new Vector3(Random.Range(-0.1f, 0.1f), 0, Random.Range(-0.1f, 0.1f));
            Vector3 spawnPos = transform.position + randomOffset;
            Instantiate(itemPrefab, spawnPos, Quaternion.identity, transform);
        }
    }
}
