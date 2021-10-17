using Assets.Script.Creatures.Enemys.Class;
using Assets.Script.Creatures.Interfase;
using UnityEngine;

public class EnemysControl : MonoBehaviour/*, IID*/
{

    //   public abstract void InitStats<T>(T t);
    internal IMove _MoveEnemys;
    internal IHP _HPEnemys;
    internal IEnergy _EnergyEnemys;
    internal IAtack _AtackEnemys;
    internal IHiroTransform _HiroTransform;
    internal IAtackAction _AtackAction;
    //private int _IDEnemys;
    //public int ID { get => _IDEnemys; set => _IDEnemys = value; }
    private EnemysTipe _EnemysTipe;
    public EnemysTipe TipeEnemys { get => _EnemysTipe; set => _EnemysTipe = value; }

    internal void InitEnemysRed(GameObject obj, StatsEnemys enemysStats, Transform hiro)
    {
        
        EnemysMove enemysMove = obj.AddComponent<EnemysMoveRed>();
        enemysMove.InitStats(enemysStats.Speed);
        _MoveEnemys = enemysMove;
        enemysMove.HiroTransform = hiro;
        _HiroTransform = enemysMove;
        // enemysMove._ID = this.ID;

        EnemysHP enemysHP = obj.AddComponent<EnemysHP>();
        enemysHP.InitStats(enemysStats.HP);
        _HPEnemys = enemysHP;

        EnemysAtack enemysAtack = obj.AddComponent<EnemysAtackRed>();
        enemysAtack.InitStats(enemysStats.Demage);
        _AtackEnemys = enemysAtack;
        _AtackAction = enemysAtack as EnemysAtackRed;
       
        //enemysAtack._ID = this.ID;

        // _IDEnemys++;
    }

    internal void InitEnemysBlue(GameObject obj, StatsEnemys enemysStats, Transform hiro)
    {

        EnemysMove enemysMove = obj.AddComponent<EnemysMoveBlue>();
        enemysMove.InitStats(enemysStats.Speed);
        _MoveEnemys = enemysMove;
        enemysMove.HiroTransform = hiro;
        _HiroTransform = enemysMove;
        // enemysMove._ID = this.ID;

        EnemysHP enemysHP = obj.AddComponent<EnemysHP>();
        enemysHP.InitStats(enemysStats.HP);
        _HPEnemys = enemysHP;

        EnemysAtack enemysAtack = obj.AddComponent<EnemysAtackBlue>();
        enemysAtack.InitStats(enemysStats.Demage);
        _AtackEnemys = enemysAtack;
        _AtackAction = enemysAtack as EnemysAtackBlue;

        //enemysAtack._ID = this.ID;

        //  _IDEnemys++;
    }
}
