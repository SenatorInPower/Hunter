using Sirenix.OdinInspector;
using Sirenix.Serialization;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
    public int SpawnCount;
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
    [NonSerialized, OdinSerialize]
    private EnemysSpawn enemysSpawnRed;
    [NonSerialized, OdinSerialize]
    private EnemysSpawn enemysSpawnBlue;
    [NonSerialized, OdinSerialize]
    private StatsEnemys enemysRedStats;
    [NonSerialized, OdinSerialize]
    private StatsEnemys enemysBlueStats;


    private static List<EnemysControl> enemysControlsRed;
    private static List<EnemysControl> enemysControlsBlue;

    private int timeSpawnBlue = 5;
    private int timeSpawnRed = 5;
    private WaitForSeconds _waitTimeBlue;
    private WaitForSeconds _waitTimeSpawnDelayBlue => new WaitForSeconds(1);
    private WaitForSeconds _waitTimeRed;

    internal List<EnemysControl> EnemysControlsRed()
    {
        return enemysControlsRed;
    }
    internal List<EnemysControl> EnemysControlsBlue()
    {
        return enemysControlsBlue;
    }
    internal static EnemysControl EnemysRedToIndex(int index)
    {
        return enemysControlsRed[index] != null ? enemysControlsRed[index] : null;

    }
    internal static EnemysControl EnemyBlueToIndex(int index)
    {
        return enemysControlsBlue[index] != null ? enemysControlsBlue[index] : null;
    }
    internal static Transform AtackNearestRed(Vector3 from)
    {
        //  RaycastHit[] rhit = Physics.BoxCastAll(transform.position, Vector3.one * 7);
        Transform enemys = enemysControlsRed.Where(t => t.gameObject.activeInHierarchy).OrderBy(t => Vector3.Distance(from, t.transform.position)).FirstOrDefault().transform;

        if (enemys)
        {
            return enemys;
        }
        else
        {
            return null;
        }

    }
    internal static Transform AtackNearestBlue(Vector3 from)
    {
        //  RaycastHit[] rhit = Physics.BoxCastAll(transform.position, Vector3.one * 7);
        Transform enemys = enemysControlsBlue.Where(t => t.gameObject.activeInHierarchy).OrderBy(t => Vector3.Distance(from, t.transform.position)).FirstOrDefault().transform;

        if (enemys)
        {
            return enemys;
        }
        else
        {
            return null;
        }

    }
  
    private void Awake()
    {
        Init();
        EnemysCriate();
    }
    private void Start()
    {
        Spawn();
    }
    private void Init()
    {
        enemysControlsRed = new List<EnemysControl>();
        enemysControlsBlue = new List<EnemysControl>();
    }

    [Button]
    private void EnemysCriate()
    {
        CriateEnemysBlue();
        CriateEnemysRed();
    }
    void Spawn()
    {
        StartCoroutine(SpawnBlue());
        StartCoroutine(SpawnRed());
    }
    private void CriateEnemysBlue()
    {
        for (int i = 0; i < enemysSpawnBlue.Count; i++)
        {
            GameObject blue = Instantiate(enemysSpawnBlue.Prefab, enemysSpawnBlue.SpawnPos);
            EnemysControl enemysControl = blue.AddComponent<EnemysControl>();
            enemysControl.InitEnemys(blue, enemysBlueStats);
            enemysControlsBlue.Add(enemysControl);
            enemysControl.TipeEnemys = EnemysTipe.Blue;
            blue.SetActive(false);

        }
    }
    private void CriateEnemysRed()
    {
        for (int i = 0; i < enemysSpawnRed.Count; i++)
        {
            GameObject red = Instantiate(enemysSpawnRed.Prefab, enemysSpawnRed.SpawnPos);
            EnemysControl enemysControl = red.AddComponent<EnemysControl>();
            enemysControl.InitEnemys(red, enemysRedStats);
            enemysControlsRed.Add(enemysControl);
            enemysControl.TipeEnemys = EnemysTipe.Red;

            red.SetActive(false);

        }
    }
    private IEnumerator SpawnBlue()
    {
        _waitTimeBlue = new WaitForSeconds(timeSpawnBlue);
        while (true)
        {
            for (int allEnemys = 0; allEnemys < enemysSpawnBlue.Count; allEnemys++)
            {
                for (int spawbEnemys = 0; spawbEnemys < enemysSpawnBlue.SpawnCount; spawbEnemys++)
                {
                    enemysControlsBlue[allEnemys].transform.position = enemysSpawnBlue.SpawnPos.position;
                    enemysControlsBlue[allEnemys].gameObject.SetActive(true);
                    yield return _waitTimeSpawnDelayBlue;

                }


                yield return _waitTimeBlue;

                if (timeSpawnBlue >= 2)
                {
                    --timeSpawnBlue;
                }
                _waitTimeBlue = new WaitForSeconds(timeSpawnBlue);
            }
          
        }
    }

    private IEnumerator SpawnRed()
    {
        _waitTimeRed = new WaitForSeconds(5);
        while (true)
        {
            for (int i = 0; i < enemysSpawnRed.Count; i++)
            {
                enemysControlsRed[i].transform.position = enemysSpawnRed.SpawnPos.position;
                enemysControlsRed[i].gameObject.SetActive(true);

                yield return _waitTimeRed;

                if (timeSpawnRed > 2)
                {
                    --timeSpawnRed;
                }
                _waitTimeBlue = new WaitForSeconds(timeSpawnRed);
            }
        }
    }
}
