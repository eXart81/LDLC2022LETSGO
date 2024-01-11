using UnityEngine.AI;
using UnityEngine;
using Unity.VisualScripting;

public class Agent_nav : MonoBehaviour
{
    [SerializeField] private GameObject chemin;
    int currentIndex = 0;

    public NavMeshAgent agent;
    // Update is called once per frame
    
    Vector3 GetPositionFromTargetIndex(int index)
    {
        return chemin.transform.GetChild(index).position;
    }
    
    void Start()
    {
        agent.destination = GetPositionFromTargetIndex(currentIndex);
    }

    private void Update()
    {

        bool hasArrived = Vector3.Distance(transform.position, GetPositionFromTargetIndex(currentIndex)) < 1; 
        if(hasArrived)
        {
            currentIndex += 1;
            if (currentIndex >= chemin.transform.childCount)
                currentIndex = 0;

            agent.destination = GetPositionFromTargetIndex(currentIndex);
        }
    }
}
