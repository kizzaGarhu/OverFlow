using UnityEngine;
using System.Collections;

public class ThrowableBehavior : MonoBehaviour {

	// Used to determine whether object is accepted.
	//public ObjectType type;
	public ThrowableType type;
	
	public float flySpeed = 0.25f; //How fast objects fly after drag
	
	
	private float _posX = 80.0f, _negX = -80.0f, _posY = 50.0f, _negY = -50.0f;
	private float _positionX = 0.0f, _positionY = 0.0f;
	
	public float startX = 0.0f, startY = 0.0f, startZ = 0.0f;
    private Vector3 _startPosition;
	
	//For calculating object's flying direction 
	private Vector3 _flyDirection = Vector3.zero; //general fly direction applied to object's position on each update
	private Vector3 _startingPos; //object's starting position before drag. 
	private Vector3 _flyToPos; //object's destination after drag.
	
	// Use this for initialization
	void Start () {
		_startPosition = new Vector3(startX,startY,startZ);
		gameObject.transform.position = _startPosition;
	}
	
	// Update is called once per frame
	void Update () {
		CheckPosition();
		
		// Add general fly direction to object.
		gameObject.transform.position -= (_flyDirection*flySpeed);
	
	}
	
	
	public void CheckPosition(){
		_positionX = gameObject.transform.position.x;
		_positionY = gameObject.transform.position.y;
		
		if(_positionX >= _posX || _positionX <= _negX){
			
			Debug.Log("Respawning...");
			_flyDirection = Vector3.zero;
			
			gameObject.rigidbody.velocity = Vector3.zero;
			gameObject.transform.position = _startPosition;
		}//if
		
		if(_positionY >= _posY ||  _positionY <= _negY){
			Debug.Log("Respawning...");
			_flyDirection = Vector3.zero;
			gameObject.rigidbody.velocity = Vector3.zero;
			gameObject.transform.position = _startPosition;
		}//if
		
	}//CheckPosition
	
	private Vector3 screenPoint;
	private Vector3 offset;
	
	void OnMouseDown()
	{
	    //get object's starting position 
		//_startingPos = gameObject.transform.position;
		
		screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
	    offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
	 
	}
	 
	void OnMouseDrag()
	{
	    _startingPos = gameObject.transform.position;
		Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
	 
		Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint), offset;
		transform.position = curPosition;
	}
	
	void OnMouseUp()
	{
		//get object's destination position
		_flyToPos = gameObject.transform.position;
		
		// Calculate object's general fly position.
		_flyDirection = _startingPos - _flyToPos;

	}
}

