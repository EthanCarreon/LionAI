using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class AT_Eat : ActionTask {
		public BBParameter<float> hunger;
		public BBParameter<GameObject> attackIcon;
        public BBParameter<float> eatTimer;
		public BBParameter<GameObject> prey;

        public BBParameter<float> defenseTimer;

        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit() {
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {

            defenseTimer.value = 0;
			hunger.value += 5;
            attackIcon.value.SetActive(false);
            prey.value.SetActive(false);
        }

		//Called once per frame while the action is active.
		protected override void OnUpdate() {

		}

		//Called when the task is disabled.
		protected override void OnStop() {
			eatTimer.value = 0;
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}