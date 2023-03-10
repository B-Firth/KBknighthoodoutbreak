using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeAway : StateMachineBehaviour
{
    EndTrigger trigger;
    public float fadeTimer = 0.5f;
    private float elapsedTime = 0f;
    SpriteRenderer spriteRenderer;
    GameObject removeObject;
    Color startColor;
    
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator anim, AnimatorStateInfo stateInfo, int layerIndex)
    {
        elapsedTime = 0f;
        spriteRenderer = anim.GetComponent<SpriteRenderer>();
        startColor = spriteRenderer.color;
        removeObject = anim.gameObject;
        
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator anim, AnimatorStateInfo stateInfo, int layerIndex)
    {
        elapsedTime += Time.deltaTime;
        float fadeAlpha = startColor.a * (1 - (elapsedTime / fadeTimer));
       spriteRenderer.color = new Color(startColor.r, startColor.g, startColor.b, fadeAlpha);

        if (elapsedTime > fadeTimer)
        {
            
            Destroy(removeObject);  
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

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
