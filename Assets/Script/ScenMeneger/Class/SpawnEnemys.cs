using Assets.Script.ScenMeneger.UI;
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

    private UIAction UI;
    public void SetUI(UIAction UI)
    {
        this.UI = UI;
    }

    public void InitUI()
    {
        UI.UIUlt.action += DestoryEnemys;
    }

    public void DestoryEnemys(GameObject parical)
    {
        foreach (EnemysControl item in enemysControlsRed)
        {
            item.gameObject.SetActive(false);
        }
        foreach (EnemysControl item in enemysControlsBlue)
        {
            item.gameObject.SetActive(false);
        }
    }

    private static List<EnemysControl> enemysControlsRed;
    private static List<EnemysControl> enemysControlsBlue;

    private int timeSpawnRed = 5;
    private int timeSpawnBlue = 5;
    private WaitForSeconds _waitTimeRed;
    private WaitForSeconds _waitTimeSpawnDelayRed => new WaitForSeconds(1);
    private WaitForSeconds _waitTimeBlue;

    internal int CountRed()
    {
        return enemysControlsRed.Count;
    }
    internal int CountBlue()
    {
        return enemysControlsBlue.Count;
    }
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


    private void Start()
    {
        Spawn();
    }
    private void Init()
    {
        enemysControlsBlue = new List<EnemysControl>();
        enemysControlsRed = new List<EnemysControl>();
    }

    //[Button]
    internal void EnemysCriate(Transform hiro)
    {
        Init();
        InitUI();
        CriateEnemysBlue(hiro);
        CriateEnemysRed(hiro);

    }
    void Spawn()
    {
        StartCoroutine(SpawnBlue());
        StartCoroutine(SpawnRed());
    }
    private void CriateEnemysRed(Transform hiro)
    {
        for (int i = 0; i < enemysSpawnRed.Count; i++)
        {
            GameObject red = Instantiate(enemysSpawnRed.Prefab, enemysSpawnRed.SpawnPos);
            EnemysControl enemysControl = red.AddComponent<EnemysControl>();
            enemysControl.InitEnemysRed(red, enemysRedStats, hiro);
            enemysControlsRed.Add(enemysControl);
            enemysControl.TipeEnemys = EnemysTipe.Red;
            red.SetActive(false);

        }
    }
    private void CriateEnemysBlue(Transform hiro)
    {
        for (int i = 0; i < enemysSpawnBlue.Count; i++)
        {
            GameObject blue = Instantiate(enemysSpawnBlue.Prefab, enemysSpawnBlue.SpawnPos);
            EnemysControl enemysControl = blue.AddComponent<EnemysControl>();
            enemysControl.InitEnemysBlue(blue, enemysBlueStats, hiro, UI);
            enemysControlsBlue.Add(enemysControl);
            enemysControl.TipeEnemys = EnemysTipe.Blue;
            blue.SetActive(false);

        }
    }
    private IEnumerator SpawnRed()
    {
        _waitTimeRed = new WaitForSeconds(timeSpawnRed);
        while (true)
        {
            for (int allEnemys = 0; allEnemys < enemysSpawnRed.Count; allEnemys++)
            {
                for (int spawbEnemys = 0; spawbEnemys < enemysSpawnRed.SpawnCount; spawbEnemys++)
                {
                    enemysControlsRed[allEnemys].transform.position = enemysSpawnRed.SpawnPos.position;
                    enemysControlsRed[allEnemys].gameObject.SetActive(true);
                    yield return _waitTimeSpawnDelayRed;

                }


                yield return _waitTimeRed;

                if (timeSpawnRed >= 2)
                {
                    --timeSpawnRed;
                }
                _waitTimeRed = new WaitForSeconds(timeSpawnRed);
            }

        }
    }

    private IEnumerator SpawnBlue()
    {
        _waitTimeBlue = new WaitForSeconds(5);
        while (true)
        {
            for (int i = 0; i < enemysSpawnBlue.Count; i++)
            {
                enemysControlsBlue[i].transform.position = enemysSpawnBlue.SpawnPos.position;
                enemysControlsBlue[i].gameObject.SetActive(true);

                yield return _waitTimeBlue;

                if (timeSpawnBlue > 2)
                {
                    --timeSpawnBlue;
                }
                _waitTimeBlue = new WaitForSeconds(timeSpawnBlue);
            }
        }
    }
}
