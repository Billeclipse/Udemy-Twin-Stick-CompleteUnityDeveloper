using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class GameManager : MonoBehaviour {

	public bool isRecording = true;

	private float fixedDeltaTime;
	private bool isPaused = false;

	void Start () {
		fixedDeltaTime = Time.fixedDeltaTime;
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

		if (CrossPlatformInputManager.GetButtonDown("Pause"))
		{
			PauseOrUnpause();
		}
	}

	private void PauseOrUnpause()
	{
		if (!isPaused)
		{
			Time.timeScale = 0;
			Time.fixedDeltaTime = 0;
			isPaused = true;			
		}
		else
		{
			Time.timeScale = 1f;
			Time.fixedDeltaTime = fixedDeltaTime;
			isPaused = false;
		}
	}

	private void OnApplicationPause(bool pause)
	{
		isPaused = pause;
	}
}
