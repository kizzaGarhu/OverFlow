using UnityEngine;
using System.Collections;

public class BinBehavior : MonoBehaviour {

	public GameObject gameWorld;
	
	//public ObjectType type;
	public ThrowableType type;
	
	void OnTriggerEnter(Collider other){
	    if (other.gameObject.GetComponent<ThrowableBehavior>() != null) {
		    ThrowableType[] types = {type,other.gameObject.GetComponent<ThrowableBehavior>().type};
		    gameWorld.SendMessage("React", types);//other.gameObject.GetComponent<FallingObjectBehaviour>().type);
		}
	}//OnTriggerEnter
	
}
