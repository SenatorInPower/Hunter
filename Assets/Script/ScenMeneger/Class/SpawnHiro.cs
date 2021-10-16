using Assets.Script.Creatures.Player.Class;
using Sirenix.OdinInspector;
using System;
using UnityEngine;
public struct StatsHiro
{
    public int HP;
    public int Demage;
    public int Energy;
    public int Speed;
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


   internal void InitUI(AbilityAction UITeleport, AbilityAction UIUlt)
    {
        UIUlt.action += HiroStats.Ult;
        UITeleport.action += HiroStats.Teleport;
    }
  
    //[Button]
   internal void HiroCreate(out GameObject Hiro)
    {

        Hiro = Instantiate(hiroPrefab, PosSpawner);
        HiroControl.InitHiro(Hiro, HiroStats);
        DestroyImmediate(gameObject);

    }
}
