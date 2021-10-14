using Assets.Script.Creatures.Interfase;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemysControl : MonoBehaviour
{

    //   public abstract void InitStats<T>(T t);

    protected  IAtack _AtackHiro;
    protected  IMove _MoveHiro;
    protected  IHP _HPHiro;
    protected  IEnergy _EnergyHiro;
}
