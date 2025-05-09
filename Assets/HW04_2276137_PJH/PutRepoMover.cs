using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutRepoMover : MonoBehaviour
{
    public Vector3 centerPosition;
    public float moveRadius = 0.2f;

    void Start()
    {
        InvokeRepeating(nameof(MoveRandomly), 0.5f, Random.Range(0.5f, 1f));
    }

    void MoveRandomly()
    {
        Vector3 randomOffset = new Vector3(
            Random.Range(-moveRadius, moveRadius),
            0f,
            Random.Range(-moveRadius, moveRadius)
        );

        transform.localPosition = centerPosition + randomOffset;
    }
}
