using Assets.Script.Creatures.Player.Class;
using Assets.Script.ScenMeneger.Class;
using Sirenix.OdinInspector;
using System;
using UnityEngine;
public struct StatsHiro
{
    public int HP;
    public int Demage;
    public int Energy;
    public int Speed;
    internal Transform targetShutPoint;
    internal Action Shut;
    internal Action<GameObject> Teleport;
    internal Action<GameObject> Ult;

}
public class SpawnHiro : SerializedMonoBehaviour
{
    [InfoBox("Select Stats value.", InfoMessageType.Info)]

    [SerializeField]
    private Transform PosSpawner;
    [SerializeField]
    private GameObject hiroPrefab;
    [SerializeField]
    private StatsHiro HiroStats;


    internal void InitUI(AbilityAction UITeleport, AbilityAction UIUlt, MoveAction moveAction, ShutAction ShutAction)
    {
        UIUlt.action += HiroStats.Ult;
        UITeleport.action += HiroStats.Teleport;
        moveAction.Init(HiroStats.Speed);
        HiroStats.targetShutPoint = ShutAction.ShutPoint;
        HiroStats.Shut = ShutAction.ShutButton;
    }

    //[Button]
    internal void HiroCreate(out GameObject Hiro)
    {

        Hiro = Instantiate(hiroPrefab, PosSpawner);
        HiroControl.InitHiro(Hiro, HiroStats);
        DestroyImmediate(gameObject);

    }
}
