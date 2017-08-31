using UnityEngine.AI;
using UnityEngine;

[RequireComponent(typeof(NavMeshAgent))]
public class Warrior : MonoBehaviour {

    private NavMeshAgent agent;

    public Transform target;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        MoveWarrior();
    }

    private void MoveWarrior()
    {
        Vector3 targetPos = new Vector3(target.position.x, target.position.y, target.position.z);

        agent.SetDestination(targetPos);
    }
}
