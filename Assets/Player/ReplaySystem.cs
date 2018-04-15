using UnityEngine;
using System.Collections;

public class ReplaySystem : MonoBehaviour {

	private const int bufferFrames = 100;
	private MyKeyFrame[] keyFrames = new MyKeyFrame[bufferFrames];
	private Rigidbody rigidBody;
	private GameManager gameManager;

	void Start () {
		rigidBody = GetComponent<Rigidbody>();
		gameManager = FindObjectOfType<GameManager>();
	}
	
	void Update ()
	{
		if (gameManager.isRecording)
		{
			Record();
		}
		else
		{
			PlayBack();
		}
	}

	private void PlayBack()
	{		
		rigidBody.isKinematic = true;
		int frame = Time.frameCount % bufferFrames;
		transform.position = keyFrames[frame].position;
		transform.rotation = keyFrames[frame].rotation;
				
	}

	private void Record()
	{
		rigidBody.isKinematic = false;
		int frame = Time.frameCount % bufferFrames;
		keyFrames[frame] = new MyKeyFrame(Time.time, transform.position, transform.rotation);
	}
}

/// <summary>
/// A stracture for storing time, position and rotation.
/// </summary>
public struct MyKeyFrame
{
	public float time;
	public Vector3 position;
	public Quaternion rotation;

	public MyKeyFrame(float aTime, Vector3 aPosition, Quaternion aRotation)
	{
		time = aTime;
		position = aPosition;
		rotation = aRotation;
	}
}
