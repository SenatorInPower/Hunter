using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField]
    private Image endPanel;
    [SerializeField]
    internal Button startGame;
    [SerializeField]
    private Button lose;

    [SerializeField]
    private Color panelColorStart;
    private Color panelColorEnd;
    private void Awake()
    {
        lose.onClick.AddListener(EndGame);

    }

    public  void EndGame()
    {
        endPanel.DOColor(panelColorEnd, 2).OnComplete(()=>lose.gameObject.SetActive(true));
    }
    
   void  StartGame()
    {
        endPanel.DOColor(panelColorEnd, 2).OnComplete(() => startGame.gameObject.SetActive(true));

    }
}
