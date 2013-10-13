using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RecycleGameBehavior : IWorldBehavior {
	
	private GameObject _scoreObject;
	private int _score = 0;
	private int _health = 6;
	private int _numberOfTrash = 20;
	private List<GameObject> _trash = new List<GameObject>();	
	private TextMesh _textMeshObject;
	
	public void Initialize(){
		InitializeGameObjects();
	}
	
	public void React(ThrowableType[] types){
		Debug.Log(types[0]);
		Debug.Log(types[1]);
		if(types[0] == types[1]){
			_score += 50;
			updateScore();
		}else{
			_score -= 25;
			_health -= 1;
			updateScore();
			CheckConditions();
		}
	}//React
	
	private void CheckConditions(){
		if(_health == 0){
			//End game and return to main menu
			Application.LoadLevel("00_main_menu");
		}//if
	}//CheckConditions
	
	private void InstantiateTrash(){
		/*
		for(int i = 0; i < _numberOfTrash; i++){
			int randomPrefab = Random.Range(0,3);
			float x = Random.Range(-5, 5);
			float y = Random.Range(-5, 5);
			

			
		}//
		*/
	}//instantiateTrash
	
	private void InitializeGameObjects(){
		_scoreObject = GameObject.Find("score");
		_textMeshObject = _scoreObject.GetComponent<TextMesh>();
		updateScore();
	}
	
	private void updateScore(){
		//_textMeshObject = _scoreObject.GetComponent<TextMesh>();
		_textMeshObject.text = "score: " + _score.ToString();
	}
}
