using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Set_IsMoving : StateMachineBehaviour
{
    // 애니메이션 상태에 들어갈 때 호출됨
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool("isMoving", false);  // 애니 상태 진입 시 자동으로 false로 변경
    }
}
