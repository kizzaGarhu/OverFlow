using UnityEngine;
using System.Collections;

public class ReturnableText : MonoBehaviour {
	
	public Vector3 startPosition;
	public Quaternion startRotation;
	
	// Use this for initialization
	void Start () {
		startPosition = gameObject.transform.position;
		startRotation = gameObject.transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void ResetToSpawn() {
		gameObject.transform.position = startPosition;
		gameObject.transform.rotation = startRotation;
	}
}
