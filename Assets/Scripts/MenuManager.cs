using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField]
    GameObject startBtn, exitBtn,startTxt,exitTxt;
    public string belirli;
    void Start()
    {
        
        BttnStart();
    }

    

    void BttnStart()
    {
        Vector3 target = new Vector3(0, 0, 0);

        startBtn.GetComponent<RectTransform>().DOLocalMoveX(-275f,1.5f).SetEase(Ease.OutBack);
        exitBtn.GetComponent<RectTransform>().DOLocalMoveX(275, 1.5f).SetEase(Ease.OutBack);

        startTxt.transform.GetComponent<RectTransform>().DOLocalRotate(target, 1.8f);

        exitTxt.transform.GetComponent<RectTransform>().DOLocalRotate(target, 1.8f);

    }


    public void StartBtnDown()
    {
        startTxt.transform.GetComponent<RectTransform>().DOScale(1.25f,0.5f);
    }


    public void StartBtnUp()
    {
        startTxt.transform.GetComponent<RectTransform>().DOScale(1, 0.5f);
    }

    public void ExitBtnDown()
    {
        exitTxt.transform.GetComponent<RectTransform>().DOScale(1.25f, 0.5f);

    }


    public void ExitBtnUp()
    {
        exitTxt.transform.GetComponent<RectTransform>().DOScale(1, 0.5f);
    }


    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {

        Application.OpenURL("www.instagram.com/dev.emka");
        Application.Quit();

    }
}
