using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class gameManager : MonoBehaviour {

	public GameObject selectedZombie; 
	public List<GameObject> zombies;
	public Vector3 selectedSize;
	public Vector3 defaultSize;
	private int indexOfSelectedZombie = 0;
	public Text scoreText; 
	private int score = 0;

	// Use this for initialization
	void Start () {
		SelectZombie(selectedZombie);
		scoreText.text = "Score:" + score;
	}
	
	// Update is called once per frame
	void Update () {
		// detect key press	
		if(Input.GetKeyDown("right")){
			if(indexOfSelectedZombie == 3)
			indexOfSelectedZombie = 0;
			else
			{
				indexOfSelectedZombie++;
			}
		}	
		if(Input.GetKeyDown("left")){
			if(indexOfSelectedZombie == 0)
				indexOfSelectedZombie = 3;
			else
			{
				indexOfSelectedZombie--;
			}
		}
		if(Input.GetKeyDown("up")){
			pushUp();
		}
		SelectZombie(zombies[indexOfSelectedZombie]);
	}


	void SelectZombie(GameObject newZombie){
		selectedZombie.transform.localScale = defaultSize;
		selectedZombie = newZombie;
		newZombie.transform.localScale = selectedSize;
	}

	void pushUp(){
		Rigidbody rb = selectedZombie.GetComponent<Rigidbody>();
		rb.AddForce(0, 0, 10, ForceMode.Impulse);
	}

	public void AddPoint(){
		score += 1;
		scoreText.text = "Score:" + score;
	}

}
