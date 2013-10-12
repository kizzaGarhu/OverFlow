using UnityEngine;
using System.Collections; 

public class AnswerBoxBehaviour : MonoBehaviour {
	
	public GameObject gameWorld;
	
	public ObjectType type; 
	
	void OnTriggerEnter(Collider other){
		
		if(other.gameObject.GetComponent<FallingObjectBehaviour>().type == this.type){
			Debug.Log("Answer");	
		}
		
		gameWorld.SendMessage("printHello", type);//other.gameObject.GetComponent<FallingObjectBehaviour>().type);
	}//OnTriggerEnter

}//AnswerBoxBehaviour

public enum ObjectType{
	a,
	b,
	c,
	d,
	e,
	f,
	g
}
