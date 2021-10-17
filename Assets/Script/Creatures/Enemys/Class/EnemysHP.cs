using Assets.Script.Creatures.Interfase;
using System;
using UnityEngine;

public class EnemysHP : MonoBehaviour, IHP, IInit
{
    internal GameObject effectDead;
    private int _HP;
    public int HP { get => _HP; set { _HP = value; if (_HP < 1) { _dead.Invoke(); } } }

    private int _MaxHP;
    public int MaxHP { get => _MaxHP; }

    private Action _dead;
    public Action Dead { get => _dead; set => _dead = value; }

    public void InitStats<T>(T t)
    {
        _HP = Convert.ToInt32(t);
        _MaxHP = _HP;
    }
    private void OnEnable()
    {
        _dead += DeadEffect;
    }
    private void OnDisable()
    {
        _dead -= DeadEffect;

    }
    void DeadEffect()
    {
        if (effectDead)
        {
            Instantiate(effectDead, transform.position, Quaternion.identity);
        }
        gameObject.SetActive(false);
    }
}
