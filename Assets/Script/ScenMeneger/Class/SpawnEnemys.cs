using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;


public enum EnemysTipe
{
    Blue,
    Red
}
public struct EnemysSpawn
{
    public EnemysTipe _EnemysTipe;
    public int _Count;
    public GameObject _Prefab;
    public Transform _SpawnPos;
}
public struct StatsEnemys
{
    public int HP;
    public int Demage;    
    public int Speed;
    
}
public class SpawnEnemys : SerializedMonoBehaviour
{


    public EnemysSpawn enemysSpawnRed;
    public EnemysSpawn enemysSpawnBlue;
    public StatsEnemys enemysRedStats;
    public StatsEnemys enemysBlueStats;
    private List<EnemysControl> enemysControlsRed;
    private List<EnemysControl> enemysControlsBlue;

    [Button]
    void EnemysCriate()
    {
        for (int i = 0; i < enemysSpawnRed._Count; i++)
        {
            GameObject red = Instantiate(enemysSpawnRed._Prefab, enemysSpawnRed._SpawnPos);
            EnemysControl enemysControl = red.AddComponent<EnemysControl>();
            enemysControl.InitEnemys(red, enemysRedStats);
            enemysControlsRed.Add(enemysControl);
        }
        for (int i = 0; i < enemysSpawnBlue._Count; i++)
        {
            GameObject blue = Instantiate(enemysSpawnRed._Prefab, enemysSpawnRed._SpawnPos);
            EnemysControl enemysControl = blue.AddComponent<EnemysControl>();
            enemysControl.InitEnemys(blue, enemysBlueStats);
            enemysControlsBlue.Add(enemysControl);


        }
    }


}
