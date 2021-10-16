using GeekGame.Input;
using System.Collections;
using UnityEngine;

namespace Assets.Script.ScenMeneger.Class
{
    public class MoveAction : MonoBehaviour
    {
		internal Transform Hiro;
		private float speedHiro;
      
		public void Init(int speed)
        {
		
			speedHiro = speed;

		}
        void Update()
		{
			Hiro.Translate(new Vector3(JoystickMove.instance.H, 0f, JoystickMove.instance.V) * speedHiro * Time.deltaTime);


			Hiro.LookAt(transform.position + new Vector3(JoystickRotate.instance.H, 0f, JoystickRotate.instance.V));

			if (JoystickFire.instance.Fire)
			{
				Debug.Log("fire");
			}
		}
	}
}