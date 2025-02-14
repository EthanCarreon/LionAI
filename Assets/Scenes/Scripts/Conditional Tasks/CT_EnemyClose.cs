using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions {

	public class CT_EnemyClose : ConditionTask {

		public Transform enemy;
        public BBParameter<GameObject> idleIcon;
        public BBParameter<GameObject> sleep;
        public float enemyReach;

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

			float distance = Vector3.Distance(agent.transform.position, enemy.transform.position);

			if (distance <= enemyReach)
			{
                idleIcon.value.SetActive(false);
                sleep.value.SetActive(false);

                return true;
            }
			else
			{
				return false;
			}
		}
	}
}