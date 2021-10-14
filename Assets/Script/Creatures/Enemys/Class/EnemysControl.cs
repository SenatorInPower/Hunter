using Assets.Script.Creatures.Interfase;
using Assets.Script.Creatures.Player.Class;
using UnityEngine;
using static SpawnHiro;

public class EnemysControl : MonoBehaviour
{

    //   public abstract void InitStats<T>(T t);
    private IMove _MoveEnemys;  
    private IHP _HPEnemys;
    private IEnergy _EnergyEnemys;
    private IAtack _AtackEnemys;

    internal void InitEnemys(GameObject obj, StatsEnemys enemysStats)
    {


        EnemysMove enemysMove = obj.AddComponent<EnemysMove>();
        enemysMove.InitStats(enemysStats.Speed);
        _MoveEnemys = enemysMove;

        EnemysHP enemysHP = obj.AddComponent<EnemysHP>();
        enemysHP.InitStats(enemysStats.HP);
        _HPEnemys = enemysHP;

        EnemysAtack enemysAtack = obj.AddComponent<EnemysAtack>();
        enemysAtack.InitStats(enemysStats.Demage);
        _AtackEnemys = enemysAtack;


    }
}
