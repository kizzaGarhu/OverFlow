using UnityEngine;
using System.Collections;

public class BinBehavior : MonoBehaviour {

	public GameObject gameWorld;
	
	//public ObjectType type;
	public ThrowableType type;
	
	void OnTriggerEnter(Collider other){
		
		if(other.gameObject.GetComponent<ThrowableBehavior>().type == this.type){
			Debug.Log("Answer");	
		}
		
		gameWorld.SendMessage("React", type);//other.gameObject.GetComponent<FallingObjectBehaviour>().type);
	}//OnTriggerEnter
}
