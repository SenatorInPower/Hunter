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
    
}
public class SpawnHiro : SerializedMonoBehaviour
{
    [SerializeField]
    private Transform PosSpawner;
    [SerializeField]
    private GameObject hiroPrefab;
    [SerializeField]
    private StatsHiro HiroStats;
   
    

    [Button]
    void HiroCreate()
    {
        GameObject Hiro = Instantiate(hiroPrefab, PosSpawner);
        HiroControl.InitHiro(Hiro, HiroStats);
        DestroyImmediate(gameObject);

    }
}
