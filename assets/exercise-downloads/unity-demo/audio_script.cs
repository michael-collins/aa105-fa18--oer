using UnityEngine;
using System.Collections;

public class audio_script : MonoBehaviour {

	public AudioClip MusicClip;
	public AudioSource MusicSource;

	// Use this for initialization
	void Start () {
		MusicSource.clip = MusicClip;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space))
			MusicSource.Play ();
	}
}
