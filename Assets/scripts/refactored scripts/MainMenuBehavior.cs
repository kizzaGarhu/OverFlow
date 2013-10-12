﻿using UnityEngine;
using System.Collections;

public class MainMenuBehavior : IWorldBehavior {
	
	#region Class Variables
	//Class Variables
	public enum GameState{
		MainState,
		NewGameState,
		SettingsState,
		QuitState,
		QuitConfirmState
		
	}//GameState
	
	private GameState _currentState = GameState.MainState;
	
	private Vector3 _notVisible = new Vector3(1000.0f, 0.0f, 0.0f);
	private Vector3 _visible = Vector3.zero;
	
	//References to game objects
	private GameObject _mainState;
	private GameObject _newGameState;
	private GameObject _settingsState;
	private GameObject _quitState;
	#endregion
	
	public MainMenuBehavior(){
		findGameObjects();
		
	}
	
	public void findGameObjects(){
		//find game state objects
		_mainState = GameObject.Find("MainState");
		_newGameState = GameObject.Find("NewGameState");
		//_settingsState = GameObject.Find("SettingsState");
		//_quitState = GameObject.Find("QuitState");
		
		//set visibility
		_newGameState.transform.position = _notVisible;
		//_settingsState.transform.position = _notVisible;
		//_quitState.transform.position = _notVisible;
	}
	
	public void React(ThrowableType type){
		switch(type){
		case ThrowableType.A:
			switch(_currentState){
			case GameState.MainState:
				// New Game Label in Main State
				_mainState.transform.position = _notVisible;
				_newGameState.transform.position = _visible;
				_currentState = GameState.NewGameState;
				break;
			
			case GameState.NewGameState:
				//Back Label in New Game State
				_newGameState.transform.position = _notVisible;
				_mainState.transform.position = _visible;
				_currentState = GameState.MainState;
				break;
			
			case GameState.SettingsState:
				break;
			
			case GameState.QuitState:
				
				break;
			}
			
			/*
			if(_currentState == GameState.MainState){
				_mainState.transform.position = _notVisible;
				_newGameState.transform.position = _visible;
				Debug.Log(_currentState);
				Debug.Log(_mainState.transform.position);
				_currentState = GameState.NewGameState;
				//CurrentState = GameState.NewGameState;
				Debug.Log(_currentState);
			}else if(_currentState == GameState.NewGameState){
				_newGameState.transform.position = _notVisible;
				_mainState.transform.position = _visible;
				_currentState = GameState.MainState;
			}else if(_currentState == GameState.SettingsState){
				
			}else if(_currentState == GameState.QuitState){
				
			}
			*/
			break;
		case ThrowableType.B:
			break;
			
		}//switch
	}//React
	
}