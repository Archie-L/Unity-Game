using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Animation : MonoBehaviour
{
    public float attackRange;
    public bool playerInAttackRange;
    public UnityEngine.AI.NavMeshAgent agent;
    public Transform player;
    public LayerMask PlayerLayer;
    [SerializeField] private Animator anim;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, PlayerLayer);

        if (!playerInAttackRange) ChasePlayer();
        if (playerInAttackRange) AttackPlayer();
    }

    private void ChasePlayer()
    {
        agent.SetDestination(player.position);
        anim.SetBool("punch", false);
    }

    private void AttackPlayer()
    {
        agent.SetDestination(transform.position);
        anim.SetBool("punch", true);
        transform.LookAt(player);
    }
}
