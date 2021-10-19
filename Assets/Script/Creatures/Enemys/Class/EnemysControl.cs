using Assets.Script.Creatures.Enemys.Class;
using Assets.Script.Creatures.Interfase;
using Assets.Script.ScenMeneger.UI;
using EnemysBoll;
using Sirenix.OdinInspector;
using UnityEngine;

public class EnemysControl : SerializedMonoBehaviour /*, IID*/, IHiroStats
{
    private IMove _MoveEnemys;
    public IMove MoveEnemys()
    {
        return _MoveEnemys;
    }

    private IHP _HPEnemys;

    public IHP HPEnemys()
    {
        return _HPEnemys;
    }

    //internal IEnergy _EnergyEnemys;

    private IAtack _AtackEnemys;

    public IAtack AtackEnemys()
    {
        return _AtackEnemys;
    }

    private IAtackAction _AtackAction;
    public IAtackAction AtackAction()
    {
        return _AtackAction;
    }

    public IHiroStats HiroStats()
    {
        return this;
    }
    private EnemysTipe _EnemysTipe;
    public EnemysTipe TipeEnemys { get => _EnemysTipe; set => _EnemysTipe = value; }

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
        enemysMove.Control = this;
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
        enemysAtack.Control = this;

        //enemysAtack._ID = this.ID;

        // _IDEnemys++;
    }

    internal void InitEnemysBlue(GameObject obj, StatsEnemys enemysStats, Transform hiro, UIAction MenuAction)
    {

        EnemysMove enemysMove = obj.AddComponent<EnemysMoveBlue>();
        enemysMove.InitStats(enemysStats.Speed);
        _MoveEnemys = enemysMove;
        enemysMove.Control = this;
       
        // enemysMove._ID = this.ID;

        EnemysHP enemysHP = obj.AddComponent<EnemysHP>();
        enemysHP.InitStats(enemysStats.HP);
        _HPEnemys = enemysHP;
        enemysHP.Dead+=MenuAction.Menu.TextEnemysAdd; //Dead enemys text

        EnemysAtack enemysAtack = obj.AddComponent<EnemysAtackBlue>();
        enemysAtack.InitStats(enemysStats.Demage);
        _AtackEnemys = enemysAtack;
        _AtackAction = enemysAtack as EnemysAtackBlue;
        HiroTransform = hiro;
        MenuAction.UITeleport.action += (enemysAtack as EnemysAtackBlue)._TeleportHiro_();


        BollPull bollPull = obj.GetComponent<BollPull>();
        bollPull.EnemysAtack = enemysAtack;
        bollPull.Init(obj.transform);
        (enemysAtack as EnemysAtackBlue).BollPull = bollPull;
       

        _HPHiro = hiro.gameObject.GetComponent<IHP>();
        _energy = hiro.gameObject.GetComponent<IEnergy>();
        EnergyToHiro = 50;

        enemysAtack.Control = this;

        //enemysAtack._ID = this.ID;

        //  _IDEnemys++;
    }
}
