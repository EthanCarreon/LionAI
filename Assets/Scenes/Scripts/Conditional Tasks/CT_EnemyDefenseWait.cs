using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions {

	public class CT_EnemyDefenseWait : ConditionTask {

		public BBParameter<float> defenseTimer;
		public float timeUntilAttack;
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
			defenseTimer.value += Time.deltaTime;

			if (defenseTimer.value >= timeUntilAttack)
			{
                return true;
            }
			else
			{
				return false;
			}
		}
	}
}