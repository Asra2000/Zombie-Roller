using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour {

	public gameManager manager;
	public AudioClip hit;
	AudioSource source;

	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other) {
		manager.AddPoint();
		source.PlayOneShot(hit);
	}
}
