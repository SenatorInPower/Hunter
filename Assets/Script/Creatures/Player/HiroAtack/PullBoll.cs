using Assets.Script.Creatures.Interfase;
using Assets.Script.Creatures.Player.Class;
using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullBoll: SerializedMonoBehaviour
{
    public GameObject Boll;
    public HiroAtack atackHiro;
    public int BollCount = 10;
    private List<GameObject> pull;
    private void Awake()
    {
        for (int i = 0; i < BollCount; i++)
        {
            GameObject Bools = Instantiate(Boll, atackHiro.transform);
            pull.Add(Bools);
            Bools.SetActive(false);
            Boll objectBoll= Bools.GetComponent<Boll>();
            objectBoll.Damage = atackHiro.DamageGive;
            objectBoll.BollCollision += Damage;

        }

    }

    void Damage(IHP hp)
    {
        atackHiro.AtackOut(hp);
    }
}
