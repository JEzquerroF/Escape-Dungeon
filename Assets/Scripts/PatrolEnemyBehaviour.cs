using System;
using UnityEngine;

public class PatrolEnemyBehaviour : StateMachineBehaviour
{
    Enemy _enemy;

    float movementSpeed;
    [SerializeField] float minDistance;
    int nextPoint = 0;

    public static Action OnPatrol;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        _enemy = animator.gameObject.GetComponent<Enemy>();
        movementSpeed = _enemy.patrolSpeed;
        OnPatrol?.Invoke();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.transform.position = Vector2.MoveTowards(animator.transform.position, _enemy._movementPoints[nextPoint].position, movementSpeed * Time.deltaTime);

        if (Vector2.Distance(animator.transform.position, _enemy._movementPoints[nextPoint].position) < minDistance)
        {
            nextPoint += 1;
            if (nextPoint >= _enemy._movementPoints.Length)
            {
                nextPoint = 0;
            }
            _enemy.Flip();
        }

        _enemy._directionEnemy = _enemy._movementPoints[nextPoint].position - animator.transform.position;
    }
}
