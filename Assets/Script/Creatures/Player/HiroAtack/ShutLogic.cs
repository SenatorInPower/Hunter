using UnityEngine;

namespace Assets.Script.Creatures.Player.HiroAtack
{
    public partial class PullLogic 
    {

        void Damage(IHP hp)
        {
            atackHiro.Atack(hp);
        }

    }
}