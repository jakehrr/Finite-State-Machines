using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : NPCBaseClassFSM
{
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);
        NPC.GetComponent<enemyAI>().StartFiring();
        
    }
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        NPC.transform.LookAt(opponent.transform.position);
    }
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        NPC.GetComponent<enemyAI>().StopFiring();
    }
}
