using UnityEngine;

namespace Assets.Script.ScenMeneger.UI
{
    public class MoveAction : MonoBehaviour
    {
        [SerializeField]
        private ETCJoystick left;
        [SerializeField]

        private ETCJoystick right;
       
        internal Transform Hiro;
        [SerializeField]
        private float speedHiro;

        public void Init(int speed)
        {

            speedHiro = speed;

        }
        private void Start()
        {
            right.InitTurnMoveCurve();
        }
        void Update()
        {
            //Hiro.Translate(new Vector3(JoystickMove.instance.H, 0f, JoystickMove.instance.V) * speedHiro / 100 * Time.deltaTime);


            //Hiro.LookAt(transform.position + new Vector3(JoystickRotate.instance.H, 0f, JoystickRotate.instance.V));

            //if (JoystickFire.instance.Fire)
            //{
            //    Debug.Log("fire");
            //}


            Hiro.Translate(new Vector3(left.axisX.axisValue, 0f, left.axisY.axisValue) * speedHiro  * Time.deltaTime);


            //   Hiro.LookAt(transform.position + new Vector3(right.axisX.axisValue* 360, 0f, right.axisY.axisValue* 360));
            //   Hiro.LookAt(transform.position + new Vector3(right.axisX.axisValue* 360, 0f, right.axisY.axisValue* 360));


        }
    }
}