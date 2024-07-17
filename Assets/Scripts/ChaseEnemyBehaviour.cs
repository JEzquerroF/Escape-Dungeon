using UnityEngine;

public class ChaseEnemyBehaviour : StateMachineBehaviour
{
    Enemy _enemy;
    float movementSpeed;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        _enemy = animator.GetComponent<Enemy>();
        movementSpeed = _enemy.chaseSpeed;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.transform.position = Vector2.MoveTowards(animator.transform.position, PlayerMovement._playerTransform.position, movementSpeed * Time.deltaTime);
        animator.transform.localScale = new Vector3(2.5f, 2.5f, 1f);
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.transform.localScale = new Vector3(2f, 2f, 1f);
    }
}
