using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions {

	public class CT_EnemyDefenseWait : ConditionTask {

		public float timer;
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
			timer += Time.deltaTime;

			if (timer >= timeUntilAttack)
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