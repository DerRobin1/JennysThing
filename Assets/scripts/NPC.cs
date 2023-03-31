using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC : MonoBehaviour
{

	public GameObject desinationPoint;
	NavMeshAgent theAgent;

	void Start()
	{
		theAgent = GetComponent<NavMeshAgent>();
	}



	void Update()
	{
		theAgent.SetDestination(desinationPoint.transform.position);
	}
}