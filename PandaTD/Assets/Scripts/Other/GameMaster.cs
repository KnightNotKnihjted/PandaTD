using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{
    public int lives;
    public Text livesText;

    public int pandaCoins;
    public Text pandaCoinsText;

    public int round;
    public Text roundText;

    void Update(){
        livesText.text = lives + "ㅤ";
        pandaCoinsText.text = pandaCoins + "ㅤ";
        roundText.text = "Round " + round;
    }
}