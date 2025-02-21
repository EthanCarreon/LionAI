using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class AT_Idle : ActionTask {
        public float timer;
        public float maxWaitTime;

		public BBParameter<GameObject> idleIcon;
		public BBParameter<float> hunger;

        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit() {
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
			idleIcon.value.SetActive(true);
        }

		//Called once per frame while the action is active.
		protected override void OnUpdate() {
            timer += Time.deltaTime;
			hunger.value -= Time.deltaTime / 2;

            if (timer >= maxWaitTime)
            {
                timer = 0;
				idleIcon.value.SetActive(false);
				EndAction(true);
            }
        }

		//Called when the task is disabled.
		protected override void OnStop() {
			
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}