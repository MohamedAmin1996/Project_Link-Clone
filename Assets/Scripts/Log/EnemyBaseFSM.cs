using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBaseFSM : StateMachineBehaviour
{
    public GameObject enemy;
    public Rigidbody2D enemyRB;
    public GameObject player;

    public float speed;
    public float chaseRadius;
    public float attackRadius;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);
        enemy = animator.gameObject;
        enemyRB = enemy.GetComponent<EnemyBehaviour>().getEnemyRB();
        player = enemy.GetComponent<EnemyBehaviour>().getPlayer();
    }

    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateExit(animator, stateInfo, layerIndex);
    }
}
