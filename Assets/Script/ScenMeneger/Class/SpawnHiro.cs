using Assets.Script.Creatures.Player.Class;
using Sirenix.OdinInspector;
using UnityEngine;

public class SpawnHiro : SerializedMonoBehaviour
{
    public GameObject hiroPrefab;
    public Stats HiroStats;
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
