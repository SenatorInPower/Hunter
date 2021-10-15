using Assets.Script.Creatures.Interfase;
using DG.Tweening;
using System;
using System.Collections;
using UnityEngine;

public class EnemysMove : MonoBehaviour, IMove, IInit
{

    public CapsuleCollider Collider;
    private int _speed;
    public int Speed { get => _speed; set => _speed = value; }
    //internal IID _ID;

    private void Awake()
    {
        Collider = gameObject.GetComponent<CapsuleCollider>();

        if (Collider == null)
        {
            gameObject.AddComponent<CapsuleCollider>().isTrigger = true;
            Collider = gameObject.GetComponent<CapsuleCollider>();
        }
        Collider.isTrigger = true;
    }
    public void InitStats<T>(T t)
    {
        _speed = Convert.ToInt32(t);
    }

    void MovePatchToHiro(Transform hiroPos)
    {
        int hightFlie = UnityEngine.Random.Range(6, 10);
        transform.DOMove(ControlerLevel.RandomLevelPosition() + Vector3.up * hightFlie, 3).OnComplete(() => { StartCoroutine(ToHiro(hiroPos)); });
    }
 
    
    IEnumerator ToHiro(Transform hiroPos)
    {
        while (true)
        {
            transform.position = Vector3.Lerp(transform.position, hiroPos.position, Time.deltaTime);
            yield return null;
        }
    }
    void Dead()
    {
        print("Dead");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == ControlerLevel.NameTagHiro)
        {
            gameObject.SetActive(false);
            Dead();
        }
    }
}
