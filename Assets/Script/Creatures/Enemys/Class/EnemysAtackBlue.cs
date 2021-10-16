using DG.Tweening;
using System;
using System.Collections;
using UnityEngine;

namespace Assets.Script.Creatures.Enemys.Class
{ //атака перенесена в enemysmoveblue из за связи атаки с движением
    public class EnemysAtackBlue : EnemysAtack
    {
        public Action<GameObject> TeleportHiro;

    }
}