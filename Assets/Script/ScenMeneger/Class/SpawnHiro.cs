using Assets.Script.Creatures.Player.Class;
using Sirenix.OdinInspector;
using System;
using UnityEngine;

public class SpawnHiro : SerializedMonoBehaviour
{
    [SerializeField]
    private GameObject hiroPrefab;
    [SerializeField]
    private Stats HiroStats;
   
    public struct Stats
    {

        public int HP;
        public int Demage;
        public int Energy;
        public int Speed;
        public Transform PosSpawner;
    }

    [Button]

    void SpawnerHiro()
    {
        GameObject Hiro = Instantiate(hiroPrefab, HiroStats.PosSpawner);

        HiroControl.InitHiro(Hiro, HiroStats);

    }
}
