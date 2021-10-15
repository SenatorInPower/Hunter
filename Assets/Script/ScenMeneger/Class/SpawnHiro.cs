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
    public Action<GameObject> Ultimate;
    public Action<Transform> Teleport;
}
public  class SpawnHiro: SerializedMonoBehaviour
{
    public Ability AbilityHiro;
    

    [InfoBox("Select Stats value.", InfoMessageType.Info)]

    [SerializeField]
    private Transform PosSpawner;
    [SerializeField]
    private GameObject hiroPrefab;
    [SerializeField]
    private StatsHiro HiroStats;
   
    

    [Button]
    void HiroCreate()
    {
        HiroStats.Ultimate = AbilityHiro._Ultimate;
        HiroStats.Teleport = AbilityHiro._Teleportation;
        GameObject Hiro = Instantiate(hiroPrefab, PosSpawner);
        HiroControl.InitHiro(Hiro, HiroStats);
        DestroyImmediate(gameObject);

    }
}
