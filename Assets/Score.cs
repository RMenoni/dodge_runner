using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour {

    public TextMeshPro scoreBoard;
    public PlayerController player;

	void Update () {
        scoreBoard.SetText("Score: " + (Time.timeSinceLevelLoad * 10).ToString("0") + "\nLives: " + player.lives.ToString());
	}
}
