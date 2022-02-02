using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBaseFSM : StateMachineBehaviour
{
    public GameObject player;
    
    public Vector3 direction;
    public float speed;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);
        player = animator.gameObject;
    }

    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateExit(animator, stateInfo, layerIndex);
    }
}
