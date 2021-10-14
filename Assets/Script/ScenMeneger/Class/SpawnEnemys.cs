using Sirenix.OdinInspector;
using Sirenix.Serialization;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum EnemysTipe
{
    Blue,
    Red
}
public struct EnemysSpawn
{
    public EnemysTipe EnemysTipe;
    public int Count;
    public GameObject Prefab;
    public Transform SpawnPos;
}
public struct StatsEnemys
{
    public int HP;
    public int Demage;
    public int Speed;

}
public class SpawnEnemys : SerializedMonoBehaviour
{

    [InfoBox("Select Spawn and Stats value.", InfoMessageType.Info)]
    public EnemysSpawn enemysSpawnRed;
    public EnemysSpawn enemysSpawnBlue;

    public StatsEnemys enemysRedStats;
    public StatsEnemys enemysBlueStats;


    private static List<EnemysControl> enemysControlsRed;
    private static List<EnemysControl> enemysControlsBlue;




    private WaitForSeconds _waitTimeBlue=>new WaitForSeconds(5);
    private WaitForSeconds _waitTimeRed=>new WaitForSeconds(5);
    private void Awake()
    {
        enemysControlsRed = new List<EnemysControl>();
        enemysControlsBlue = new List<EnemysControl>();
    }
    void Init()
    {

    }
    [Button]
  
    void EnemysCriate()
    {
        StartCoroutine(SpawnBlue());
        StartCoroutine(SpawnRed());
    }

    IEnumerator SpawnBlue()
    {
        while (true)
        {
            
            for (int i = 0; i < enemysSpawnBlue.Count; i++)
            {
                GameObject blue = Instantiate(enemysSpawnBlue.Prefab, enemysSpawnBlue.SpawnPos);
                EnemysControl enemysControl = blue.AddComponent<EnemysControl>();
                enemysControl.InitEnemys(blue, enemysBlueStats);
                enemysControlsBlue.Add(enemysControl);
                print(enemysControlsRed.Count);
                yield return _waitTimeBlue;

            }
          
        }
    }

    IEnumerator SpawnRed()
    {
        while (true)
        {
            for (int i = 0; i < enemysSpawnRed.Count; i++)
            {
                GameObject red = Instantiate(enemysSpawnRed.Prefab, enemysSpawnRed.SpawnPos);
                EnemysControl enemysControl = red.AddComponent<EnemysControl>();
                enemysControl.InitEnemys(red, enemysRedStats);
                enemysControlsRed.Add(enemysControl);
                print(enemysControlsBlue.Count);
                yield return _waitTimeRed;
               
            }
       


        }
    }
}
