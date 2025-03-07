using System.Collections.Generic;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class AT_Hunt : ActionTask {

		public GameObject huntIcon;
		public BBParameter<GameObject> idleIcon;

        public BBParameter<Vector3> targetPosition;
        public BBParameter<Vector3> startingPosition;
        public float huntRadius;
        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit() {
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
			huntIcon.SetActive(true);
			idleIcon.value.SetActive(false);
        }

		//Called once per frame while the action is active.
		protected override void OnUpdate() {
            startingPosition.value = agent.transform.position;
            targetPosition.value = Random.insideUnitSphere * huntRadius + agent.transform.position;
        }

		//Called when the task is disabled.
		protected override void OnStop() {
			
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}