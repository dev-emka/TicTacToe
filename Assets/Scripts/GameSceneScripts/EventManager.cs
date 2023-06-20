using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using UnityEngine.UI;


public class EventManager : MonoBehaviour
{
    public  GameManager gameManager;
    public GameObject gameScreen, winnerScreen,MenuBtn,exitbtn;
    public List<GameObject> btn = new List<GameObject>();
    public List<Text> btnTxt = new List<Text>();
    string winner;
    string player;
    [SerializeField]
    Text quitsTxt;

    [SerializeField]
    GameObject whoTxt;
    void Start()
    {
        gameManager = Object.FindObjectOfType<GameManager>();
    }


    void Update()
    {
        player = gameManager.player;
        
    }

    public void ClickEvent()
    {
        whoTxt.transform.DOLocalMoveY(415, 0.4f).SetLoops(2, LoopType.Yoyo);

        UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.transform.GetChild(0).GetComponent<Text>().text = gameManager.player;
        UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.transform.GetChild(0).DOScale(1.25f, 0.5f).SetLoops(2,LoopType.Yoyo);
        CheckWinner();
        
        UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.GetComponent<Button>().interactable = false;
        IsQuits();
        if (gameManager.random == 0)
        {
            gameManager.random = 1;
        }else if (gameManager.random == 1)
        {
            gameManager.random = 0;
        }
        
    }

    public void CheckWinner()
    {

        if (btnTxt[0].text == player && btnTxt[1].text == player && btnTxt[2].text == player)
        {
            winner = btnTxt[0].text;

            quitsTxt.text = "WINNER" + "\n" + "PLAYER" + winner;
            gameScreen.GetComponent<CanvasGroup>().DOFade(0.22f, 0.5f);
            winnerScreen.SetActive(true);
            winnerScreen.GetComponent<CanvasGroup>().DOFade(1, 0.35f);
            
        }

        if (btnTxt[0].text == player && btnTxt[3].text == player && btnTxt[6].text == player)
        {
            winner = btnTxt[0].text;

            quitsTxt.text = "WINNER" + "\n" + "PLAYER" + winner;
            gameScreen.GetComponent<CanvasGroup>().DOFade(0.22f, 0.5f);
            winnerScreen.SetActive(true);
            winnerScreen.GetComponent<CanvasGroup>().DOFade(1, 0.35f);

        }

        if (btnTxt[0].text == player && btnTxt[4].text == player && btnTxt[8].text == player)
        {
            winner = btnTxt[0].text;

            quitsTxt.text = "WINNER" + "\n" + "PLAYER" + winner;
            gameScreen.GetComponent<CanvasGroup>().DOFade(0.22f, 0.5f);
            winnerScreen.SetActive(true);
            winnerScreen.GetComponent<CanvasGroup>().DOFade(1, 0.35f);

        }

        if (btnTxt[1].text == player && btnTxt[4].text == player && btnTxt[7].text == player)
        {
            winner = btnTxt[1].text;

            quitsTxt.text = "WINNER" + "\n" + "PLAYER" + winner;
            gameScreen.GetComponent<CanvasGroup>().DOFade(0.22f, 0.5f);
            winnerScreen.SetActive(true);
            winnerScreen.GetComponent<CanvasGroup>().DOFade(1, 0.35f);

        }

        if (btnTxt[2].text == player && btnTxt[5].text == player && btnTxt[8].text == player)
        {
            winner = btnTxt[2].text;

            quitsTxt.text = "WINNER" + "\n" + "PLAYER" + winner;
            gameScreen.GetComponent<CanvasGroup>().DOFade(0.22f, 0.5f);
            winnerScreen.SetActive(true);
            winnerScreen.GetComponent<CanvasGroup>().DOFade(1, 0.35f);
        }

        if (btnTxt[2].text == player && btnTxt[4].text == player && btnTxt[6].text == player)
        {
            winner = btnTxt[2].text;

            quitsTxt.text = "WINNER" + "\n" + "PLAYER" + winner;
            gameScreen.GetComponent<CanvasGroup>().DOFade(0.22f, 0.5f);
            winnerScreen.SetActive(true);
            winnerScreen.GetComponent<CanvasGroup>().DOFade(1, 0.35f);

        }

        if (btnTxt[5].text == player && btnTxt[4].text == player && btnTxt[3].text == player)
        {
            winner = btnTxt[3].text;

            quitsTxt.text = "WINNER" + "\n" + "PLAYER" + winner;
            gameScreen.GetComponent<CanvasGroup>().DOFade(0.22f, 0.5f);
            winnerScreen.SetActive(true);
            winnerScreen.GetComponent<CanvasGroup>().DOFade(1, 0.35f);

        }

        if (btnTxt[8].text == player && btnTxt[7].text == player && btnTxt[6].text == player)
        {
            winner = btnTxt[7].text;
            quitsTxt.text = "WINNER" + "\n" + "PLAYER" + winner;
            gameScreen.GetComponent<CanvasGroup>().DOFade(0.22f, 0.5f);
            winnerScreen.SetActive(true);
            winnerScreen.GetComponent<CanvasGroup>().DOFade(1, 0.35f);

        }

        Debug.Log(winner);

    }
    
    public void MenuBtnDown()
    {
        
        MenuBtn.transform.GetChild(0).DOScale(1.25f, 0.65f);
        
    }

    public void MenuBtnUp()
    {
        MenuBtn.transform.GetChild(0).DOScale(1f, 0.65f);
        
    }

    
    public void ExitBtnDown()
    {
        exitbtn.transform.GetChild(0).DOScale(1.25f, 0.65f);
        
    }
    
    public void ExitBtnUp()
    {
        exitbtn.transform.GetChild(0).DOScale(1f, 0.65f);
        
    }

    public void MenuGame()
    {
        SceneManager.LoadScene(0);
    }

    public void ExitGame()
    {
        Application.OpenURL("www.instagram.com/dev.emka");
        Application.Quit();
    }



    void IsQuits()
    {
        if (btn[0].GetComponent<Button>().interactable==false && btn[1].GetComponent<Button>().interactable==false && btn[2].GetComponent<Button>().interactable==false && btn[3].GetComponent<Button>().interactable ==false && btn[4].GetComponent<Button>().interactable==false && btn[5].GetComponent<Button>().interactable==false && btn[6].GetComponent<Button>().interactable==false && btn[7].GetComponent<Button>().interactable==false && btn[8].GetComponent<Button>().interactable==false)
        {
            quitsTxt.text = "ENDED IN A DRAW";
            gameScreen.GetComponent<CanvasGroup>().DOFade(0.22f, 0.5f);
            winnerScreen.SetActive(true);
            winnerScreen.GetComponent<CanvasGroup>().DOFade(1, 0.35f);
        }       
        
    }
    

}
