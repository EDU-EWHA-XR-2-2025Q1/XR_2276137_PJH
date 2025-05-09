using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW03_Animation_Ride_Controller : MonoBehaviour
{
    public Animator Animator;
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Vehicle")
        {
            transform.SetParent(other.transform);
            transform.position = other.transform.position + Vector3.up * 2f;
            Animator.speed = 1f;
            Animator.SetBool("isMoving", true); // 또는 Trigger, speed 등
        }

  
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Vehicle")
        {

            transform.SetParent(null);

            // Vehicle 애니메이션 정지
            if (Animator != null)
            {
                Animator.speed = 0f;// 또는 animator.speed = 0f;
            }

        }
    }
}
