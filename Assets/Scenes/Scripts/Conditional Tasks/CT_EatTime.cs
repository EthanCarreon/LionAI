using System.Collections.Generic;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions {

	public class CT_EatTime : ConditionTask {

		public BBParameter<float> eatTimer;
		public BBParameter<bool> readyToAttack;
		public float maxTimeEat;

        public BBParameter<Vector3> targetPosition;
		public BBParameter<Transform> prey;
		public BBParameter<GameObject> eatIcon;
		public BBParameter<GameObject> attackIcon;

		public float distanceToPrey;
        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit(){
			return null;
		}

		//Called whenever the condition gets enabled.
		protected override void OnEnable() {
			
		}

		//Called whenever the condition gets disabled.
		protected override void OnDisable() {
			
		}

		//Called once per frame while the condition is active.
		//Return whether the condition is success or failure.
		protected override bool OnCheck() {

			float distance = Vector3.Distance(agent.transform.position, prey.value.transform.position);
			
			if (distance <= distanceToPrey)
			{
				eatIcon.value.SetActive(true);
				attackIcon.value.SetActive(false);
				readyToAttack.value = true;
			}

			if (readyToAttack.value == true)
			{
                eatTimer.value += Time.deltaTime;
            }

			if (eatTimer.value >= maxTimeEat)
			{
				readyToAttack.value = false;
                return true;
            }
			else
			{
				return false;
			}
		}
	}
}