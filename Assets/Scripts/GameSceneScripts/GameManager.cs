using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class GameManager : MonoBehaviour
{
    public string player;

    [SerializeField]
    GameObject whoTxt;

    [SerializeField]
    Text showPlayer;
    public int random;
    private void Start()
    {
        random = Random.Range(0, 2);
        if (random == 0)
        {
            player = "X";
            showPlayer.text = player;
            whoTxt.GetComponent<RectTransform>().DOScale(1.25f, 0.6f).SetLoops(2, LoopType.Yoyo);
        }
        else
        {
            player = "O";
            showPlayer.text =player;
            whoTxt.GetComponent<RectTransform>().DOScale(1.25f, 0.6f).SetLoops(2, LoopType.Yoyo);

        }
    }
    private void Update()
    {
        if (random == 0)
        {
            player = "X";
            showPlayer.text =player;
            
        }
        else
        {
            player = "O";
            showPlayer.text = player;
           

        }
    }
}
