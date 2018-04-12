using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {
	
	void Start () {
		
	}
	
	void Update () {
		Debug.Log(CrossPlatformInputManager.GetAxis("Horizontal"));
	}
}
