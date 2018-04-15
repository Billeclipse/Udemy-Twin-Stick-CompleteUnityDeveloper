using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class GameManager : MonoBehaviour {

	public bool isRecording = true;

	void Start () {
		
	}
	
	void Update () {
		if (CrossPlatformInputManager.GetButton("Fire1"))
		{
			isRecording = false;
		}
		else
		{
			isRecording = true;
		}
	}
}
