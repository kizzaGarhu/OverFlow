	using UnityEngine;
	using System.Collections;
	
	public class ItemCreatorScript : MonoBehaviour {
	
		
		// Use this for initialization
		void Start () {
			 GameObject iniatedObject = (GameObject)Instantiate (GameObject.Find("Square"), new Vector3(0.0f,0.0f,-4.0f), Quaternion.identity); 
			 iniatedObject.transform.Rotate(new Vector3(90.0f,90.0f,-90.0f));
			 iniatedObject.rigidbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY;
		}
		
	
		// Update is called once per frame
		void Update () {
			
		}
	}
