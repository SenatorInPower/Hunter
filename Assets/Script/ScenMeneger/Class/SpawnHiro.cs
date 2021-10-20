using Assets.Script.Creatures.Player.Class;
using Assets.Script.Creatures.Player.HiroAtack;
using Assets.Script.ScenMeneger.Class;
using Assets.Script.ScenMeneger.UI;
using Cinemachine;
using Sirenix.OdinInspector;
using System;
using UnityEngine;
using UnityEngine.Events;

public struct StatsHiro
{
    public int HP;
    public int Demage;
    public int Energy;
    public int Speed;
    

}
public class SpawnHiro : SerializedMonoBehaviour
{

    [SerializeField]
    private CinemachineVirtualCamera virtualCamera;
    [InfoBox("Select Stats value.", InfoMessageType.Info)]

    [SerializeField]
    private Transform PosSpawner;
    [SerializeField]
    private GameObject hiroPrefab;
    [SerializeField]
    private StatsHiro HiroStats;
   
    private UIAction UI;
    public void SetUI(UIAction UI)
    {
        this.UI = UI;
    }
    //internal void InitUI(AbilityAction UITeleport, AbilityAction UIUlt, MoveAction moveAction, ShutAction ShutAction)
    //{
    //    UIUlt.action += HiroStats.Ult;
    //    UITeleport.action += HiroStats.Teleport;
    //    moveAction.Init(HiroStats.Speed);
    //    ShutAction.InitShut(HiroStats.Shut);
    //    HiroStats.targetShutPoint = ShutAction.ShutPoint;

    //}
    internal void InitCamera(Transform hiro)
    {
        //virtualCamera.LookAt = hiro;
        //virtualCamera.Follow = hiro;
        //CinemachineTransposer cinemashin = virtualCamera.GetCinemachineComponent<CinemachineTransposer>();
        //cinemashin.m_BindingMode = CinemachineTransposer.BindingMode.LockToTargetWithWorldUp;
        //// cinemashin.m_FollowOffset = new Vector3(0f, 0.5f, -1.3f);
        // cinemashin.m_FollowOffset = new Vector3(0f, -0.08f, -0.80f);

        virtualCamera.LookAt = hiro;
        virtualCamera.Follow = hiro;
        Cinemachine3rdPersonFollow cinemashin = virtualCamera.GetCinemachineComponent<Cinemachine3rdPersonFollow>();

        cinemashin.ShoulderOffset = new Vector3(0f, -0.22f, -0.16f);
    }
    //[Button]
    internal void HiroCreate(out GameObject Hiro)
    {

        Hiro = Instantiate(hiroPrefab, PosSpawner);
        PullLogic pullLogic = Hiro.GetComponent<PullLogic>();
        HiroControl.InitHiro(Hiro, HiroStats, pullLogic, UI);


    }
}
