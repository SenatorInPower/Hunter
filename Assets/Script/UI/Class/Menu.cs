using DG.Tweening;
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
        if (Time.timeScale==1)
        {
            endPanel.DOColor(panelColorInGame, 1).OnComplete(() => {/*rootEnd.SetActive(false);*/ SceneManager.LoadScene(SceneManager.GetActiveScene().name); });
        }
        else
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    public void StartGame()
    {
        //  endPanel.DOColor(panelColorStart, 1).OnComplete(() => { Start.gameObject.SetActive(true); });

    }
    public void EndGame()
    {
        endPanel.DOColor(panelColorEnd, 2).OnComplete(() => { rootEnd.SetActive(true); });
    }
    private bool controlPause = true;
    public void GamePause()
    {
        rootEnd.SetActive(controlPause);
        Time.timeScale = controlPause == true ? Time.timeScale = 0 : Time.timeScale = 1;
        controlPause = !controlPause;

    }
    public void TextEnemysAdd()
    {
        ++_countDeadEnemys;
        TextEnemys.text = _countDeadEnemys.ToString();
    }
}
