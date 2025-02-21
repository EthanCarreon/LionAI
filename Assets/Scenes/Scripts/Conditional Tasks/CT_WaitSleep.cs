using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;

namespace NodeCanvas.Tasks.Conditions {

	public class CT_WaitSleep : ConditionTask {

		public BBParameter<float> hunger;
		public float timer;
		public float maxTimerSleep;

        public BBParameter<Transform> startingPosition;
        public BBParameter<Vector3> targetPosition;

        NavMeshAgent navAgent;
        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise

        protected override string OnInit(){
            navAgent = agent.GetComponent<NavMeshAgent>();
            return null;
		}

		//Called whenever the condition gets enabled.
		protected override void OnEnable() {
			
		}

		//Called whenever the condition gets disabled.
		protected override void OnDisable() {
            targetPosition.value = startingPosition.value.transform.position;
			navAgent.SetDestination(startingPosition.value.transform.position);
        }

		//Called once per frame while the condition is active.
		//Return whether the condition is success or failure.
		protected override bool OnCheck() {
			timer += Time.deltaTime;

			if (timer >= maxTimerSleep)
			{
				timer = 0;
                return true;
            }
			else
			{
				return false;
			}

			
		}
	}
}