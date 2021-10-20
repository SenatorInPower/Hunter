using UnityEngine;
namespace Assets.Script.ScenMeneger.UI
{
    public class UIAction : MonoBehaviour
    {
        public AbilityAction UITeleport;
        public AbilityAction UIUlt;
        public MoveAction MoveAction;
        public ShutAction ShutAction;
        public Menu Menu;

        public void  DeadAction()
        {
            Menu.EndGame();
        }
    }
}