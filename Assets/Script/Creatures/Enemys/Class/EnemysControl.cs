using Assets.Script.Creatures.Enemys.Class;
using Assets.Script.Creatures.Interfase;
using Sirenix.OdinInspector;
using UnityEngine;

public class EnemysControl : MonoBehaviour/*, IID*/, IHiroStats
{


    internal IMove _MoveEnemys;


    internal IHP _HPEnemys;


    //internal IEnergy _EnergyEnemys;

    internal IAtack _AtackEnemys;


    internal IAtackAction _AtackAction;

    private EnemysTipe _EnemysTipe;
    private EnemysTipe TipeEnemys { get => _EnemysTipe; set => _EnemysTipe = value; }

    #region HiroStats

    private static Transform _hiroMove;
    public Transform HiroTransform { get => _hiroMove; set => _hiroMove = value; }

    private IHP _HPHiro;
    public IHP HPHiro { get => _HPHiro; set => _HPHiro = value; }    

    private IEnergy _energy;
    public IEnergy EnergyHiro { get => _energy; set => _energy = value; }

    internal int EnergyToHiro;

    #endregion

    internal void InitEnemysRed(GameObject obj, StatsEnemys enemysStats, Transform hiro)
    {

        EnemysMove enemysMove = obj.AddComponent<EnemysMoveRed>();
        enemysMove.InitStats(enemysStats.Speed);
        _MoveEnemys = enemysMove;

        // enemysMove._ID = this.ID;

        EnemysHP enemysHP = obj.AddComponent<EnemysHP>();
        enemysHP.InitStats(enemysStats.HP);
        _HPEnemys = enemysHP;


        EnemysAtack enemysAtack = obj.AddComponent<EnemysAtackRed>();
        enemysAtack.InitStats(enemysStats.Demage);
        _AtackEnemys = enemysAtack;
        _AtackAction = enemysAtack as EnemysAtackRed;
        HiroTransform = hiro;

        _HPHiro = hiro.gameObject.GetComponent<IHP>();
        _energy = hiro.gameObject.GetComponent<IEnergy>();
        EnergyToHiro = 15;

        //enemysAtack._ID = this.ID;

        // _IDEnemys++;
    }

    internal void InitEnemysBlue(GameObject obj, StatsEnemys enemysStats, Transform hiro)
    {

        EnemysMove enemysMove = obj.AddComponent<EnemysMoveBlue>();
        enemysMove.InitStats(enemysStats.Speed);
        _MoveEnemys = enemysMove;

        // enemysMove._ID = this.ID;

        EnemysHP enemysHP = obj.AddComponent<EnemysHP>();
        enemysHP.InitStats(enemysStats.HP);
        _HPEnemys = enemysHP;


        EnemysAtack enemysAtack = obj.AddComponent<EnemysAtackBlue>();
        enemysAtack.InitStats(enemysStats.Demage);
        _AtackEnemys = enemysAtack;
        _AtackAction = enemysAtack as EnemysAtackBlue;
        HiroTransform = hiro;

        _HPHiro = hiro.gameObject.GetComponent<IHP>();
        _energy = hiro.gameObject.GetComponent<IEnergy>();
        enemysAtack.EnergyToHiro = 50;
        //enemysAtack._ID = this.ID;

        //  _IDEnemys++;
    }
}
