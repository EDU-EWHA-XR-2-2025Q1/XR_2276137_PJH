using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW03_Door_Controller : MonoBehaviour
{
    public Animator Animator;
    public Transform doorTransform; // 문 자체의 Transform

    private bool enteredFromOutside = false;

    private void OnTriggerEnter(Collider other)
    {
        Vector3 doorForward = doorTransform.forward;
        Vector3 playerToDoor = (doorTransform.position - other.transform.position).normalized;

        float dot = Vector3.Dot(doorForward, playerToDoor);

        if (dot > 0)
        {
            // 문이 바라보는 방향과 플레이어가 오는 방향이 유사 -> 안에서 들어오는 중
            Animator.SetInteger("status", 1);
            enteredFromOutside = false;
        }
        else
        {
            // 반대 방향에서 들어오는 중 -> 밖에서 안으로
            Animator.SetInteger("status", 3);
            enteredFromOutside = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (enteredFromOutside)
        {
            Animator.SetInteger("status", 4); // 밖 -> 안 닫힘
        }
        else
        {
            Animator.SetInteger("status", 2); // 안 -> 밖 닫힘
        }
    }
}
