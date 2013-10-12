using UnityEngine;
using System.Collections;

public class BinBehavior : MonoBehaviour {

	public GameObject gameWorld;
	
	//public ObjectType type;
	public ThrowableType type;
	
	void OnTriggerEnter(Collider other){
				
		ThrowableType[] types = {type,other.gameObject.GetComponent<ThrowableBehavior>().type};
		
		gameWorld.SendMessage("React", types);//other.gameObject.GetComponent<FallingObjectBehaviour>().type);
	}//OnTriggerEnter
}
