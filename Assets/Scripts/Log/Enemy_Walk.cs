using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Walk : EnemyBaseFSM
{
    void Awake()
    {

    }

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (Vector3.Distance(player.transform.position, enemy.transform.position) <= chaseRadius && Vector3.Distance(player.transform.position, enemy.transform.position) > attackRadius)
        {
            Vector3 temp = Vector3.MoveTowards(enemy.transform.position, player.transform.position, speed * Time.deltaTime);
            Vector3 direction = temp - enemy.transform.position;
            direction.Normalize();

            enemyRB.MovePosition(temp);

            if (Mathf.Abs(direction.x) > Mathf.Abs(direction.y))
            {
                if (direction.x > 0)
                {
                    animator.SetFloat("moveX", direction.x);
                }
                else if (direction.x < 0)
                {
                    animator.SetFloat("moveX", direction.x);
                }
            }
            else if (Mathf.Abs(direction.x) < Mathf.Abs(direction.y))
            {
                if (direction.y > 0)
                {
                    animator.SetFloat("moveY", direction.y);
                }
                else if (direction.y < 0)
                {
                    animator.SetFloat("moveY", direction.y);
                }
            }
        }
        else if (Vector3.Distance(player.transform.position, enemy.transform.position) > chaseRadius)
        {
            animator.SetBool("isWakingUp", false);
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
