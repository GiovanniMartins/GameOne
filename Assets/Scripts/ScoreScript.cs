using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreScript : MonoBehaviour {

	public Text scoretext;
	public Text highScoreText;
	public float scoreCount;
	public float highScoreCount;
	public float pointsPorSecond;
	public bool scoreIncreasing;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// IMPLEMENTAR A PARTE DE COLISÃO DA FACA COM O BONECO PARA GERAR A PONTUAÇÃO

		if(scoreIncreasing){
			// CADA ACERTO, INCREMENTAR O SCORE; 
		}

		if (scoreCount > highScoreCount) {
			highScoreCount = scoreCount;
		}

		scoretext.text = "Score: " + scoreCount;
		highScoreText.text = "High Score: " + highScoreText;
	}
}
