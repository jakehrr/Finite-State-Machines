using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCBaseClassFSM : StateMachineBehaviour
{
    public GameObject NPC;
    public GameObject opponent;
    public float speed = 2.0f;
    public float rotationSpeed = 1.0f;
    public float accuracy = 3.0f;
    // Start is called before the first frame update
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        NPC = animator.gameObject;
        opponent = NPC.GetComponent<enemyAI>().GetPlayer();
    }
}
