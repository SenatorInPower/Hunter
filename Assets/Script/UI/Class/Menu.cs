using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField]
    private Image endPanel;
    [SerializeField]
    internal Button Start;
    [SerializeField]
    internal Button Restart;

    [SerializeField]
    private Color panelColorStart;
    [SerializeField]
    private Color panelColorInGame;
    [SerializeField]
    private Color panelColorEnd;
    [SerializeField]
    private TextMeshProUGUI TextEnemys;
    [SerializeField]
    private GameObject rootEnd;

   private int _countDeadEnemys;
    private void Awake()
    {
        //lose.onClick.AddListener(EndGame);
        //startGame.onClick.AddListener(StartGame);
        Restart.onClick.AddListener(RestartGame);
    }

   public void RestartGame()
    {
        endPanel.DOColor(panelColorInGame, 1).OnComplete(() => {/*rootEnd.SetActive(false);*/ SceneManager.LoadScene(SceneManager.GetActiveScene().name); });

    }
    public void  StartGame()
    {
      //  endPanel.DOColor(panelColorStart, 1).OnComplete(() => { Start.gameObject.SetActive(true); });

    }
    public void EndGame()
    {
        endPanel.DOColor(panelColorEnd, 2).OnComplete(() => { rootEnd.SetActive(true); });
    }
   
   public void TextEnemysAdd()
    {
        ++_countDeadEnemys;
        TextEnemys.text= _countDeadEnemys.ToString();
    }
}
