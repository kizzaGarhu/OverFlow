using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RecycleGameBehavior : IWorldBehavior {
	

	
	private GameObject _scoreObject;
	private int _score = 0;
	private int _health = 6;
	private int _numberOfTrash = 20;
	private List<GameObject> _trash = new List<GameObject>();	
	
	public void React(ThrowableType[] types){
		if(types[0] == types[1]){
			_score += 50;
			
		}else{
			_score -= 25;
			_health -= 1;
			CheckConditions();
		}
	}//React
	
	private void CheckConditions(){
		if(_health == 0){
			//End game and return to main menu
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
}
