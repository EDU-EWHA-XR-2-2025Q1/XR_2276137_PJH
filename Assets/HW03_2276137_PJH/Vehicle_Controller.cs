using UnityEngine;

public class VehicleController : MonoBehaviour
{
    public Transform targetPoint;  // 이동 목표 지점(Room2)
    public float speed = 3f;

    private bool isMoving = false;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void StartMoving()
    {
        isMoving = true;
        if (animator != null)
        {
            animator.SetBool("isMoving", true);
        }
    }

    public void StopMoving()
    {
        isMoving = false;
        if (animator != null)
        {
            animator.SetBool("isMoving", false);
        }
    }

    private void Update()
    {
        if (isMoving && targetPoint != null)
        {
            Vector3 direction = (targetPoint.position - transform.position).normalized;
            float distance = Vector3.Distance(transform.position, targetPoint.position);

            if (distance > 0.1f)
            {
                transform.position += direction * speed * Time.deltaTime;
            }
            else
            {
                StopMoving();
            }
        }
    }
}
