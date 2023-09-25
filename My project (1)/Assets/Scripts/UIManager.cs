using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Player_Base playerbase;
    public Image image;
    public Text hptxt;

  
    void Update()
    {
        hptxt.text = "HP : " + playerbase.Player_HP;
        Debug.Log(playerbase.Player_HP);
    }
}
