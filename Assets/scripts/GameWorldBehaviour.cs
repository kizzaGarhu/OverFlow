using UnityEngine;
using System.Collections;

public class GameWorldBehaviour : MonoBehaviour {
	
	private IWorldBehavior worldBehaviour;
	
	public WorldBehavior instantiateWorldBehavior;
	
	public enum WorldBehavior{
		MainMenuBehavior,
		RecycleGameBehavior
	}
	
	// Use this for initialization
	void Start () {
		switch(instantiateWorldBehavior){
		case WorldBehavior.MainMenuBehavior:
			worldBehaviour = new MainMenuBehavior();
			break;
		}
	}
	
	public void React(ThrowableType[] types){
		worldBehaviour.React(types);
	}
	
	//#################
		public void printHello(ObjectType type){//ObjectType type){
		switch(type){
		case ObjectType.a:
			Debug.Log("New Game state");
			//GameObject.Find("NewGameState").transform.position = Vector3.zero;
			//GameObject.Find("MainState").transform.position = new Vector3(1000.0f,0.0f,0.0f);
			break;
		case ObjectType.b:
			Debug.Log("Settings state");
			break;
		case ObjectType.c:
			Debug.Log("Credits state");
			break;
		case ObjectType.d:
			Debug.Log("Quit state");
			break;
		default:
			Debug.Log("Hello from GameWorld!! Default");
			break;
			
		}
		
		
	}
	
		public void printHello(ThrowableType type){//ObjectType type){
		switch(type){
		case ThrowableType.A:
			Debug.Log("New Game state");
			//GameObject.Find("NewGameState").transform.position = Vector3.zero;
			//GameObject.Find("MainState").transform.position = new Vector3(1000.0f,0.0f,0.0f);
			break;
		case ThrowableType.B:
			Debug.Log("Settings state");
			break;
		case ThrowableType.C:
			Debug.Log("Credits state");
			break;
		case ThrowableType.D:
			Debug.Log("Quit state");
			break;
		default:
			Debug.Log("Hello from GameWorld!! Default");
			break;
			
		}
		
		
	}
	//#################
}

