using Assets.Script.Creatures.Interfase;
using UnityEngine;

public class EnemysControl : MonoBehaviour, IID
{

    //   public abstract void InitStats<T>(T t);
    internal IMove _MoveEnemys;
    internal IHP _HPEnemys;
    internal IEnergy _EnergyEnemys;
    internal IAtack _AtackEnemys;
    private int _IDEnemys;
    public int ID { get => _IDEnemys; set => _IDEnemys = value; }
    private EnemysTipe _EnemysTipe;
    public EnemysTipe TipeEnemys { get => _EnemysTipe; set => _EnemysTipe = value; }

    internal void InitEnemys(GameObject obj, StatsEnemys enemysStats)
    {

        EnemysMove enemysMove = obj.AddComponent<EnemysMove>();
        enemysMove.InitStats(enemysStats.Speed);
        _MoveEnemys = enemysMove;
        // enemysMove._ID = this.ID;

        EnemysHP enemysHP = obj.AddComponent<EnemysHP>();
        enemysHP.InitStats(enemysStats.HP);
        _HPEnemys = enemysHP;

        EnemysAtack enemysAtack = obj.AddComponent<EnemysAtack>();
        enemysAtack.InitStats(enemysStats.Demage);
        _AtackEnemys = enemysAtack;
        enemysAtack.EnemysHP = enemysHP;
        //enemysAtack._ID = this.ID;

        _IDEnemys++;
    }
}
