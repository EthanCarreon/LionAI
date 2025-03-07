using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.AI;

namespace NodeCanvas.Tasks.Actions {

	public class AT_Patrol : ActionTask {

		public BBParameter<Transform> startingPosition;
        public BBParameter<Vector3> targetPosition;

		public BBParameter<List<Transform>> patrolList;
		public BBParameter<int> patrolIndex;

		public BBParameter<GameObject> patrolIcon;

		NavMeshAgent navAgent;
        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit() {

			navAgent = agent.GetComponent<NavMeshAgent>();
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
			targetPosition.value = startingPosition.value.transform.position;
			patrolIcon.value.SetActive(true);
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate() {
			navAgent.SetDestination(patrolList.value[patrolIndex.value].transform.position);
		}

		//Called when the task is disabled.
		protected override void OnStop() {
			
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}