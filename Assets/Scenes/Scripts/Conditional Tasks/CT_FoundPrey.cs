using System.Collections.Generic;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions {

	public class CT_FoundPrey : ConditionTask {

		public float preyDist;

        public BBParameter<Transform> prey;

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

			// check distance between lion and prey
			float distanceToPrey = Vector3.Distance(agent.transform.position, prey.value.transform.position);

            if (distanceToPrey <= preyDist)
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